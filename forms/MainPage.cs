using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZappCash.database;

namespace ZappCash.forms
{
    public partial class MainPage : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            this.Hide();

            AccountsManager.New();

            AccountsPage accountsPage = new AccountsPage();
            accountsPage.ShowDialog();

            this.Show();
        }
        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            FileManager.OpenFile();

            if (db_ZappCash.AccessFile.Path != null)
            {
                this.Hide();

                AccountsPage accountsPage = new AccountsPage();
                accountsPage.ShowDialog();
                
                this.Show();
            }
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
