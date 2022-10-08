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

using ZappCash.database;
using ZappCash.classes;
using ZappCash;

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
            //string content = txtOutput.Text;


            //string fileLocation = @"C:\Users\vince\source\repos\ZappCash\test_output\save.zappcash";
            //AccountsControl instance = new AccountsControl(FileManager.OpenFile());

            //instance.GetTransaction(AccountID: "000007E6A040D346", TransactionID: "FF2C07E6A040CF0B");
            //instance.NewTransaction(AccountID: "000007E6A040D335", TransferAccountId: "000007E6A040D346", Amount: 10000);

            //foreach (var i in instance.Accounts[0].Transactions)
            //{
            //    content += $"{i.Id}: {i.Amount}\r\n";
            //}

            //content += $"{instance.SelectedAccount.Attributes.Name}: {instance.SelectedTransaction.Description}\r\n";
            
            //txtOutput.Text = content;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            
        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            FileManager.OpenFile();
        }

        private void frmDebugConsole_Load(object sender, EventArgs e)
        {
        }

        private void btnTempSave_Click(object sender, EventArgs e)
        {
            FileManager.TempSave();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileManager.Save();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            string parentId = txtAccountParentId.Text;
            byte decimals = Convert.ToByte(cmbAccountDecimal.SelectedIndex);
            string name = txtAccountName.Text;
            string code = txtAccountCode.Text;
            string description = txtAccountDescription.Text;
            string color = txtAccountColor.Text;
            string notes = txtAccountNotes.Text;
            string assetType = cmbAccountAssetType.Text;
            bool isPlaceholder = chkAccountPlaceholder.Checked;

            AccountsManager.NewAccount(ParentId: parentId, Decimals: decimals, Name: name, Code: code, Description: description, Color: color, Notes: notes, AssetType: assetType, IsPlaceholder: isPlaceholder);

            Account account = db_ZappCash.Accounts.Last();

            txtOutput.AppendText($"New account {account.Id} successfuly Created \r\n");

        }
    }
}
