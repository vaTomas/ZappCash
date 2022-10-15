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
    public partial class AccountsPage : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public AccountsPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void lblAddAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeAcc MakeAcc = new MakeAcc();
            MakeAcc.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage MainPage = new MainPage();
            MainPage.Show();
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileManager.OpenFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileManager.Save();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            FileManager.SaveAs();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
