using System;
using System.Windows.Forms;
using ZappCash.forms;

namespace ZappCash
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileManager.ReloadDefaults();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool DebugMode = false;

            if (!DebugMode)
            {
                Application.Run(new MainPage());
            }
            else
            {
                Application.Run(new frmDebugConsole());
            }

            FileManager.TempDelete();
        }
    }
}
