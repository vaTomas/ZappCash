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

            instance.GetTransaction(AccountID: "000007E6A040D346", TransactionID: "FF2C07E6A040CF0B");

            content += $"{instance.SelectedAccount.Attributes.Name}: {instance.SelectedTransaction.Description}\r\n";

            txtOutput.Text = content;
        }
    }
}
