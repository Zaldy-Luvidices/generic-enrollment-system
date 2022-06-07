using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment
{
    public partial class frmMain : Form
    {
        public const string TITLE_STUDENTS = "    STUDENTS MASTERLIST ";
        public const string TITLE_TUITION = "    TUITION ";

        private Timer tmrDate = null;

        public frmMain()
        {
            InitializeComponent();

            // check database
            string loc = Application.StartupPath;
            if (!loc.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()))
                loc += System.IO.Path.DirectorySeparatorChar;
            if (!System.IO.File.Exists(loc + "DATA.mdf"))
            {
                try { System.IO.File.Copy(loc + "DBASE.mdf", loc + "DATA.mdf"); }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create database!\n" + ex.ToString(), "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            tmrDate = new Timer();
            tmrDate.Interval = 100;
            tmrDate.Tick += tmrDate_Tick;
            tmrDate.Start();

            cboMPMonth.SelectedIndex = DateTime.Now.Month - 1;
            lblMPYear.Text = DateTime.Now.Year.ToString();
            lblTuitionsList.Text = TITLE_TUITION + "[" + DateTime.Now.Year.ToString() + "]";
        }

        private void listStudents()
        {
            lvwStudents.Items.Clear();

            for (int i = 0; i < Global.Students.Count; ++i)
            {
                Ref.StudentInfo student = Global.Students[i];
                if (student.Type != Ref.STUD_TYPE_STUDENT && student.Type != Ref.STUD_TYPE_ENROLLEE) continue;

                ListViewItem item = new ListViewItem((lvwStudents.Items.Count + 1).ToString());
                item.SubItems.Add(student.StudentID);
                item.SubItems.Add(student.Lastname);
                item.SubItems.Add(student.Firstname);
                item.SubItems.Add(student.Middlename);
                item.SubItems.Add(student.Level);
                item.SubItems.Add(student.Section);
                item.SubItems.Add(Ref.DateToShortString(student.Birthdate));
                item.SubItems.Add(student.Contact);
                item.SubItems.Add(student.Address);
                item.SubItems.Add(Ref.GetStudentTypeString(student.Type));
                item.SubItems.Add(student.Notes);
                item.SubItems.Add(Ref.DateToShortString(student.DateCreated));
                item.SubItems.Add(Ref.DateToShortString(student.DateUpdated));
                item.SubItems.Add(student.Grade.ToString());

                item.Tag = student;
                item.Name = i.ToString();
                lvwStudents.Items.Add(item);
            }

            if (lvwStudents.Items.Count > 0) lvwStudents.Items[0].Selected = true;
            lblStudentList.Text = TITLE_STUDENTS + "(" + lvwStudents.Items.Count.ToString("000") + " / " + Ref.TOTAL_STUDENTS.ToString() + ")";
        }

        private void listTuitions()
        {
            lvwTuitions.Items.Clear();
            int cYear = DateTime.Now.Year;

            // identify tuition fee amount for current year
            float totalElem = -1f;
            float totalHigh = -1f;
            float totalSenior = -1f;
            float totalRes = -1f;
            Ref.TuitionFeeInfo tt = Global.TuitionFees.FirstOrDefault((a) => (a.Year == cYear));
            if (tt != null)
            {
                totalElem = tt.Elem;
                totalHigh = tt.High;
                totalSenior = tt.Senior;
                totalRes = tt.Reserved;
            }

            int paidCount = 0;
            for (int i = 0; i < Global.Students.Count; ++i)
            {
                Ref.StudentInfo stud = Global.Students[i];
                if (stud.Type != Ref.STUD_TYPE_ENROLLEE && stud.Type != Ref.STUD_TYPE_STUDENT) continue;
                string name = stud.Lastname + ", " + stud.Firstname + " " + stud.Middlename;

                Ref.TransTuitionInfo tf = Global.TFTransactions.FirstOrDefault((a) =>
                    (a.Year == cYear && a.StudentID == stud.ID && a.StudentLevel == stud.Level));
                string status = "(N/A)";
                if (tf != null)
                {
                    float total = 0f;
                    if (stud.Level.Equals(Ref.LEVEL_ELEM)) total = totalElem;
                    else if (stud.Level.Equals(Ref.LEVEL_HIGH)) total = totalHigh;
                    else if (stud.Level.Equals(Ref.LEVEL_SENIOR_HIGH)) total = totalSenior;
                    float bal = total - tf.Amount;
                    if (bal == 0f)
                    {
                        status = "Paid";
                        paidCount++;
                    }
                    else if (bal == total) status = "Unpaid";
                    else if (bal > 0) status = "Partial";
                    else if (bal < 0) status = "Overpaid";
                }

                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(name);
                item.SubItems.Add(status);
                if (status.Equals("Paid")) item.BackColor = Color.AliceBlue;
                else item.BackColor = Color.White;
                lvwTuitions.Items.Add(item);
            }

            lblTuitionStatus.Text = paidCount.ToString() + "/" + lvwTuitions.Items.Count.ToString();
            pgbTuitionStatus.Minimum = 0;
            pgbTuitionStatus.Maximum = lvwTuitions.Items.Count;
            pgbTuitionStatus.Value = paidCount;
        }

        private void listMonthly()
        {
            lvwMonthly.Items.Clear();
            int cYear = Convert.ToInt32(lblMPYear.Text);

            Ref.MonthlyFeeInfo tm = Global.MonthlyFees.FirstOrDefault((a) => a.Year == cYear);

            for (int i = 0; i < Global.Students.Count; ++i)
            {
                Ref.StudentInfo stud = Global.Students[i];
                if (stud.Type != Ref.STUD_TYPE_ENROLLEE && stud.Type != Ref.STUD_TYPE_STUDENT) continue;
                string name = stud.Lastname + ", " + stud.Firstname + " " + stud.Middlename;
                float total = -1f;
                if (tm != null)
                {
                    if (stud.Level.Equals(Ref.LEVEL_ELEM)) total = tm.Elem;
                    else if (stud.Level.Equals(Ref.LEVEL_HIGH)) total = tm.High;
                    else if (stud.Level.Equals(Ref.LEVEL_SENIOR_HIGH)) total = tm.Senior;
                }

                List<Ref.TransMonthlyInfo> trans = Global.MPTransactions.Where((a) =>
                    (a.Year == cYear && a.StudentID == stud.ID && a.StudentLevel.Equals(stud.Level))).ToList();

                List<string> stats = new List<string>();
                for (int m = 0; m < 12; ++m) stats.Add((total == -1f) ? "(N/A)" : "Unpaid");
                if (total == -1f) total = 0f;
                for (int m = 0; m < trans.Count; ++m)
                {
                    int mon = trans[m].Month - 1;
                    string status = "";
                    float bal = total - trans[m].Amount;
                    if (bal == 0f) status = "Paid";
                    else if (bal == total) status = "Unpaid";
                    else if (bal > 0) status = "Partial";
                    else if (bal < 0) status = "Overpaid";
                    stats[mon] = status;
                }

                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(stud.StudentID);
                item.SubItems.Add(name);
                foreach (string s in stats) item.SubItems.Add(s);
                lvwMonthly.Items.Add(item);
            }

            setMonthStatus();
        }

        private void listAll()
        {
            listStudents();
            listTuitions();
            listMonthly();
        }

        private void setMonthStatus()
        {
            int count = 0;
            for (int i = 0; i < lvwMonthly.Items.Count; ++i)
            {
                int mon = cboMPMonth.SelectedIndex;
                string s = lvwMonthly.Items[i].SubItems[mon + 3].Text;
                if (s.Equals("Paid")) count++;
            }

            lblMonthlyStatus.Text = count.ToString() + "/" + lvwMonthly.Items.Count.ToString();
            pgbMonthlyStatus.Minimum = 0;
            pgbMonthlyStatus.Maximum = lvwMonthly.Items.Count;
            pgbMonthlyStatus.Value = count;
        }

        private void tmrDate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("U");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Global.CurrentUser = null;
            this.Hide();
            frmLogIn frm = new frmLogIn();
            frm.ShowDialog();
            if (Global.CurrentUser == null)
            {
                this.Close();
                return;
            }
            // load everything
            Global.LoadStudents();
            Global.LoadTuitionFees();
            Global.LoadTransTuition();
            Global.LoadMonthlyFees();
            Global.LoadTransMonthly();
            Global.LoadSubjects();
            Global.LoadSubjectMaps();
            Global.LoadGradings();
            if (Global.SubjectMaps.Count == 0) initializeSubjectMaps();
            listAll();
            if (frm.FirstRun) runInitializationSetup();

            if (Global.CurrentUser.Access == Ref.AccessTypes.Viewer)
            {
                frmViewerPortal portal = new frmViewerPortal(this);
                portal.Show();
            }
            else this.Show();
        }

        private void runInitializationSetup()
        {
            MessageBox.Show("Initial Setup: 2 of 5\n\n" +
                "In the next form, please enter the [Tuition Fee] due amount for this year.\n" +
                "You can also setup the amounts for the other years.",
                "Initialization", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmTuitionManager frm1 = new frmTuitionManager(DateTime.Now.Year);
            frm1.ShowDialog();
            listTuitions();

            MessageBox.Show("Initial Setup: 3 of 5\n\n" +
                "In the next form, please enter the [Monthly Payment] due amount for this year.\n" +
                "You can also setup the amounts for the other years.",
                "Initialization", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMonthlyManager frm2 = new frmMonthlyManager(DateTime.Now.Year);
            frm2.ShowDialog();
            listMonthly();

            MessageBox.Show("Initial Setup: 4 of 5\n\n" +
                "In the next form, please input all subjects for all grade levels under [Elementary], [High School], and [Senior High School].",
                "Initialization", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmSubjectsRegister frm3 = new frmSubjectsRegister();
            frm3.ShowDialog();

            MessageBox.Show("Initial Setup: 5 of 5\n\n" +
                "In the next form, please map the inputted subjects to each grade levels.\n" +
                "This will be the basis when inputting grades for each student.",
                "Initialization", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmSubjectsManager frm4 = new frmSubjectsManager();
            frm4.ShowDialog();

            MessageBox.Show("Thanks for following the setup.\nYou can update the settings again on system menus.",
                "Initialization Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void initializeSubjectMaps()
        {
            // initialize with 12 entries
            bool allOk = true;
            for (int i = 1; i <= 12; ++i)
            {
                Ref.SubjectMapInfo map = new Ref.SubjectMapInfo();
                map.Grade = i;
                map.Subjects = "";
                if (!Global.AddSubjectMap(map)) allOk = false;
            }
            if (!allOk) ; // TODO: Do something here (e.g. abort run)
        }

        private void toolUsersMasterlist_Click(object sender, EventArgs e)
        {
            if(Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can access Users masterlist.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmUserList frm = new frmUserList();
            frm.ShowDialog();
        }

        private void btnDirectUsers_Click(object sender, EventArgs e)
        {
            toolStudentsMasterlist_Click(this, null);
        }

        private void btnMPNextYear_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(lblMPYear.Text);
            i++;
            if (i > 9999) i = 9999;
            lblMPYear.Text = i.ToString("0000");
            listMonthly();
        }

        private void btnMPPreviousYear_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(lblMPYear.Text);
            i--;
            if (i < 0) i = 0;
            lblMPYear.Text = i.ToString("0000");
            listMonthly();
        }

        private void toolUsersAddNew_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can add new users.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmUserUpdate frm = new frmUserUpdate(frmUserUpdate.UpdateMode.AddNew);
            frm.ShowDialog();
            if (!frm.IsCancelled)
            {
                Ref.UserInfo res = frm.OutputUser;
                if (Global.AddUser(res))
                    MessageBox.Show("Account was registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.CloseConnection();
        }

        private void toolStudentsMasterlist_Click(object sender, EventArgs e)
        {
            frmStudentsList frm = new frmStudentsList();
            frm.ShowDialog();
            // refresh
            listAll();
        }

        private void cboMPMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            setMonthStatus();
        }

        private void toolSetupSubjects_Click(object sender, EventArgs e)
        {
            frmSubjectsRegister frm = new frmSubjectsRegister();
            frm.ShowDialog();
        }

        private void toolStudentsNew_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can add new students.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmStudentUpdate frm = new frmStudentUpdate(frmStudentUpdate.UpdateMode.AddNew);
            frm.ShowDialog();
            if (!frm.IsCancelled)
            {
                if (Global.AddStudent(frm.OutputStudent))
                {
                    MessageBox.Show("Student was added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listAll();
                }
            }
        }

        private void toolSetupTuition_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can manage tuition fee amounts.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmTuitionManager frm = new frmTuitionManager(DateTime.Now.Year);
            frm.ShowDialog();
            if (frm.IsUpdated) listTuitions();
        }

        private void toolSetupMonthly_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can manage monthly payment due amounts.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmMonthlyManager frm = new frmMonthlyManager(DateTime.Now.Year);
            frm.ShowDialog();
            if (frm.IsUpdated) listMonthly();
        }

        private void toolSetupSubjectsManage_Click(object sender, EventArgs e)
        {
            frmSubjectsManager frm = new frmSubjectsManager();
            frm.ShowDialog();
        }

        private void btnDirectTuition_Click(object sender, EventArgs e)
        {
            toolRecordTuition_Click(this, null);
        }

        private void btnDirectMonthly_Click(object sender, EventArgs e)
        {
            toolRecordMonthly_Click(this, null);
        }

        private void toolRecordTuition_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can do tuition fee transactions.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            frmRecordManager frm = new frmRecordManager(frmRecordManager.Mode.Tuition);
            frm.ShowDialog();
            listTuitions();
        }

        private void toolRecordMonthly_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can do monthly payment transactions.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmRecordManager frm = new frmRecordManager(frmRecordManager.Mode.Monthly);
            frm.ShowDialog();
            listMonthly();
        }

        private void toolRecordGrades_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can input student grades.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmRecordManager frm = new frmRecordManager(frmRecordManager.Mode.Grade);
            frm.ShowDialog();
        }

        private void showPortal(object sender, frmPortal.Mode mode)
        {
            string note = "NOTE:\n";
            note += "You will logout from the system upon entering [" +
                ((mode == frmPortal.Mode.Parent) ? "Parents" : "Students") +
                " Portal].\n";
            note += "After closing the portal, the login window will appear to let you enter again.";
            if (MessageBox.Show(note, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                return;

            if (sender is frmViewerPortal)
            {
                frmViewerPortal v = sender as frmViewerPortal;
                v.Close();
            }

            this.Hide();
            frmPortal frm = new frmPortal(mode);
            frm.ShowDialog();

            Global.CurrentUser = null;
            frmLogIn log = new frmLogIn();
            log.ShowDialog();
            if (Global.CurrentUser == null)
            {
                this.Close();
                return;
            }

            if (Global.CurrentUser.Access == Ref.AccessTypes.Viewer)
            {
                frmViewerPortal portal = new frmViewerPortal(this);
                portal.Show();
            }
            else this.Show();
        }

        public void btnPortalParent_Click(object sender, EventArgs e)
        {
            showPortal(sender, frmPortal.Mode.Parent);
        }

        public void btnPortalStudent_Click(object sender, EventArgs e)
        {
            showPortal(sender, frmPortal.Mode.Student);
        }

        public void toolUsersSwitch_Click(object sender, EventArgs e)
        {
            frmLogIn log = new frmLogIn();
            log.ShowDialog();

            if (sender is frmViewerPortal)
            {
                frmViewerPortal v = sender as frmViewerPortal;
                v.Close();
            }

            if (Global.CurrentUser.Access == Ref.AccessTypes.Viewer)
            {
                this.Hide();
                frmViewerPortal portal = new frmViewerPortal(this);
                portal.Show();
            }
            else this.Show();
        }
    }
}
