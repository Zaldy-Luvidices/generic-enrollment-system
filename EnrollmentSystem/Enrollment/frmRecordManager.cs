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
    public partial class frmRecordManager : Form
    {
        public enum Mode
        {
            Tuition,
            Monthly,
            Grade,
        }

        public const string NO_VALUE = "---.--";

        private Mode mode = Mode.Tuition;
        private Ref.StudentInfo cStud = null;
        private float savedValue = 0f;
        private bool needGradeSave = false;
        private Ref.GradingInfo cGradeRecord = null;
        private int lastSelQuarter = -1;

        public frmRecordManager(Mode mode)
        {
            InitializeComponent();

            cboYear.Items.Clear();
            for (int i = 2000; i < 2050; ++i) cboYear.Items.Add(i.ToString());
            cboYear.Text = DateTime.Now.Year.ToString();
            cboMPMonth.Items.Clear();
            for (int i = 1; i <= 12; ++i) cboMPMonth.Items.Add(Ref.GetMonthShortString(i));
            cboMPMonth.SelectedIndex = DateTime.Now.Month - 1;
            cboQuarter.Items.Clear();
            cboQuarter.Items.Add("Quarter I");
            cboQuarter.Items.Add("Quarter II");
            cboQuarter.Items.Add("Quarter III");
            cboQuarter.Items.Add("Quarter IV");
            cboQuarter.SelectedIndex = 0;
            lastSelQuarter = 0;
            this.mode = mode;
            setupMode();

            listStudents();
        }

        private void listStudents()
        {
            lvwStudents.Items.Clear();

            for (int i = 0; i < Global.Students.Count; ++i)
            {
                Ref.StudentInfo stud = Global.Students[i];
                if (stud.Type != Ref.STUD_TYPE_ENROLLEE && stud.Type != Ref.STUD_TYPE_STUDENT) continue;

                string name = stud.Lastname + ", " + stud.Firstname + " " + stud.Middlename;
                if (txtSearch.Text != "")
                {
                    bool hasMatch = false;
                    hasMatch |= name.ToLower().Contains(txtSearch.Text);
                    hasMatch |= stud.StudentID.Contains(txtSearch.Text);
                    if (!hasMatch) continue;
                }

                ListViewItem item = new ListViewItem((lvwStudents.Items.Count + 1).ToString());
                item.SubItems.Add(stud.StudentID);
                item.SubItems.Add(name);
                item.Tag = stud;
                item.Name = i.ToString();
                lvwStudents.Items.Add(item);
            }

            clearPage();
            if (lvwStudents.Items.Count > 0) lvwStudents.Items[0].Selected = true;
        }

        private void setupMode()
        {
            tabPageTuition.Enabled = false;
            tabPageMonthly.Enabled = false;
            tabPageGrades.Enabled = false;
            if (mode == Mode.Tuition)
            {
                tabPageTuition.Enabled = true;
                tabRecord.SelectedIndex = 0;
                this.Text = "Tuition Fee Transactions";
            }
            else if (mode == Mode.Monthly)
            {
                tabPageMonthly.Enabled = true;
                tabRecord.SelectedIndex = 1;
                this.Text = "Monthly Payment Transactions";
            }
            else if (mode == Mode.Grade)
            {
                tabPageGrades.Enabled = true;
                tabRecord.SelectedIndex = 2;
                this.Text = "Grades Input";
            }

            clearPage();
        }

        private void clearPage()
        {
            txtStudentName.Clear();
            lblLevel.Text = "---";
            lblGrade.Text = "---";
            lblSection.Text = "---";
            lblType.Text = "---";
            lblStatus.Text = "---";
            lblStatus.ForeColor = Color.Black;
            cStud = null;

            if (mode == Mode.Tuition)
            {
                lblTFTotal.Text = NO_VALUE;
                txtTFPayment.Clear();
                txtTFPayment.Enabled = true;
                lblTFTotal.Text = NO_VALUE;
                btnTFSubmit.Enabled = false;
            }
            else if (mode == Mode.Monthly)
            {
                cboMPMonth.Enabled = false;
                lblMPTotal.Text = NO_VALUE;
                txtMPPayment.Clear();
                txtMPPayment.Enabled = true;
                lblMPTotal.Text = NO_VALUE;
                btnMPSubmit.Enabled = false;
            }
            else if (mode == Mode.Grade)
            {
                lvwGrades.Items.Clear();
                numGrade.Value = 0;
                numGrade.Enabled = false;
                btnGradeUpdate.Enabled = false;
                btnGradeSubmit.Enabled = false;
                cboQuarter.Enabled = false;
                btnGradePass.Enabled = false;
            }
        }

        private void loadPage()
        {
            if(cStud == null) return;

            if (mode == Mode.Tuition)
            {
                #region Tuition
                // tuition total
                Ref.TuitionFeeInfo tf = Global.TuitionFees.FirstOrDefault((a) =>
                    a.Year == Convert.ToInt32(cboYear.Text));
                float total = -1f;
                if (tf != null)
                {
                    if (cStud.Level.Equals(Ref.LEVEL_ELEM)) total = tf.Elem;
                    else if (cStud.Level.Equals(Ref.LEVEL_HIGH)) total = tf.High;
                    else if (cStud.Level.Equals(Ref.LEVEL_SENIOR_HIGH)) total = tf.Senior;
                }
                if (total == -1f) return;
                lblTFTotal.Text = total.ToString("#,0.00");
                // current payment
                int ind = -1;
                for (int i = 0; i < Global.TFTransactions.Count; ++i)
                {
                    Ref.TransTuitionInfo tt = Global.TFTransactions[i];
                    if (tt.Year == Convert.ToInt32(cboYear.Text) && tt.StudentID == cStud.ID && tt.StudentLevel.Equals(cStud.Level))
                    {
                        ind = i;
                        break;
                    }
                }
                txtTFPayment.Tag = ind.ToString();
                float paid = -1f;
                if (ind != -1) paid = Global.TFTransactions[ind].Amount;
                if (paid == -1f) paid = 0f;
                txtTFPayment.Text = paid.ToString("#,0.00");
                // balance
                float bal = total - paid;
                lblTFBalance.Text = bal.ToString("#,0.00");
                if (bal == 0f)
                {
                    lblStatus.Text = "Paid";
                    lblStatus.ForeColor = Color.DodgerBlue;
                }
                else if (bal == total)
                {
                    lblStatus.Text = "Unpaid";
                    lblStatus.ForeColor = Color.Orange;
                }
                else if (bal > 0f)
                {
                    lblStatus.Text = "Partial";
                    lblStatus.ForeColor = Color.Black;
                }
                else if (bal < 0f)
                {
                    lblStatus.Text = "Overpaid";
                    lblStatus.ForeColor = Color.Green;
                }
                btnTFSubmit.Enabled = true;
                #endregion
            }
            else if (mode == Mode.Monthly)
            {
                #region Monthly
                // monthly total
                Ref.MonthlyFeeInfo mp = Global.MonthlyFees.FirstOrDefault((a) =>
                    a.Year == Convert.ToInt32(cboYear.Text));
                float total = -1f;
                if (mp != null)
                {
                    if (cStud.Level.Equals(Ref.LEVEL_ELEM)) total = mp.Elem;
                    else if (cStud.Level.Equals(Ref.LEVEL_HIGH)) total = mp.High;
                    else if (cStud.Level.Equals(Ref.LEVEL_SENIOR_HIGH)) total = mp.Senior;
                }
                if (total == -1f) return;
                lblMPTotal.Text = total.ToString("#,0.00");
                // current payment
                int ind = -1;
                for (int i = 0; i < Global.MPTransactions.Count; ++i)
                {
                    Ref.TransMonthlyInfo mt = Global.MPTransactions[i];
                    if (mt.Year == Convert.ToInt32(cboYear.Text) && mt.Month == (cboMPMonth.SelectedIndex + 1) && mt.StudentID == cStud.ID && mt.StudentLevel.Equals(cStud.Level))
                    {
                        ind = i;
                        break;
                    }
                }
                txtMPPayment.Tag = ind.ToString();
                float paid = -1f;
                if (ind != -1) paid = Global.MPTransactions[ind].Amount;
                if (paid == -1f) paid = 0f;
                txtMPPayment.Text = paid.ToString("#,0.00");
                // balance
                float bal = total - paid;
                lblMPBalance.Text = bal.ToString("#,0.00");
                if (bal == 0f)
                {
                    lblStatus.Text = "Paid";
                    lblStatus.ForeColor = Color.DodgerBlue;
                }
                else if (bal == total)
                {
                    lblStatus.Text = "Unpaid";
                    lblStatus.ForeColor = Color.Orange;
                }
                else if (bal > 0f)
                {
                    lblStatus.Text = "Partial";
                    lblStatus.ForeColor = Color.Black;
                }
                else if (bal < 0f)
                {
                    lblStatus.Text = "Overpaid";
                    lblStatus.ForeColor = Color.Green;
                }
                btnMPSubmit.Enabled = true;
                cboMPMonth.Enabled = true;
                #endregion
            }
            else if (mode == Mode.Grade)
            {
                #region Grades
                Ref.SubjectMapInfo smap = Global.SubjectMaps[cStud.Grade - 1];
                List<string> cSubjectIDs = smap.Subjects.Split(',').ToList();
                List<int> cGrades = new List<int>();
                for (int i = 0; i < cSubjectIDs.Count; ++i) cGrades.Add(0); // initialize with 0s
                cGradeRecord = Global.Gradings.FirstOrDefault((a) =>
                    a.StudentID == cStud.ID && a.Year == Convert.ToInt32(cboYear.Text) && a.Grade == cStud.Grade && a.Quarter == (cboQuarter.SelectedIndex + 1));
                if (cGradeRecord != null)
                { // we will follow current subject mapping, existing grades on unknown subjects will be removed. TODO: Should have user notification
                    List<string> lg = cGradeRecord.Records.Split(',').ToList();
                    List<string> lgKeys = new List<string>();
                    List<string> lgValues = new List<string>();
                    for (int i = 0; i < lg.Count; ++i)
                    {
                        if(String.IsNullOrEmpty(lg[i])) continue;
                        string[] keyVal = lg[i].Split(':');
                        lgKeys.Add(keyVal[0]);
                        lgValues.Add(keyVal[1]);
                    }

                    for (int i = 0; i < cSubjectIDs.Count; ++i)
                    {
                        int ind = lgKeys.IndexOf(cSubjectIDs[i]);
                        if (ind >= 0) cGrades[i] = Convert.ToInt32(lgValues[ind]);
                    }
                }

                lvwGrades.Items.Clear();
                for (int i = 0; i < cSubjectIDs.Count; ++i)
                {
                    Ref.SubjectInfo sub = Global.Subjects.FirstOrDefault((a) => a.ID == Convert.ToInt32(cSubjectIDs[i]));
                    if (sub == null) continue;
                    ListViewItem item = new ListViewItem(cGrades[i].ToString());
                    item.SubItems.Add(sub.PassingGrade.ToString());
                    item.SubItems.Add(sub.Code);
                    item.SubItems.Add(sub.Desciption);
                    item.Name = sub.ID.ToString();
                    if (cGrades[i] >= sub.PassingGrade) item.BackColor = Color.White;
                    else item.BackColor = Color.Orange;
                    lvwGrades.Items.Add(item);
                }
                cboQuarter.Enabled = true;
                numGrade.Enabled = true;
                btnGradeUpdate.Enabled = true;
                btnGradeSubmit.Enabled = true;
                btnGradePass.Enabled = true;
                needGradeSave = false;
                #endregion
            }
        }

        private void lvwStudents_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            clearPage();
            if (!e.IsSelected) return;

            cStud = lvwStudents.SelectedItems[0].Tag as Ref.StudentInfo;
            txtStudentName.Text = cStud.Lastname + ", " + cStud.Firstname + " " + cStud.Middlename;
            lblLevel.Text = cStud.Level;
            lblGrade.Text = cStud.Grade.ToString();
            lblSection.Text = cStud.Section;
            lblType.Text = Ref.GetStudentTypeString(cStud.Type);
            loadPage();
        }

        private void btnTFEquate_Click(object sender, EventArgs e)
        {
            txtTFPayment.Text = lblTFTotal.Text;
        }

        private void txtTFPayment_Enter(object sender, EventArgs e)
        {
            savedValue = Convert.ToSingle(txtTFPayment.Text);
        }

        private void txtTFPayment_Leave(object sender, EventArgs e)
        {
            float val = savedValue;
            try { val = Convert.ToSingle(txtTFPayment.Text); }
            catch { MessageBox.Show("Invalid monetary input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            txtTFPayment.Text = val.ToString("#,0.00");
        }

        private void btnTFSubmit_Click(object sender, EventArgs e)
        {
            bool success = false;
            int ind = Convert.ToInt32(txtTFPayment.Tag);
            if (ind == -1)
            { // add new
                Ref.TransTuitionInfo t = new Ref.TransTuitionInfo();
                t.StudentID = cStud.ID;
                t.Year = Convert.ToInt32(cboYear.Text);
                t.Amount = Convert.ToSingle(txtTFPayment.Text);
                t.StudentLevel = cStud.Level;
                success = Global.AddTransTuition(t);
            }
            else
            { // update existing
                success = (Global.UpdateTransTuitionData(ind, Convert.ToSingle(txtTFPayment.Text)) != null);
            }

            if (success)
            {
                MessageBox.Show("Transaction successful.\nStudent record was updated.", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadPage();
            }
        }

        private void btnMPEquate_Click(object sender, EventArgs e)
        {
            txtMPPayment.Text = lblMPTotal.Text;
        }

        private void txtMPPayment_Enter(object sender, EventArgs e)
        {
            savedValue = Convert.ToSingle(txtMPPayment.Text);
        }

        private void txtMPPayment_Leave(object sender, EventArgs e)
        {
            float val = savedValue;
            try { val = Convert.ToSingle(txtMPPayment.Text); }
            catch { MessageBox.Show("Invalid monetary input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            txtMPPayment.Text = val.ToString("#,0.00");
        }

        private void btnMPSubmit_Click(object sender, EventArgs e)
        {
            bool success = false;
            int ind = Convert.ToInt32(txtMPPayment.Tag);
            if (ind == -1)
            { // add new
                Ref.TransMonthlyInfo m = new Ref.TransMonthlyInfo();
                m.StudentID = cStud.ID;
                m.Year = Convert.ToInt32(cboYear.Text);
                m.Month = cboMPMonth.SelectedIndex + 1;
                m.Amount = Convert.ToSingle(txtMPPayment.Text);
                m.StudentLevel = cStud.Level;
                success = Global.AddTransMonthly(m);
            }
            else
            { // update existing
                success = (Global.UpdateTransMonthlyData(ind, Convert.ToSingle(txtMPPayment.Text)) != null);
            }

            if (success)
            {
                MessageBox.Show("Transaction successful.\nStudent record was updated.", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadPage();
            }
        }

        private void cboMPMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPage();
        }

        private void btnYearPrev_Click(object sender, EventArgs e)
        {
            if (needGradeSave &&
                MessageBox.Show("You've made changes in gradings record.\nDo you want to save it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                btnGradeSubmit.PerformClick();

            int i = Convert.ToInt32(cboYear.Text);
            i--;
            if (i < 0) i = 0;
            cboYear.Text = i.ToString("0000");
            loadPage();
        }

        private void btnYearNext_Click(object sender, EventArgs e)
        {
            if (needGradeSave &&
                MessageBox.Show("You've made changes in gradings record.\nDo you want to save it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                btnGradeSubmit.PerformClick();

            int i = Convert.ToInt32(cboYear.Text);
            i++;
            if (i > 9999) i = 9999;
            cboYear.Text = i.ToString("0000");
            loadPage();
        }

        private void cboQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (needGradeSave &&
                MessageBox.Show("You've made changes in gradings record.\nDo you want to save it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                btnGradeSubmit.PerformClick();
            lastSelQuarter = cboQuarter.SelectedIndex;
            loadPage();
        }

        private void btnGradeUpdate_Click(object sender, EventArgs e)
        {
            if (lvwGrades.SelectedItems.Count <= 0)
            {
                MessageBox.Show("You must select the subject first.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            lvwGrades.SelectedItems[0].SubItems[0].Text = numGrade.Value.ToString();
            if (Convert.ToInt32(lvwGrades.SelectedItems[0].SubItems[0].Text) >= Convert.ToInt32(lvwGrades.SelectedItems[0].SubItems[1].Text))
                lvwGrades.SelectedItems[0].BackColor = Color.White;
            else lvwGrades.SelectedItems[0].BackColor = Color.Orange;
            needGradeSave = true;
        }

        private void btnGradeSubmit_Click(object sender, EventArgs e)
        {
            string recs = "";
            foreach (ListViewItem item in lvwGrades.Items) recs += item.Name.ToString() + ":" + item.SubItems[0].Text + ",";
            recs = recs.TrimEnd(',');

            if (cGradeRecord == null)
            { // add new
                Ref.GradingInfo grade = new Ref.GradingInfo();
                grade.Year = Convert.ToInt32(cboYear.Text);
                grade.StudentID = cStud.ID;
                grade.Grade = cStud.Grade;
                grade.Quarter = lastSelQuarter + 1;
                grade.Records = recs;
                if (Global.AddGrading(grade))
                    MessageBox.Show("Grading record successfully updated.", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { // update existing
                int ind = Global.Gradings.IndexOf(cGradeRecord);
                if (ind >= 0)
                {
                    if (Global.UpdateGradingData(ind, recs))
                        MessageBox.Show("Grading record successfully updated.", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            needGradeSave = false;
            loadPage();
        }

        private void btnGradePass_Click(object sender, EventArgs e)
        {
            if (lvwGrades.SelectedItems.Count <= 0)
            {
                MessageBox.Show("You must select the subject first.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            lvwGrades.SelectedItems[0].SubItems[0].Text = lvwGrades.SelectedItems[0].SubItems[1].Text;
            lvwGrades.SelectedItems[0].BackColor = Color.White;
            needGradeSave = true;
        }

        private void cboYear_Leave(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            try { year = Convert.ToInt32(cboYear.Text); }
            catch { MessageBox.Show("Invalid integral input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            cboYear.Text = year.ToString();
            loadPage();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPage();
        }

        private void cboYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b') e.Handled = true;
            else e.Handled = false;
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            listStudents();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listStudents();
        }

        private void frmRecordManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needGradeSave &&
                MessageBox.Show("You've made changes in gradings record.\nDo you want to save it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnGradeSubmit.PerformClick();
                this.Close();
            }
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            if (lvwStudents.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No information to display.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Ref.StudentInfo stud = lvwStudents.SelectedItems[0].Tag as Ref.StudentInfo;
            frmStudentUpdate frm = new frmStudentUpdate(frmStudentUpdate.UpdateMode.Preview, stud);
            frm.ShowDialog();
        }
    }
}