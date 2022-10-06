using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;


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

            string fileLocation = @"C:\Users\vince\source\repos\ZappCash\test_output\save.zappcash";
            AccountsControl instance = new AccountsControl(fileLocation);
            var accounts = instance.OpenAccounts();
            
            foreach(var item in accounts)
            {

                foreach (var txn in item.transactions)
                {
                    content += $"{txn.id} \r\n";
                }
            }
            txtOutput.Text = content;
        }
    }
}
