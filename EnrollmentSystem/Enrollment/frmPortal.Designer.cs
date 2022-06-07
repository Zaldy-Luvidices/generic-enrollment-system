namespace Enrollment
{
    partial class frmPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtFirstname = new Enrollment.HintTextBox();
            this.txtLastname = new Enrollment.HintTextBox();
            this.lblPortal = new System.Windows.Forms.Label();
            this.txtStudentID = new Enrollment.HintTextBox();
            this.picParent = new System.Windows.Forms.PictureBox();
            this.tabParent = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlTFMessage = new System.Windows.Forms.Panel();
            this.lblTFMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTFYear = new System.Windows.Forms.ComboBox();
            this.lblTFBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTFPaid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTFTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlMPMessage = new System.Windows.Forms.Panel();
            this.lblMPMessage = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboMPMonth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMPYear = new System.Windows.Forms.ComboBox();
            this.lblMPBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMPPaid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMPTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lvwGrades = new System.Windows.Forms.ListView();
            this.colGRQuarter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParent)).BeginInit();
            this.tabParent.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlTFMessage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlMPMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picStudent);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.lblPortal);
            this.panel1.Controls.Add(this.txtStudentID);
            this.panel1.Controls.Add(this.picParent);
            this.panel1.Controls.Add(this.tabParent);
            this.panel1.Controls.Add(this.lvwGrades);
            this.panel1.Location = new System.Drawing.Point(192, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 578);
            this.panel1.TabIndex = 0;
            // 
            // picStudent
            // 
            this.picStudent.Image = ((System.Drawing.Image)(resources.GetObject("picStudent.Image")));
            this.picStudent.Location = new System.Drawing.Point(166, 16);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(72, 72);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStudent.TabIndex = 88;
            this.picStudent.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnter.FlatAppearance.BorderSize = 3;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(94, 268);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(237, 70);
            this.btnEnter.TabIndex = 85;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.White;
            this.txtFirstname.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Black;
            this.txtFirstname.Location = new System.Drawing.Point(57, 216);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(301, 37);
            this.txtFirstname.TabIndex = 84;
            this.txtFirstname.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtFirstname.WaterMarkText = "Firstname";
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.White;
            this.txtLastname.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.Black;
            this.txtLastname.Location = new System.Drawing.Point(57, 173);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(301, 37);
            this.txtLastname.TabIndex = 83;
            this.txtLastname.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtLastname.WaterMarkText = "Lastname";
            // 
            // lblPortal
            // 
            this.lblPortal.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblPortal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPortal.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortal.ForeColor = System.Drawing.Color.White;
            this.lblPortal.Location = new System.Drawing.Point(3, 91);
            this.lblPortal.Name = "lblPortal";
            this.lblPortal.Size = new System.Drawing.Size(402, 25);
            this.lblPortal.TabIndex = 35;
            this.lblPortal.Text = "PORTAL";
            this.lblPortal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.White;
            this.txtStudentID.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.ForeColor = System.Drawing.Color.Black;
            this.txtStudentID.Location = new System.Drawing.Point(57, 130);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(301, 37);
            this.txtStudentID.TabIndex = 82;
            this.txtStudentID.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtStudentID.WaterMarkText = "Student ID";
            // 
            // picParent
            // 
            this.picParent.Image = ((System.Drawing.Image)(resources.GetObject("picParent.Image")));
            this.picParent.Location = new System.Drawing.Point(166, 16);
            this.picParent.Name = "picParent";
            this.picParent.Size = new System.Drawing.Size(72, 72);
            this.picParent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picParent.TabIndex = 0;
            this.picParent.TabStop = false;
            // 
            // tabParent
            // 
            this.tabParent.Controls.Add(this.tabPage1);
            this.tabParent.Controls.Add(this.tabPage2);
            this.tabParent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabParent.Location = new System.Drawing.Point(16, 352);
            this.tabParent.Name = "tabParent";
            this.tabParent.SelectedIndex = 0;
            this.tabParent.Size = new System.Drawing.Size(375, 207);
            this.tabParent.TabIndex = 87;
            this.tabParent.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlTFMessage);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cboTFYear);
            this.tabPage1.Controls.Add(this.lblTFBalance);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblTFPaid);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblTFTotal);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tuition Fee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlTFMessage
            // 
            this.pnlTFMessage.Controls.Add(this.lblTFMessage);
            this.pnlTFMessage.Location = new System.Drawing.Point(3, 3);
            this.pnlTFMessage.Name = "pnlTFMessage";
            this.pnlTFMessage.Size = new System.Drawing.Size(244, 172);
            this.pnlTFMessage.TabIndex = 121;
            this.pnlTFMessage.Visible = false;
            // 
            // lblTFMessage
            // 
            this.lblTFMessage.Location = new System.Drawing.Point(4, 61);
            this.lblTFMessage.Name = "lblTFMessage";
            this.lblTFMessage.Size = new System.Drawing.Size(237, 56);
            this.lblTFMessage.TabIndex = 0;
            this.lblTFMessage.Text = "label1";
            this.lblTFMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 120;
            this.label5.Text = "Year:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTFYear
            // 
            this.cboTFYear.BackColor = System.Drawing.Color.White;
            this.cboTFYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTFYear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTFYear.ForeColor = System.Drawing.Color.Black;
            this.cboTFYear.FormattingEnabled = true;
            this.cboTFYear.Items.AddRange(new object[] {
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
            this.cboTFYear.Location = new System.Drawing.Point(257, 27);
            this.cboTFYear.Name = "cboTFYear";
            this.cboTFYear.Size = new System.Drawing.Size(102, 31);
            this.cboTFYear.TabIndex = 119;
            this.cboTFYear.SelectedIndexChanged += new System.EventHandler(this.cboTFYear_SelectedIndexChanged);
            // 
            // lblTFBalance
            // 
            this.lblTFBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTFBalance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFBalance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTFBalance.Location = new System.Drawing.Point(10, 141);
            this.lblTFBalance.Name = "lblTFBalance";
            this.lblTFBalance.Size = new System.Drawing.Size(237, 31);
            this.lblTFBalance.TabIndex = 115;
            this.lblTFBalance.Text = "---.--";
            this.lblTFBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 114;
            this.label4.Text = "Balance (PHP):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTFPaid
            // 
            this.lblTFPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTFPaid.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFPaid.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTFPaid.Location = new System.Drawing.Point(10, 85);
            this.lblTFPaid.Name = "lblTFPaid";
            this.lblTFPaid.Size = new System.Drawing.Size(237, 31);
            this.lblTFPaid.TabIndex = 113;
            this.lblTFPaid.Text = "---.--";
            this.lblTFPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 112;
            this.label2.Text = "Paid (PHP):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTFTotal
            // 
            this.lblTFTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTFTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTFTotal.Location = new System.Drawing.Point(10, 27);
            this.lblTFTotal.Name = "lblTFTotal";
            this.lblTFTotal.Size = new System.Drawing.Size(237, 31);
            this.lblTFTotal.TabIndex = 111;
            this.lblTFTotal.Text = "---.--";
            this.lblTFTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 16);
            this.label18.TabIndex = 110;
            this.label18.Text = "Total (PHP):";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlMPMessage);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.cboMPMonth);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cboMPYear);
            this.tabPage2.Controls.Add(this.lblMPBalance);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblMPPaid);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.lblMPTotal);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monthly Payment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlMPMessage
            // 
            this.pnlMPMessage.Controls.Add(this.lblMPMessage);
            this.pnlMPMessage.Location = new System.Drawing.Point(3, 3);
            this.pnlMPMessage.Name = "pnlMPMessage";
            this.pnlMPMessage.Size = new System.Drawing.Size(244, 172);
            this.pnlMPMessage.TabIndex = 131;
            this.pnlMPMessage.Visible = false;
            // 
            // lblMPMessage
            // 
            this.lblMPMessage.Location = new System.Drawing.Point(4, 61);
            this.lblMPMessage.Name = "lblMPMessage";
            this.lblMPMessage.Size = new System.Drawing.Size(237, 56);
            this.lblMPMessage.TabIndex = 0;
            this.lblMPMessage.Text = "label1";
            this.lblMPMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(257, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 130;
            this.label14.Text = "Month:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboMPMonth
            // 
            this.cboMPMonth.BackColor = System.Drawing.Color.White;
            this.cboMPMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMPMonth.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMPMonth.ForeColor = System.Drawing.Color.Black;
            this.cboMPMonth.FormattingEnabled = true;
            this.cboMPMonth.Items.AddRange(new object[] {
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
            this.cboMPMonth.Location = new System.Drawing.Point(257, 85);
            this.cboMPMonth.Name = "cboMPMonth";
            this.cboMPMonth.Size = new System.Drawing.Size(102, 31);
            this.cboMPMonth.TabIndex = 129;
            this.cboMPMonth.SelectedIndexChanged += new System.EventHandler(this.cboMPMonth_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 128;
            this.label6.Text = "Year:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboMPYear
            // 
            this.cboMPYear.BackColor = System.Drawing.Color.White;
            this.cboMPYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMPYear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMPYear.ForeColor = System.Drawing.Color.Black;
            this.cboMPYear.FormattingEnabled = true;
            this.cboMPYear.Items.AddRange(new object[] {
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
            this.cboMPYear.Location = new System.Drawing.Point(257, 27);
            this.cboMPYear.Name = "cboMPYear";
            this.cboMPYear.Size = new System.Drawing.Size(102, 31);
            this.cboMPYear.TabIndex = 127;
            this.cboMPYear.SelectedIndexChanged += new System.EventHandler(this.cboMPYear_SelectedIndexChanged);
            // 
            // lblMPBalance
            // 
            this.lblMPBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPBalance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPBalance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMPBalance.Location = new System.Drawing.Point(10, 141);
            this.lblMPBalance.Name = "lblMPBalance";
            this.lblMPBalance.Size = new System.Drawing.Size(237, 31);
            this.lblMPBalance.TabIndex = 126;
            this.lblMPBalance.Text = "---.--";
            this.lblMPBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 125;
            this.label8.Text = "Balance (PHP):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMPPaid
            // 
            this.lblMPPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPPaid.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPPaid.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMPPaid.Location = new System.Drawing.Point(10, 85);
            this.lblMPPaid.Name = "lblMPPaid";
            this.lblMPPaid.Size = new System.Drawing.Size(237, 31);
            this.lblMPPaid.TabIndex = 124;
            this.lblMPPaid.Text = "---.--";
            this.lblMPPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 123;
            this.label11.Text = "Paid (PHP):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMPTotal
            // 
            this.lblMPTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMPTotal.Location = new System.Drawing.Point(10, 27);
            this.lblMPTotal.Name = "lblMPTotal";
            this.lblMPTotal.Size = new System.Drawing.Size(237, 31);
            this.lblMPTotal.TabIndex = 122;
            this.lblMPTotal.Text = "---.--";
            this.lblMPTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 121;
            this.label13.Text = "Total (PHP):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwGrades
            // 
            this.lvwGrades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGRQuarter,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwGrades.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwGrades.FullRowSelect = true;
            this.lvwGrades.GridLines = true;
            this.lvwGrades.HideSelection = false;
            this.lvwGrades.Location = new System.Drawing.Point(16, 352);
            this.lvwGrades.MultiSelect = false;
            this.lvwGrades.Name = "lvwGrades";
            this.lvwGrades.Size = new System.Drawing.Size(375, 207);
            this.lvwGrades.TabIndex = 86;
            this.lvwGrades.UseCompatibleStateImageBehavior = false;
            this.lvwGrades.View = System.Windows.Forms.View.Details;
            this.lvwGrades.Visible = false;
            // 
            // colGRQuarter
            // 
            this.colGRQuarter.Text = "Subject";
            this.colGRQuarter.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Q1";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Q2";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Q3";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Q4";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 50;
            // 
            // frmPortal
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(792, 626);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPortal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParent)).EndInit();
            this.tabParent.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlTFMessage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlMPMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picParent;
        private System.Windows.Forms.Label lblPortal;
        private HintTextBox txtFirstname;
        private HintTextBox txtLastname;
        private HintTextBox txtStudentID;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListView lvwGrades;
        private System.Windows.Forms.ColumnHeader colGRQuarter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabControl tabParent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTFBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTFPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTFTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTFYear;
        private System.Windows.Forms.Panel pnlTFMessage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboMPMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMPYear;
        private System.Windows.Forms.Label lblMPBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMPPaid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMPTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTFMessage;
        private System.Windows.Forms.Panel pnlMPMessage;
        private System.Windows.Forms.Label lblMPMessage;
        private System.Windows.Forms.PictureBox picStudent;
    }
}