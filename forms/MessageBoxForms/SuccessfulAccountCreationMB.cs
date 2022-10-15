﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZappCash.forms
{
    public partial class SuccessfulAccountCreationMB : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public SuccessfulAccountCreationMB()
        {
            InitializeComponent();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountsPage accountsPage = new AccountsPage();
            accountsPage.Show();
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