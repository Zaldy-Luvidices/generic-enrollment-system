namespace Enrollment
{
    partial class frmStudentsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentsList));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Q1");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Q2");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Q3");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Q4");
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.txtSearch = new Enrollment.HintTextBox();
            this.lvwStudents = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMiddlename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBirthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateUpdated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.chkFilterDropouts = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkFilterGraduates = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkFilterStudents = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chkFilterEnrollees = new System.Windows.Forms.CheckBox();
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMarkStudent = new System.Windows.Forms.ToolStripButton();
            this.toolMarkGraduate = new System.Windows.Forms.ToolStripButton();
            this.toolMarkDropout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.splitGrading = new System.Windows.Forms.SplitContainer();
            this.cboGradeYears = new System.Windows.Forms.ComboBox();
            this.cboGradeRecord = new System.Windows.Forms.ComboBox();
            this.btnGradingInput = new System.Windows.Forms.Button();
            this.lvwGrading = new System.Windows.Forms.ListView();
            this.colGRQuarter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitleGrading = new System.Windows.Forms.Label();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.splitTuition = new System.Windows.Forms.SplitContainer();
            this.btnTuitionEditPaid = new System.Windows.Forms.Button();
            this.btnTuitionEditTotal = new System.Windows.Forms.Button();
            this.btnTuitionNext = new System.Windows.Forms.Button();
            this.btnTuitionPrevious = new System.Windows.Forms.Button();
            this.lblTuitionBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblTuitionPaid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTuitionTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvwTuition = new System.Windows.Forms.ListView();
            this.colTFYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTFTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTFPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTHLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTHLastUpdated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitleTuition = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.splitMonthly = new System.Windows.Forms.SplitContainer();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.btnMonthlyEditPaid = new System.Windows.Forms.Button();
            this.btnMonthlyEditTotal = new System.Windows.Forms.Button();
            this.btnMonthlyNext = new System.Windows.Forms.Button();
            this.btnMonthlyPrevious = new System.Windows.Forms.Button();
            this.lblMonthlyBalance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMonthlyPaid = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMonthlyTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lvwMonthly = new System.Windows.Forms.ListView();
            this.colMPMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPDateUpdated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitleMonthly = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.toolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGrading)).BeginInit();
            this.splitGrading.Panel1.SuspendLayout();
            this.splitGrading.Panel2.SuspendLayout();
            this.splitGrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitTuition)).BeginInit();
            this.splitTuition.Panel1.SuspendLayout();
            this.splitTuition.Panel2.SuspendLayout();
            this.splitTuition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMonthly)).BeginInit();
            this.splitMonthly.Panel1.SuspendLayout();
            this.splitMonthly.Panel2.SuspendLayout();
            this.splitMonthly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitLeft);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Size = new System.Drawing.Size(937, 595);
            this.splitMain.SplitterDistance = 679;
            this.splitMain.TabIndex = 0;
            // 
            // splitLeft
            // 
            this.splitLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitLeft.IsSplitterFixed = true;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.Controls.Add(this.txtSearch);
            this.splitLeft.Panel1.Controls.Add(this.lvwStudents);
            this.splitLeft.Panel1.Controls.Add(this.pnlStatus);
            this.splitLeft.Panel1.Controls.Add(this.toolMenu);
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.BackColor = System.Drawing.Color.White;
            this.splitLeft.Panel2.Controls.Add(this.pictureBox9);
            this.splitLeft.Panel2.Controls.Add(this.splitGrading);
            this.splitLeft.Panel2.Controls.Add(this.lblTitleGrading);
            this.splitLeft.Size = new System.Drawing.Size(679, 595);
            this.splitLeft.SplitterDistance = 460;
            this.splitLeft.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(477, 4);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 23);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.LightGray;
            this.txtSearch.WaterMarkText = "Filter";
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lvwStudents
            // 
            this.lvwStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colID,
            this.colLastname,
            this.colFirstname,
            this.colMiddlename,
            this.colLevel,
            this.colSection,
            this.colBirthdate,
            this.colContact,
            this.colAddress,
            this.colType,
            this.colNotes,
            this.colDateCreated,
            this.colDateUpdated,
            this.colGrade});
            this.lvwStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwStudents.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwStudents.FullRowSelect = true;
            this.lvwStudents.GridLines = true;
            this.lvwStudents.HideSelection = false;
            this.lvwStudents.Location = new System.Drawing.Point(0, 31);
            this.lvwStudents.MultiSelect = false;
            this.lvwStudents.Name = "lvwStudents";
            this.lvwStudents.Size = new System.Drawing.Size(677, 397);
            this.lvwStudents.TabIndex = 33;
            this.lvwStudents.UseCompatibleStateImageBehavior = false;
            this.lvwStudents.View = System.Windows.Forms.View.Details;
            this.lvwStudents.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwStudents_ItemSelectionChanged);
            // 
            // colIndex
            // 
            this.colIndex.Text = "#";
            this.colIndex.Width = 40;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 100;
            // 
            // colLastname
            // 
            this.colLastname.Text = "Lastname";
            this.colLastname.Width = 120;
            // 
            // colFirstname
            // 
            this.colFirstname.Text = "Firstname";
            this.colFirstname.Width = 120;
            // 
            // colMiddlename
            // 
            this.colMiddlename.Text = "Middlename";
            this.colMiddlename.Width = 120;
            // 
            // colLevel
            // 
            this.colLevel.DisplayIndex = 7;
            this.colLevel.Text = "Level";
            // 
            // colSection
            // 
            this.colSection.DisplayIndex = 8;
            this.colSection.Text = "Section";
            this.colSection.Width = 100;
            // 
            // colBirthdate
            // 
            this.colBirthdate.DisplayIndex = 9;
            this.colBirthdate.Text = "Birthdate";
            this.colBirthdate.Width = 100;
            // 
            // colContact
            // 
            this.colContact.DisplayIndex = 10;
            this.colContact.Text = "Contact #";
            this.colContact.Width = 100;
            // 
            // colAddress
            // 
            this.colAddress.DisplayIndex = 11;
            this.colAddress.Text = "Address";
            this.colAddress.Width = 400;
            // 
            // colType
            // 
            this.colType.DisplayIndex = 5;
            this.colType.Text = "Type";
            this.colType.Width = 100;
            // 
            // colNotes
            // 
            this.colNotes.DisplayIndex = 12;
            this.colNotes.Text = "Notes";
            this.colNotes.Width = 200;
            // 
            // colDateCreated
            // 
            this.colDateCreated.DisplayIndex = 13;
            this.colDateCreated.Text = "Date Registered";
            this.colDateCreated.Width = 120;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.DisplayIndex = 14;
            this.colDateUpdated.Text = "Date Updated";
            this.colDateUpdated.Width = 120;
            // 
            // colGrade
            // 
            this.colGrade.DisplayIndex = 6;
            this.colGrade.Text = "Grade";
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.White;
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.cboGrade);
            this.pnlStatus.Controls.Add(this.label1);
            this.pnlStatus.Controls.Add(this.label16);
            this.pnlStatus.Controls.Add(this.lblTotal);
            this.pnlStatus.Controls.Add(this.pictureBox5);
            this.pnlStatus.Controls.Add(this.chkFilterDropouts);
            this.pnlStatus.Controls.Add(this.pictureBox3);
            this.pnlStatus.Controls.Add(this.chkFilterGraduates);
            this.pnlStatus.Controls.Add(this.pictureBox2);
            this.pnlStatus.Controls.Add(this.chkFilterStudents);
            this.pnlStatus.Controls.Add(this.pictureBox4);
            this.pnlStatus.Controls.Add(this.chkFilterEnrollees);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 428);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(677, 30);
            this.pnlStatus.TabIndex = 2;
            // 
            // cboGrade
            // 
            this.cboGrade.BackColor = System.Drawing.Color.White;
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade.ForeColor = System.Drawing.Color.Black;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(488, 2);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(73, 24);
            this.cboGrade.TabIndex = 119;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 118;
            this.label1.Text = "Grade:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(554, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 23);
            this.label16.TabIndex = 49;
            this.label16.Text = "Total:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(615, 3);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 22);
            this.lblTotal.TabIndex = 48;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(375, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1, 20);
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            // 
            // chkFilterDropouts
            // 
            this.chkFilterDropouts.AutoSize = true;
            this.chkFilterDropouts.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilterDropouts.Location = new System.Drawing.Point(288, 4);
            this.chkFilterDropouts.Name = "chkFilterDropouts";
            this.chkFilterDropouts.Size = new System.Drawing.Size(86, 20);
            this.chkFilterDropouts.TabIndex = 46;
            this.chkFilterDropouts.Text = "Dropouts";
            this.chkFilterDropouts.UseVisualStyleBackColor = true;
            this.chkFilterDropouts.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(281, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 20);
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // chkFilterGraduates
            // 
            this.chkFilterGraduates.AutoSize = true;
            this.chkFilterGraduates.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilterGraduates.Location = new System.Drawing.Point(188, 4);
            this.chkFilterGraduates.Name = "chkFilterGraduates";
            this.chkFilterGraduates.Size = new System.Drawing.Size(94, 20);
            this.chkFilterGraduates.TabIndex = 44;
            this.chkFilterGraduates.Text = "Graduates";
            this.chkFilterGraduates.UseVisualStyleBackColor = true;
            this.chkFilterGraduates.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(181, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 20);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // chkFilterStudents
            // 
            this.chkFilterStudents.AutoSize = true;
            this.chkFilterStudents.Checked = true;
            this.chkFilterStudents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilterStudents.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilterStudents.Location = new System.Drawing.Point(95, 4);
            this.chkFilterStudents.Name = "chkFilterStudents";
            this.chkFilterStudents.Size = new System.Drawing.Size(87, 20);
            this.chkFilterStudents.TabIndex = 42;
            this.chkFilterStudents.Text = "Students";
            this.chkFilterStudents.UseVisualStyleBackColor = true;
            this.chkFilterStudents.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(89, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 20);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // chkFilterEnrollees
            // 
            this.chkFilterEnrollees.AutoSize = true;
            this.chkFilterEnrollees.Checked = true;
            this.chkFilterEnrollees.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilterEnrollees.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilterEnrollees.Location = new System.Drawing.Point(4, 4);
            this.chkFilterEnrollees.Name = "chkFilterEnrollees";
            this.chkFilterEnrollees.Size = new System.Drawing.Size(85, 20);
            this.chkFilterEnrollees.TabIndex = 26;
            this.chkFilterEnrollees.Text = "Enrollees";
            this.chkFilterEnrollees.UseVisualStyleBackColor = true;
            this.chkFilterEnrollees.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // toolMenu
            // 
            this.toolMenu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.toolEdit,
            this.toolStripSeparator2,
            this.toolMarkStudent,
            this.toolMarkGraduate,
            this.toolMarkDropout,
            this.toolStripSeparator1,
            this.toolDelete});
            this.toolMenu.Location = new System.Drawing.Point(0, 0);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(677, 31);
            this.toolMenu.TabIndex = 1;
            this.toolMenu.Text = "toolStrip1";
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(28, 28);
            this.toolAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolAdd.ToolTipText = "Add new student";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolEdit
            // 
            this.toolEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEdit.Enabled = false;
            this.toolEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolEdit.Image")));
            this.toolEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.Size = new System.Drawing.Size(28, 28);
            this.toolEdit.Text = "toolStripButton2";
            this.toolEdit.ToolTipText = "Edit selected student";
            this.toolEdit.Click += new System.EventHandler(this.toolEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolMarkStudent
            // 
            this.toolMarkStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMarkStudent.Enabled = false;
            this.toolMarkStudent.Image = ((System.Drawing.Image)(resources.GetObject("toolMarkStudent.Image")));
            this.toolMarkStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMarkStudent.Name = "toolMarkStudent";
            this.toolMarkStudent.Size = new System.Drawing.Size(28, 28);
            this.toolMarkStudent.Text = "toolStripButton4";
            this.toolMarkStudent.ToolTipText = "Mark as [Student]";
            this.toolMarkStudent.Click += new System.EventHandler(this.toolMark_Click);
            // 
            // toolMarkGraduate
            // 
            this.toolMarkGraduate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMarkGraduate.Enabled = false;
            this.toolMarkGraduate.Image = ((System.Drawing.Image)(resources.GetObject("toolMarkGraduate.Image")));
            this.toolMarkGraduate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMarkGraduate.Name = "toolMarkGraduate";
            this.toolMarkGraduate.Size = new System.Drawing.Size(28, 28);
            this.toolMarkGraduate.Text = "toolStripButton5";
            this.toolMarkGraduate.ToolTipText = "Mark as [Graduate]";
            this.toolMarkGraduate.Click += new System.EventHandler(this.toolMark_Click);
            // 
            // toolMarkDropout
            // 
            this.toolMarkDropout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMarkDropout.Enabled = false;
            this.toolMarkDropout.Image = ((System.Drawing.Image)(resources.GetObject("toolMarkDropout.Image")));
            this.toolMarkDropout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMarkDropout.Name = "toolMarkDropout";
            this.toolMarkDropout.Size = new System.Drawing.Size(28, 28);
            this.toolMarkDropout.Text = "toolStripButton6";
            this.toolMarkDropout.ToolTipText = "Mark as [Dropout]";
            this.toolMarkDropout.Click += new System.EventHandler(this.toolMark_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolDelete
            // 
            this.toolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDelete.Enabled = false;
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(28, 28);
            this.toolDelete.Text = "toolStripButton3";
            this.toolDelete.ToolTipText = "Delete selected student";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(1, 1);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 40;
            this.pictureBox9.TabStop = false;
            // 
            // splitGrading
            // 
            this.splitGrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGrading.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitGrading.IsSplitterFixed = true;
            this.splitGrading.Location = new System.Drawing.Point(0, 22);
            this.splitGrading.Name = "splitGrading";
            // 
            // splitGrading.Panel1
            // 
            this.splitGrading.Panel1.BackColor = System.Drawing.Color.Azure;
            this.splitGrading.Panel1.Controls.Add(this.cboGradeYears);
            this.splitGrading.Panel1.Controls.Add(this.cboGradeRecord);
            this.splitGrading.Panel1.Controls.Add(this.btnGradingInput);
            // 
            // splitGrading.Panel2
            // 
            this.splitGrading.Panel2.Controls.Add(this.lvwGrading);
            this.splitGrading.Size = new System.Drawing.Size(677, 107);
            this.splitGrading.SplitterDistance = 88;
            this.splitGrading.TabIndex = 39;
            // 
            // cboGradeYears
            // 
            this.cboGradeYears.BackColor = System.Drawing.Color.White;
            this.cboGradeYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGradeYears.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGradeYears.ForeColor = System.Drawing.Color.Black;
            this.cboGradeYears.FormattingEnabled = true;
            this.cboGradeYears.Location = new System.Drawing.Point(5, 36);
            this.cboGradeYears.Name = "cboGradeYears";
            this.cboGradeYears.Size = new System.Drawing.Size(76, 24);
            this.cboGradeYears.TabIndex = 121;
            this.cboGradeYears.SelectedIndexChanged += new System.EventHandler(this.cboGradeYears_SelectedIndexChanged);
            // 
            // cboGradeRecord
            // 
            this.cboGradeRecord.BackColor = System.Drawing.Color.White;
            this.cboGradeRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGradeRecord.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGradeRecord.ForeColor = System.Drawing.Color.Black;
            this.cboGradeRecord.FormattingEnabled = true;
            this.cboGradeRecord.Location = new System.Drawing.Point(5, 5);
            this.cboGradeRecord.Name = "cboGradeRecord";
            this.cboGradeRecord.Size = new System.Drawing.Size(76, 24);
            this.cboGradeRecord.TabIndex = 120;
            this.cboGradeRecord.SelectedIndexChanged += new System.EventHandler(this.cboGradeRecord_SelectedIndexChanged);
            // 
            // btnGradingInput
            // 
            this.btnGradingInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGradingInput.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGradingInput.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGradingInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradingInput.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradingInput.ForeColor = System.Drawing.Color.White;
            this.btnGradingInput.Image = ((System.Drawing.Image)(resources.GetObject("btnGradingInput.Image")));
            this.btnGradingInput.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGradingInput.Location = new System.Drawing.Point(5, 66);
            this.btnGradingInput.Name = "btnGradingInput";
            this.btnGradingInput.Size = new System.Drawing.Size(76, 36);
            this.btnGradingInput.TabIndex = 72;
            this.btnGradingInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tip.SetToolTip(this.btnGradingInput, "Go to [Grades Input] window.");
            this.btnGradingInput.UseVisualStyleBackColor = false;
            this.btnGradingInput.Click += new System.EventHandler(this.btnGradingInput_Click);
            // 
            // lvwGrading
            // 
            this.lvwGrading.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGRQuarter});
            this.lvwGrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwGrading.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwGrading.FullRowSelect = true;
            this.lvwGrading.GridLines = true;
            this.lvwGrading.HideSelection = false;
            this.lvwGrading.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lvwGrading.Location = new System.Drawing.Point(0, 0);
            this.lvwGrading.MultiSelect = false;
            this.lvwGrading.Name = "lvwGrading";
            this.lvwGrading.Size = new System.Drawing.Size(585, 107);
            this.lvwGrading.TabIndex = 73;
            this.lvwGrading.UseCompatibleStateImageBehavior = false;
            this.lvwGrading.View = System.Windows.Forms.View.Details;
            // 
            // colGRQuarter
            // 
            this.colGRQuarter.Text = "";
            this.colGRQuarter.Width = 32;
            // 
            // lblTitleGrading
            // 
            this.lblTitleGrading.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitleGrading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleGrading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleGrading.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGrading.ForeColor = System.Drawing.Color.White;
            this.lblTitleGrading.Location = new System.Drawing.Point(0, 0);
            this.lblTitleGrading.Name = "lblTitleGrading";
            this.lblTitleGrading.Size = new System.Drawing.Size(677, 22);
            this.lblTitleGrading.TabIndex = 38;
            this.lblTitleGrading.Text = "     GRADING RECORD";
            this.lblTitleGrading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitRight
            // 
            this.splitRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.BackColor = System.Drawing.Color.White;
            this.splitRight.Panel1.Controls.Add(this.pictureBox6);
            this.splitRight.Panel1.Controls.Add(this.splitTuition);
            this.splitRight.Panel1.Controls.Add(this.lblTitleTuition);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitRight.Panel2.Controls.Add(this.pictureBox8);
            this.splitRight.Panel2.Controls.Add(this.splitMonthly);
            this.splitRight.Panel2.Controls.Add(this.lblTitleMonthly);
            this.splitRight.Size = new System.Drawing.Size(254, 595);
            this.splitRight.SplitterDistance = 321;
            this.splitRight.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(2, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // splitTuition
            // 
            this.splitTuition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTuition.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitTuition.IsSplitterFixed = true;
            this.splitTuition.Location = new System.Drawing.Point(0, 22);
            this.splitTuition.Name = "splitTuition";
            this.splitTuition.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitTuition.Panel1
            // 
            this.splitTuition.Panel1.BackColor = System.Drawing.Color.Azure;
            this.splitTuition.Panel1.Controls.Add(this.btnTuitionEditPaid);
            this.splitTuition.Panel1.Controls.Add(this.btnTuitionEditTotal);
            this.splitTuition.Panel1.Controls.Add(this.btnTuitionNext);
            this.splitTuition.Panel1.Controls.Add(this.btnTuitionPrevious);
            this.splitTuition.Panel1.Controls.Add(this.lblTuitionBalance);
            this.splitTuition.Panel1.Controls.Add(this.label6);
            this.splitTuition.Panel1.Controls.Add(this.pictureBox7);
            this.splitTuition.Panel1.Controls.Add(this.lblTuitionPaid);
            this.splitTuition.Panel1.Controls.Add(this.label4);
            this.splitTuition.Panel1.Controls.Add(this.lblTuitionTotal);
            this.splitTuition.Panel1.Controls.Add(this.label8);
            // 
            // splitTuition.Panel2
            // 
            this.splitTuition.Panel2.Controls.Add(this.lvwTuition);
            this.splitTuition.Size = new System.Drawing.Size(252, 297);
            this.splitTuition.SplitterDistance = 120;
            this.splitTuition.TabIndex = 37;
            // 
            // btnTuitionEditPaid
            // 
            this.btnTuitionEditPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTuitionEditPaid.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTuitionEditPaid.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTuitionEditPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuitionEditPaid.Image = ((System.Drawing.Image)(resources.GetObject("btnTuitionEditPaid.Image")));
            this.btnTuitionEditPaid.Location = new System.Drawing.Point(216, 38);
            this.btnTuitionEditPaid.Name = "btnTuitionEditPaid";
            this.btnTuitionEditPaid.Size = new System.Drawing.Size(29, 25);
            this.btnTuitionEditPaid.TabIndex = 83;
            this.tip.SetToolTip(this.btnTuitionEditPaid, "Edit this payment record.");
            this.btnTuitionEditPaid.UseVisualStyleBackColor = false;
            this.btnTuitionEditPaid.Click += new System.EventHandler(this.btnTuitionEditPaid_Click);
            // 
            // btnTuitionEditTotal
            // 
            this.btnTuitionEditTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTuitionEditTotal.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTuitionEditTotal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTuitionEditTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuitionEditTotal.Image = ((System.Drawing.Image)(resources.GetObject("btnTuitionEditTotal.Image")));
            this.btnTuitionEditTotal.Location = new System.Drawing.Point(216, 6);
            this.btnTuitionEditTotal.Name = "btnTuitionEditTotal";
            this.btnTuitionEditTotal.Size = new System.Drawing.Size(29, 25);
            this.btnTuitionEditTotal.TabIndex = 82;
            this.tip.SetToolTip(this.btnTuitionEditTotal, "Go to [Tuition Fee Manager] window. ");
            this.btnTuitionEditTotal.UseVisualStyleBackColor = false;
            this.btnTuitionEditTotal.Click += new System.EventHandler(this.btnTuitionEditTotal_Click);
            // 
            // btnTuitionNext
            // 
            this.btnTuitionNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTuitionNext.BackColor = System.Drawing.Color.White;
            this.btnTuitionNext.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTuitionNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuitionNext.Image = ((System.Drawing.Image)(resources.GetObject("btnTuitionNext.Image")));
            this.btnTuitionNext.Location = new System.Drawing.Point(131, 79);
            this.btnTuitionNext.Name = "btnTuitionNext";
            this.btnTuitionNext.Size = new System.Drawing.Size(35, 35);
            this.btnTuitionNext.TabIndex = 81;
            this.btnTuitionNext.UseVisualStyleBackColor = false;
            this.btnTuitionNext.Click += new System.EventHandler(this.btnTuitionNext_Click);
            // 
            // btnTuitionPrevious
            // 
            this.btnTuitionPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTuitionPrevious.BackColor = System.Drawing.Color.White;
            this.btnTuitionPrevious.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTuitionPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuitionPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnTuitionPrevious.Image")));
            this.btnTuitionPrevious.Location = new System.Drawing.Point(90, 79);
            this.btnTuitionPrevious.Name = "btnTuitionPrevious";
            this.btnTuitionPrevious.Size = new System.Drawing.Size(35, 35);
            this.btnTuitionPrevious.TabIndex = 80;
            this.btnTuitionPrevious.UseVisualStyleBackColor = false;
            this.btnTuitionPrevious.Click += new System.EventHandler(this.btnTuitionPrevious_Click);
            // 
            // lblTuitionBalance
            // 
            this.lblTuitionBalance.AutoSize = true;
            this.lblTuitionBalance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuitionBalance.ForeColor = System.Drawing.Color.Black;
            this.lblTuitionBalance.Location = new System.Drawing.Point(123, 57);
            this.lblTuitionBalance.Name = "lblTuitionBalance";
            this.lblTuitionBalance.Size = new System.Drawing.Size(41, 14);
            this.lblTuitionBalance.TabIndex = 79;
            this.lblTuitionBalance.Text = "---.--";
            this.lblTuitionBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 14);
            this.label6.TabIndex = 78;
            this.label6.Text = "Balance (PHP):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(8, 34);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(237, 1);
            this.pictureBox7.TabIndex = 77;
            this.pictureBox7.TabStop = false;
            // 
            // lblTuitionPaid
            // 
            this.lblTuitionPaid.AutoSize = true;
            this.lblTuitionPaid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuitionPaid.Location = new System.Drawing.Point(123, 40);
            this.lblTuitionPaid.Name = "lblTuitionPaid";
            this.lblTuitionPaid.Size = new System.Drawing.Size(41, 14);
            this.lblTuitionPaid.TabIndex = 76;
            this.lblTuitionPaid.Text = "---.--";
            this.lblTuitionPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 14);
            this.label4.TabIndex = 75;
            this.label4.Text = "Paid (PHP):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTuitionTotal
            // 
            this.lblTuitionTotal.AutoSize = true;
            this.lblTuitionTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuitionTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTuitionTotal.Location = new System.Drawing.Point(123, 10);
            this.lblTuitionTotal.Name = "lblTuitionTotal";
            this.lblTuitionTotal.Size = new System.Drawing.Size(48, 16);
            this.lblTuitionTotal.TabIndex = 74;
            this.lblTuitionTotal.Text = "---.--";
            this.lblTuitionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "TOTAL (PHP):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwTuition
            // 
            this.lvwTuition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTFYear,
            this.colTFTotal,
            this.colTFPaid,
            this.colTHLevel,
            this.colTHLastUpdated});
            this.lvwTuition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTuition.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTuition.FullRowSelect = true;
            this.lvwTuition.GridLines = true;
            this.lvwTuition.HideSelection = false;
            this.lvwTuition.Location = new System.Drawing.Point(0, 0);
            this.lvwTuition.MultiSelect = false;
            this.lvwTuition.Name = "lvwTuition";
            this.lvwTuition.Size = new System.Drawing.Size(252, 173);
            this.lvwTuition.TabIndex = 71;
            this.lvwTuition.UseCompatibleStateImageBehavior = false;
            this.lvwTuition.View = System.Windows.Forms.View.Details;
            // 
            // colTFYear
            // 
            this.colTFYear.Text = "Year";
            this.colTFYear.Width = 50;
            // 
            // colTFTotal
            // 
            this.colTFTotal.DisplayIndex = 2;
            this.colTFTotal.Text = "Total";
            this.colTFTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colTFTotal.Width = 90;
            // 
            // colTFPaid
            // 
            this.colTFPaid.DisplayIndex = 3;
            this.colTFPaid.Text = "Paid";
            this.colTFPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colTFPaid.Width = 90;
            // 
            // colTHLevel
            // 
            this.colTHLevel.DisplayIndex = 1;
            this.colTHLevel.Text = "Level";
            // 
            // colTHLastUpdated
            // 
            this.colTHLastUpdated.Text = "Last Payment";
            this.colTHLastUpdated.Width = 100;
            // 
            // lblTitleTuition
            // 
            this.lblTitleTuition.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitleTuition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleTuition.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleTuition.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTuition.ForeColor = System.Drawing.Color.White;
            this.lblTitleTuition.Location = new System.Drawing.Point(0, 0);
            this.lblTitleTuition.Name = "lblTitleTuition";
            this.lblTitleTuition.Size = new System.Drawing.Size(252, 22);
            this.lblTitleTuition.TabIndex = 36;
            this.lblTitleTuition.Text = "     TUITION FEE (2001)";
            this.lblTitleTuition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(2, 1);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 39;
            this.pictureBox8.TabStop = false;
            // 
            // splitMonthly
            // 
            this.splitMonthly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMonthly.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMonthly.IsSplitterFixed = true;
            this.splitMonthly.Location = new System.Drawing.Point(0, 22);
            this.splitMonthly.Name = "splitMonthly";
            this.splitMonthly.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMonthly.Panel1
            // 
            this.splitMonthly.Panel1.BackColor = System.Drawing.Color.Azure;
            this.splitMonthly.Panel1.Controls.Add(this.cboMonth);
            this.splitMonthly.Panel1.Controls.Add(this.btnMonthlyEditPaid);
            this.splitMonthly.Panel1.Controls.Add(this.btnMonthlyEditTotal);
            this.splitMonthly.Panel1.Controls.Add(this.btnMonthlyNext);
            this.splitMonthly.Panel1.Controls.Add(this.btnMonthlyPrevious);
            this.splitMonthly.Panel1.Controls.Add(this.lblMonthlyBalance);
            this.splitMonthly.Panel1.Controls.Add(this.label10);
            this.splitMonthly.Panel1.Controls.Add(this.pictureBox1);
            this.splitMonthly.Panel1.Controls.Add(this.lblMonthlyPaid);
            this.splitMonthly.Panel1.Controls.Add(this.label12);
            this.splitMonthly.Panel1.Controls.Add(this.lblMonthlyTotal);
            this.splitMonthly.Panel1.Controls.Add(this.label14);
            // 
            // splitMonthly.Panel2
            // 
            this.splitMonthly.Panel2.Controls.Add(this.lvwMonthly);
            this.splitMonthly.Size = new System.Drawing.Size(252, 246);
            this.splitMonthly.SplitterDistance = 123;
            this.splitMonthly.TabIndex = 38;
            // 
            // cboMonth
            // 
            this.cboMonth.BackColor = System.Drawing.Color.White;
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
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
            this.cboMonth.Location = new System.Drawing.Point(172, 92);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(73, 24);
            this.cboMonth.TabIndex = 98;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // btnMonthlyEditPaid
            // 
            this.btnMonthlyEditPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonthlyEditPaid.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMonthlyEditPaid.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMonthlyEditPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyEditPaid.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthlyEditPaid.Image")));
            this.btnMonthlyEditPaid.Location = new System.Drawing.Point(216, 38);
            this.btnMonthlyEditPaid.Name = "btnMonthlyEditPaid";
            this.btnMonthlyEditPaid.Size = new System.Drawing.Size(29, 25);
            this.btnMonthlyEditPaid.TabIndex = 97;
            this.tip.SetToolTip(this.btnMonthlyEditPaid, "Edit this payment record.");
            this.btnMonthlyEditPaid.UseVisualStyleBackColor = false;
            this.btnMonthlyEditPaid.Click += new System.EventHandler(this.btnMonthlyEditPaid_Click);
            // 
            // btnMonthlyEditTotal
            // 
            this.btnMonthlyEditTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonthlyEditTotal.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMonthlyEditTotal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMonthlyEditTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyEditTotal.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthlyEditTotal.Image")));
            this.btnMonthlyEditTotal.Location = new System.Drawing.Point(216, 6);
            this.btnMonthlyEditTotal.Name = "btnMonthlyEditTotal";
            this.btnMonthlyEditTotal.Size = new System.Drawing.Size(29, 25);
            this.btnMonthlyEditTotal.TabIndex = 96;
            this.tip.SetToolTip(this.btnMonthlyEditTotal, "Go to [Monthly Payment Manager] window. ");
            this.btnMonthlyEditTotal.UseVisualStyleBackColor = false;
            this.btnMonthlyEditTotal.Click += new System.EventHandler(this.btnMonthlyEditTotal_Click);
            // 
            // btnMonthlyNext
            // 
            this.btnMonthlyNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMonthlyNext.BackColor = System.Drawing.Color.White;
            this.btnMonthlyNext.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMonthlyNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyNext.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthlyNext.Image")));
            this.btnMonthlyNext.Location = new System.Drawing.Point(131, 81);
            this.btnMonthlyNext.Name = "btnMonthlyNext";
            this.btnMonthlyNext.Size = new System.Drawing.Size(35, 35);
            this.btnMonthlyNext.TabIndex = 95;
            this.btnMonthlyNext.UseVisualStyleBackColor = false;
            this.btnMonthlyNext.Click += new System.EventHandler(this.btnMonthlyNext_Click);
            // 
            // btnMonthlyPrevious
            // 
            this.btnMonthlyPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMonthlyPrevious.BackColor = System.Drawing.Color.White;
            this.btnMonthlyPrevious.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMonthlyPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthlyPrevious.Image")));
            this.btnMonthlyPrevious.Location = new System.Drawing.Point(90, 81);
            this.btnMonthlyPrevious.Name = "btnMonthlyPrevious";
            this.btnMonthlyPrevious.Size = new System.Drawing.Size(35, 35);
            this.btnMonthlyPrevious.TabIndex = 94;
            this.btnMonthlyPrevious.UseVisualStyleBackColor = false;
            this.btnMonthlyPrevious.Click += new System.EventHandler(this.btnMonthlyPrevious_Click);
            // 
            // lblMonthlyBalance
            // 
            this.lblMonthlyBalance.AutoSize = true;
            this.lblMonthlyBalance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyBalance.Location = new System.Drawing.Point(123, 56);
            this.lblMonthlyBalance.Name = "lblMonthlyBalance";
            this.lblMonthlyBalance.Size = new System.Drawing.Size(41, 14);
            this.lblMonthlyBalance.TabIndex = 93;
            this.lblMonthlyBalance.Text = "---.--";
            this.lblMonthlyBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 14);
            this.label10.TabIndex = 92;
            this.label10.Text = "Balance (PHP):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 1);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // lblMonthlyPaid
            // 
            this.lblMonthlyPaid.AutoSize = true;
            this.lblMonthlyPaid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyPaid.Location = new System.Drawing.Point(123, 39);
            this.lblMonthlyPaid.Name = "lblMonthlyPaid";
            this.lblMonthlyPaid.Size = new System.Drawing.Size(41, 14);
            this.lblMonthlyPaid.TabIndex = 90;
            this.lblMonthlyPaid.Text = "---.--";
            this.lblMonthlyPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 14);
            this.label12.TabIndex = 89;
            this.label12.Text = "Paid (PHP):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonthlyTotal
            // 
            this.lblMonthlyTotal.AutoSize = true;
            this.lblMonthlyTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMonthlyTotal.Location = new System.Drawing.Point(123, 9);
            this.lblMonthlyTotal.Name = "lblMonthlyTotal";
            this.lblMonthlyTotal.Size = new System.Drawing.Size(48, 16);
            this.lblMonthlyTotal.TabIndex = 88;
            this.lblMonthlyTotal.Text = "---.--";
            this.lblMonthlyTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 16);
            this.label14.TabIndex = 87;
            this.label14.Text = "TOTAL (PHP):";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwMonthly
            // 
            this.lvwMonthly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMPMonth,
            this.colMPPaid,
            this.colMPLevel,
            this.colMPDateUpdated});
            this.lvwMonthly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMonthly.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMonthly.FullRowSelect = true;
            this.lvwMonthly.GridLines = true;
            this.lvwMonthly.HideSelection = false;
            this.lvwMonthly.Location = new System.Drawing.Point(0, 0);
            this.lvwMonthly.MultiSelect = false;
            this.lvwMonthly.Name = "lvwMonthly";
            this.lvwMonthly.Size = new System.Drawing.Size(252, 119);
            this.lvwMonthly.TabIndex = 86;
            this.lvwMonthly.UseCompatibleStateImageBehavior = false;
            this.lvwMonthly.View = System.Windows.Forms.View.Details;
            // 
            // colMPMonth
            // 
            this.colMPMonth.Text = "Month";
            // 
            // colMPPaid
            // 
            this.colMPPaid.DisplayIndex = 2;
            this.colMPPaid.Text = "Paid";
            this.colMPPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colMPPaid.Width = 90;
            // 
            // colMPLevel
            // 
            this.colMPLevel.DisplayIndex = 1;
            this.colMPLevel.Text = "Level";
            // 
            // colMPDateUpdated
            // 
            this.colMPDateUpdated.Text = "Date Updated";
            this.colMPDateUpdated.Width = 100;
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
            this.lblTitleMonthly.Size = new System.Drawing.Size(252, 22);
            this.lblTitleMonthly.TabIndex = 37;
            this.lblTitleMonthly.Text = "     MONTHLY PAYMENT (2000)";
            this.lblTitleMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.DodgerBlue;
            this.tip.ForeColor = System.Drawing.Color.White;
            this.tip.IsBalloon = true;
            this.tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tip.ToolTipTitle = "Hint";
            // 
            // frmStudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 595);
            this.Controls.Add(this.splitMain);
            this.MinimumSize = new System.Drawing.Size(953, 633);
            this.Name = "frmStudentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Masterlist";
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel1.PerformLayout();
            this.splitLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.splitGrading.Panel1.ResumeLayout(false);
            this.splitGrading.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGrading)).EndInit();
            this.splitGrading.ResumeLayout(false);
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.splitTuition.Panel1.ResumeLayout(false);
            this.splitTuition.Panel1.PerformLayout();
            this.splitTuition.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTuition)).EndInit();
            this.splitTuition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.splitMonthly.Panel1.ResumeLayout(false);
            this.splitMonthly.Panel1.PerformLayout();
            this.splitMonthly.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMonthly)).EndInit();
            this.splitMonthly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.Label lblTitleTuition;
        private System.Windows.Forms.Label lblTitleMonthly;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.SplitContainer splitGrading;
        private System.Windows.Forms.Button btnGradingInput;
        private System.Windows.Forms.ListView lvwGrading;
        private System.Windows.Forms.ColumnHeader colGRQuarter;
        private System.Windows.Forms.Label lblTitleGrading;
        private System.Windows.Forms.SplitContainer splitTuition;
        private System.Windows.Forms.Button btnTuitionEditPaid;
        private System.Windows.Forms.Button btnTuitionEditTotal;
        private System.Windows.Forms.Button btnTuitionNext;
        private System.Windows.Forms.Button btnTuitionPrevious;
        private System.Windows.Forms.Label lblTuitionBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblTuitionPaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTuitionTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvwTuition;
        private System.Windows.Forms.ColumnHeader colTFYear;
        private System.Windows.Forms.ColumnHeader colTFTotal;
        private System.Windows.Forms.ColumnHeader colTFPaid;
        private System.Windows.Forms.SplitContainer splitMonthly;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Button btnMonthlyEditPaid;
        private System.Windows.Forms.Button btnMonthlyEditTotal;
        private System.Windows.Forms.Button btnMonthlyNext;
        private System.Windows.Forms.Button btnMonthlyPrevious;
        private System.Windows.Forms.Label lblMonthlyBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMonthlyPaid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMonthlyTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lvwMonthly;
        private System.Windows.Forms.ColumnHeader colMPMonth;
        private System.Windows.Forms.ColumnHeader colMPPaid;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ListView lvwStudents;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colLastname;
        private System.Windows.Forms.ColumnHeader colFirstname;
        private System.Windows.Forms.ColumnHeader colMiddlename;
        private System.Windows.Forms.ColumnHeader colLevel;
        private System.Windows.Forms.ColumnHeader colSection;
        private System.Windows.Forms.ColumnHeader colBirthdate;
        private System.Windows.Forms.ColumnHeader colContact;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton toolMarkStudent;
        private System.Windows.Forms.ToolStripButton toolMarkGraduate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox chkFilterEnrollees;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox chkFilterDropouts;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chkFilterGraduates;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkFilterStudents;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ToolStripButton toolMarkDropout;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private HintTextBox txtSearch;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colNotes;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateUpdated;
        private System.Windows.Forms.ColumnHeader colTHLevel;
        private System.Windows.Forms.ColumnHeader colTHLastUpdated;
        private System.Windows.Forms.ColumnHeader colMPLevel;
        private System.Windows.Forms.ColumnHeader colMPDateUpdated;
        private System.Windows.Forms.ColumnHeader colGrade;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGradeYears;
        private System.Windows.Forms.ComboBox cboGradeRecord;
        private System.Windows.Forms.ToolTip tip;

    }
}