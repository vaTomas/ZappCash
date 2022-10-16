using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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

            txtOutput.AppendText($"Successfully Saved to {db_ZappCash.AccessFile.Path} \r\n");
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

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            string accountId = txtTransactionAccountId.Text;
            DateTime date = dateTransactionDate.Value.Date;
            string number = txtTransactionNumber.Text;
            string description = txtTransactionDescription.Text;
            string transferId = txtTransactionTransferAccountId.Text;
            long amount = Convert.ToInt64(txtTransactionAmount.Text);

            AccountsManager.NewTransaction(AccountID: accountId, TransferAccountId: transferId, Date: date, Number: number, Description: description, Amount: amount);

            Account account = AccountsManager.GetAccount(accountId);

            Transaction transaction = account.Transactions.Last();

            txtOutput.AppendText($"New transaction {transaction.Id} successfuly Created \r\n");
        }

        private void btnTransactionDelete_Click(object sender, EventArgs e)
        {
            string transactionId = txtDeleteTransactionId.Text;
            AccountsManager.DeleteTransaction(transactionId);

            txtOutput.AppendText($"Transaction {transactionId} successfuly Deleted \r\n");
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string accountId = txtDeleteAccountId.Text;
            AccountsManager.DeleteAccount(accountId);

            txtOutput.AppendText($"Account {accountId} and all of its transaction successfuly Deleted \r\n");
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            FileManager.SaveAs();

            txtOutput.AppendText($"Successfully Saved to {db_ZappCash.AccessFile.Path} \r\n");
        }

        private void btnUpdateBalances_Click(object sender, EventArgs e)
        {
            AccountsManager.UpdateBalances();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AccountsManager.New();
        }

        private void btnShowAccounts_Click(object sender, EventArgs e)
        {
            foreach (Account account in AccountsManager.GetAccounts())
            {
                txtOutput.AppendText($"{account.Id} | {account.ParentId} | {account.Attributes.Name} \r\n");
            }
        }

        private void btnShowTransactions_Click(object sender, EventArgs e)
        {
            string accountId = txtShowTransactionsAccountId.Text;
            List<Transaction> transactions = AccountsManager.GetTransactions(accountId);

            foreach (Transaction transaction in transactions)
            {
                txtOutput.AppendText($"{transaction.Id} | {transaction.Description} | {transaction.Amount} \r\n");
            }
        }

        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            string accountId = txtTransactionAccountId.Text;
            DateTime date = dateTransactionDate.Value.Date;
            string number = txtTransactionNumber.Text;
            string description = txtTransactionDescription.Text;
            string transferId = txtTransactionTransferAccountId.Text;
            long amount = Convert.ToInt64(txtTransactionAmount.Text);
            string transactionId = txtTransactionId.Text;

            AccountsManager.EditTransaction(AccountId: accountId, TransactionId: transactionId, Date: date, Number: number, Description: description, TransferId: transferId, Amount: amount);

            txtOutput.AppendText($"Transaction {transactionId} successfuly Edited \r\n");
        }

        private void btnTransactionGet_Click(object sender, EventArgs e)
        {
            string transactionId = txtTransactionId.Text;
            string accountId = txtTransactionAccountId.Text;
            Transaction transaction = AccountsManager.GetTransaction(AccountId: accountId, TransactionId: transactionId);

            dateTransactionDate.Value = transaction.Date;
            txtTransactionNumber.Text = transaction.Number;
            txtTransactionDescription.Text = transaction.Description;
            txtTransactionTransferAccountId.Text = transaction.TransferId;
            txtTransactionAmount.Text = transaction.Amount.ToString();

        }

        private void btnSoundAsterisk_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }

        private void btnSoundBeep_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnSoundExclamation_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void btnSoundHand_Click(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
        }

        private void btnSoundQuestion_Click(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
        }
    }
}
