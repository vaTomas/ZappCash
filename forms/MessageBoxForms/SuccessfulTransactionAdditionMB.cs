using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZappCash.forms
{
    public partial class SuccessfulTransactionAdditionMB : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public SuccessfulTransactionAdditionMB()
        {
            InitializeComponent();
        }

        private void btnBackToTransactions_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuccessfulAccountCreationMB_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void SuccessfulAccountCreationMB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void SuccessfulAccountCreationMB_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
