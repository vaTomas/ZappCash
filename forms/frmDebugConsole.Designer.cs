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
            this.label8 = new System.Windows.Forms.Label();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTransactionTransferAccountId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTransactionDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTransactionNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTransactionAccountId = new System.Windows.Forms.TextBox();
            this.dateTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.txtDeleteTransactionId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTransactionDelete = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeleteAccountId = new System.Windows.Forms.TextBox();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnEditTransaction = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.btnUpdateBalances = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnShowAccounts = new System.Windows.Forms.Button();
            this.btnShowTransactions = new System.Windows.Forms.Button();
            this.txtShowTransactionsAccountId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTransactionGet = new System.Windows.Forms.Button();
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
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(666, 587);
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
            this.btnOpenFile.Location = new System.Drawing.Point(91, 12);
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
            this.btnTempSave.Location = new System.Drawing.Point(172, 12);
            this.btnTempSave.Name = "btnTempSave";
            this.btnTempSave.Size = new System.Drawing.Size(75, 23);
            this.btnTempSave.TabIndex = 5;
            this.btnTempSave.Text = "Temp Save";
            this.btnTempSave.UseVisualStyleBackColor = true;
            this.btnTempSave.Click += new System.EventHandler(this.btnTempSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAccountParentId
            // 
            this.txtAccountParentId.Location = new System.Drawing.Point(797, 47);
            this.txtAccountParentId.Name = "txtAccountParentId";
            this.txtAccountParentId.Size = new System.Drawing.Size(121, 20);
            this.txtAccountParentId.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(704, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Parent ID";
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(741, 278);
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
            this.lblAccountDecimal.Location = new System.Drawing.Point(704, 76);
            this.lblAccountDecimal.Name = "lblAccountDecimal";
            this.lblAccountDecimal.Size = new System.Drawing.Size(87, 13);
            this.lblAccountDecimal.TabIndex = 11;
            this.lblAccountDecimal.Text = "Smallest Fraction";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(704, 102);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(35, 13);
            this.lblAccountName.TabIndex = 13;
            this.lblAccountName.Text = "Name";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(797, 99);
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
            this.cmbAccountDecimal.Location = new System.Drawing.Point(797, 72);
            this.cmbAccountDecimal.Name = "cmbAccountDecimal";
            this.cmbAccountDecimal.Size = new System.Drawing.Size(121, 21);
            this.cmbAccountDecimal.TabIndex = 14;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(704, 128);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 16;
            this.lblCode.Text = "Code";
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.Location = new System.Drawing.Point(797, 125);
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(121, 20);
            this.txtAccountCode.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Description";
            // 
            // txtAccountDescription
            // 
            this.txtAccountDescription.Location = new System.Drawing.Point(797, 151);
            this.txtAccountDescription.Name = "txtAccountDescription";
            this.txtAccountDescription.Size = new System.Drawing.Size(121, 20);
            this.txtAccountDescription.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Color";
            // 
            // txtAccountColor
            // 
            this.txtAccountColor.Location = new System.Drawing.Point(797, 177);
            this.txtAccountColor.Name = "txtAccountColor";
            this.txtAccountColor.Size = new System.Drawing.Size(121, 20);
            this.txtAccountColor.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Notes";
            // 
            // txtAccountNotes
            // 
            this.txtAccountNotes.Location = new System.Drawing.Point(797, 203);
            this.txtAccountNotes.Name = "txtAccountNotes";
            this.txtAccountNotes.Size = new System.Drawing.Size(121, 20);
            this.txtAccountNotes.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Asset Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 258);
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
            this.cmbAccountAssetType.Location = new System.Drawing.Point(797, 229);
            this.cmbAccountAssetType.Name = "cmbAccountAssetType";
            this.cmbAccountAssetType.Size = new System.Drawing.Size(121, 21);
            this.cmbAccountAssetType.TabIndex = 27;
            // 
            // chkAccountPlaceholder
            // 
            this.chkAccountPlaceholder.AutoSize = true;
            this.chkAccountPlaceholder.Location = new System.Drawing.Point(797, 258);
            this.chkAccountPlaceholder.Name = "chkAccountPlaceholder";
            this.chkAccountPlaceholder.Size = new System.Drawing.Size(15, 14);
            this.chkAccountPlaceholder.TabIndex = 28;
            this.chkAccountPlaceholder.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(951, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Amount (e)";
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Location = new System.Drawing.Point(1076, 182);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(121, 20);
            this.txtTransactionAmount.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(951, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Transfer Account ID (e)";
            // 
            // txtTransactionTransferAccountId
            // 
            this.txtTransactionTransferAccountId.Location = new System.Drawing.Point(1076, 155);
            this.txtTransactionTransferAccountId.Name = "txtTransactionTransferAccountId";
            this.txtTransactionTransferAccountId.Size = new System.Drawing.Size(121, 20);
            this.txtTransactionTransferAccountId.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(951, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Description (e)";
            // 
            // txtTransactionDescription
            // 
            this.txtTransactionDescription.Location = new System.Drawing.Point(1076, 129);
            this.txtTransactionDescription.Name = "txtTransactionDescription";
            this.txtTransactionDescription.Size = new System.Drawing.Size(121, 20);
            this.txtTransactionDescription.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(951, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Number (e)";
            // 
            // txtTransactionNumber
            // 
            this.txtTransactionNumber.Location = new System.Drawing.Point(1076, 97);
            this.txtTransactionNumber.Name = "txtTransactionNumber";
            this.txtTransactionNumber.Size = new System.Drawing.Size(121, 20);
            this.txtTransactionNumber.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(951, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Date (e)";
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Location = new System.Drawing.Point(1018, 223);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(143, 23);
            this.btnNewTransaction.TabIndex = 31;
            this.btnNewTransaction.Text = "Add New Transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(951, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Account ID";
            // 
            // txtTransactionAccountId
            // 
            this.txtTransactionAccountId.Location = new System.Drawing.Point(1076, 44);
            this.txtTransactionAccountId.Name = "txtTransactionAccountId";
            this.txtTransactionAccountId.Size = new System.Drawing.Size(121, 20);
            this.txtTransactionAccountId.TabIndex = 29;
            // 
            // dateTransactionDate
            // 
            this.dateTransactionDate.Location = new System.Drawing.Point(1076, 70);
            this.dateTransactionDate.Name = "dateTransactionDate";
            this.dateTransactionDate.Size = new System.Drawing.Size(200, 20);
            this.dateTransactionDate.TabIndex = 48;
            // 
            // txtDeleteTransactionId
            // 
            this.txtDeleteTransactionId.Location = new System.Drawing.Point(786, 353);
            this.txtDeleteTransactionId.Name = "txtDeleteTransactionId";
            this.txtDeleteTransactionId.Size = new System.Drawing.Size(121, 20);
            this.txtDeleteTransactionId.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(695, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Transaction ID";
            // 
            // btnTransactionDelete
            // 
            this.btnTransactionDelete.Location = new System.Drawing.Point(741, 379);
            this.btnTransactionDelete.Name = "btnTransactionDelete";
            this.btnTransactionDelete.Size = new System.Drawing.Size(116, 23);
            this.btnTransactionDelete.TabIndex = 51;
            this.btnTransactionDelete.Text = "Delete Transaction";
            this.btnTransactionDelete.UseVisualStyleBackColor = true;
            this.btnTransactionDelete.Click += new System.EventHandler(this.btnTransactionDelete_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(731, 448);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteAccount.TabIndex = 54;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(685, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Account ID";
            // 
            // txtDeleteAccountId
            // 
            this.txtDeleteAccountId.Location = new System.Drawing.Point(776, 422);
            this.txtDeleteAccountId.Name = "txtDeleteAccountId";
            this.txtDeleteAccountId.Size = new System.Drawing.Size(121, 20);
            this.txtDeleteAccountId.TabIndex = 52;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(334, 12);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 55;
            this.btnSaveAs.Text = "Save As...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnEditTransaction
            // 
            this.btnEditTransaction.Location = new System.Drawing.Point(969, 288);
            this.btnEditTransaction.Name = "btnEditTransaction";
            this.btnEditTransaction.Size = new System.Drawing.Size(116, 23);
            this.btnEditTransaction.TabIndex = 56;
            this.btnEditTransaction.Text = "Edit Transaction";
            this.btnEditTransaction.UseVisualStyleBackColor = true;
            this.btnEditTransaction.Click += new System.EventHandler(this.btnEditTransaction_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(951, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Transaction ID (e o)";
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Location = new System.Drawing.Point(1076, 262);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.Size = new System.Drawing.Size(121, 20);
            this.txtTransactionId.TabIndex = 57;
            // 
            // btnUpdateBalances
            // 
            this.btnUpdateBalances.Location = new System.Drawing.Point(851, 641);
            this.btnUpdateBalances.Name = "btnUpdateBalances";
            this.btnUpdateBalances.Size = new System.Drawing.Size(139, 23);
            this.btnUpdateBalances.TabIndex = 59;
            this.btnUpdateBalances.Text = "Recalculate Balances";
            this.btnUpdateBalances.UseVisualStyleBackColor = true;
            this.btnUpdateBalances.Click += new System.EventHandler(this.btnUpdateBalances_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(10, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 60;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnShowAccounts
            // 
            this.btnShowAccounts.Location = new System.Drawing.Point(689, 612);
            this.btnShowAccounts.Name = "btnShowAccounts";
            this.btnShowAccounts.Size = new System.Drawing.Size(112, 23);
            this.btnShowAccounts.TabIndex = 61;
            this.btnShowAccounts.Text = "Show All Accounts";
            this.btnShowAccounts.UseVisualStyleBackColor = true;
            this.btnShowAccounts.Click += new System.EventHandler(this.btnShowAccounts_Click);
            // 
            // btnShowTransactions
            // 
            this.btnShowTransactions.Location = new System.Drawing.Point(836, 612);
            this.btnShowTransactions.Name = "btnShowTransactions";
            this.btnShowTransactions.Size = new System.Drawing.Size(154, 23);
            this.btnShowTransactions.TabIndex = 62;
            this.btnShowTransactions.Text = "Show All Transactions";
            this.btnShowTransactions.UseVisualStyleBackColor = true;
            this.btnShowTransactions.Click += new System.EventHandler(this.btnShowTransactions_Click);
            // 
            // txtShowTransactionsAccountId
            // 
            this.txtShowTransactionsAccountId.Location = new System.Drawing.Point(869, 586);
            this.txtShowTransactionsAccountId.Name = "txtShowTransactionsAccountId";
            this.txtShowTransactionsAccountId.Size = new System.Drawing.Size(121, 20);
            this.txtShowTransactionsAccountId.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(796, 589);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 64;
            this.label15.Text = "Account ID";
            // 
            // btnTransactionGet
            // 
            this.btnTransactionGet.Location = new System.Drawing.Point(1091, 288);
            this.btnTransactionGet.Name = "btnTransactionGet";
            this.btnTransactionGet.Size = new System.Drawing.Size(141, 23);
            this.btnTransactionGet.TabIndex = 65;
            this.btnTransactionGet.Text = "Get Transaction";
            this.btnTransactionGet.UseVisualStyleBackColor = true;
            this.btnTransactionGet.Click += new System.EventHandler(this.btnTransactionGet_Click);
            // 
            // frmDebugConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 676);
            this.Controls.Add(this.btnTransactionGet);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtShowTransactionsAccountId);
            this.Controls.Add(this.btnShowTransactions);
            this.Controls.Add(this.btnShowAccounts);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdateBalances);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTransactionId);
            this.Controls.Add(this.btnEditTransaction);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeleteAccountId);
            this.Controls.Add(this.btnTransactionDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDeleteTransactionId);
            this.Controls.Add(this.dateTransactionDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTransactionAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTransactionTransferAccountId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTransactionDescription);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTransactionNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTransactionAccountId);
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
            this.Text = "Debug Console";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTransactionTransferAccountId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTransactionDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTransactionNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTransactionAccountId;
        private System.Windows.Forms.DateTimePicker dateTransactionDate;
        private System.Windows.Forms.TextBox txtDeleteTransactionId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTransactionDelete;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDeleteAccountId;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnEditTransaction;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.Button btnUpdateBalances;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnShowAccounts;
        private System.Windows.Forms.Button btnShowTransactions;
        private System.Windows.Forms.TextBox txtShowTransactionsAccountId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTransactionGet;
    }
}