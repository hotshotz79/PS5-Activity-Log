using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.Sqlite;
using WinSCP;
using static System.Collections.Specialized.BitVector32;


namespace PS5_Activity_Log
{
    public partial class MainMenu : Form
    {
        public SessionOptions sessionOptions = new SessionOptions();
        public DataTable dt = new DataTable();
        public DataTable dtProfile = new DataTable();
        public bool rePosition = true;
        public MainMenu()
        {
            InitializeComponent();
            SetTransparency();
            //Populate Default Settings
            txtIP.Text = Properties.Settings.Default.ip;
            txtPort.Text = Properties.Settings.Default.port;
        }

        private void btnFTP_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ip = txtIP.Text;
            Properties.Settings.Default.port = txtPort.Text;
            Properties.Settings.Default.Save();
            sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Ftp,
                HostName = Properties.Settings.Default.ip,
                PortNumber = Convert.ToInt32(Properties.Settings.Default.port),
                UserName = "anonymous",
                Password = "anonymous"
            };
            ConnectPS5();
            dbPrepare();
            flowGameList.Enabled = true;
        }

        // Chart Data Point
        private void GenerateChart()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            int j = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int maxRows = dt.Rows.Count;
                //Display Last 10 records
                if (maxRows > 10)
                {
                    int displayRows = maxRows - i;
                    if (displayRows <= 10)
                    {
                        double hours = Math.Round(Convert.ToDouble(dt.Rows[i]["Log"].ToString().Trim()) / 3600, 2);
                        var date = DateTime.Parse(dt.Rows[i]["Date"].ToString().Trim());

                        chart1.Series["Log"].Points.Add(new DataPoint(j, hours));
                        chart1.Series[0].Points[j].AxisLabel = date.ToString("M/dd");
                        j++;
                    }
                }
                else
                {
                    double hours = Math.Round(Convert.ToDouble(dt.Rows[i]["Log"].ToString().Trim()) / 3600, 2);
                    var date = DateTime.Parse(dt.Rows[i]["Date"].ToString().Trim());

                    chart1.Series["Log"].Points.Add(new DataPoint(j, hours));
                    chart1.Series[0].Points[j].AxisLabel = date.ToString("M/dd");
                    j++;
                }
            }
        }

        private void ConnectPS5()
        {
            try
            {
                // Start the session
                using (Session session = new Session())
                {
                    session.Open(sessionOptions);

                    //Get Profiles
                    RemoteDirectoryInfo directory = session.ListDirectory("user/home/");

                    dtProfile = new DataTable();
                    dtProfile.Columns.Add("userID", typeof(string));
                    dtProfile.Columns.Add("userName", typeof(string));

                    foreach (RemoteFileInfo fileInfo in directory.Files)
                    {
                        // Skip the first FTP listing
                        if (fileInfo.Name != "..")
                        {
                            string userProfile = @"/user/home/" + fileInfo.Name + @"/username.dat";
                            using (StreamReader file = new StreamReader(session.GetFile(userProfile)))
                            {
                                string userName = file.ReadLine().ToString().Trim('\0');
                                DataRow dr = dtProfile.NewRow();

                                dr[0] = fileInfo.Name;
                                dr[1] = userName;
                                dtProfile.Rows.Add(dr);

                                cmbProfile.Items.Add(userName);
                            }
                        }
                    }
                    cmbProfile.SelectedIndex = 0;

                    // Get all folder names into a list
                    directory = session.ListDirectory("user/appmeta");

                    foreach (RemoteFileInfo fileInfo in directory.Files)
                    {
                        // Skip the first FTP listing
                        if (fileInfo.Name != "..")
                        {
                            string iconPath = @"/user/appmeta/" + fileInfo.Name + @"/icon0.png";

                            if (fileInfo.Name == "addcont" || fileInfo.Name == "external")
                            {
                                continue;
                            }

                            if (session.FileExists(iconPath))
                            {
                                Stream iconStream = session.GetFile(iconPath);

                                PictureBox pbCard1 = new PictureBox();
                                pbCard1.Image = Image.FromStream(iconStream);
                                pbCard1.Name = fileInfo.Name; //Title ID
                                pbCard1.Size = new Size(128, 128);
                                pbCard1.SizeMode = PictureBoxSizeMode.StretchImage;
                                pbCard1.BorderStyle = BorderStyle.FixedSingle;
                                pbCard1.DoubleClick += new EventHandler(iconClicked);
                                pbCard1.MouseHover += new EventHandler(iconHover);
                                pbCard1.MouseLeave += new EventHandler(iconLeave);
                                flowGameList.Controls.Add(pbCard1);
                            }
                            else
                            {
                                //Replace with a generic Image.FromFile("NoImageFound.png")
                                PictureBox pbCard1 = new PictureBox();
                                pbCard1.Image = Properties.Resources.no_Image;
                                pbCard1.Name = fileInfo.Name; //Title ID
                                pbCard1.Size = new Size(128, 128);
                                pbCard1.SizeMode = PictureBoxSizeMode.StretchImage;
                                pbCard1.BorderStyle = BorderStyle.FixedSingle;
                                pbCard1.DoubleClick += new EventHandler(iconClicked);
                                pbCard1.MouseHover += new EventHandler(iconHover);
                                pbCard1.MouseLeave += new EventHandler(iconLeave);
                                flowGameList.Controls.Add(pbCard1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void iconLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.FixedSingle;
        }

        private void iconHover(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.Fixed3D;
        }

        private void iconClicked(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            txtLog.Text = "Pulling Activity for " + pb.Name + "...";
            GetData(pb);
            panel1.Visible = true;
            EnableLabels();
            GenerateChart();
            txtLog.Text = txtLog.Text + Environment.NewLine + "Log retrieved";
        }

        private void GetData(PictureBox gameName)
        {
            //Get Title Name first
            string database = Path.Combine(Directory.GetCurrentDirectory(), "appinfo.db");
            string titleName = "";

            string sqlQuery = "SELECT val from tbl_appinfo where titleId = '" + gameName.Name + "' and key = 'TITLE'";
            SqliteConnection connect;
            connect = new SqliteConnection("Data Source=" + database + ";");

            try
            {
                connect.Open();
                var sqlSelect = connect.CreateCommand();
                sqlSelect.CommandText = sqlQuery;

                // Execute SQL and place data in a reader object.
                SqliteDataReader reader = sqlSelect.ExecuteReader();
                while (reader.Read()) {
                    titleName = reader[0].ToString();
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //Activity database data lookup
            database = Path.Combine(Directory.GetCurrentDirectory(),"sl2_log.db");
            string userID = "";
            foreach (DataRow dr in dtProfile.Rows)
            {
                if (dr[1].ToString() == cmbProfile.SelectedItem.ToString())
                {
                    userID = dr[0].ToString();
                    break;
                }
            }
            
            sqlQuery = "SELECT created_date, log FROM tbl_log where log like '%" + gameName.Name +
                "%' AND log not like '%totalFgTime\":0%' and event_id = 'ApplicationSessionEnd' and log_header like '%" + 
                userID + "%'";

            connect = new SqliteConnection("Data Source=" + database + ";");

            try
            {
                connect.Open();

                //PRAGMA - Not needed
                //var sqlPragma = connect.CreateCommand();
                //sqlPragma.CommandText = "PRAGMA integrity_check;";
                //sqlPragma.ExecuteNonQuery();

                var sqlSelect = connect.CreateCommand();
                sqlSelect.CommandText = sqlQuery;

                // Execute SQL and place data in a reader object.
                SqliteDataReader reader = sqlSelect.ExecuteReader();
                dt = new DataTable();
                dt.Columns.Add("Date");
                dt.Columns.Add("Log");

                while (reader.Read())
                {
                    int indx = reader[1].ToString().IndexOf("fgTime");
                    string timePlayed = reader[1].ToString().Substring(indx+8, 5);
                    timePlayed = timePlayed.Split(',')[0];
                    dt.Rows.Add(reader[0].ToString().Substring(0, 10), timePlayed);
                }
            }
            catch (Exception ex)
            {
                //Suppress the sl2_log.db error: database disk image is malformed
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                int totalTime = 0, count = 0, sec =0, h=0, m=0, avgSec=0;

                foreach (DataRow row in dt.Rows)
                {
                    totalTime = totalTime + Convert.ToInt32(row[1]);
                    count++;
                }

                if (count > 0)
                {
                    sec = totalTime;    //Total time in seconds
                    h = (sec/3600);     //Converted to hours
                    m = (sec-(3600*h))/60; //Converted to minutes
                    avgSec = totalTime / count;
                }
                connect.Close();

                //Grab background wallpaper
                string iconPath = @"/user/appmeta/" + gameName.Name + @"/pic0.png";
                using (Session session = new Session())
                {
                    session.Open(sessionOptions);
                    if (session.FileExists(iconPath))
                    {
                        Stream iconStream = session.GetFile(iconPath);

                        //pbCard1.Image = Image.FromStream(iconStream);
                        Image original = Image.FromStream(iconStream);
                        pbAct.BackColor = Color.Transparent;
                        pbAct.Image = SetAlpha((Bitmap)original, 125);
                    }
                    else
                    {
                        pbAct.Image = null;
                        panel1.BackColor = Color.DimGray;
                    }
                    session.Close();
                }
                
                //Populate Activity Panel
                PopulateActivity(h,m, gameName.Name, avgSec, count, titleName, dt.Rows[0][0].ToString(), dt.Rows[dt.Rows.Count-1][0].ToString());
            }
        }

        private void PopulateActivity(int hour, int min, string titleID, int average, int times, string name, string first, string last)
        {
            int avgh = (average/3600);     //Converted to hours
            int avgm = (average-(3600*avgh))/60; //Converted to minutes
            actLbl_title.Text = titleID;
            actLbl_name.Text = name;
            actLbl_total.Text = $"{hour} hours and {min} minutes";
            actLbl_avg.Text = $"{avgh} hours and {avgm} minutes";
            actLbl_times.Text = times + " times";
            actLbl_first.Text = first;
            actLbl_last.Text = last;
        }

        private async void dbPrepare()
        {
            txtLog.Text = "Preparing to download activity log database";
            await Task.Run(() => DownloadDB());
            txtLog.Text = "Activity database downloaded" + Environment.NewLine +
                "Double Click any game to view Activity";
        }

        private void DownloadDB()
        { 
            try
            {
                // Start the session
                using (Session session = new Session())
                {
                    //--------------------------------
                    //DL: App db for game name lookup
                    session.Open(sessionOptions);
                    var appdbSize = session.GetFileInfo(@"system_data/priv/mms/appinfo.db");
                    session.Close();

                    //if downloading log db if same file already exists
                    if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), appdbSize.Name)))
                    {
                        var existingDbSize = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), appdbSize.Name));
                        if (appdbSize.Length ==  existingDbSize.Length)
                        {
                            return;
                        }
                    }

                    // Download files
                    session.Open(sessionOptions);
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;

                    TransferOperationResult transferResult;
                    transferResult = session.GetFiles(@"system_data/priv/mms/appinfo.db",
                        Path.Combine(Directory.GetCurrentDirectory(), appdbSize.Name), false, transferOptions);

                    // Throw on any error
                    transferResult.Check();
                    session.Close();

                    //--------------------------------
                    //DL: Activiy db for playtime/logs
                    session.Open(sessionOptions);
                    var dbSize = session.GetFileInfo(@"system_data/priv/system_logger2/nobackup/database/sl2_log.db");
                    session.Close();

                    //if downloading log db if same file already exists
                    if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), dbSize.Name)))
                    {
                        var existingDbSize = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), dbSize.Name));
                        if (dbSize.Length ==  existingDbSize.Length)
                        {
                            return;
                        }
                    }

                    session.FileTransferProgress += (sender, e) =>
                    {
                        //Updates the Progress Bar
                        progressBar1.Invoke((MethodInvoker)(() => {
                            progressBar1.Value = (int)(e.OverallProgress * 100);
                        }));
                        //Updates the download speed
                        txtLog.Invoke((MethodInvoker)(() =>
                        {
                            txtLog.Text = "Downloading... " + Environment.NewLine +
                            "Filename: " + dbSize.Name + "  | File Size: " +
                            string.Format("{0:n1} MB", (dbSize.Length / 1024f) / 1024f)  + Environment.NewLine +
                            "Download speed: " + 
                            string.Format("{0:n1} MB/sec", (e.CPS / 1024f)/1024f);
                        }));
                    };

                    // Download files
                    session.Open(sessionOptions);
                    transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;

                    transferResult = session.GetFiles(@"system_data/priv/system_logger2/nobackup/database/sl2_log.db", 
                        Path.Combine(Directory.GetCurrentDirectory(),dbSize.Name), false, transferOptions);
                    
                    // Throw on any error
                    transferResult.Check();
                    session.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Control transparency over background image
        private void SetTransparency()
        {
            label5.Parent = pbAct;
            label8.Parent = pbAct;
            label99.Parent = pbAct;
            lbl98.Parent = pbAct;
            label97.Parent = pbAct;
            actLbl_avg.Parent = pbAct;
            actLbl_first.Parent = pbAct;
            actLbl_last.Parent = pbAct;
            actLbl_times.Parent = pbAct;
            actLbl_title.Parent = pbAct;
            actLbl_name.Parent = pbAct;
            actLbl_total.Parent = pbAct;
            chart1.Parent = pbAct;

            label5.Visible = false;
            label8.Visible = false;
            label99.Visible = false;
            lbl98.Visible = false;
            label97.Visible = false;
            actLbl_avg.Visible = false;
            actLbl_first.Visible = false;
            actLbl_last.Visible = false;
            actLbl_times.Visible = false;
            actLbl_title.Visible = false;
            actLbl_name.Visible = false;
            actLbl_total.Visible = false;
            chart1.Visible = false;
        }

        private void EnableLabels()
        {
            label5.Visible = true;
            label8.Visible = true;
            label99.Visible = true;
            lbl98.Visible = true;
            label97.Visible = true;
            actLbl_avg.Visible = true;
            actLbl_first.Visible = true;
            actLbl_last.Visible = true;
            actLbl_times.Visible = true;
            actLbl_title.Visible = true;
            actLbl_name.Visible = true;
            actLbl_total.Visible = true;
            chart1.Visible = true;
        }

        //Transparency function
        static Bitmap SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha /  255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, a, 0},
                new float[] {0, 0, 0, 0, 1}
            };

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }
    }
}
