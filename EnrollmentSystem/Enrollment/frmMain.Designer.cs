namespace Enrollment
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.toolUsers = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolUsersMasterlist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolUsersAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolUsersSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStudents = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStudentsMasterlist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStudentsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolRecordGrades = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRecordTuition = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRecordMonthly = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolSetupSubjects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSetupSubjectsManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSetupTuition = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSetupMonthly = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDirectUsers = new System.Windows.Forms.Button();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.lvwMonthly = new System.Windows.Forms.ListView();
            this.colMPIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPJan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPFeb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPMar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPApr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPMay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPJun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPJul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPAug = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPSep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPOct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPNov = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMPDec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboMPMonth = new System.Windows.Forms.ComboBox();
            this.pgbMonthlyStatus = new System.Windows.Forms.ProgressBar();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblMonthlyStatus = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMPNextYear = new System.Windows.Forms.Button();
            this.lblMPYear = new System.Windows.Forms.Label();
            this.btnMPPreviousYear = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDirectMonthly = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.lvwTuitions = new System.Windows.Forms.ListView();
            this.colTIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pgbTuitionStatus = new System.Windows.Forms.ProgressBar();
            this.lblTuitionStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDirectTuition = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblTuitionsList = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPortalStudent = new System.Windows.Forms.Button();
            this.btnPortalParent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.toolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolMenu
            // 
            this.toolMenu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUsers,
            this.lblDate,
            this.toolStripSeparator1,
            this.toolStudents,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1,
            this.toolStripSeparator5,
            this.toolSettings,
            this.toolStripSeparator3,
            this.toolExit});
            this.toolMenu.Location = new System.Drawing.Point(0, 0);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(815, 25);
            this.toolMenu.TabIndex = 0;
            this.toolMenu.Text = "toolStrip1";
            // 
            // toolUsers
            // 
            this.toolUsers.AutoToolTip = false;
            this.toolUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUsersMasterlist,
            this.toolStripMenuItem1,
            this.toolUsersAddNew,
            this.toolUsersSwitch});
            this.toolUsers.Image = ((System.Drawing.Image)(resources.GetObject("toolUsers.Image")));
            this.toolUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUsers.Name = "toolUsers";
            this.toolUsers.Size = new System.Drawing.Size(73, 22);
            this.toolUsers.Text = "Users";
            // 
            // toolUsersMasterlist
            // 
            this.toolUsersMasterlist.Image = ((System.Drawing.Image)(resources.GetObject("toolUsersMasterlist.Image")));
            this.toolUsersMasterlist.Name = "toolUsersMasterlist";
            this.toolUsersMasterlist.Size = new System.Drawing.Size(170, 22);
            this.toolUsersMasterlist.Text = "&Masterlist";
            this.toolUsersMasterlist.Click += new System.EventHandler(this.toolUsersMasterlist_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // toolUsersAddNew
            // 
            this.toolUsersAddNew.Image = ((System.Drawing.Image)(resources.GetObject("toolUsersAddNew.Image")));
            this.toolUsersAddNew.Name = "toolUsersAddNew";
            this.toolUsersAddNew.Size = new System.Drawing.Size(170, 22);
            this.toolUsersAddNew.Text = "Add &New";
            this.toolUsersAddNew.Click += new System.EventHandler(this.toolUsersAddNew_Click);
            // 
            // toolUsersSwitch
            // 
            this.toolUsersSwitch.Image = ((System.Drawing.Image)(resources.GetObject("toolUsersSwitch.Image")));
            this.toolUsersSwitch.Name = "toolUsersSwitch";
            this.toolUsersSwitch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolUsersSwitch.Size = new System.Drawing.Size(170, 22);
            this.toolUsersSwitch.Text = "Switch";
            this.toolUsersSwitch.Click += new System.EventHandler(this.toolUsersSwitch_Click);
            // 
            // lblDate
            // 
            this.lblDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(78, 22);
            this.lblDate.Text = "date time";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStudents
            // 
            this.toolStudents.AutoToolTip = false;
            this.toolStudents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStudentsMasterlist,
            this.toolStripMenuItem2,
            this.toolStudentsNew});
            this.toolStudents.Image = ((System.Drawing.Image)(resources.GetObject("toolStudents.Image")));
            this.toolStudents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStudents.Name = "toolStudents";
            this.toolStudents.Size = new System.Drawing.Size(97, 22);
            this.toolStudents.Text = "Students";
            // 
            // toolStudentsMasterlist
            // 
            this.toolStudentsMasterlist.Image = ((System.Drawing.Image)(resources.GetObject("toolStudentsMasterlist.Image")));
            this.toolStudentsMasterlist.Name = "toolStudentsMasterlist";
            this.toolStudentsMasterlist.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStudentsMasterlist.Size = new System.Drawing.Size(189, 22);
            this.toolStudentsMasterlist.Text = "&Masterlist";
            this.toolStudentsMasterlist.Click += new System.EventHandler(this.toolStudentsMasterlist_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 6);
            // 
            // toolStudentsNew
            // 
            this.toolStudentsNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStudentsNew.Image")));
            this.toolStudentsNew.Name = "toolStudentsNew";
            this.toolStudentsNew.Size = new System.Drawing.Size(189, 22);
            this.toolStudentsNew.Text = "Add &New";
            this.toolStudentsNew.Click += new System.EventHandler(this.toolStudentsNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRecordGrades,
            this.toolStripMenuItem3,
            this.toolRecordTuition,
            this.toolRecordMonthly});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(82, 22);
            this.toolStripDropDownButton1.Text = "Record";
            // 
            // toolRecordGrades
            // 
            this.toolRecordGrades.Image = ((System.Drawing.Image)(resources.GetObject("toolRecordGrades.Image")));
            this.toolRecordGrades.Name = "toolRecordGrades";
            this.toolRecordGrades.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.toolRecordGrades.Size = new System.Drawing.Size(241, 22);
            this.toolRecordGrades.Text = "Grades Input";
            this.toolRecordGrades.Click += new System.EventHandler(this.toolRecordGrades_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(238, 6);
            // 
            // toolRecordTuition
            // 
            this.toolRecordTuition.Image = ((System.Drawing.Image)(resources.GetObject("toolRecordTuition.Image")));
            this.toolRecordTuition.Name = "toolRecordTuition";
            this.toolRecordTuition.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolRecordTuition.Size = new System.Drawing.Size(241, 22);
            this.toolRecordTuition.Text = "Tuition Fee";
            this.toolRecordTuition.Click += new System.EventHandler(this.toolRecordTuition_Click);
            // 
            // toolRecordMonthly
            // 
            this.toolRecordMonthly.Image = ((System.Drawing.Image)(resources.GetObject("toolRecordMonthly.Image")));
            this.toolRecordMonthly.Name = "toolRecordMonthly";
            this.toolRecordMonthly.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.toolRecordMonthly.Size = new System.Drawing.Size(241, 22);
            this.toolRecordMonthly.Text = "Monthly Payment";
            this.toolRecordMonthly.Click += new System.EventHandler(this.toolRecordMonthly_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSettings
            // 
            this.toolSettings.AutoToolTip = false;
            this.toolSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSetupSubjects,
            this.toolStripSeparator4,
            this.toolSetupSubjectsManage,
            this.toolSetupTuition,
            this.toolSetupMonthly});
            this.toolSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolSettings.Image")));
            this.toolSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSettings.Name = "toolSettings";
            this.toolSettings.Size = new System.Drawing.Size(76, 22);
            this.toolSettings.Text = "Setup";
            // 
            // toolSetupSubjects
            // 
            this.toolSetupSubjects.Image = ((System.Drawing.Image)(resources.GetObject("toolSetupSubjects.Image")));
            this.toolSetupSubjects.Name = "toolSetupSubjects";
            this.toolSetupSubjects.Size = new System.Drawing.Size(251, 22);
            this.toolSetupSubjects.Text = "&Subjects Register";
            this.toolSetupSubjects.Click += new System.EventHandler(this.toolSetupSubjects_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(248, 6);
            // 
            // toolSetupSubjectsManage
            // 
            this.toolSetupSubjectsManage.Image = ((System.Drawing.Image)(resources.GetObject("toolSetupSubjectsManage.Image")));
            this.toolSetupSubjectsManage.Name = "toolSetupSubjectsManage";
            this.toolSetupSubjectsManage.Size = new System.Drawing.Size(251, 22);
            this.toolSetupSubjectsManage.Text = "S&ubjects Manager";
            this.toolSetupSubjectsManage.Click += new System.EventHandler(this.toolSetupSubjectsManage_Click);
            // 
            // toolSetupTuition
            // 
            this.toolSetupTuition.Image = ((System.Drawing.Image)(resources.GetObject("toolSetupTuition.Image")));
            this.toolSetupTuition.Name = "toolSetupTuition";
            this.toolSetupTuition.Size = new System.Drawing.Size(251, 22);
            this.toolSetupTuition.Text = "&Tuition Fee Manager";
            this.toolSetupTuition.Click += new System.EventHandler(this.toolSetupTuition_Click);
            // 
            // toolSetupMonthly
            // 
            this.toolSetupMonthly.Image = ((System.Drawing.Image)(resources.GetObject("toolSetupMonthly.Image")));
            this.toolSetupMonthly.Name = "toolSetupMonthly";
            this.toolSetupMonthly.Size = new System.Drawing.Size(251, 22);
            this.toolSetupMonthly.Text = "&Monthly Payment Manager";
            this.toolSetupMonthly.Click += new System.EventHandler(this.toolSetupMonthly_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolExit
            // 
            this.toolExit.AutoToolTip = false;
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(52, 22);
            this.toolExit.Text = "Exit";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // splitMain
            // 
            this.splitMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(0, 25);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitLeft);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Size = new System.Drawing.Size(815, 515);
            this.splitMain.SplitterDistance = 539;
            this.splitMain.TabIndex = 1;
            // 
            // splitLeft
            // 
            this.splitLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.BackColor = System.Drawing.Color.White;
            this.splitLeft.Panel1.Controls.Add(this.lvwStudents);
            this.splitLeft.Panel1.Controls.Add(this.pictureBox2);
            this.splitLeft.Panel1.Controls.Add(this.btnDirectUsers);
            this.splitLeft.Panel1.Controls.Add(this.lblStudentList);
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.Controls.Add(this.lvwMonthly);
            this.splitLeft.Panel2.Controls.Add(this.panel1);
            this.splitLeft.Panel2.Controls.Add(this.pictureBox3);
            this.splitLeft.Panel2.Controls.Add(this.btnDirectMonthly);
            this.splitLeft.Panel2.Controls.Add(this.label2);
            this.splitLeft.Size = new System.Drawing.Size(539, 515);
            this.splitLeft.SplitterDistance = 315;
            this.splitLeft.TabIndex = 0;
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
            this.lvwStudents.Location = new System.Drawing.Point(0, 25);
            this.lvwStudents.MultiSelect = false;
            this.lvwStudents.Name = "lvwStudents";
            this.lvwStudents.Size = new System.Drawing.Size(537, 288);
            this.lvwStudents.TabIndex = 34;
            this.lvwStudents.UseCompatibleStateImageBehavior = false;
            this.lvwStudents.View = System.Windows.Forms.View.Details;
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
            this.colLevel.DisplayIndex = 6;
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
            this.colGrade.DisplayIndex = 7;
            this.colGrade.Text = "Grade";
            this.colGrade.Width = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // btnDirectUsers
            // 
            this.btnDirectUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectUsers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDirectUsers.FlatAppearance.BorderSize = 0;
            this.btnDirectUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnDirectUsers.Image")));
            this.btnDirectUsers.Location = new System.Drawing.Point(507, -1);
            this.btnDirectUsers.Name = "btnDirectUsers";
            this.btnDirectUsers.Size = new System.Drawing.Size(29, 25);
            this.btnDirectUsers.TabIndex = 29;
            this.btnDirectUsers.TabStop = false;
            this.tip.SetToolTip(this.btnDirectUsers, "Go to [Students] masterlist.");
            this.btnDirectUsers.UseVisualStyleBackColor = false;
            this.btnDirectUsers.Click += new System.EventHandler(this.btnDirectUsers_Click);
            // 
            // lblStudentList
            // 
            this.lblStudentList.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblStudentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStudentList.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentList.ForeColor = System.Drawing.Color.White;
            this.lblStudentList.Location = new System.Drawing.Point(0, 0);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(537, 25);
            this.lblStudentList.TabIndex = 28;
            this.lblStudentList.Text = "    STUDENTS MASTERLIST (002/500)";
            this.lblStudentList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwMonthly
            // 
            this.lvwMonthly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMPIndex,
            this.colMPID,
            this.colMPName,
            this.colMPJan,
            this.colMPFeb,
            this.colMPMar,
            this.colMPApr,
            this.colMPMay,
            this.colMPJun,
            this.colMPJul,
            this.colMPAug,
            this.colMPSep,
            this.colMPOct,
            this.colMPNov,
            this.colMPDec});
            this.lvwMonthly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMonthly.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMonthly.FullRowSelect = true;
            this.lvwMonthly.GridLines = true;
            this.lvwMonthly.Location = new System.Drawing.Point(0, 25);
            this.lvwMonthly.MultiSelect = false;
            this.lvwMonthly.Name = "lvwMonthly";
            this.lvwMonthly.Size = new System.Drawing.Size(537, 127);
            this.lvwMonthly.TabIndex = 36;
            this.lvwMonthly.UseCompatibleStateImageBehavior = false;
            this.lvwMonthly.View = System.Windows.Forms.View.Details;
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
            // colMPJan
            // 
            this.colMPJan.Text = "JAN";
            this.colMPJan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPFeb
            // 
            this.colMPFeb.Text = "FEB";
            this.colMPFeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPMar
            // 
            this.colMPMar.Text = "MAR";
            this.colMPMar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPApr
            // 
            this.colMPApr.Text = "APR";
            this.colMPApr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPMay
            // 
            this.colMPMay.Text = "MAY";
            this.colMPMay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPJun
            // 
            this.colMPJun.Text = "JUN";
            this.colMPJun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPJul
            // 
            this.colMPJul.Text = "JUL";
            this.colMPJul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPAug
            // 
            this.colMPAug.Text = "AUG";
            this.colMPAug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPSep
            // 
            this.colMPSep.Text = "SEP";
            this.colMPSep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPOct
            // 
            this.colMPOct.Text = "OCT";
            this.colMPOct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPNov
            // 
            this.colMPNov.Text = "NOV";
            this.colMPNov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMPDec
            // 
            this.colMPDec.Text = "DEC";
            this.colMPDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboMPMonth);
            this.panel1.Controls.Add(this.pgbMonthlyStatus);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.lblMonthlyStatus);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnMPNextYear);
            this.panel1.Controls.Add(this.lblMPYear);
            this.panel1.Controls.Add(this.btnMPPreviousYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 42);
            this.panel1.TabIndex = 35;
            // 
            // cboMPMonth
            // 
            this.cboMPMonth.BackColor = System.Drawing.Color.White;
            this.cboMPMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMPMonth.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cboMPMonth.Location = new System.Drawing.Point(359, 5);
            this.cboMPMonth.Name = "cboMPMonth";
            this.cboMPMonth.Size = new System.Drawing.Size(84, 32);
            this.cboMPMonth.TabIndex = 44;
            this.cboMPMonth.SelectedIndexChanged += new System.EventHandler(this.cboMPMonth_SelectedIndexChanged);
            // 
            // pgbMonthlyStatus
            // 
            this.pgbMonthlyStatus.Location = new System.Drawing.Point(143, 20);
            this.pgbMonthlyStatus.Name = "pgbMonthlyStatus";
            this.pgbMonthlyStatus.Size = new System.Drawing.Size(209, 16);
            this.pgbMonthlyStatus.TabIndex = 43;
            this.pgbMonthlyStatus.Value = 50;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(450, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1, 35);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // lblMonthlyStatus
            // 
            this.lblMonthlyStatus.AutoSize = true;
            this.lblMonthlyStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyStatus.Location = new System.Drawing.Point(240, 3);
            this.lblMonthlyStatus.Name = "lblMonthlyStatus";
            this.lblMonthlyStatus.Size = new System.Drawing.Size(69, 14);
            this.lblMonthlyStatus.TabIndex = 41;
            this.lblMonthlyStatus.Text = "333/500";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(136, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 35);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 39;
            this.label4.Text = "Paid Students:";
            // 
            // btnMPNextYear
            // 
            this.btnMPNextYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMPNextYear.BackColor = System.Drawing.Color.White;
            this.btnMPNextYear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMPNextYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPNextYear.Image = ((System.Drawing.Image)(resources.GetObject("btnMPNextYear.Image")));
            this.btnMPNextYear.Location = new System.Drawing.Point(96, 3);
            this.btnMPNextYear.Name = "btnMPNextYear";
            this.btnMPNextYear.Size = new System.Drawing.Size(35, 35);
            this.btnMPNextYear.TabIndex = 38;
            this.btnMPNextYear.UseVisualStyleBackColor = false;
            this.btnMPNextYear.Click += new System.EventHandler(this.btnMPNextYear_Click);
            // 
            // lblMPYear
            // 
            this.lblMPYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMPYear.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblMPYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMPYear.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPYear.ForeColor = System.Drawing.Color.White;
            this.lblMPYear.Location = new System.Drawing.Point(40, 3);
            this.lblMPYear.Name = "lblMPYear";
            this.lblMPYear.Size = new System.Drawing.Size(54, 35);
            this.lblMPYear.TabIndex = 37;
            this.lblMPYear.Text = "2019";
            this.lblMPYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMPPreviousYear
            // 
            this.btnMPPreviousYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMPPreviousYear.BackColor = System.Drawing.Color.White;
            this.btnMPPreviousYear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMPPreviousYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPPreviousYear.Image = ((System.Drawing.Image)(resources.GetObject("btnMPPreviousYear.Image")));
            this.btnMPPreviousYear.Location = new System.Drawing.Point(3, 3);
            this.btnMPPreviousYear.Name = "btnMPPreviousYear";
            this.btnMPPreviousYear.Size = new System.Drawing.Size(35, 35);
            this.btnMPPreviousYear.TabIndex = 36;
            this.btnMPPreviousYear.UseVisualStyleBackColor = false;
            this.btnMPPreviousYear.Click += new System.EventHandler(this.btnMPPreviousYear_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // btnDirectMonthly
            // 
            this.btnDirectMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectMonthly.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDirectMonthly.FlatAppearance.BorderSize = 0;
            this.btnDirectMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectMonthly.Image = ((System.Drawing.Image)(resources.GetObject("btnDirectMonthly.Image")));
            this.btnDirectMonthly.Location = new System.Drawing.Point(507, -1);
            this.btnDirectMonthly.Name = "btnDirectMonthly";
            this.btnDirectMonthly.Size = new System.Drawing.Size(29, 25);
            this.btnDirectMonthly.TabIndex = 33;
            this.tip.SetToolTip(this.btnDirectMonthly, "Go to [Monthly Payment] transactions window. (Cashier)");
            this.btnDirectMonthly.UseVisualStyleBackColor = false;
            this.btnDirectMonthly.Click += new System.EventHandler(this.btnDirectMonthly_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "    MONTHLY PAYMENT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitRight
            // 
            this.splitRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitRight.IsSplitterFixed = true;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.lvwTuitions);
            this.splitRight.Panel1.Controls.Add(this.panel2);
            this.splitRight.Panel1.Controls.Add(this.btnDirectTuition);
            this.splitRight.Panel1.Controls.Add(this.pictureBox6);
            this.splitRight.Panel1.Controls.Add(this.lblTuitionsList);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.BackColor = System.Drawing.Color.White;
            this.splitRight.Panel2.Controls.Add(this.label9);
            this.splitRight.Panel2.Controls.Add(this.btnPortalStudent);
            this.splitRight.Panel2.Controls.Add(this.btnPortalParent);
            this.splitRight.Panel2.Controls.Add(this.pictureBox1);
            this.splitRight.Size = new System.Drawing.Size(272, 515);
            this.splitRight.SplitterDistance = 379;
            this.splitRight.TabIndex = 0;
            // 
            // lvwTuitions
            // 
            this.lvwTuitions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTIndex,
            this.colTName,
            this.colTStatus});
            this.lvwTuitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTuitions.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTuitions.FullRowSelect = true;
            this.lvwTuitions.GridLines = true;
            this.lvwTuitions.Location = new System.Drawing.Point(0, 25);
            this.lvwTuitions.MultiSelect = false;
            this.lvwTuitions.Name = "lvwTuitions";
            this.lvwTuitions.Size = new System.Drawing.Size(270, 305);
            this.lvwTuitions.TabIndex = 38;
            this.lvwTuitions.UseCompatibleStateImageBehavior = false;
            this.lvwTuitions.View = System.Windows.Forms.View.Details;
            // 
            // colTIndex
            // 
            this.colTIndex.Text = "#";
            this.colTIndex.Width = 40;
            // 
            // colTName
            // 
            this.colTName.Text = "Student Name";
            this.colTName.Width = 170;
            // 
            // colTStatus
            // 
            this.colTStatus.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pgbTuitionStatus);
            this.panel2.Controls.Add(this.lblTuitionStatus);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 47);
            this.panel2.TabIndex = 37;
            // 
            // pgbTuitionStatus
            // 
            this.pgbTuitionStatus.Location = new System.Drawing.Point(7, 23);
            this.pgbTuitionStatus.Name = "pgbTuitionStatus";
            this.pgbTuitionStatus.Size = new System.Drawing.Size(252, 16);
            this.pgbTuitionStatus.TabIndex = 46;
            this.pgbTuitionStatus.Value = 50;
            // 
            // lblTuitionStatus
            // 
            this.lblTuitionStatus.AutoSize = true;
            this.lblTuitionStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuitionStatus.Location = new System.Drawing.Point(104, 6);
            this.lblTuitionStatus.Name = "lblTuitionStatus";
            this.lblTuitionStatus.Size = new System.Drawing.Size(69, 14);
            this.lblTuitionStatus.TabIndex = 45;
            this.lblTuitionStatus.Text = "333/500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 14);
            this.label7.TabIndex = 44;
            this.label7.Text = "Paid Students:";
            // 
            // btnDirectTuition
            // 
            this.btnDirectTuition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectTuition.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDirectTuition.FlatAppearance.BorderSize = 0;
            this.btnDirectTuition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectTuition.Image = ((System.Drawing.Image)(resources.GetObject("btnDirectTuition.Image")));
            this.btnDirectTuition.Location = new System.Drawing.Point(240, -1);
            this.btnDirectTuition.Name = "btnDirectTuition";
            this.btnDirectTuition.Size = new System.Drawing.Size(29, 25);
            this.btnDirectTuition.TabIndex = 36;
            this.tip.SetToolTip(this.btnDirectTuition, "Go to [Tuition Fee] transactions window. (Cashier)");
            this.btnDirectTuition.UseVisualStyleBackColor = false;
            this.btnDirectTuition.Click += new System.EventHandler(this.btnDirectTuition_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            // 
            // lblTuitionsList
            // 
            this.lblTuitionsList.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTuitionsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTuitionsList.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuitionsList.ForeColor = System.Drawing.Color.White;
            this.lblTuitionsList.Location = new System.Drawing.Point(0, 0);
            this.lblTuitionsList.Name = "lblTuitionsList";
            this.lblTuitionsList.Size = new System.Drawing.Size(270, 25);
            this.lblTuitionsList.TabIndex = 33;
            this.lblTuitionsList.Text = "    TUITION";
            this.lblTuitionsList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DodgerBlue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "PORTAL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnPortalStudent.Location = new System.Drawing.Point(109, 33);
            this.btnPortalStudent.Name = "btnPortalStudent";
            this.btnPortalStudent.Size = new System.Drawing.Size(90, 90);
            this.btnPortalStudent.TabIndex = 28;
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
            this.btnPortalParent.Location = new System.Drawing.Point(9, 33);
            this.btnPortalParent.Name = "btnPortalParent";
            this.btnPortalParent.Size = new System.Drawing.Size(90, 90);
            this.btnPortalParent.TabIndex = 26;
            this.btnPortalParent.Text = "PARENT";
            this.btnPortalParent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPortalParent.UseVisualStyleBackColor = false;
            this.btnPortalParent.Click += new System.EventHandler(this.btnPortalParent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.DodgerBlue;
            this.tip.ForeColor = System.Drawing.Color.White;
            this.tip.IsBalloon = true;
            this.tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tip.ToolTipTitle = "Hint";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 540);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.toolMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment System [Santo Rosario Academy]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDirectUsers;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnDirectMonthly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMPNextYear;
        private System.Windows.Forms.Label lblMPYear;
        private System.Windows.Forms.Button btnMPPreviousYear;
        private System.Windows.Forms.ListView lvwMonthly;
        private System.Windows.Forms.ColumnHeader colMPIndex;
        private System.Windows.Forms.ColumnHeader colMPID;
        private System.Windows.Forms.ColumnHeader colMPJan;
        private System.Windows.Forms.ColumnHeader colMPFeb;
        private System.Windows.Forms.ColumnHeader colMPMar;
        private System.Windows.Forms.ColumnHeader colMPApr;
        private System.Windows.Forms.ColumnHeader colMPMay;
        private System.Windows.Forms.ColumnHeader colMPJun;
        private System.Windows.Forms.ColumnHeader colMPJul;
        private System.Windows.Forms.ColumnHeader colMPAug;
        private System.Windows.Forms.ColumnHeader colMPSep;
        private System.Windows.Forms.ColumnHeader colMPOct;
        private System.Windows.Forms.ColumnHeader colMPNov;
        private System.Windows.Forms.ColumnHeader colMPDec;
        private System.Windows.Forms.ColumnHeader colMPName;
        private System.Windows.Forms.Label lblMonthlyStatus;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripDropDownButton toolUsers;
        private System.Windows.Forms.ToolStripMenuItem toolUsersMasterlist;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolUsersAddNew;
        private System.Windows.Forms.ProgressBar pgbMonthlyStatus;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripLabel lblDate;
        private System.Windows.Forms.ComboBox cboMPMonth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.Button btnDirectTuition;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblTuitionsList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar pgbTuitionStatus;
        private System.Windows.Forms.Label lblTuitionStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvwTuitions;
        private System.Windows.Forms.ColumnHeader colTIndex;
        private System.Windows.Forms.ColumnHeader colTName;
        private System.Windows.Forms.ColumnHeader colTStatus;
        private System.Windows.Forms.ToolStripDropDownButton toolStudents;
        private System.Windows.Forms.ToolStripMenuItem toolStudentsMasterlist;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStudentsNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colNotes;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateUpdated;
        private System.Windows.Forms.ToolStripDropDownButton toolSettings;
        private System.Windows.Forms.ToolStripMenuItem toolSetupSubjects;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolSetupTuition;
        private System.Windows.Forms.ToolStripMenuItem toolSetupMonthly;
        private System.Windows.Forms.ColumnHeader colGrade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolSetupSubjectsManage;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolRecordGrades;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolRecordTuition;
        private System.Windows.Forms.ToolStripMenuItem toolRecordMonthly;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Button btnPortalParent;
        private System.Windows.Forms.Button btnPortalStudent;
        private System.Windows.Forms.ToolStripMenuItem toolUsersSwitch;
        private System.Windows.Forms.ToolTip tip;
    }
}