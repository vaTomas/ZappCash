namespace ZappCash.forms
{
    partial class AddTransactions
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
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTransferAccount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.radioButtonSend = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPositiveNegative = new System.Windows.Forms.Label();
            this.radioButtonReceive = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
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
            this.btnBack.Size = new System.Drawing.Size(53, 46);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
            this.btnAddTransaction.FlatAppearance.BorderSize = 0;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddTransaction.Location = new System.Drawing.Point(56, 592);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(427, 71);
            this.btnAddTransaction.TabIndex = 1;
            this.btnAddTransaction.Text = "ADD TRANSACTION";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(47, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "DATE";
            // 
            // cmbTransferAccount
            // 
            this.cmbTransferAccount.BackColor = System.Drawing.Color.White;
            this.cmbTransferAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransferAccount.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransferAccount.FormattingEnabled = true;
            this.cmbTransferAccount.ItemHeight = 34;
            this.cmbTransferAccount.Location = new System.Drawing.Point(582, 210);
            this.cmbTransferAccount.Name = "cmbTransferAccount";
            this.cmbTransferAccount.Size = new System.Drawing.Size(513, 42);
            this.cmbTransferAccount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(47, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 49);
            this.label2.TabIndex = 9;
            this.label2.Text = "TRANSFER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(47, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 49);
            this.label3.TabIndex = 11;
            this.label3.Text = "DESCRIPTION";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(582, 420);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(513, 41);
            this.txtDescription.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(47, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 49);
            this.label6.TabIndex = 16;
            this.label6.Text = "NUMBER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(47, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 49);
            this.label8.TabIndex = 18;
            this.label8.Text = "AMOUNT";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.White;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.Black;
            this.txtNumber.Location = new System.Drawing.Point(582, 140);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(513, 41);
            this.txtNumber.TabIndex = 19;
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmount.Location = new System.Drawing.Point(710, 350);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(385, 41);
            this.numAmount.TabIndex = 20;
            this.numAmount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radioButtonSend
            // 
            this.radioButtonSend.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSend.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSend.ForeColor = System.Drawing.Color.Transparent;
            this.radioButtonSend.Location = new System.Drawing.Point(582, 280);
            this.radioButtonSend.Name = "radioButtonSend";
            this.radioButtonSend.Size = new System.Drawing.Size(143, 56);
            this.radioButtonSend.TabIndex = 23;
            this.radioButtonSend.TabStop = true;
            this.radioButtonSend.Text = "SEND";
            this.radioButtonSend.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(608, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 49);
            this.label9.TabIndex = 24;
            this.label9.Text = "PHP";
            // 
            // lblPositiveNegative
            // 
            this.lblPositiveNegative.AutoSize = true;
            this.lblPositiveNegative.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositiveNegative.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPositiveNegative.Location = new System.Drawing.Point(573, 350);
            this.lblPositiveNegative.Name = "lblPositiveNegative";
            this.lblPositiveNegative.Size = new System.Drawing.Size(44, 49);
            this.lblPositiveNegative.TabIndex = 25;
            this.lblPositiveNegative.Text = "+";
            // 
            // radioButtonReceive
            // 
            this.radioButtonReceive.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonReceive.Font = new System.Drawing.Font("Gilroy ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonReceive.ForeColor = System.Drawing.Color.Transparent;
            this.radioButtonReceive.Location = new System.Drawing.Point(760, 280);
            this.radioButtonReceive.Name = "radioButtonReceive";
            this.radioButtonReceive.Size = new System.Drawing.Size(197, 56);
            this.radioButtonReceive.TabIndex = 26;
            this.radioButtonReceive.TabStop = true;
            this.radioButtonReceive.Text = "RECEIVE";
            this.radioButtonReceive.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(582, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(513, 41);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // AddTransactions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1205, 707);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonReceive);
            this.Controls.Add(this.lblPositiveNegative);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButtonSend);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTransferAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage1";
            this.Load += new System.EventHandler(this.AddTransactions_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTransferAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.RadioButton radioButtonSend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPositiveNegative;
        private System.Windows.Forms.RadioButton radioButtonReceive;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

