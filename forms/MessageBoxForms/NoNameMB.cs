﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace ZappCash.forms.MessageBoxForms
{
    public partial class NoNameMB : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        public NoNameMB()
        {
            SystemSounds.Asterisk.Play();
            InitializeComponent();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NoNameMB_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void NoNameMB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void NoNameMB_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void NoNameMB_Load(object sender, EventArgs e)
        {
           
        }
    }
}
