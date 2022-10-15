using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZappCash.forms.MessageBoxForms.EditOrDelete
{
    public partial class EditOrDeleteTransactionMB : Form
    {
        private string accountId { get; set; }
        private string transactionId { get; set; }


        private bool mouseDown;
        private Point lastLocation;
        public EditOrDeleteTransactionMB(string AccountId, string TransactionId)
        {
            InitializeComponent();
            this.accountId = AccountId;
            this.transactionId = TransactionId;
        }


        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            // Hide then show EditTransaction page
            this.Hide();
            EditTransaction editTransaction = new EditTransaction(AccountId: accountId, TransactionId: transactionId);
            editTransaction.ShowDialog();
            this.Close();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            // Hide then show TransactionDeletionConfirmationMB
            this.Hide();
            TransactionDeletionConfirmationMB transactionDeletionConfirmationMB = new TransactionDeletionConfirmationMB();
            transactionDeletionConfirmationMB.ShowDialog();

            if (transactionDeletionConfirmationMB.DialogResult == DialogResult.Yes)
            {
                
                AccountsManager.DeleteTransaction(transactionId);

                SuccessfulTransactionDeletionMB successfulTransactionDeletionMB = new SuccessfulTransactionDeletionMB();
                successfulTransactionDeletionMB.ShowDialog();

                this.Close();
            }

            this.Show();
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

        private void EditOrDeleteTransactionMB_Load(object sender, EventArgs e)
        {

        }
    }
}
