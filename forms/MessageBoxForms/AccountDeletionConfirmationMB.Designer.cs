namespace ZappCash.forms.MessageBoxForms.EditOrDelete
{
    partial class AccountDeletionConfirmationMB
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Gilroy ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 87);
            this.label3.TabIndex = 7;
            this.label3.Text = "DO YOU WANT TO DELETE THIS ITEM?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 43);
            this.panel1.TabIndex = 11;
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(41, 262);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(136, 49);
            this.btnYes.TabIndex = 12;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(243, 262);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(136, 49);
            this.btnNo.TabIndex = 13;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxError.ErrorImage = null;
            this.pictureBoxError.Image = global::ZappCash.Properties.Resources.Error_Icon1;
            this.pictureBoxError.Location = new System.Drawing.Point(175, 68);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(75, 79);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 4;
            this.pictureBoxError.TabStop = false;
            // 
            // AccountDeletionConfirmationMB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(421, 365);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxError);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountDeletionConfirmationMB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}

