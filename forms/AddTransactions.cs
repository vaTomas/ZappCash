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
    public partial class AddTransactions : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public AddTransactions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionsPage TransactionsPage = new TransactionsPage();
            TransactionsPage.Show();
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
                if (!account.IsPlaceholder)
                {
                    string accountName = account.Attributes.Name;
                    string accountParentName = AccountsManager.GetAccount(account.ParentId).Attributes.Name;

                    cmbTransferAccount.Items.Add($"{AccountsManager.GetLongAccountName(account.Id)}");
                }
            }
        }
    }
}
