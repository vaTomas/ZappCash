using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZappCash.forms.MessageBoxForms.EditOrDelete
{
    public partial class TransactionDeletionConfirmationMB : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public TransactionDeletionConfirmationMB()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //delete transaction method then show SuccessfulTransactionDeletionMB
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
