using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZappCash.forms
{
    public partial class MainPage : Form
    {

        public MainPage()
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
            AccountsManager.New();
            AccountsPage AccountsPage = new AccountsPage();
            AccountsPage.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileManager.OpenFile();
            TransactionsPage TransactionsPage = new TransactionsPage();
            TransactionsPage.Show();
        }
    }
}
