using System;
using System.Drawing;
using System.Windows.Forms;

using ZappCash.database;
using ZappCash.forms.MessageBoxForms;

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

            if (accountsPage.DialogResult == DialogResult.Abort) { this.Close(); return; }

            this.Show();
        }
        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                FileManager.OpenFile();
            }
            catch
            {
                this.Hide();
                NoNameMB noNameMB = new NoNameMB("Unsupported File");
                noNameMB.ShowDialog();
                this.Show();
                return;
            }

            if (db_ZappCash.AccessFile.Path != null)
            {
                this.Hide();

                AccountsPage accountsPage = new AccountsPage();
                accountsPage.ShowDialog();

                if (accountsPage.DialogResult == DialogResult.Abort) { this.Close(); return; }

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

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
