namespace Enrollment
{
    partial class frmAmountInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmountInput));
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayment = new Enrollment.HintTextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnEquate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTotal.Location = new System.Drawing.Point(144, 14);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(157, 23);
            this.lblTotal.TabIndex = 76;
            this.lblTotal.Text = "1,000,000.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "Amount (PHP):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Payment (PHP):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtPayment.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPayment.ForeColor = System.Drawing.Color.White;
            this.txtPayment.Location = new System.Drawing.Point(144, 45);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(149, 31);
            this.txtPayment.TabIndex = 80;
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayment.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPayment.WaterMarkText = "";
            this.txtPayment.Enter += new System.EventHandler(this.txtPayment_Enter);
            this.txtPayment.Leave += new System.EventHandler(this.txtPayment_Leave);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.White;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.Image")));
            this.btnEnter.Location = new System.Drawing.Point(396, 26);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(67, 58);
            this.btnEnter.TabIndex = 82;
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnEquate
            // 
            this.btnEquate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEquate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEquate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquate.ForeColor = System.Drawing.Color.White;
            this.btnEquate.Image = ((System.Drawing.Image)(resources.GetObject("btnEquate.Image")));
            this.btnEquate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEquate.Location = new System.Drawing.Point(299, 45);
            this.btnEquate.Name = "btnEquate";
            this.btnEquate.Size = new System.Drawing.Size(40, 31);
            this.btnEquate.TabIndex = 83;
            this.btnEquate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tip.SetToolTip(this.btnEquate, "Equate payment with due amount.");
            this.btnEquate.UseVisualStyleBackColor = false;
            this.btnEquate.Click += new System.EventHandler(this.btnEquate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-191, -104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(341, 394);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEquate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPayment);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 95);
            this.panel1.TabIndex = 85;
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.DodgerBlue;
            this.tip.ForeColor = System.Drawing.Color.White;
            this.tip.IsBalloon = true;
            this.tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tip.ToolTipTitle = "Hint";
            // 
            // frmAmountInput
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 113);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAmountInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAmountInput";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private HintTextBox txtPayment;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnEquate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip tip;
    }
}