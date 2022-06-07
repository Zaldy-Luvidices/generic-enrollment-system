namespace Enrollment
{
    partial class frmMonthlyManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonthlyManager));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSHigh = new Enrollment.HintTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHigh = new Enrollment.HintTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtElem = new Enrollment.HintTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.colSenior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colElem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwMonthly = new System.Windows.Forms.ListView();
            this.colHigh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(263, 76);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 56);
            this.btnUpdate.TabIndex = 76;
            this.btnUpdate.Text = "SAVE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, -72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "PHP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSHigh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHigh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtElem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboYear);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 125);
            this.panel1.TabIndex = 77;
            // 
            // txtSHigh
            // 
            this.txtSHigh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSHigh.Location = new System.Drawing.Point(125, 94);
            this.txtSHigh.MaxLength = 50;
            this.txtSHigh.Name = "txtSHigh";
            this.txtSHigh.Size = new System.Drawing.Size(72, 23);
            this.txtSHigh.TabIndex = 17;
            this.txtSHigh.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtSHigh.WaterMarkText = "";
            this.txtSHigh.Enter += new System.EventHandler(this.txt_Enter);
            this.txtSHigh.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Senior High:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "PHP";
            // 
            // txtHigh
            // 
            this.txtHigh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHigh.Location = new System.Drawing.Point(125, 65);
            this.txtHigh.MaxLength = 50;
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(72, 23);
            this.txtHigh.TabIndex = 14;
            this.txtHigh.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtHigh.WaterMarkText = "";
            this.txtHigh.Enter += new System.EventHandler(this.txt_Enter);
            this.txtHigh.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "High School:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "PHP";
            // 
            // txtElem
            // 
            this.txtElem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElem.Location = new System.Drawing.Point(125, 36);
            this.txtElem.MaxLength = 50;
            this.txtElem.Name = "txtElem";
            this.txtElem.Size = new System.Drawing.Size(72, 23);
            this.txtElem.TabIndex = 11;
            this.txtElem.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtElem.WaterMarkText = "";
            this.txtElem.Enter += new System.EventHandler(this.txt_Enter);
            this.txtElem.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elementary:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year:";
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(125, 6);
            this.cboYear.MaxLength = 4;
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(111, 24);
            this.cboYear.TabIndex = 0;
            this.cboYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboYear_KeyPress);
            // 
            // colSenior
            // 
            this.colSenior.Text = "S_High";
            this.colSenior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSenior.Width = 80;
            // 
            // colElem
            // 
            this.colElem.Text = "Elem";
            this.colElem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colElem.Width = 80;
            // 
            // colYear
            // 
            this.colYear.Text = "Year";
            // 
            // lvwMonthly
            // 
            this.lvwMonthly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colYear,
            this.colElem,
            this.colHigh,
            this.colSenior});
            this.lvwMonthly.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMonthly.FullRowSelect = true;
            this.lvwMonthly.GridLines = true;
            this.lvwMonthly.HideSelection = false;
            this.lvwMonthly.Location = new System.Drawing.Point(8, 138);
            this.lvwMonthly.MultiSelect = false;
            this.lvwMonthly.Name = "lvwMonthly";
            this.lvwMonthly.Size = new System.Drawing.Size(331, 303);
            this.lvwMonthly.TabIndex = 75;
            this.lvwMonthly.UseCompatibleStateImageBehavior = false;
            this.lvwMonthly.View = System.Windows.Forms.View.Details;
            this.lvwMonthly.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwTuition_ItemSelectionChanged);
            // 
            // colHigh
            // 
            this.colHigh.Text = "High";
            this.colHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colHigh.Width = 80;
            // 
            // frmMonthlyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 448);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwMonthly);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMonthlyManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Payment Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private HintTextBox txtSHigh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private HintTextBox txtHigh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private HintTextBox txtElem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ColumnHeader colSenior;
        private System.Windows.Forms.ColumnHeader colElem;
        private System.Windows.Forms.ColumnHeader colYear;
        private System.Windows.Forms.ListView lvwMonthly;
        private System.Windows.Forms.ColumnHeader colHigh;
    }
}