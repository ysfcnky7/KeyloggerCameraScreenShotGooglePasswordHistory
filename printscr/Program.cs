using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
namespace printscr
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Program genel hata");
        }
    }
}
