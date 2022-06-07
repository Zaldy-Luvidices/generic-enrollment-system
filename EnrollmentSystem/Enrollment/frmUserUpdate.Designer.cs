namespace Enrollment
{
    partial class frmUserUpdate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserUpdate));
            this.lblStatus = new System.Windows.Forms.Label();
            this.picErrorNewPassword = new System.Windows.Forms.PictureBox();
            this.picErrorUsername = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picErrorPasswordConfirm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAccessType = new System.Windows.Forms.ComboBox();
            this.picAccessType = new System.Windows.Forms.PictureBox();
            this.imgListAccess = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picErrorOldPassword = new System.Windows.Forms.PictureBox();
            this.txtOldPassword = new Enrollment.HintTextBox();
            this.txtNotes = new Enrollment.HintTextBox();
            this.txtPasswordConfirm = new Enrollment.HintTextBox();
            this.txtNewPassword = new Enrollment.HintTextBox();
            this.txtUsername = new Enrollment.HintTextBox();
            this.chkUpdatePassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorPasswordConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccessType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOldPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 342);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(308, 20);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Please enter user-specific information";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picErrorNewPassword
            // 
            this.picErrorNewPassword.BackColor = System.Drawing.Color.White;
            this.picErrorNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("picErrorNewPassword.Image")));
            this.picErrorNewPassword.Location = new System.Drawing.Point(265, 104);
            this.picErrorNewPassword.Name = "picErrorNewPassword";
            this.picErrorNewPassword.Size = new System.Drawing.Size(16, 16);
            this.picErrorNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picErrorNewPassword.TabIndex = 14;
            this.picErrorNewPassword.TabStop = false;
            this.picErrorNewPassword.Visible = false;
            // 
            // picErrorUsername
            // 
            this.picErrorUsername.BackColor = System.Drawing.Color.White;
            this.picErrorUsername.Image = ((System.Drawing.Image)(resources.GetObject("picErrorUsername.Image")));
            this.picErrorUsername.Location = new System.Drawing.Point(265, 21);
            this.picErrorUsername.Name = "picErrorUsername";
            this.picErrorUsername.Size = new System.Drawing.Size(16, 16);
            this.picErrorUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picErrorUsername.TabIndex = 13;
            this.picErrorUsername.TabStop = false;
            this.picErrorUsername.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(89, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 33);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "SAVE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(76, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 322);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // picErrorPasswordConfirm
            // 
            this.picErrorPasswordConfirm.BackColor = System.Drawing.Color.White;
            this.picErrorPasswordConfirm.Image = ((System.Drawing.Image)(resources.GetObject("picErrorPasswordConfirm.Image")));
            this.picErrorPasswordConfirm.Location = new System.Drawing.Point(265, 133);
            this.picErrorPasswordConfirm.Name = "picErrorPasswordConfirm";
            this.picErrorPasswordConfirm.Size = new System.Drawing.Size(16, 16);
            this.picErrorPasswordConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picErrorPasswordConfirm.TabIndex = 17;
            this.picErrorPasswordConfirm.TabStop = false;
            this.picErrorPasswordConfirm.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Access:";
            // 
            // cboAccessType
            // 
            this.cboAccessType.BackColor = System.Drawing.Color.White;
            this.cboAccessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccessType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboAccessType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAccessType.FormattingEnabled = true;
            this.cboAccessType.Location = new System.Drawing.Point(89, 188);
            this.cboAccessType.Name = "cboAccessType";
            this.cboAccessType.Size = new System.Drawing.Size(123, 24);
            this.cboAccessType.TabIndex = 19;
            this.cboAccessType.SelectedIndexChanged += new System.EventHandler(this.cboAccessType_SelectedIndexChanged);
            // 
            // picAccessType
            // 
            this.picAccessType.BackColor = System.Drawing.Color.White;
            this.picAccessType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAccessType.Location = new System.Drawing.Point(245, 172);
            this.picAccessType.Name = "picAccessType";
            this.picAccessType.Size = new System.Drawing.Size(40, 40);
            this.picAccessType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAccessType.TabIndex = 20;
            this.picAccessType.TabStop = false;
            // 
            // imgListAccess
            // 
            this.imgListAccess.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListAccess.ImageStream")));
            this.imgListAccess.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListAccess.Images.SetKeyName(0, "Admin");
            this.imgListAccess.Images.SetKeyName(1, "Superuser");
            this.imgListAccess.Images.SetKeyName(2, "User");
            this.imgListAccess.Images.SetKeyName(3, "Viewer");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-169, -16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(341, 394);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // picErrorOldPassword
            // 
            this.picErrorOldPassword.BackColor = System.Drawing.Color.White;
            this.picErrorOldPassword.Image = ((System.Drawing.Image)(resources.GetObject("picErrorOldPassword.Image")));
            this.picErrorOldPassword.Location = new System.Drawing.Point(265, 49);
            this.picErrorOldPassword.Name = "picErrorOldPassword";
            this.picErrorOldPassword.Size = new System.Drawing.Size(16, 16);
            this.picErrorOldPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picErrorOldPassword.TabIndex = 24;
            this.picErrorOldPassword.TabStop = false;
            this.picErrorOldPassword.Visible = false;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtOldPassword.Location = new System.Drawing.Point(89, 46);
            this.txtOldPassword.MaxLength = 20;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '•';
            this.txtOldPassword.Size = new System.Drawing.Size(196, 23);
            this.txtOldPassword.TabIndex = 23;
            this.txtOldPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtOldPassword.WaterMarkText = "Password";
            this.txtOldPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNotes.Location = new System.Drawing.Point(89, 218);
            this.txtNotes.MaxLength = 50;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(196, 48);
            this.txtNotes.TabIndex = 21;
            this.txtNotes.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtNotes.WaterMarkText = "Optional notes...";
            this.txtNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Enabled = false;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirm.Location = new System.Drawing.Point(89, 130);
            this.txtPasswordConfirm.MaxLength = 20;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '•';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(196, 23);
            this.txtPasswordConfirm.TabIndex = 16;
            this.txtPasswordConfirm.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPasswordConfirm.WaterMarkText = "Confirm new password";
            this.txtPasswordConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(89, 101);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.Size = new System.Drawing.Size(196, 23);
            this.txtNewPassword.TabIndex = 10;
            this.txtNewPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtNewPassword.WaterMarkText = "New Password";
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(89, 17);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(196, 23);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtUsername.WaterMarkText = "Username";
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // chkUpdatePassword
            // 
            this.chkUpdatePassword.AutoSize = true;
            this.chkUpdatePassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdatePassword.Location = new System.Drawing.Point(90, 78);
            this.chkUpdatePassword.Name = "chkUpdatePassword";
            this.chkUpdatePassword.Size = new System.Drawing.Size(141, 20);
            this.chkUpdatePassword.TabIndex = 25;
            this.chkUpdatePassword.Text = "&Update Password";
            this.chkUpdatePassword.UseVisualStyleBackColor = true;
            this.chkUpdatePassword.CheckedChanged += new System.EventHandler(this.chkUpdatePassword_CheckedChanged);
            // 
            // frmUserUpdate
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 362);
            this.Controls.Add(this.chkUpdatePassword);
            this.Controls.Add(this.picErrorOldPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.picAccessType);
            this.Controls.Add(this.cboAccessType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picErrorPasswordConfirm);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.picErrorNewPassword);
            this.Controls.Add(this.picErrorUsername);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update User Information";
            ((System.ComponentModel.ISupportInitialize)(this.picErrorNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorPasswordConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccessType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOldPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picErrorNewPassword;
        private System.Windows.Forms.PictureBox picErrorUsername;
        private System.Windows.Forms.Button btnUpdate;
        private HintTextBox txtNewPassword;
        private HintTextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picErrorPasswordConfirm;
        private HintTextBox txtPasswordConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAccessType;
        private System.Windows.Forms.PictureBox picAccessType;
        private HintTextBox txtNotes;
        private System.Windows.Forms.ImageList imgListAccess;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picErrorOldPassword;
        private HintTextBox txtOldPassword;
        private System.Windows.Forms.CheckBox chkUpdatePassword;
    }
}