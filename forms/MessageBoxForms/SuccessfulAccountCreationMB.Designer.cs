﻿namespace ZappCash.forms
{
    partial class SuccessfulAccountCreationMB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessfulAccountCreationMB));
            this.btnBackToAccounts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToAccounts
            // 
            this.btnBackToAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
            this.btnBackToAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToAccounts.FlatAppearance.BorderSize = 0;
            this.btnBackToAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToAccounts.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToAccounts.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBackToAccounts.Location = new System.Drawing.Point(0, 313);
            this.btnBackToAccounts.Name = "btnBackToAccounts";
            this.btnBackToAccounts.Size = new System.Drawing.Size(421, 52);
            this.btnBackToAccounts.TabIndex = 1;
            this.btnBackToAccounts.Text = "BACK TO ACCOUNTS";
            this.btnBackToAccounts.UseVisualStyleBackColor = false;
            this.btnBackToAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Gilroy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 59);
            this.label2.TabIndex = 6;
            this.label2.Text = "You have successfully added an account.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Gilroy ExtraBold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "CONGRATULATIONS!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxError.ErrorImage = null;
            this.pictureBoxError.Image = global::ZappCash.Properties.Resources.check_icon;
            this.pictureBoxError.Location = new System.Drawing.Point(112, 59);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(196, 79);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 4;
            this.pictureBoxError.TabStop = false;
            // 
            // SuccessfulAccountCreationMB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(421, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxError);
            this.Controls.Add(this.btnBackToAccounts);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuccessfulAccountCreationMB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZappCash";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SuccessfulAccountCreationMB_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SuccessfulAccountCreationMB_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SuccessfulAccountCreationMB_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackToAccounts;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

