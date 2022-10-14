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
    public partial class EditAccount : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public EditAccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AccountsPage AccountsPage = new AccountsPage();
            AccountsPage.Show();
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
            foreach (Account account in accounts)
            {
                string accountName = account.Attributes.Name;
                string accountParentName = AccountsManager.GetAccount(account.ParentId).Attributes.Name;

                cmbParentAccount.Items.Add($"{AccountsManager.GetLongAccountName(account.Id)}");
            }
        }


    }
}
