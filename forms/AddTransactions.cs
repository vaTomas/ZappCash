using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZappCash.classes;
using ZappCash.forms.MessageBoxForms;

namespace ZappCash.forms
{
    public partial class AddTransactions : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private Account account;

        public AddTransactions(string AccountId)
        {
            this.account = AccountsManager.GetAccount(AccountId);

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
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
            string transferAccountId = ((ComboBoxItem)cmbTransferAccount.SelectedItem).HiddenValue;
            string description = txtDescription.Text;

            long amount = (long)(long.Parse($"{numericUpDown1.Value}E{account.Decimals}", System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowDecimalPoint));
            if (radioButtonSend.Checked)
            {
                amount = -amount;
            }

            AccountsManager.NewTransaction(AccountID: this.account.Id, TransferAccountId: transferAccountId, Date: date, Number: number, Description: description, Amount: amount);

            this.Hide();
            SuccessfulTransactionAdditionMB successfulTransactionAdditionMB = new SuccessfulTransactionAdditionMB();
            successfulTransactionAdditionMB.ShowDialog();
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddTransactions_Load(object sender, EventArgs e)
        {
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
    }
}
