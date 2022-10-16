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

namespace ZappCash.forms
{
    public partial class EditTransaction : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private Transaction transaction;
        private string accountId;
        public EditTransaction(string AccountId, string TransactionId)
        {
            InitializeComponent();
            this.transaction = AccountsManager.GetTransaction(AccountId, TransactionId);
            this.accountId = AccountId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            this.Hide();

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
            //dropdown load
            List<Account> accounts = AccountsManager.GetAccounts();
            foreach (Account account in accounts)
            {
                if (!account.IsPlaceholder)
                {
                    string accountName = account.Attributes.Name;
                    string accountParentName = AccountsManager.GetAccount(account.ParentId).Attributes.Name;

                    cmbTransferAccount.Items.Add($"{AccountsManager.GetLongAccountName(account.Id)}");
                }
            }
        }

        private void LoadItems()
        {
            dateTimePicker1.Value = this.transaction.Date;
            txtNumber.Text = this.transaction.Number;
            txtDescription.Text = this.transaction.Description;



        }




    }
}
