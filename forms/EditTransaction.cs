using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZappCash.classes;
using ZappCash.forms.MessageBoxForms;
using ZappCash.forms.MessageBoxForms.EditOrDelete;

namespace ZappCash.forms
{
    public partial class EditTransaction : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private Transaction transaction { get; set; }
        private Account account { get; set; }
        public EditTransaction(string AccountId, string TransactionId)
        {
            InitializeComponent();
            this.transaction = AccountsManager.GetTransaction(AccountId, TransactionId);
            this.account = AccountsManager.GetAccount(AccountId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (cmbTransferAccount.SelectedIndex == -1)
            {
                this.Hide();
                NoNameMB noNameMB = new NoNameMB("Please select a transfer account.");
                noNameMB.ShowDialog();
                this.Show();
                return;
            }

            DateTime date = dateTimePicker1.Value;
            string number = txtNumber.Text;
            string description = txtDescription.Text;
            string transferId = ((ComboBoxItem)cmbTransferAccount.SelectedItem).HiddenValue;
            long amount = (long)(long.Parse($"{numAmount.Value}E{account.Decimals}", System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowDecimalPoint));
            if (radioButtonSend.Checked)
            {
                amount = -amount;
            }

            AccountsManager.EditTransaction(this.account.Id, this.transaction.Id, date, number, description, transferId, amount);
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EditTransaction_Load(object sender, EventArgs e)
        {


            dateTimePicker1.Value = transaction.Date;
            txtNumber.Text = transaction.Number;
            txtDescription.Text = transaction.Description;

            decimal amount = transaction.Amount * Decimal.Parse($"1E-{this.account.Decimals}", System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowDecimalPoint);

            if (transaction.Amount > 0)
            {
                numAmount.Value = amount;
                radioButtonReceive.Checked = true;
            }
            else
            {
                numAmount.Value = -amount;
                radioButtonSend.Checked = true;
            }
            
            //dropdown load
            List<Account> accounts = AccountsManager.GetAccounts();
            foreach (Account account in accounts)
            {
                if (!account.IsPlaceholder && account.Id != this.account.Id)
                {
                    string accountName = AccountsManager.GetLongAccountName(account.Id);
                    cmbTransferAccount.Items.Add(new ComboBoxItem(accountName, account.Id));
                }
            }

            {
                int selectedTransferAccountIndex = 0;
                foreach (ComboBoxItem comboBoxItem in cmbTransferAccount.Items)
                {
                    if (comboBoxItem.HiddenValue == transaction.TransferId)
                    {
                        cmbTransferAccount.SelectedIndex = selectedTransferAccountIndex;
                        break;
                    }
                    selectedTransferAccountIndex++;
                }
            }
        }

        private class ComboBoxItem
        {
            private string displayValue;
            private string hiddenValue;

            public ComboBoxItem(string displayValue, string hiddenValue)
            {
                this.displayValue = displayValue;
                this.hiddenValue = hiddenValue;
            }

            public string HiddenValue
            {
                get
                {
                    return this.hiddenValue;
                }
            }

            public override string ToString()
            {
                return this.displayValue;
            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionDeletionConfirmationMB transactionDeletionConfirmationMB = new TransactionDeletionConfirmationMB();
            transactionDeletionConfirmationMB.ShowDialog();

            if (transactionDeletionConfirmationMB.DialogResult == DialogResult.Yes)
            {

                AccountsManager.DeleteTransaction(transaction.Id);

                SuccessfulTransactionDeletionMB successfulTransactionDeletionMB = new SuccessfulTransactionDeletionMB();
                successfulTransactionDeletionMB.ShowDialog();

                this.Close();
            }

            this.Show();
        }
    }
}
