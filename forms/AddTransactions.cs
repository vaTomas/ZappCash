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
    public partial class AddTransactions : Form
    {
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
    }
}
