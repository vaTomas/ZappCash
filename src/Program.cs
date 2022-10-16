using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZappCash.forms;
using ZappCash.forms.MessageBoxForms;
using ZappCash.forms.MessageBoxForms.EditOrDelete;

using System.Media;

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
