namespace Enrollment
{
    partial class frmViewerPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewerPortal));
            this.btnPortalStudent = new System.Windows.Forms.Button();
            this.btnPortalParent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSwitchUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPortalStudent
            // 
            this.btnPortalStudent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPortalStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPortalStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortalStudent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortalStudent.ForeColor = System.Drawing.Color.Black;
            this.btnPortalStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnPortalStudent.Image")));
            this.btnPortalStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPortalStudent.Location = new System.Drawing.Point(114, 9);
            this.btnPortalStudent.Name = "btnPortalStudent";
            this.btnPortalStudent.Size = new System.Drawing.Size(90, 90);
            this.btnPortalStudent.TabIndex = 31;
            this.btnPortalStudent.Text = "STUDENT";
            this.btnPortalStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPortalStudent.UseVisualStyleBackColor = false;
            this.btnPortalStudent.Click += new System.EventHandler(this.btnPortalStudent_Click);
            // 
            // btnPortalParent
            // 
            this.btnPortalParent.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPortalParent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPortalParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortalParent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortalParent.ForeColor = System.Drawing.Color.White;
            this.btnPortalParent.Image = ((System.Drawing.Image)(resources.GetObject("btnPortalParent.Image")));
            this.btnPortalParent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPortalParent.Location = new System.Drawing.Point(14, 9);
            this.btnPortalParent.Name = "btnPortalParent";
            this.btnPortalParent.Size = new System.Drawing.Size(90, 90);
            this.btnPortalParent.TabIndex = 30;
            this.btnPortalParent.Text = "PARENT";
            this.btnPortalParent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPortalParent.UseVisualStyleBackColor = false;
            this.btnPortalParent.Click += new System.EventHandler(this.btnPortalParent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, -34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnSwitchUser
            // 
            this.btnSwitchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitchUser.BackColor = System.Drawing.Color.White;
            this.btnSwitchUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSwitchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchUser.Image")));
            this.btnSwitchUser.Location = new System.Drawing.Point(264, 63);
            this.btnSwitchUser.Name = "btnSwitchUser";
            this.btnSwitchUser.Size = new System.Drawing.Size(33, 36);
            this.btnSwitchUser.TabIndex = 37;
            this.btnSwitchUser.UseVisualStyleBackColor = false;
            this.btnSwitchUser.Click += new System.EventHandler(this.btnSwitchUser_Click);
            // 
            // frmViewerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 111);
            this.Controls.Add(this.btnSwitchUser);
            this.Controls.Add(this.btnPortalStudent);
            this.Controls.Add(this.btnPortalParent);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewerPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPortalStudent;
        private System.Windows.Forms.Button btnPortalParent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSwitchUser;
    }
}