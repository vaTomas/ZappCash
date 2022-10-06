using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZappCash.packages;
using ZappCash.packages.json;

namespace ZappCash.forms
{
    public partial class frmDebugConsole : Form
    {
        public frmDebugConsole()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string content = txtOutput.Text;

            jsonFile myFile = new jsonFile(@"C:\Users\vince\source\repos\ZappCash\test_output\save.zappcash");
            myFile.read();
            
            content += $"{myFile.jsonDeserialized}";
            txtOutput.Text = content;
        }
    }
}
