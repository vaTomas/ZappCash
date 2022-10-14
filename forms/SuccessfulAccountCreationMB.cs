using System;
using System.Windows.Forms;

namespace ZappCash.forms
{
    public partial class SuccessfulAccountCreationMB : Form
    {
        public SuccessfulAccountCreationMB()
        {
            InitializeComponent();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountsPage AccountsPage = new AccountsPage();
            AccountsPage.Show();
        }
    }
}
