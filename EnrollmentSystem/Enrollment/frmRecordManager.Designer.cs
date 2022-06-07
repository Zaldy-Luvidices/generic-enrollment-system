namespace Enrollment
{
    partial class frmRecordManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecordManager));
            this.lvwStudents = new System.Windows.Forms.ListView();
            this.colMPIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblTitleMonthly = new System.Windows.Forms.Label();
            this.tabRecord = new System.Windows.Forms.TabControl();
            this.tabPageTuition = new System.Windows.Forms.TabPage();
            this.chkTFGenerateOR = new System.Windows.Forms.CheckBox();
            this.btnTFSubmit = new System.Windows.Forms.Button();
            this.btnTFEquate = new System.Windows.Forms.Button();
            this.lblTFBalance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTFPayment = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTFTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageMonthly = new System.Windows.Forms.TabPage();
            this.cboMPMonth = new System.Windows.Forms.ComboBox();
            this.chkMPGenerateOR = new System.Windows.Forms.CheckBox();
            this.btnMPSubmit = new System.Windows.Forms.Button();
            this.btnMPEquate = new System.Windows.Forms.Button();
            this.lblMPBalance = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMPPayment = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblMPTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPageGrades = new System.Windows.Forms.TabPage();
            this.btnGradePass = new System.Windows.Forms.Button();
            this.lvwGrades = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboQuarter = new System.Windows.Forms.ComboBox();
            this.btnGradeUpdate = new System.Windows.Forms.Button();
            this.btnGradeSubmit = new System.Windows.Forms.Button();
            this.numGrade = new System.Windows.Forms.NumericUpDown();
            this.btnYearNext = new System.Windows.Forms.Button();
            this.btnYearPrev = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new Enrollment.HintTextBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabRecord.SuspendLayout();
            this.tabPageTuition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tabPageMonthly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwStudents
            // 
            this.lvwStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMPIndex,
            this.colMPID,
            this.colMPName});
            this.lvwStudents.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwStudents.FullRowSelect = true;
            this.lvwStudents.GridLines = true;
            this.lvwStudents.HideSelection = false;
            this.lvwStudents.Location = new System.Drawing.Point(10, 50);
            this.lvwStudents.MultiSelect = false;
            this.lvwStudents.Name = "lvwStudents";
            this.lvwStudents.Size = new System.Drawing.Size(366, 134);
            this.lvwStudents.TabIndex = 94;
            this.lvwStudents.UseCompatibleStateImageBehavior = false;
            this.lvwStudents.View = System.Windows.Forms.View.Details;
            this.lvwStudents.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwStudents_ItemSelectionChanged);
            // 
            // colMPIndex
            // 
            this.colMPIndex.Text = "#";
            this.colMPIndex.Width = 40;
            // 
            // colMPID
            // 
            this.colMPID.Text = "Student ID";
            this.colMPID.Width = 100;
            // 
            // colMPName
            // 
            this.colMPName.Text = "Student Name";
            this.colMPName.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Level:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStudentInfo);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblGrade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTitleMonthly);
            this.panel1.Location = new System.Drawing.Point(10, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 190);
            this.panel1.TabIndex = 97;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStatus.Location = new System.Drawing.Point(264, 162);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(29, 16);
            this.lblStatus.TabIndex = 106;
            this.lblStatus.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Status:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblType.Location = new System.Drawing.Point(81, 162);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 16);
            this.lblType.TabIndex = 104;
            this.lblType.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 103;
            this.label8.Text = "Type:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(7, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 1);
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(81, 128);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(29, 16);
            this.lblSection.TabIndex = 101;
            this.lblSection.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 100;
            this.label6.Text = "Section:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(81, 106);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(29, 16);
            this.lblGrade.TabIndex = 99;
            this.lblGrade.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "Grade:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(81, 86);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(29, 16);
            this.lblLevel.TabIndex = 97;
            this.lblLevel.Text = "---";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.White;
            this.txtStudentName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtStudentName.Location = new System.Drawing.Point(7, 28);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtStudentName.Size = new System.Drawing.Size(349, 45);
            this.txtStudentName.TabIndex = 39;
            this.txtStudentName.WordWrap = false;
            // 
            // lblTitleMonthly
            // 
            this.lblTitleMonthly.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitleMonthly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleMonthly.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleMonthly.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMonthly.ForeColor = System.Drawing.Color.White;
            this.lblTitleMonthly.Location = new System.Drawing.Point(0, 0);
            this.lblTitleMonthly.Name = "lblTitleMonthly";
            this.lblTitleMonthly.Size = new System.Drawing.Size(364, 22);
            this.lblTitleMonthly.TabIndex = 38;
            this.lblTitleMonthly.Text = "INFORMATION";
            this.lblTitleMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabRecord
            // 
            this.tabRecord.Controls.Add(this.tabPageTuition);
            this.tabRecord.Controls.Add(this.tabPageMonthly);
            this.tabRecord.Controls.Add(this.tabPageGrades);
            this.tabRecord.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRecord.Location = new System.Drawing.Point(383, 7);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.SelectedIndex = 0;
            this.tabRecord.Size = new System.Drawing.Size(293, 377);
            this.tabRecord.TabIndex = 98;
            // 
            // tabPageTuition
            // 
            this.tabPageTuition.Controls.Add(this.chkTFGenerateOR);
            this.tabPageTuition.Controls.Add(this.btnTFSubmit);
            this.tabPageTuition.Controls.Add(this.btnTFEquate);
            this.tabPageTuition.Controls.Add(this.lblTFBalance);
            this.tabPageTuition.Controls.Add(this.label13);
            this.tabPageTuition.Controls.Add(this.txtTFPayment);
            this.tabPageTuition.Controls.Add(this.pictureBox7);
            this.tabPageTuition.Controls.Add(this.label11);
            this.tabPageTuition.Controls.Add(this.lblTFTotal);
            this.tabPageTuition.Controls.Add(this.label12);
            this.tabPageTuition.Location = new System.Drawing.Point(4, 25);
            this.tabPageTuition.Name = "tabPageTuition";
            this.tabPageTuition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTuition.Size = new System.Drawing.Size(285, 348);
            this.tabPageTuition.TabIndex = 0;
            this.tabPageTuition.Text = "Tuition Fee";
            this.tabPageTuition.UseVisualStyleBackColor = true;
            // 
            // chkTFGenerateOR
            // 
            this.chkTFGenerateOR.AutoSize = true;
            this.chkTFGenerateOR.Checked = true;
            this.chkTFGenerateOR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTFGenerateOR.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTFGenerateOR.Location = new System.Drawing.Point(23, 291);
            this.chkTFGenerateOR.Name = "chkTFGenerateOR";
            this.chkTFGenerateOR.Size = new System.Drawing.Size(110, 20);
            this.chkTFGenerateOR.TabIndex = 107;
            this.chkTFGenerateOR.Text = "Generate OR";
            this.chkTFGenerateOR.UseVisualStyleBackColor = true;
            this.chkTFGenerateOR.Visible = false;
            // 
            // btnTFSubmit
            // 
            this.btnTFSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTFSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTFSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTFSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTFSubmit.ForeColor = System.Drawing.Color.White;
            this.btnTFSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnTFSubmit.Image")));
            this.btnTFSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTFSubmit.Location = new System.Drawing.Point(143, 255);
            this.btnTFSubmit.Name = "btnTFSubmit";
            this.btnTFSubmit.Size = new System.Drawing.Size(117, 56);
            this.btnTFSubmit.TabIndex = 106;
            this.btnTFSubmit.Text = "SUBMIT";
            this.btnTFSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTFSubmit.UseVisualStyleBackColor = false;
            this.btnTFSubmit.Click += new System.EventHandler(this.btnTFSubmit_Click);
            // 
            // btnTFEquate
            // 
            this.btnTFEquate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTFEquate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTFEquate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTFEquate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTFEquate.ForeColor = System.Drawing.Color.White;
            this.btnTFEquate.Image = ((System.Drawing.Image)(resources.GetObject("btnTFEquate.Image")));
            this.btnTFEquate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTFEquate.Location = new System.Drawing.Point(220, 123);
            this.btnTFEquate.Name = "btnTFEquate";
            this.btnTFEquate.Size = new System.Drawing.Size(40, 31);
            this.btnTFEquate.TabIndex = 105;
            this.btnTFEquate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tip.SetToolTip(this.btnTFEquate, "Set amount as fully paid.");
            this.btnTFEquate.UseVisualStyleBackColor = false;
            this.btnTFEquate.Click += new System.EventHandler(this.btnTFEquate_Click);
            // 
            // lblTFBalance
            // 
            this.lblTFBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTFBalance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFBalance.ForeColor = System.Drawing.Color.Black;
            this.lblTFBalance.Location = new System.Drawing.Point(23, 214);
            this.lblTFBalance.Name = "lblTFBalance";
            this.lblTFBalance.Size = new System.Drawing.Size(237, 31);
            this.lblTFBalance.TabIndex = 89;
            this.lblTFBalance.Text = "---.--";
            this.lblTFBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 88;
            this.label13.Text = "Balance (PHP):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTFPayment
            // 
            this.txtTFPayment.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtTFPayment.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTFPayment.ForeColor = System.Drawing.Color.White;
            this.txtTFPayment.Location = new System.Drawing.Point(23, 157);
            this.txtTFPayment.Name = "txtTFPayment";
            this.txtTFPayment.Size = new System.Drawing.Size(237, 31);
            this.txtTFPayment.TabIndex = 87;
            this.txtTFPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTFPayment.Enter += new System.EventHandler(this.txtTFPayment_Enter);
            this.txtTFPayment.Leave += new System.EventHandler(this.txtTFPayment_Leave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(25, 117);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(232, 1);
            this.pictureBox7.TabIndex = 84;
            this.pictureBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 14);
            this.label11.TabIndex = 82;
            this.label11.Text = "Payment (PHP):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTFTotal
            // 
            this.lblTFTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTFTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTFTotal.Location = new System.Drawing.Point(23, 75);
            this.lblTFTotal.Name = "lblTFTotal";
            this.lblTFTotal.Size = new System.Drawing.Size(237, 31);
            this.lblTFTotal.TabIndex = 81;
            this.lblTFTotal.Text = "---.--";
            this.lblTFTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 80;
            this.label12.Text = "Total (PHP):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPageMonthly
            // 
            this.tabPageMonthly.Controls.Add(this.cboMPMonth);
            this.tabPageMonthly.Controls.Add(this.chkMPGenerateOR);
            this.tabPageMonthly.Controls.Add(this.btnMPSubmit);
            this.tabPageMonthly.Controls.Add(this.btnMPEquate);
            this.tabPageMonthly.Controls.Add(this.lblMPBalance);
            this.tabPageMonthly.Controls.Add(this.label15);
            this.tabPageMonthly.Controls.Add(this.txtMPPayment);
            this.tabPageMonthly.Controls.Add(this.pictureBox1);
            this.tabPageMonthly.Controls.Add(this.label16);
            this.tabPageMonthly.Controls.Add(this.lblMPTotal);
            this.tabPageMonthly.Controls.Add(this.label18);
            this.tabPageMonthly.Location = new System.Drawing.Point(4, 25);
            this.tabPageMonthly.Name = "tabPageMonthly";
            this.tabPageMonthly.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonthly.Size = new System.Drawing.Size(285, 348);
            this.tabPageMonthly.TabIndex = 1;
            this.tabPageMonthly.Text = "Monthly Payment";
            this.tabPageMonthly.UseVisualStyleBackColor = true;
            // 
            // cboMPMonth
            // 
            this.cboMPMonth.BackColor = System.Drawing.Color.White;
            this.cboMPMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMPMonth.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMPMonth.ForeColor = System.Drawing.Color.DodgerBlue;
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
            this.cboMPMonth.Location = new System.Drawing.Point(187, 30);
            this.cboMPMonth.Name = "cboMPMonth";
            this.cboMPMonth.Size = new System.Drawing.Size(73, 26);
            this.cboMPMonth.TabIndex = 118;
            this.cboMPMonth.SelectedIndexChanged += new System.EventHandler(this.cboMPMonth_SelectedIndexChanged);
            // 
            // chkMPGenerateOR
            // 
            this.chkMPGenerateOR.AutoSize = true;
            this.chkMPGenerateOR.Checked = true;
            this.chkMPGenerateOR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMPGenerateOR.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMPGenerateOR.Location = new System.Drawing.Point(23, 291);
            this.chkMPGenerateOR.Name = "chkMPGenerateOR";
            this.chkMPGenerateOR.Size = new System.Drawing.Size(110, 20);
            this.chkMPGenerateOR.TabIndex = 117;
            this.chkMPGenerateOR.Text = "Generate OR";
            this.chkMPGenerateOR.UseVisualStyleBackColor = true;
            this.chkMPGenerateOR.Visible = false;
            // 
            // btnMPSubmit
            // 
            this.btnMPSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMPSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMPSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPSubmit.ForeColor = System.Drawing.Color.White;
            this.btnMPSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnMPSubmit.Image")));
            this.btnMPSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMPSubmit.Location = new System.Drawing.Point(143, 255);
            this.btnMPSubmit.Name = "btnMPSubmit";
            this.btnMPSubmit.Size = new System.Drawing.Size(117, 56);
            this.btnMPSubmit.TabIndex = 116;
            this.btnMPSubmit.Text = "SUBMIT";
            this.btnMPSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMPSubmit.UseVisualStyleBackColor = false;
            this.btnMPSubmit.Click += new System.EventHandler(this.btnMPSubmit_Click);
            // 
            // btnMPEquate
            // 
            this.btnMPEquate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMPEquate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMPEquate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPEquate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPEquate.ForeColor = System.Drawing.Color.White;
            this.btnMPEquate.Image = ((System.Drawing.Image)(resources.GetObject("btnMPEquate.Image")));
            this.btnMPEquate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMPEquate.Location = new System.Drawing.Point(220, 123);
            this.btnMPEquate.Name = "btnMPEquate";
            this.btnMPEquate.Size = new System.Drawing.Size(40, 31);
            this.btnMPEquate.TabIndex = 115;
            this.btnMPEquate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tip.SetToolTip(this.btnMPEquate, "Set amount as fully paid.");
            this.btnMPEquate.UseVisualStyleBackColor = false;
            this.btnMPEquate.Click += new System.EventHandler(this.btnMPEquate_Click);
            // 
            // lblMPBalance
            // 
            this.lblMPBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPBalance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPBalance.ForeColor = System.Drawing.Color.Black;
            this.lblMPBalance.Location = new System.Drawing.Point(23, 214);
            this.lblMPBalance.Name = "lblMPBalance";
            this.lblMPBalance.Size = new System.Drawing.Size(237, 31);
            this.lblMPBalance.TabIndex = 114;
            this.lblMPBalance.Text = "---.--";
            this.lblMPBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 16);
            this.label15.TabIndex = 113;
            this.label15.Text = "Balance (PHP):";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMPPayment
            // 
            this.txtMPPayment.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtMPPayment.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPPayment.ForeColor = System.Drawing.Color.White;
            this.txtMPPayment.Location = new System.Drawing.Point(23, 157);
            this.txtMPPayment.Name = "txtMPPayment";
            this.txtMPPayment.Size = new System.Drawing.Size(237, 31);
            this.txtMPPayment.TabIndex = 112;
            this.txtMPPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMPPayment.Enter += new System.EventHandler(this.txtMPPayment_Enter);
            this.txtMPPayment.Leave += new System.EventHandler(this.txtMPPayment_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(25, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 1);
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 14);
            this.label16.TabIndex = 110;
            this.label16.Text = "Payment (PHP):";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMPTotal
            // 
            this.lblMPTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMPTotal.Location = new System.Drawing.Point(23, 75);
            this.lblMPTotal.Name = "lblMPTotal";
            this.lblMPTotal.Size = new System.Drawing.Size(237, 31);
            this.lblMPTotal.TabIndex = 109;
            this.lblMPTotal.Text = "---.--";
            this.lblMPTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 16);
            this.label18.TabIndex = 108;
            this.label18.Text = "Total (PHP):";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPageGrades
            // 
            this.tabPageGrades.Controls.Add(this.btnGradePass);
            this.tabPageGrades.Controls.Add(this.lvwGrades);
            this.tabPageGrades.Controls.Add(this.cboQuarter);
            this.tabPageGrades.Controls.Add(this.btnGradeUpdate);
            this.tabPageGrades.Controls.Add(this.btnGradeSubmit);
            this.tabPageGrades.Controls.Add(this.numGrade);
            this.tabPageGrades.Location = new System.Drawing.Point(4, 25);
            this.tabPageGrades.Name = "tabPageGrades";
            this.tabPageGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrades.Size = new System.Drawing.Size(285, 348);
            this.tabPageGrades.TabIndex = 2;
            this.tabPageGrades.Text = "Grades";
            this.tabPageGrades.UseVisualStyleBackColor = true;
            // 
            // btnGradePass
            // 
            this.btnGradePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGradePass.BackColor = System.Drawing.Color.White;
            this.btnGradePass.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGradePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradePass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradePass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGradePass.Image = ((System.Drawing.Image)(resources.GetObject("btnGradePass.Image")));
            this.btnGradePass.Location = new System.Drawing.Point(135, 283);
            this.btnGradePass.Name = "btnGradePass";
            this.btnGradePass.Size = new System.Drawing.Size(35, 27);
            this.btnGradePass.TabIndex = 121;
            this.btnGradePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tip.SetToolTip(this.btnGradePass, "Set selected subject\'s grade as the passing grade.");
            this.btnGradePass.UseVisualStyleBackColor = false;
            this.btnGradePass.Click += new System.EventHandler(this.btnGradePass_Click);
            // 
            // lvwGrades
            // 
            this.lvwGrades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwGrades.FullRowSelect = true;
            this.lvwGrades.GridLines = true;
            this.lvwGrades.HideSelection = false;
            this.lvwGrades.Location = new System.Drawing.Point(4, 50);
            this.lvwGrades.MultiSelect = false;
            this.lvwGrades.Name = "lvwGrades";
            this.lvwGrades.Size = new System.Drawing.Size(276, 227);
            this.lvwGrades.TabIndex = 120;
            this.lvwGrades.UseCompatibleStateImageBehavior = false;
            this.lvwGrades.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Grade";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Passing";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Code";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 300;
            // 
            // cboQuarter
            // 
            this.cboQuarter.BackColor = System.Drawing.Color.White;
            this.cboQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuarter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuarter.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cboQuarter.FormattingEnabled = true;
            this.cboQuarter.Items.AddRange(new object[] {
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
            this.cboQuarter.Location = new System.Drawing.Point(4, 20);
            this.cboQuarter.Name = "cboQuarter";
            this.cboQuarter.Size = new System.Drawing.Size(136, 26);
            this.cboQuarter.TabIndex = 119;
            this.cboQuarter.SelectedIndexChanged += new System.EventHandler(this.cboQuarter_SelectedIndexChanged);
            // 
            // btnGradeUpdate
            // 
            this.btnGradeUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGradeUpdate.BackColor = System.Drawing.Color.White;
            this.btnGradeUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGradeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradeUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGradeUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnGradeUpdate.Image")));
            this.btnGradeUpdate.Location = new System.Drawing.Point(94, 283);
            this.btnGradeUpdate.Name = "btnGradeUpdate";
            this.btnGradeUpdate.Size = new System.Drawing.Size(35, 27);
            this.btnGradeUpdate.TabIndex = 97;
            this.btnGradeUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tip.SetToolTip(this.btnGradeUpdate, "Update selected subject with this grade.");
            this.btnGradeUpdate.UseVisualStyleBackColor = false;
            this.btnGradeUpdate.Click += new System.EventHandler(this.btnGradeUpdate_Click);
            // 
            // btnGradeSubmit
            // 
            this.btnGradeSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGradeSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGradeSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGradeSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradeSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeSubmit.ForeColor = System.Drawing.Color.White;
            this.btnGradeSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnGradeSubmit.Image")));
            this.btnGradeSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGradeSubmit.Location = new System.Drawing.Point(179, 282);
            this.btnGradeSubmit.Name = "btnGradeSubmit";
            this.btnGradeSubmit.Size = new System.Drawing.Size(101, 59);
            this.btnGradeSubmit.TabIndex = 96;
            this.btnGradeSubmit.Text = "SUBMIT";
            this.btnGradeSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGradeSubmit.UseVisualStyleBackColor = false;
            this.btnGradeSubmit.Click += new System.EventHandler(this.btnGradeSubmit_Click);
            // 
            // numGrade
            // 
            this.numGrade.BackColor = System.Drawing.Color.DodgerBlue;
            this.numGrade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGrade.ForeColor = System.Drawing.Color.White;
            this.numGrade.Location = new System.Drawing.Point(4, 283);
            this.numGrade.Name = "numGrade";
            this.numGrade.Size = new System.Drawing.Size(84, 27);
            this.numGrade.TabIndex = 95;
            this.numGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numGrade.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btnYearNext
            // 
            this.btnYearNext.BackColor = System.Drawing.Color.White;
            this.btnYearNext.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnYearNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearNext.Image = ((System.Drawing.Image)(resources.GetObject("btnYearNext.Image")));
            this.btnYearNext.Location = new System.Drawing.Point(339, 7);
            this.btnYearNext.Name = "btnYearNext";
            this.btnYearNext.Size = new System.Drawing.Size(35, 35);
            this.btnYearNext.TabIndex = 101;
            this.btnYearNext.UseVisualStyleBackColor = false;
            this.btnYearNext.Visible = false;
            this.btnYearNext.Click += new System.EventHandler(this.btnYearNext_Click);
            // 
            // btnYearPrev
            // 
            this.btnYearPrev.BackColor = System.Drawing.Color.White;
            this.btnYearPrev.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnYearPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnYearPrev.Image")));
            this.btnYearPrev.Location = new System.Drawing.Point(298, 7);
            this.btnYearPrev.Name = "btnYearPrev";
            this.btnYearPrev.Size = new System.Drawing.Size(35, 35);
            this.btnYearPrev.TabIndex = 99;
            this.btnYearPrev.UseVisualStyleBackColor = false;
            this.btnYearPrev.Visible = false;
            this.btnYearPrev.Click += new System.EventHandler(this.btnYearPrev_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-185, -41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(344, 453);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 104;
            this.pictureBox3.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(10, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 23);
            this.txtSearch.TabIndex = 93;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.LightGray;
            this.txtSearch.WaterMarkText = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.Color.DodgerBlue;
            this.cboYear.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.White;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(275, 12);
            this.cboYear.MaxLength = 4;
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(100, 30);
            this.cboYear.Sorted = true;
            this.cboYear.TabIndex = 105;
            this.cboYear.Text = "2019";
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            this.cboYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboYear_KeyPress);
            this.cboYear.Leave += new System.EventHandler(this.cboYear_Leave);
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearchClear.BackColor = System.Drawing.Color.White;
            this.btnSearchClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchClear.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchClear.Image")));
            this.btnSearchClear.Location = new System.Drawing.Point(186, 17);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(35, 27);
            this.btnSearchClear.TabIndex = 106;
            this.btnSearchClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tip.SetToolTip(this.btnSearchClear, "Clear search filter.");
            this.btnSearchClear.UseVisualStyleBackColor = false;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.DodgerBlue;
            this.tip.ForeColor = System.Drawing.Color.White;
            this.tip.IsBalloon = true;
            this.tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tip.ToolTipTitle = "Hint";
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStudentInfo.BackColor = System.Drawing.Color.White;
            this.btnStudentInfo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnStudentInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentInfo.Image")));
            this.btnStudentInfo.Location = new System.Drawing.Point(322, 119);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(35, 27);
            this.btnStudentInfo.TabIndex = 107;
            this.btnStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tip.SetToolTip(this.btnStudentInfo, "Clear search filter.");
            this.btnStudentInfo.UseVisualStyleBackColor = false;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // frmRecordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 393);
            this.Controls.Add(this.btnSearchClear);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.tabRecord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwStudents);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnYearNext);
            this.Controls.Add(this.btnYearPrev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecordManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRecordManager_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabRecord.ResumeLayout(false);
            this.tabPageTuition.ResumeLayout(false);
            this.tabPageTuition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tabPageMonthly.ResumeLayout(false);
            this.tabPageMonthly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HintTextBox txtSearch;
        private System.Windows.Forms.ListView lvwStudents;
        private System.Windows.Forms.ColumnHeader colMPIndex;
        private System.Windows.Forms.ColumnHeader colMPID;
        private System.Windows.Forms.ColumnHeader colMPName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblTitleMonthly;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabRecord;
        private System.Windows.Forms.TabPage tabPageTuition;
        private System.Windows.Forms.TabPage tabPageMonthly;
        private System.Windows.Forms.TabPage tabPageGrades;
        private System.Windows.Forms.Button btnYearNext;
        private System.Windows.Forms.Button btnYearPrev;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTFTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTFBalance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTFPayment;
        private System.Windows.Forms.Button btnTFEquate;
        private System.Windows.Forms.Button btnTFSubmit;
        private System.Windows.Forms.CheckBox chkTFGenerateOR;
        private System.Windows.Forms.CheckBox chkMPGenerateOR;
        private System.Windows.Forms.Button btnMPSubmit;
        private System.Windows.Forms.Button btnMPEquate;
        private System.Windows.Forms.Label lblMPBalance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMPPayment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblMPTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboMPMonth;
        private System.Windows.Forms.NumericUpDown numGrade;
        private System.Windows.Forms.Button btnGradeSubmit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGradeUpdate;
        private System.Windows.Forms.ComboBox cboQuarter;
        private System.Windows.Forms.ListView lvwGrades;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnGradePass;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Button btnStudentInfo;
    }
}