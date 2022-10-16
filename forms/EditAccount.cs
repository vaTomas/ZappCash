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
using ZappCash.forms.MessageBoxForms.EditOrDelete;
using ZappCash.forms.MessageBoxForms;
using ZappCash.database;

namespace ZappCash.forms
{
    public partial class EditAccount : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private Account account { get; set; }


        public EditAccount(string AccountId)
        {
            InitializeComponent();
            this.account = AccountsManager.GetAccount(AccountId);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                this.Hide();
                NoNameMB noNameMB = new NoNameMB();
                noNameMB.ShowDialog();
                this.Show();
                return;
            }
            
            
            this.Hide();
            SaveAccountChangesConfirmationMB saveAccountChangesConfirmationMB = new SaveAccountChangesConfirmationMB();
            saveAccountChangesConfirmationMB.ShowDialog();
            this.Show();

            if (saveAccountChangesConfirmationMB.DialogResult == DialogResult.Yes)
            {
                string accountName = txtAccountName.Text;
                string parentId = ((ComboBoxItem)cmbParentAccount.SelectedItem).HiddenValue;
                bool isPlaceholder = chkPlaceholder.Checked;
                string description = txtDescription.Text;

                AccountsManager.EditAccount(AccountId: this.account.Id, Name: accountName, ParentId: parentId, IsPlaceholder: isPlaceholder, Description: description);
                this.Close();
            }

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
            //dropdown load
            List<Account> accounts = AccountsManager.GetAccounts();
            cmbParentAccount.Items.Add(new ComboBoxItem("Top level", db_ZappCash.Defaults.AccountDefaults.ParentId));
            foreach (Account account in accounts)
            {
                if(account.Id != this.account.Id)
                {
                    if (account.ParentId != this.account.Id)
                    {
                        string accountName = AccountsManager.GetLongAccountName(account.Id);

                        cmbParentAccount.Items.Add(new ComboBoxItem(accountName, account.Id));

                    }
                }
            }

            //info
            txtAccountName.Text = this.account.Attributes.Name;

            {
                int index = 0;
                string parentId = this.account.ParentId;
                if (parentId == null)
                {
                    parentId = db_ZappCash.Defaults.AccountDefaults.ParentId;
                }

                foreach (ComboBoxItem item in cmbParentAccount.Items) {
                    if (item.HiddenValue == parentId)
                    {
                        cmbParentAccount.SelectedIndex = index;
                        break;
                    }
                    index++;
                }
            }

            
            chkPlaceholder.Checked = this.account.IsPlaceholder;
            txtDescription.Text = this.account.Attributes.Description;

        }

        public class ComboBoxItem
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
