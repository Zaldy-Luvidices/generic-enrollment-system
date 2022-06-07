namespace Enrollment
{
    partial class frmStudentUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentUpdate));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.picErrorLastname = new System.Windows.Forms.PictureBox();
            this.picErrorFirstname = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNotes = new Enrollment.HintTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtAddress = new Enrollment.HintTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContact = new Enrollment.HintTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSection = new Enrollment.HintTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiddlename = new Enrollment.HintTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstname = new Enrollment.HintTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastname = new Enrollment.HintTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentID = new Enrollment.HintTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLevel = new Enrollment.HintTextBox();
            this.txtGrade = new Enrollment.HintTextBox();
            this.txtType = new Enrollment.HintTextBox();
            this.txtBirthdate = new Enrollment.HintTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorLastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-184, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(341, 533);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBirthdate);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtGrade);
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.cboGrade);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.picErrorLastname);
            this.panel1.Controls.Add(this.picErrorFirstname);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtNotes);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpBirthdate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSection);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboLevel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMiddlename);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtStudentID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(76, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 479);
            this.panel1.TabIndex = 24;
            // 
            // cboGrade
            // 
            this.cboGrade.BackColor = System.Drawing.Color.White;
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade.ForeColor = System.Drawing.Color.Black;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Items.AddRange(new object[] {
            "ELEM",
            "HIGH",
            "S_HIGH"});
            this.cboGrade.Location = new System.Drawing.Point(130, 158);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(73, 24);
            this.cboGrade.TabIndex = 117;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 116;
            this.label12.Text = "Grade:";
            // 
            // picErrorLastname
            // 
            this.picErrorLastname.BackColor = System.Drawing.Color.White;
            this.picErrorLastname.Image = ((System.Drawing.Image)(resources.GetObject("picErrorLastname.Image")));
            this.picErrorLastname.Location = new System.Drawing.Point(306, 44);
            this.picErrorLastname.Name = "picErrorLastname";
            this.picErrorLastname.Size = new System.Drawing.Size(16, 16);
            this.picErrorLastname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picErrorLastname.TabIndex = 115;
            this.picErrorLastname.TabStop = false;
            this.picErrorLastname.Visible = false;
            // 
            // picErrorFirstname
            // 
            this.picErrorFirstname.BackColor = System.Drawing.Color.White;
            this.picErrorFirstname.Image = ((System.Drawing.Image)(resources.GetObject("picErrorFirstname.Image")));
            this.picErrorFirstname.Location = new System.Drawing.Point(306, 73);
            this.picErrorFirstname.Name = "picErrorFirstname";
            this.picErrorFirstname.Size = new System.Drawing.Size(16, 16);
            this.picErrorFirstname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picErrorFirstname.TabIndex = 114;
            this.picErrorFirstname.TabStop = false;
            this.picErrorFirstname.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(130, 428);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 33);
            this.btnUpdate.TabIndex = 113;
            this.btnUpdate.Text = "SAVE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNotes.Location = new System.Drawing.Point(130, 347);
            this.txtNotes.MaxLength = 50;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(196, 57);
            this.txtNotes.TabIndex = 112;
            this.txtNotes.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtNotes.WaterMarkText = "Optional notes...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 111;
            this.label11.Text = "Notes:";
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.White;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.ForeColor = System.Drawing.Color.Black;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.cboType.Location = new System.Drawing.Point(130, 317);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(136, 24);
            this.cboType.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 109;
            this.label10.Text = "Type:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(13, 307);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(317, 1);
            this.pictureBox7.TabIndex = 108;
            this.pictureBox7.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(130, 275);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(196, 23);
            this.txtAddress.TabIndex = 107;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtAddress.WaterMarkText = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 106;
            this.label9.Text = "Address:";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(130, 246);
            this.txtContact.MaxLength = 50;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(136, 23);
            this.txtContact.TabIndex = 105;
            this.txtContact.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtContact.WaterMarkText = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 104;
            this.label8.Text = "Contact #:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Checked = false;
            this.dtpBirthdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(130, 217);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.ShowCheckBox = true;
            this.dtpBirthdate.Size = new System.Drawing.Size(136, 23);
            this.dtpBirthdate.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 102;
            this.label7.Text = "Birthdate:";
            // 
            // txtSection
            // 
            this.txtSection.BackColor = System.Drawing.Color.White;
            this.txtSection.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.Location = new System.Drawing.Point(130, 188);
            this.txtSection.MaxLength = 50;
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(136, 23);
            this.txtSection.TabIndex = 101;
            this.txtSection.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtSection.WaterMarkText = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 100;
            this.label6.Text = "Section:";
            // 
            // cboLevel
            // 
            this.cboLevel.BackColor = System.Drawing.Color.White;
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevel.ForeColor = System.Drawing.Color.Black;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "ELEM",
            "HIGH",
            "S_HIGH"});
            this.cboLevel.Location = new System.Drawing.Point(130, 128);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(73, 24);
            this.cboLevel.TabIndex = 99;
            this.cboLevel.SelectedIndexChanged += new System.EventHandler(this.cboLevel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Level:";
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.BackColor = System.Drawing.Color.White;
            this.txtMiddlename.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddlename.Location = new System.Drawing.Point(130, 99);
            this.txtMiddlename.MaxLength = 50;
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(196, 23);
            this.txtMiddlename.TabIndex = 16;
            this.txtMiddlename.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtMiddlename.WaterMarkText = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Middlename:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.White;
            this.txtFirstname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(130, 70);
            this.txtFirstname.MaxLength = 50;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(196, 23);
            this.txtFirstname.TabIndex = 14;
            this.txtFirstname.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtFirstname.WaterMarkText = "";
            this.txtFirstname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Firstname:";
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.White;
            this.txtLastname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(130, 41);
            this.txtLastname.MaxLength = 50;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(196, 23);
            this.txtLastname.TabIndex = 12;
            this.txtLastname.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtLastname.WaterMarkText = "";
            this.txtLastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lastname:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.White;
            this.txtStudentID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(130, 12);
            this.txtStudentID.MaxLength = 50;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(136, 23);
            this.txtStudentID.TabIndex = 10;
            this.txtStudentID.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtStudentID.WaterMarkText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 499);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(432, 20);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Please enter student information";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.Color.White;
            this.txtLevel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.Location = new System.Drawing.Point(130, 129);
            this.txtLevel.MaxLength = 50;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(73, 23);
            this.txtLevel.TabIndex = 118;
            this.txtLevel.Visible = false;
            this.txtLevel.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtLevel.WaterMarkText = "";
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.White;
            this.txtGrade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(130, 159);
            this.txtGrade.MaxLength = 50;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(73, 23);
            this.txtGrade.TabIndex = 119;
            this.txtGrade.Visible = false;
            this.txtGrade.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtGrade.WaterMarkText = "";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.White;
            this.txtType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(130, 318);
            this.txtType.MaxLength = 50;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(136, 23);
            this.txtType.TabIndex = 120;
            this.txtType.Visible = false;
            this.txtType.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtType.WaterMarkText = "";
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.BackColor = System.Drawing.Color.White;
            this.txtBirthdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthdate.Location = new System.Drawing.Point(130, 217);
            this.txtBirthdate.MaxLength = 50;
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.ReadOnly = true;
            this.txtBirthdate.Size = new System.Drawing.Size(136, 23);
            this.txtBirthdate.TabIndex = 121;
            this.txtBirthdate.Visible = false;
            this.txtBirthdate.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtBirthdate.WaterMarkText = "";
            // 
            // frmStudentUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 519);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Student Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorLastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private HintTextBox txtStudentID;
        private System.Windows.Forms.Label label5;
        private HintTextBox txtMiddlename;
        private System.Windows.Forms.Label label4;
        private HintTextBox txtFirstname;
        private System.Windows.Forms.Label label3;
        private HintTextBox txtLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLevel;
        private HintTextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private HintTextBox txtContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label7;
        private HintTextBox txtSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label11;
        private HintTextBox txtNotes;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox picErrorFirstname;
        private System.Windows.Forms.PictureBox picErrorLastname;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label label12;
        private HintTextBox txtType;
        private HintTextBox txtGrade;
        private HintTextBox txtLevel;
        private HintTextBox txtBirthdate;
    }
}