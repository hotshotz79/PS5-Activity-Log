namespace PS5_Activity_Log
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnFTP = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.flowGameList = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbAct = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.actLbl_last = new System.Windows.Forms.Label();
            this.actLbl_first = new System.Windows.Forms.Label();
            this.actLbl_avg = new System.Windows.Forms.Label();
            this.actLbl_total = new System.Windows.Forms.Label();
            this.actLbl_name = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.actLbl_title = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.lbl98 = new System.Windows.Forms.Label();
            this.actLbl_times = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProfile = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFTP
            // 
            this.btnFTP.BackColor = System.Drawing.Color.Aquamarine;
            this.btnFTP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFTP.ForeColor = System.Drawing.Color.Black;
            this.btnFTP.Location = new System.Drawing.Point(12, 9);
            this.btnFTP.Name = "btnFTP";
            this.btnFTP.Size = new System.Drawing.Size(60, 23);
            this.btnFTP.TabIndex = 5;
            this.btnFTP.Text = "Connect";
            this.btnFTP.UseVisualStyleBackColor = false;
            this.btnFTP.Click += new System.EventHandler(this.btnFTP_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(100, 11);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(85, 20);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.2.140";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(226, 11);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(36, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "1337";
            // 
            // flowGameList
            // 
            this.flowGameList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowGameList.AutoScroll = true;
            this.flowGameList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowGameList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowGameList.Enabled = false;
            this.flowGameList.Location = new System.Drawing.Point(12, 40);
            this.flowGameList.Name = "flowGameList";
            this.flowGameList.Size = new System.Drawing.Size(557, 405);
            this.flowGameList.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1193, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "db Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(12, 536);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(556, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLog.Location = new System.Drawing.Point(12, 453);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(557, 77);
            this.txtLog.TabIndex = 11;
            this.txtLog.Text = "Waiting for connection to PS5...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Port:";
            // 
            // pbAct
            // 
            this.pbAct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAct.BackColor = System.Drawing.Color.Transparent;
            this.pbAct.Image = ((System.Drawing.Image)(resources.GetObject("pbAct.Image")));
            this.pbAct.Location = new System.Drawing.Point(-1, -1);
            this.pbAct.Name = "pbAct";
            this.pbAct.Size = new System.Drawing.Size(725, 519);
            this.pbAct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAct.TabIndex = 26;
            this.pbAct.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.actLbl_last);
            this.panel1.Controls.Add(this.actLbl_first);
            this.panel1.Controls.Add(this.actLbl_avg);
            this.panel1.Controls.Add(this.actLbl_total);
            this.panel1.Controls.Add(this.actLbl_name);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.actLbl_title);
            this.panel1.Controls.Add(this.label97);
            this.panel1.Controls.Add(this.lbl98);
            this.panel1.Controls.Add(this.actLbl_times);
            this.panel1.Controls.Add(this.label99);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pbAct);
            this.panel1.Location = new System.Drawing.Point(575, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 519);
            this.panel1.TabIndex = 15;
            // 
            // actLbl_last
            // 
            this.actLbl_last.AutoSize = true;
            this.actLbl_last.BackColor = System.Drawing.Color.Transparent;
            this.actLbl_last.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actLbl_last.ForeColor = System.Drawing.Color.Aquamarine;
            this.actLbl_last.Location = new System.Drawing.Point(13, 310);
            this.actLbl_last.Name = "actLbl_last";
            this.actLbl_last.Size = new System.Drawing.Size(236, 18);
            this.actLbl_last.TabIndex = 24;
            this.actLbl_last.Text = "{X} hours and {Y} minutes";
            // 
            // actLbl_first
            // 
            this.actLbl_first.AutoSize = true;
            this.actLbl_first.BackColor = System.Drawing.Color.Transparent;
            this.actLbl_first.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actLbl_first.ForeColor = System.Drawing.Color.Aquamarine;
            this.actLbl_first.Location = new System.Drawing.Point(13, 256);
            this.actLbl_first.Name = "actLbl_first";
            this.actLbl_first.Size = new System.Drawing.Size(236, 18);
            this.actLbl_first.TabIndex = 22;
            this.actLbl_first.Text = "{X} hours and {Y} minutes";
            // 
            // actLbl_avg
            // 
            this.actLbl_avg.AutoSize = true;
            this.actLbl_avg.BackColor = System.Drawing.Color.Transparent;
            this.actLbl_avg.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actLbl_avg.ForeColor = System.Drawing.Color.Aquamarine;
            this.actLbl_avg.Location = new System.Drawing.Point(13, 147);
            this.actLbl_avg.Name = "actLbl_avg";
            this.actLbl_avg.Size = new System.Drawing.Size(236, 18);
            this.actLbl_avg.TabIndex = 18;
            this.actLbl_avg.Text = "{X} hours and {Y} minutes";
            // 
            // actLbl_total
            // 
            this.actLbl_total.AutoSize = true;
            this.actLbl_total.BackColor = System.Drawing.Color.Transparent;
            this.actLbl_total.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actLbl_total.ForeColor = System.Drawing.Color.Aquamarine;
            this.actLbl_total.Location = new System.Drawing.Point(13, 94);
            this.actLbl_total.Name = "actLbl_total";
            this.actLbl_total.Size = new System.Drawing.Size(236, 18);
            this.actLbl_total.TabIndex = 16;
            this.actLbl_total.Text = "{X} hours and {Y} minutes";
            // 
            // actLbl_name
            // 
            this.actLbl_name.AutoSize = true;
            this.actLbl_name.BackColor = System.Drawing.Color.Transparent;
            this.actLbl_name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actLbl_name.ForeColor = System.Drawing.Color.Aquamarine;
            this.actLbl_name.Location = new System.Drawing.Point(135, 21);
            this.actLbl_name.Name = "actLbl_name";
            this.actLbl_name.Size = new System.Drawing.Size(134, 18);
            this.actLbl_name.TabIndex = 28;
            this.actLbl_name.Text = "{TITLEName}";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Angle = -45;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LabelStyle.Format = "M/dd";
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineWidth = 3;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorTickMark.LineWidth = 2;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineWidth = 3;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorTickMark.LineWidth = 2;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(225, 62);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Aquamarine;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            series3.IsValueShownAsLabel = true;
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Name = "Log";
            series3.ShadowOffset = 1;
            series3.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(495, 452);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "Title1";
            title3.Text = "Last 10 Activity (Hrs)";
            this.chart1.Titles.Add(title3);
            // 
            // actLbl_title
            // 
            this.actLbl_title.AutoSize = true;
            this.actLbl_title.BackColor = System.Drawing.Color.Transparent;
            this.actLbl_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actLbl_title.ForeColor = System.Drawing.Color.White;
            this.actLbl_title.Location = new System.Drawing.Point(16, 21);
            this.actLbl_title.Name = "actLbl_title";
            this.actLbl_title.Size = new System.Drawing.Size(104, 18);
            this.actLbl_title.TabIndex = 25;
            this.actLbl_title.Text = "{TITLEID}";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.BackColor = System.Drawing.Color.Transparent;
            this.label97.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.ForeColor = System.Drawing.Color.White;
            this.label97.Location = new System.Drawing.Point(13, 288);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(96, 17);
            this.label97.TabIndex = 23;
            this.label97.Text = "Last Played";
            // 
            // lbl98
            // 
            this.lbl98.AutoSize = true;
            this.lbl98.BackColor = System.Drawing.Color.Transparent;
            this.lbl98.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl98.ForeColor = System.Drawing.Color.White;
            this.lbl98.Location = new System.Drawing.Point(13, 234);
            this.lbl98.Name = "lbl98";
            this.lbl98.Size = new System.Drawing.Size(98, 17);
            this.lbl98.TabIndex = 21;
            this.lbl98.Text = "First Played";
            // 
            // actLbl_times
            // 
            this.actLbl_times.AutoSize = true;
            this.actLbl_times.BackColor = System.Drawing.Color.Transparent;
            this.actLbl_times.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actLbl_times.ForeColor = System.Drawing.Color.Aquamarine;
            this.actLbl_times.Location = new System.Drawing.Point(13, 202);
            this.actLbl_times.Name = "actLbl_times";
            this.actLbl_times.Size = new System.Drawing.Size(92, 18);
            this.actLbl_times.TabIndex = 20;
            this.actLbl_times.Text = "{X} times";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.Color.Transparent;
            this.label99.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.Color.White;
            this.label99.Location = new System.Drawing.Point(13, 180);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(109, 17);
            this.label99.TabIndex = 19;
            this.label99.Text = "Times Played";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Average Playtime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Playtime";
            // 
            // cmbProfile
            // 
            this.cmbProfile.FormattingEnabled = true;
            this.cmbProfile.Location = new System.Drawing.Point(416, 11);
            this.cmbProfile.Name = "cmbProfile";
            this.cmbProfile.Size = new System.Drawing.Size(153, 21);
            this.cmbProfile.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Profile Select:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1312, 572);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbProfile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowGameList);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnFTP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "PS5 Activity Log - v0.9";
            ((System.ComponentModel.ISupportInitialize)(this.pbAct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFTP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.FlowLayoutPanel flowGameList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label actLbl_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label actLbl_last;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label actLbl_first;
        private System.Windows.Forms.Label lbl98;
        private System.Windows.Forms.Label actLbl_times;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label actLbl_avg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label actLbl_title;
        private System.Windows.Forms.PictureBox pbAct;
        private System.Windows.Forms.ComboBox cmbProfile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label actLbl_name;
    }
}

