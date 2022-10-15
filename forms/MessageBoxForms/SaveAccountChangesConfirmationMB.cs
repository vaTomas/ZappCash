using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZappCash.forms.MessageBoxForms.EditOrDelete
{
    public partial class SaveAccountChangesConfirmationMB : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public SaveAccountChangesConfirmationMB()
        {
            InitializeComponent();
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

        private void btnYes_Click(object sender, EventArgs e)
        {
            // Save account changes method 
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
