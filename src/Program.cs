using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            
            bool DebugMode = true;

            if (!DebugMode)
            {
                Application.Run(new frmHome());
            }
            else
            {
                Application.Run(new frmDebugConsole());
            }
        }
    }
}
