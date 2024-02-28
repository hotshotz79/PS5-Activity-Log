![Hit](https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https%3A%2F%2Fgithub.com%2F{hotshotz79}1212%2Fhit-counter)
![Github All Releases](https://img.shields.io/github/downloads/hotshotz79/PS5-Activity-Log/total)
![tag](https://img.shields.io/github/v/release/hotshotz79/PS5-Activity-Log)
![GitHub Issues](https://img.shields.io/github/issues/hotshotz79/PS5-Activity-Log)
![GitHub](https://img.shields.io/github/license/hotshotz79/PS5-Activity-Log)
![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)
<br>
<!-- Add hyperlink to Discord and Reddit post -->
![GitHub-Banner](https://github.com/hotshotz79/PS5-Activity-Log/assets/7006684/a62c8491-f95c-4ad9-9415-f490dc1cd006)

<p align="center"><b>PS5 Activity Log</b></p>
<p align="center">An app to display playtime activities from PlayStation 5</p>

<p align="center">
  <a href="https://github.com/hotshotz79/PS5-Activity-Log/releases">Download</a>
</p>

____

# About

Users on exploited PS5 do not have the capability to view playtime for any game they play. This app connects to the PS5, grabbing the database that stores all the acitivity log and then displays the details to the user.

**Note:**
* An active connection to the PS5 via FTP is required
* App has to be extracted to a local folder before running (executing from .zip file will cause issues)
* The file size varies for the activity log database (sl2_log.db), therefore patience is required when its being downloaded

![MainMenu](https://github.com/hotshotz79/PS5-Activity-Log/assets/7006684/23ca6a92-a271-4bf0-81b3-65aab8fa8a87)

Created using;
![VS](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white) ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
____

# Features

* Downloads the activity log database (sl2_log.db); skips if same file name/size already exists for faster results
* Displays all current installed games (including virtual games from ItemFlowz titled * FG *)
* Playtime stats includes
  * Total time spent
  * Average per session
  * Number of times played
  * First time and
  * Last time played
____

# Requirements

* Jailbroken PS5 with FTP access
* .NET Framework 4.6
____

# Known Issues

* [Unconfirmed] if a game crashes where the PS5 reboots; no log will be recorded for that session
* The activity log database (sl2_log.db) returns a "database disk image is malformed" error however still able to query
____

# Future Enhancements

* Offline function
* Deleted games history

____

# Credits

* Inspired by [NX-Activity Log](https://github.com/tallbl0nde/NX-Activity-Log)
* Support from [LightningMods](https://twitter.com/LightningMods_)
