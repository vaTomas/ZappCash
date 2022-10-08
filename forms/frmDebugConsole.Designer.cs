namespace ZappCash.forms
{
    partial class frmDebugConsole
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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnTempSave = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAccountParentId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.lblAccountDecimal = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.cmbAccountDecimal = new System.Windows.Forms.ComboBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAccountAssetType = new System.Windows.Forms.ComboBox();
            this.chkAccountPlaceholder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(9, 641);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(666, 20);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(9, 47);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(666, 437);
            this.txtOutput.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(689, 641);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(770, 641);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Open a FIle";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnTempSave
            // 
            this.btnTempSave.AccessibleDescription = "";
            this.btnTempSave.Location = new System.Drawing.Point(93, 12);
            this.btnTempSave.Name = "btnTempSave";
            this.btnTempSave.Size = new System.Drawing.Size(75, 23);
            this.btnTempSave.TabIndex = 5;
            this.btnTempSave.Text = "Temp Save";
            this.btnTempSave.UseVisualStyleBackColor = true;
            this.btnTempSave.Click += new System.EventHandler(this.btnTempSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAccountParentId
            // 
            this.txtAccountParentId.Location = new System.Drawing.Point(826, 47);
            this.txtAccountParentId.Name = "txtAccountParentId";
            this.txtAccountParentId.Size = new System.Drawing.Size(121, 20);
            this.txtAccountParentId.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(733, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Parent ID";
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(804, 278);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(116, 23);
            this.btnNewAccount.TabIndex = 9;
            this.btnNewAccount.Text = "Add New Account";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // lblAccountDecimal
            // 
            this.lblAccountDecimal.AutoSize = true;
            this.lblAccountDecimal.Location = new System.Drawing.Point(733, 76);
            this.lblAccountDecimal.Name = "lblAccountDecimal";
            this.lblAccountDecimal.Size = new System.Drawing.Size(87, 13);
            this.lblAccountDecimal.TabIndex = 11;
            this.lblAccountDecimal.Text = "Smallest Fraction";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(733, 102);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(35, 13);
            this.lblAccountName.TabIndex = 13;
            this.lblAccountName.Text = "Name";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(826, 99);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(121, 20);
            this.txtAccountName.TabIndex = 12;
            // 
            // cmbAccountDecimal
            // 
            this.cmbAccountDecimal.FormattingEnabled = true;
            this.cmbAccountDecimal.Items.AddRange(new object[] {
            "1/1",
            "1/10",
            "1/100",
            "1/1000",
            "1/10000",
            "1/100000"});
            this.cmbAccountDecimal.Location = new System.Drawing.Point(826, 72);
            this.cmbAccountDecimal.Name = "cmbAccountDecimal";
            this.cmbAccountDecimal.Size = new System.Drawing.Size(121, 21);
            this.cmbAccountDecimal.TabIndex = 14;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(733, 128);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 16;
            this.lblCode.Text = "Code";
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.Location = new System.Drawing.Point(826, 125);
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(121, 20);
            this.txtAccountCode.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Description";
            // 
            // txtAccountDescription
            // 
            this.txtAccountDescription.Location = new System.Drawing.Point(826, 151);
            this.txtAccountDescription.Name = "txtAccountDescription";
            this.txtAccountDescription.Size = new System.Drawing.Size(121, 20);
            this.txtAccountDescription.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Color";
            // 
            // txtAccountColor
            // 
            this.txtAccountColor.Location = new System.Drawing.Point(826, 177);
            this.txtAccountColor.Name = "txtAccountColor";
            this.txtAccountColor.Size = new System.Drawing.Size(121, 20);
            this.txtAccountColor.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(733, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Notes";
            // 
            // txtAccountNotes
            // 
            this.txtAccountNotes.Location = new System.Drawing.Point(826, 203);
            this.txtAccountNotes.Name = "txtAccountNotes";
            this.txtAccountNotes.Size = new System.Drawing.Size(121, 20);
            this.txtAccountNotes.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(733, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Asset Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Placeholder";
            // 
            // cmbAccountAssetType
            // 
            this.cmbAccountAssetType.FormattingEnabled = true;
            this.cmbAccountAssetType.Items.AddRange(new object[] {
            "PHP"});
            this.cmbAccountAssetType.Location = new System.Drawing.Point(826, 229);
            this.cmbAccountAssetType.Name = "cmbAccountAssetType";
            this.cmbAccountAssetType.Size = new System.Drawing.Size(121, 21);
            this.cmbAccountAssetType.TabIndex = 27;
            // 
            // chkAccountPlaceholder
            // 
            this.chkAccountPlaceholder.AutoSize = true;
            this.chkAccountPlaceholder.Location = new System.Drawing.Point(826, 258);
            this.chkAccountPlaceholder.Name = "chkAccountPlaceholder";
            this.chkAccountPlaceholder.Size = new System.Drawing.Size(15, 14);
            this.chkAccountPlaceholder.TabIndex = 28;
            this.chkAccountPlaceholder.UseVisualStyleBackColor = true;
            // 
            // frmDebugConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 676);
            this.Controls.Add(this.chkAccountPlaceholder);
            this.Controls.Add(this.cmbAccountAssetType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccountNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccountDescription);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtAccountCode);
            this.Controls.Add(this.cmbAccountDecimal);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.lblAccountDecimal);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAccountParentId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTempSave);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtCommand);
            this.Name = "frmDebugConsole";
            this.Text = "frmDebugConsole";
            this.Load += new System.EventHandler(this.frmDebugConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnTempSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAccountParentId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Label lblAccountDecimal;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.ComboBox cmbAccountDecimal;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtAccountCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAccountAssetType;
        private System.Windows.Forms.CheckBox chkAccountPlaceholder;
    }
}