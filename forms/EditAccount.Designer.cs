namespace ZappCash.forms
{
    partial class EditAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbParentAccount = new System.Windows.Forms.ComboBox();
            this.chkPlaceholder = new System.Windows.Forms.CheckBox();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Gilroy ExtraBold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 46);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gilroy ExtraBold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(1151, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 46);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "ACCOUNT  NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(47, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 49);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESCRIPTION";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(582, 350);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(513, 41);
            this.txtDescription.TabIndex = 10;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveChanges.Location = new System.Drawing.Point(56, 592);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(427, 71);
            this.btnSaveChanges.TabIndex = 12;
            this.btnSaveChanges.Text = "SAVE CHANGES";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(573, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 49);
            this.label4.TabIndex = 13;
            this.label4.Text = "PHP";
            // 
            // txtAccountName
            // 
            this.txtAccountName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountName.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.ForeColor = System.Drawing.Color.Black;
            this.txtAccountName.Location = new System.Drawing.Point(582, 70);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(513, 41);
            this.txtAccountName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(47, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 49);
            this.label5.TabIndex = 15;
            this.label5.Text = "OPENING BALANCE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(47, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 49);
            this.label6.TabIndex = 16;
            this.label6.Text = "PARENT ACCOUNT";
            // 
            // cmbParentAccount
            // 
            this.cmbParentAccount.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParentAccount.Location = new System.Drawing.Point(582, 140);
            this.cmbParentAccount.Name = "cmbParentAccount";
            this.cmbParentAccount.Size = new System.Drawing.Size(513, 42);
            this.cmbParentAccount.TabIndex = 35;
            // 
            // chkPlaceholder
            // 
            this.chkPlaceholder.AutoSize = true;
            this.chkPlaceholder.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlaceholder.Location = new System.Drawing.Point(582, 210);
            this.chkPlaceholder.Name = "chkPlaceholder";
            this.chkPlaceholder.Size = new System.Drawing.Size(312, 53);
            this.chkPlaceholder.TabIndex = 19;
            this.chkPlaceholder.Text = "PLACEHOLDER";
            this.chkPlaceholder.UseVisualStyleBackColor = true;
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpeningBalance.Location = new System.Drawing.Point(675, 280);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(420, 41);
            this.txtOpeningBalance.TabIndex = 11;
            // 
            // EditAccount
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1205, 707);
            this.Controls.Add(this.chkPlaceholder);
            this.Controls.Add(this.cmbParentAccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtOpeningBalance);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Account";
            this.Load += new System.EventHandler(this.MakeAcc_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbParentAccount;
        private System.Windows.Forms.CheckBox chkPlaceholder;
        private System.Windows.Forms.TextBox txtOpeningBalance;
    }
}

