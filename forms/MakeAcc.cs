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
using ZappCash.database;
using ZappCash.forms.MessageBoxForms;

namespace ZappCash.forms
{
    public partial class MakeAcc : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private string parentId;
        public MakeAcc(string ParentId = null)
        {
            InitializeComponent();
            this.parentId = ParentId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                this.Hide();

                NoNameMB noNameMB = new NoNameMB("Please enter an account name.");
                noNameMB.ShowDialog();
                this.Show();
                return;
            }
            
            
            List<Account> accounts = AccountsManager.GetAccounts();


            
            string parentId = ((ComboBoxItem)cmbParentAccount.SelectedItem).HiddenValue;
            if (parentId == db_ZappCash.Defaults.AccountDefaults.ParentId)
            {
                parentId = null;
            }


            string accountName = txtAccountName.Text;
            bool isPlaceholder = chkPlaceholder.Checked;
            string description = txtDescription.Text;

            AccountsManager.NewAccount(ParentId: parentId, Name: accountName, IsPlaceholder: isPlaceholder, Description: description);
            string accountId = AccountsManager.GetAccountId(ParentAccountId: parentId, AccountName: accountName);

            //opening balance
            long amount = (long)(numOpeningBalance.Value * 100);
            if (amount > 0)
            {
                string openingBalanceAccountId = AccountsManager.GetAccountId("Opening Balances");

                if (openingBalanceAccountId == null)
                {
                    string equityAccountId = AccountsManager.GetAccountId("Equity");

                    if (equityAccountId == null)
                    {
                        AccountsManager.NewAccount(Name: "Equity", IsPlaceholder: true);
                    }

                    equityAccountId = AccountsManager.GetAccountId("Equity");

                    AccountsManager.NewAccount(ParentId: equityAccountId, Name: "Opening Balances");
                }

                openingBalanceAccountId = AccountsManager.GetAccountId("Opening Balances");

                AccountsManager.NewTransaction(AccountID: accountId, TransferAccountId: openingBalanceAccountId, Amount: amount, Description: "Opening Balance");
            }

            

            //window
            this.Hide();
            SuccessfulAccountCreationMB SuccessfulAccountCreationMB = new SuccessfulAccountCreationMB();
            SuccessfulAccountCreationMB.ShowDialog();
            this.Close();

           
        }

        private void button1_Click_1(object sender, EventArgs e)
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


        private void MakeAcc_Load(object sender, EventArgs e)
        {
            List<Account> accounts = AccountsManager.GetAccounts();
            //dropdown load
            cmbParentAccount.Items.Add(new ComboBoxItem("New top level account", db_ZappCash.Defaults.AccountDefaults.ParentId));
            foreach (Account account in accounts)
            {
                string accountName = AccountsManager.GetLongAccountName(account.Id);

                cmbParentAccount.Items.Add(new ComboBoxItem(accountName, account.Id));
            }

            cmbParentAccount.SelectedIndex = AccountsManager.GetAccountIndex(parentId) + 1;

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
