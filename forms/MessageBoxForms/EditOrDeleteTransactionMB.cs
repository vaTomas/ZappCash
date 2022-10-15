using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZappCash.forms.MessageBoxForms.EditOrDelete
{
    public partial class EditOrDeleteTransactionMB : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public EditOrDeleteTransactionMB()
        {
            InitializeComponent();
        }


        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            // Hide then show EditTransaction page
            this.Hide();
            EditTransaction editTransaction = new EditTransaction();
            editTransaction.Show();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            // Hide then show TransactionDeletionConfirmationMB
            this.Hide();
            TransactionDeletionConfirmationMB transactionDeletionConfirmationMB = new TransactionDeletionConfirmationMB();
            transactionDeletionConfirmationMB.Show();
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
    }
}
