using System;
using System.Windows.Forms;

namespace ZappCash.forms.MessageBoxForms
{
    public partial class NoNameMB : Form
    {
        public NoNameMB()
        {
            InitializeComponent();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeAcc MakeAcc = new MakeAcc();
            MakeAcc.Show();
        }
    }
}
