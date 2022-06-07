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
    public partial class frmStudentsList : Form
    {
        public const string NO_VALUE = "---.--";
        public const string TITLE_TUITION_FEE = "     TUITION FEE ";
        public const string TITLE_MONTHLY_FEE = "     MONTHLY FEE ";

        private int currYearTF = 0;
        private int currYearMP = 0;
        private bool allowUpdate = true;

        private int indStudent = -1; // coll index
        private int indTuition = -1; // coll index
        private int indTransTuition = -1; // coll index
        private int indMonthly = -1; // coll index
        private int indTransMonthly = -1; // coll index

        private List<Ref.GradingInfo> cGradings = null;

        public frmStudentsList()
        {
            InitializeComponent();

            currYearTF = currYearMP = DateTime.Now.Year;
            lblTitleTuition.Text = TITLE_TUITION_FEE + "(" + currYearTF.ToString() + ")";
            lblTitleMonthly.Text = TITLE_MONTHLY_FEE + "(" + currYearMP.ToString() + ")";
            cboMonth.Items.Clear();
            for (int i = 1; i <= 12; ++i) cboMonth.Items.Add(Ref.GetMonthShortString(i));
            cboMonth.SelectedIndex = DateTime.Now.Month -1;
            allowUpdate = false;
            cboGrade.Items.Add("(All)");
            for (int i = 1; i <= 12; ++i) cboGrade.Items.Add(i.ToString());
            cboGrade.SelectedIndex = 0;
            allowUpdate = true;
            listStudents();
        }

        private void listStudents(int selIndex = 0)
        {
            if (!allowUpdate) return;
            lvwStudents.Items.Clear();

            for (int i = 0; i < Global.Students.Count; ++i)
            {
                Ref.StudentInfo stud = Global.Students[i];

                // filter from types
                if (!chkFilterEnrollees.Checked && stud.Type == Ref.STUD_TYPE_ENROLLEE) continue;
                if (!chkFilterStudents.Checked && stud.Type == Ref.STUD_TYPE_STUDENT) continue;
                if (!chkFilterGraduates.Checked && stud.Type == Ref.STUD_TYPE_GRADUATE) continue;
                if (!chkFilterDropouts.Checked && stud.Type == Ref.STUD_TYPE_DROPOUT) continue;

                // filter from search box
                if (!String.IsNullOrEmpty(txtSearch.Text))
                {
                    bool hasMatch = false;
                    string s = txtSearch.Text.ToLower();
                    hasMatch |= stud.StudentID.ToLower().Contains(s);
                    hasMatch |= stud.Lastname.ToLower().Contains(s);
                    hasMatch |= stud.Firstname.ToLower().Contains(s);
                    hasMatch |= stud.Middlename.ToLower().Contains(s);
                    hasMatch |= stud.Level.ToLower().Contains(s);
                    hasMatch |= stud.Grade.ToString().ToLower().Contains(s);
                    hasMatch |= stud.Section.ToLower().Contains(s);
                    hasMatch |= Ref.DateToShortString(stud.Birthdate).ToLower().Contains(s);
                    hasMatch |= stud.Contact.ToLower().Contains(s);
                    hasMatch |= stud.Address.ToLower().Contains(s);
                    hasMatch |= Ref.GetStudentTypeString(stud.Type).Contains(s);
                    hasMatch |= stud.Notes.ToLower().Contains(s);
                    hasMatch |= Ref.DateToShortString(stud.DateCreated).ToLower().Contains(s);
                    hasMatch |= Ref.DateToShortString(stud.DateUpdated).ToLower().Contains(s);
                    if (!hasMatch) continue;
                }

                // filter from grade
                if (cboGrade.SelectedIndex > 0 && Convert.ToInt32(cboGrade.Text) != stud.Grade) continue;

                addToList(stud, i);
            }

            if (lvwStudents.Items.Count > 0)
            {
                if (selIndex >= lvwStudents.Items.Count) selIndex = lvwStudents.Items.Count - 1;
                lvwStudents.Items[selIndex].Selected = true;
            }
            updateStatus();
            updateMarkers();
        }

        private void updateStatus()
        {
            lblTotal.Text = lvwStudents.Items.Count.ToString();
            toolEdit.Enabled = (lvwStudents.Items.Count > 0);
            toolDelete.Enabled = (lvwStudents.Items.Count > 0);

            if (Global.CurrentUser.Access == Ref.AccessTypes.User ||
                Global.CurrentUser.Access == Ref.AccessTypes.Viewer ||
                Global.CurrentUser.Access == Ref.AccessTypes.Unknown)
            {
                toolAdd.Enabled = false;
                toolEdit.Enabled = false;
                toolDelete.Enabled = false;
                toolMarkStudent.Enabled = false;
                toolMarkGraduate.Enabled = false;
                toolMarkDropout.Enabled = false;
            }
        }

        private void addToList(Ref.StudentInfo student, int index)
        {
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

            if (student.Type == Ref.STUD_TYPE_ENROLLEE) item.BackColor = Color.LightGray;
            else if (student.Type == Ref.STUD_TYPE_STUDENT) item.BackColor = Color.White;
            else if (student.Type == Ref.STUD_TYPE_GRADUATE) item.BackColor = Color.DodgerBlue;
            else if (student.Type == Ref.STUD_TYPE_DROPOUT) item.BackColor = Color.Orange;
            else item.BackColor = Color.LightGreen;

            item.Tag = student;
            item.Name = index.ToString();
            lvwStudents.Items.Add(item);
        }

        private void toolClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolAdd_Click(object sender, EventArgs e)
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
                    addToList(frm.OutputStudent, Global.Students.Count - 1);
                    updateStatus();
                }
            }
        }

        private void toolEdit_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can edit student data.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (lvwStudents.SelectedItems == null || lvwStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the student to update.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lvwStudents.Focus();
                return;
            }

            Ref.StudentInfo stud = lvwStudents.SelectedItems[0].Tag as Ref.StudentInfo;
            frmStudentUpdate frm = new frmStudentUpdate(frmStudentUpdate.UpdateMode.UpdateExisting, stud);
            frm.ShowDialog();
            if (frm.IsCancelled) return;
            Ref.StudentInfo res = frm.OutputStudent;
            Ref.StudentInfo updated = Global.UpdateStudentData(Convert.ToInt32(lvwStudents.SelectedItems[0].Name), res);
            if (updated == null) return;

            // update list
            lvwStudents.SelectedItems[0].SubItems[1].Text = updated.StudentID;
            lvwStudents.SelectedItems[0].SubItems[2].Text = updated.Lastname;
            lvwStudents.SelectedItems[0].SubItems[3].Text = updated.Firstname;
            lvwStudents.SelectedItems[0].SubItems[4].Text = updated.Middlename;
            lvwStudents.SelectedItems[0].SubItems[5].Text = updated.Level;
            lvwStudents.SelectedItems[0].SubItems[6].Text = updated.Section;
            lvwStudents.SelectedItems[0].SubItems[7].Text = Ref.DateToShortString(updated.Birthdate);
            lvwStudents.SelectedItems[0].SubItems[8].Text = updated.Contact;
            lvwStudents.SelectedItems[0].SubItems[9].Text = updated.Address;
            lvwStudents.SelectedItems[0].SubItems[10].Text = Ref.GetStudentTypeString(updated.Type);
            lvwStudents.SelectedItems[0].SubItems[11].Text = updated.Notes;
            lvwStudents.SelectedItems[0].SubItems[12].Text = Ref.DateToShortString(updated.DateCreated);
            lvwStudents.SelectedItems[0].SubItems[13].Text = Ref.DateToShortString(updated.DateUpdated);
            lvwStudents.SelectedItems[0].SubItems[14].Text = updated.Grade.ToString();

            if (updated.Type == Ref.STUD_TYPE_ENROLLEE) lvwStudents.SelectedItems[0].BackColor = Color.LightGray;
            else if (updated.Type == Ref.STUD_TYPE_STUDENT) lvwStudents.SelectedItems[0].BackColor = Color.White;
            else if (updated.Type == Ref.STUD_TYPE_GRADUATE) lvwStudents.SelectedItems[0].BackColor = Color.DodgerBlue;
            else if (updated.Type == Ref.STUD_TYPE_DROPOUT) lvwStudents.SelectedItems[0].BackColor = Color.Orange;
            else lvwStudents.SelectedItems[0].BackColor = Color.LightGreen;

            lvwStudents.SelectedItems[0].Tag = updated;
            updateMarkers();
            loadTuitionFeeData();
            loadMonthlyFeeData();
            loadGradingData();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can delete student data.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (lvwStudents.SelectedItems == null || lvwStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the student to delete.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lvwStudents.Focus();
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this student?\n" +
                "NOTE: This action can't be undone. Once deleted, all of the student's records will be invisible to the system and may not be displayed again.",
                "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Ref.StudentInfo stud = lvwStudents.SelectedItems[0].Tag as Ref.StudentInfo;
            if (!Global.DeleteStudent(Convert.ToInt32(lvwStudents.SelectedItems[0].Name)))
                return;

            int i = lvwStudents.SelectedIndices[0];
            lvwStudents.Items.RemoveAt(i);
            if (i >= lvwStudents.Items.Count) i = lvwStudents.Items.Count - 1;
            listStudents(i);
        }

        private void lvwStudents_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            toolMarkStudent.Enabled = false;
            toolMarkGraduate.Enabled = false;
            toolMarkDropout.Enabled = false;
            if (!e.IsSelected)
            { // disable fee related controls when no item is selected
                loadTuitionFeeData();
                loadMonthlyFeeData();
                loadGradingData();
                return;
            }
            updateMarkers();
            loadTuitionFeeData();
            loadMonthlyFeeData();
            loadGradingData();
        }

        private void updateMarkers()
        {
            toolMarkStudent.Enabled = false;
            toolMarkGraduate.Enabled = false;
            toolMarkDropout.Enabled = false;
            if (lvwStudents.SelectedItems.Count <= 0) return;
            Ref.StudentInfo stud = lvwStudents.SelectedItems[0].Tag as Ref.StudentInfo;
            if (stud.Type == Ref.STUD_TYPE_ENROLLEE)
            {
                toolMarkStudent.Enabled = true;
            }
            else if (stud.Type == Ref.STUD_TYPE_STUDENT)
            {
                toolMarkGraduate.Enabled = true;
                toolMarkDropout.Enabled = true;
            }
        }

        private void loadTuitionFeeData()
        {
            lblTuitionTotal.Text = NO_VALUE;
            lblTuitionPaid.Text = NO_VALUE;
            lblTuitionBalance.Text = NO_VALUE;
            lvwTuition.Items.Clear();
            btnTuitionEditPaid.Enabled = false;
            if (lvwStudents.SelectedItems.Count <= 0) return;

            btnTuitionEditPaid.Enabled = true;
            Ref.StudentInfo stud = lvwStudents.SelectedItems[0].Tag as Ref.StudentInfo;
            indStudent = Convert.ToInt32(lvwStudents.SelectedItems[0].Name);

            // identify tuition fee for current year and student's level
            float total = -1f;
            for (int i = 0; i < Global.TuitionFees.Count; ++i)
            {
                Ref.TuitionFeeInfo tuition = Global.TuitionFees[i];
                if (tuition.Year == currYearTF)
                {
                    if (stud.Level.Equals(Ref.LEVEL_ELEM)) total = tuition.Elem;
                    else if (stud.Level.Equals(Ref.LEVEL_HIGH)) total = tuition.High;
                    else if (stud.Level.Equals(Ref.LEVEL_SENIOR_HIGH)) total = tuition.Senior;

                    indTuition = i;
                    break;
                }
            }
            if (total != -1) lblTuitionTotal.Text = total.ToString("#,0.00");

            // search for all student's transactions on all years
            indTransTuition = -1;
            int listInd = -1;
            for (int i = 0; i < Global.TFTransactions.Count; ++i)
            {
                Ref.TransTuitionInfo t = Global.TFTransactions[i];
                if (t.StudentID == stud.ID)
                {
                    // identify tuition fee for that year and that level
                    float tl = -1f;
                    Ref.TuitionFeeInfo tt = Global.TuitionFees.FirstOrDefault((a) => (a.Year == t.Year));
                    if (tt != null)
                    {
                        if (t.StudentLevel.Equals(Ref.LEVEL_ELEM)) tl = tt.Elem;
                        else if (t.StudentLevel.Equals(Ref.LEVEL_HIGH)) tl = tt.High;
                        else if (t.StudentLevel.Equals(Ref.LEVEL_SENIOR_HIGH)) tl = tt.Senior;
                    }

                    ListViewItem item = new ListViewItem(t.Year.ToString());
                    item.BackColor = Color.White;
                    if (tl == -1f) item.SubItems.Add(NO_VALUE);
                    else
                    {
                        item.SubItems.Add(tl.ToString("#,0.00"));
                        if ((tl - t.Amount) > 0) item.BackColor = Color.Orange;
                    }
                    item.SubItems.Add(t.Amount.ToString("#,0.00"));
                    item.SubItems.Add(t.StudentLevel);
                    item.SubItems.Add(Ref.DateToShortString(t.DateUpdated));
                    lvwTuition.Items.Add(item);

                    if (t.Year == currYearTF && stud.Level.Equals(t.StudentLevel))
                    {
                        indTransTuition = i;
                        listInd = lvwTuition.Items.Count - 1;
                    }
                }
            }

            // load student's payment status on current year with current student's level
            if (indTransTuition != -1)
            {
                Ref.TransTuitionInfo t = Global.TFTransactions[indTransTuition];
                setTuitionPaidAmount(t.Amount);

                // highlight the record on list
                lvwTuition.Items[listInd].Selected = true;
                lvwTuition.TopItem = lvwTuition.Items[listInd];
            }
        }

        private void setTuitionPaidAmount(float amount)
        {
            float total = -1f;
            if (!lblTuitionTotal.Text.Equals(NO_VALUE)) total = Convert.ToSingle(lblTuitionTotal.Text);
            lblTuitionPaid.Text = amount.ToString("#,0.00");
            float bal = 0f;
            if (total == -1f)
            {
                lblTuitionBalance.ForeColor = Color.Green;
            }
            else
            {
                bal = total - amount;
                lblTuitionBalance.Text = bal.ToString("#,0.00");
                if (bal == 0f) lblTuitionBalance.ForeColor = Color.DodgerBlue;
                else if (bal < 0f) lblTuitionBalance.ForeColor = Color.Green;
                else lblTuitionBalance.ForeColor = Color.Red;
            }
        }

        private void loadMonthlyFeeData()
        {
            lblMonthlyTotal.Text = NO_VALUE;
            lblMonthlyPaid.Text = NO_VALUE;
            lblMonthlyBalance.Text = NO_VALUE;
            lvwMonthly.Items.Clear();
            btnMonthlyEditPaid.Enabled = false;
            if (lvwStudents.SelectedItems.Count <= 0) return;

            btnMonthlyEditPaid.Enabled = true;
            Ref.StudentInfo stud = lvwStudents.SelectedItems[0].Tag as Ref.StudentInfo;
            indStudent = Convert.ToInt32(lvwStudents.SelectedItems[0].Name);

            // identify monthly fee for current year and student's level
            float total = -1f;
            for (int i = 0; i < Global.MonthlyFees.Count; ++i)
            {
                Ref.MonthlyFeeInfo monthly = Global.MonthlyFees[i];
                if (monthly.Year == currYearMP)
                {
                    if (stud.Level.Equals(Ref.LEVEL_ELEM)) total = monthly.Elem;
                    else if (stud.Level.Equals(Ref.LEVEL_HIGH)) total = monthly.High;
                    else if (stud.Level.Equals(Ref.LEVEL_SENIOR_HIGH)) total = monthly.Senior;

                    indMonthly = i;
                    break;
                }
            }
            if (total != -1) lblMonthlyTotal.Text = total.ToString("#,0.00");

            // search for all student's transactions on current year
            indTransMonthly = -1;
            int listInd = -1;
            for (int i = 0; i < Global.MPTransactions.Count; ++i)
            {
                Ref.TransMonthlyInfo m = Global.MPTransactions[i];
                if (m.StudentID == stud.ID && m.Year == currYearMP)
                {
                    ListViewItem item = new ListViewItem(Ref.GetMonthShortString(m.Month));
                    if (total != -1f && (total - m.Amount) > 0) item.BackColor = Color.Orange;
                    else item.BackColor = Color.White;
                    item.SubItems.Add(m.Amount.ToString("#,0.00"));
                    item.SubItems.Add(m.StudentLevel);
                    item.SubItems.Add(Ref.DateToShortString(m.DateUpdated));
                    lvwMonthly.Items.Add(item);

                    if (m.Month == cboMonth.SelectedIndex + 1 && m.StudentLevel.Equals(stud.Level))
                    {
                        indTransMonthly = i;
                        listInd = lvwMonthly.Items.Count - 1;
                    }
                }
            }

            // load student's payment status on current year and month, with current student's level
            if (indTransMonthly != -1)
            {
                Ref.TransMonthlyInfo m = Global.MPTransactions[indTransMonthly];
                setMonthlyPaidAmount(m.Amount);

                // highlight the record on list
                lvwMonthly.Items[listInd].Selected = true;
                lvwMonthly.TopItem = lvwMonthly.Items[listInd];
            }
        }

        private void setMonthlyPaidAmount(float amount)
        {
            float total = -1f;
            if (!lblMonthlyTotal.Text.Equals(NO_VALUE)) total = Convert.ToSingle(lblMonthlyTotal.Text);
            lblMonthlyPaid.Text = amount.ToString("#,0.00");
            float bal = 0f;
            if (total == -1f)
            {
                lblMonthlyBalance.ForeColor = Color.Green;
            }
            else
            {
                bal = total - amount;
                lblMonthlyBalance.Text = bal.ToString("#,0.00");
                if (bal == 0f) lblMonthlyBalance.ForeColor = Color.DodgerBlue;
                else if (bal < 0f) lblMonthlyBalance.ForeColor = Color.Green;
                else lblMonthlyBalance.ForeColor = Color.Red;
            }
        }

        private void toolMark_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can edit student data.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (lvwStudents.SelectedItems == null || lvwStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select student to edit.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lvwStudents.Focus();
                return;
            }

            Ref.StudentInfo stud = lvwStudents.SelectedItems[0].Tag as Ref.StudentInfo;
            if (sender == toolMarkStudent && stud.Type != Ref.STUD_TYPE_ENROLLEE)
            {
                MessageBox.Show("Selected record can't be updated as [Student].", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lvwStudents.Focus();
                return;
            }
            else if ((sender == toolMarkGraduate || sender == toolMarkDropout) && stud.Type != Ref.STUD_TYPE_STUDENT)
            {
                MessageBox.Show("Selected record can't be updated as [" + ((sender == toolMarkGraduate) ? "Graduate" : "Dropout") + "].", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lvwStudents.Focus();
                return;
            }
            
            Ref.StudentInfo updated = Global.UpdateStudentType(Convert.ToInt32(lvwStudents.SelectedItems[0].Name),
                (sender == toolMarkStudent) ? Ref.STUD_TYPE_STUDENT : ((sender == toolMarkGraduate) ? Ref.STUD_TYPE_GRADUATE : Ref.STUD_TYPE_DROPOUT));
            if (updated == null) return;
            listStudents(lvwStudents.SelectedIndices[0]);
        }

        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            listStudents();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                listStudents();
                e.Handled = true;
            }
        }

        private void btnTuitionEditTotal_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can manage tuition fee amounts.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmTuitionManager frm = new frmTuitionManager(currYearTF);
            frm.ShowDialog();
            if (frm.IsUpdated) loadTuitionFeeData();
        }

        private void btnTuitionPrevious_Click(object sender, EventArgs e)
        {
            currYearTF--;
            if (currYearTF < 0) currYearTF = 0;
            lblTitleTuition.Text = TITLE_TUITION_FEE + "(" + currYearTF.ToString() + ")";
            loadTuitionFeeData();
        }

        private void btnTuitionNext_Click(object sender, EventArgs e)
        {
            currYearTF++;
            if (currYearTF > 9999) currYearTF = 9999;
            lblTitleTuition.Text = TITLE_TUITION_FEE + "(" + currYearTF.ToString() + ")";
            loadTuitionFeeData();
        }

        private void btnTuitionEditPaid_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can do tuition fee transactions.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            float? total = null;
            if (!lblTuitionTotal.Text.Equals(NO_VALUE)) total = Convert.ToSingle(lblTuitionTotal.Text);
            float def = 0f;
            if (!lblTuitionPaid.Text.Equals(NO_VALUE)) def = Convert.ToSingle(lblTuitionPaid.Text);
            frmAmountInput frm = new frmAmountInput("Tuition Fee", total, def);
            frm.ShowDialog();
            if (frm.Result != null)
            {
                float val = (float)frm.Result;
                // update database first
                bool success = false;
                if (lblTuitionPaid.Text.Equals(NO_VALUE))
                { // add new
                    Ref.TransTuitionInfo t = new Ref.TransTuitionInfo();
                    t.StudentID = Global.Students[indStudent].ID;
                    t.Year = currYearTF;
                    t.Amount = val;
                    t.StudentLevel = Global.Students[indStudent].Level;
                    success = Global.AddTransTuition(t);
                }
                else
                { // update existing
                    success = (Global.UpdateTransTuitionData(indTransTuition, val) != null);
                }

                if (success)
                {
                    setTuitionPaidAmount(val);
                    loadTuitionFeeData();
                }
            }
        }

        private void btnMonthlyEditTotal_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can manage monthly payment due amounts.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmMonthlyManager frm = new frmMonthlyManager(currYearMP);
            frm.ShowDialog();
            if (frm.IsUpdated) loadMonthlyFeeData();
        }

        private void btnMonthlyEditPaid_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can do monthly payment transactions.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            float? total = null;
            if (!lblMonthlyTotal.Text.Equals(NO_VALUE)) total = Convert.ToSingle(lblMonthlyTotal.Text);
            float def = 0f;
            if (!lblMonthlyPaid.Text.Equals(NO_VALUE)) def = Convert.ToSingle(lblMonthlyPaid.Text);
            frmAmountInput frm = new frmAmountInput("Monthly Payment [" + cboMonth.Text + "]", total, def);
            frm.ShowDialog();
            if (frm.Result != null)
            {
                float val = (float)frm.Result;
                // update database first
                bool success = false;
                if (lblMonthlyPaid.Text.Equals(NO_VALUE))
                { // add new
                    Ref.TransMonthlyInfo m = new Ref.TransMonthlyInfo();
                    m.StudentID = Global.Students[indStudent].ID;
                    m.Year = currYearTF;
                    m.Month = cboMonth.SelectedIndex + 1;
                    m.Amount = val;
                    m.StudentLevel = Global.Students[indStudent].Level;
                    success = Global.AddTransMonthly(m);
                }
                else
                { // update existing
                    success = (Global.UpdateTransMonthlyData(indTransMonthly, val) != null);
                }

                if (success)
                {
                    setMonthlyPaidAmount(val);
                    loadMonthlyFeeData();
                }
            }
        }

        private void btnMonthlyPrevious_Click(object sender, EventArgs e)
        {
            currYearMP--;
            if (currYearMP < 0) currYearMP = 0;
            lblTitleMonthly.Text = TITLE_MONTHLY_FEE + "(" + currYearMP.ToString() + ")";
            loadMonthlyFeeData();
        }

        private void btnMonthlyNext_Click(object sender, EventArgs e)
        {
            currYearMP++;
            if (currYearMP > 9999) currYearMP = 9999;
            lblTitleMonthly.Text = TITLE_MONTHLY_FEE + "(" + currYearMP.ToString() + ")";
            loadMonthlyFeeData();
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMonthlyFeeData();
        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            listStudents();
        }

        private void loadGradingData()
        {
            lvwGrading.Items.Clear();
            cboGradeRecord.Items.Clear();
            cboGradeYears.Items.Clear();
            btnGradingInput.Enabled = false;
            cGradings = null;

            if (lvwStudents.SelectedItems.Count <= 0) return;

            btnGradingInput.Enabled = true;
            Ref.StudentInfo stud = lvwStudents.SelectedItems[0].Tag as Ref.StudentInfo;
            indStudent = Convert.ToInt32(lvwStudents.SelectedItems[0].Name);
            cGradings = Global.Gradings.Where((a) => a.StudentID == stud.ID).ToList();
            if (cGradings == null || cGradings.Count <= 0) return;

            // list all grades
            for (int i = 1; i <= 12; ++i)
            {
                List<Ref.GradingInfo> g = cGradings.Where((a) => a.Grade == i).ToList();
                if (g == null || g.Count <= 0) continue;
                cboGradeRecord.Items.Add("Grade " + i.ToString());
            }

            cboGradeRecord.SelectedIndex = 0;
        }

        private void btnGradingInput_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can input student grades.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmRecordManager frm = new frmRecordManager(frmRecordManager.Mode.Grade);
            frm.ShowDialog();
            loadGradingData();
        }

        private void cboGradeRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cGradings == null) return;
            List<Ref.GradingInfo> filtered = cGradings.Where((a) => a.Grade == Convert.ToInt32(cboGradeRecord.Text.Replace("Grade ", ""))).ToList();
            filtered.Sort((a,b) => a.Year.CompareTo(b.Year));
            cboGradeYears.Items.Clear();
            int y = -1;
            for (int i = 0; i < filtered.Count; ++i)
            {
                if (y != filtered[i].Year)
                {
                    y = filtered[i].Year;
                    cboGradeYears.Items.Add(y);
                }
            }

            cboGradeYears.SelectedIndex = 0;
        }

        private void cboGradeYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cGradings == null) return;
            List<Ref.GradingInfo> filtered = cGradings.Where((a) => 
                a.Grade == Convert.ToInt32(cboGradeRecord.Text.Replace("Grade ", "")) &&
                a.Year == Convert.ToInt32(cboGradeYears.Text)).ToList();

            // collect all subjects as columns
            List<string> keys = new List<string>();
            for (int i = 0; i < filtered.Count; ++i)
            {
                Ref.GradingInfo g = filtered[i];
                string recs = g.Records;
                string[] subs = recs.Split(',');
                foreach (string s in subs)
                {
                    string[] keyVal = s.Split(':');
                    if (!keys.Contains(keyVal[0])) keys.Add(keyVal[0]);
                }
            }

            // collect all grades from four quarters
            List<List<string>> values = new List<List<string>>();
            for (int i = 0; i < 4; ++i)
            { // reserve for 4 items (quarters)
                List<string> vals = new List<string>();
                for (int j = 0; j < keys.Count; ++j) vals.Add(""); // provide initial values
                values.Add(vals);
            }
            for (int i = 0; i < filtered.Count; ++i)
            {
                Ref.GradingInfo g = filtered[i];
                int ind = g.Quarter - 1;
                string recs = g.Records;
                string[] subs = recs.Split(',');
                foreach (string s in subs)
                {
                    string[] keyVal = s.Split(':');
                    values[ind][keys.IndexOf(keyVal[0])] = keyVal[1];
                }
            }

            // fill list
            lvwGrading.Items.Clear();
            // columns
            lvwGrading.Columns.Clear();
            lvwGrading.Columns.Add("", 32);
            for (int i = 0; i < keys.Count; ++i)
            {
                Ref.SubjectInfo sub = Global.Subjects.FirstOrDefault((a) => a.ID == Convert.ToInt32(keys[i]));
                string col = "[???]";
                if (sub != null) col = sub.Code;
                lvwGrading.Columns.Add(col, 70);
            }
            // rows
            for (int i = 0; i < 4; ++i)
            {
                ListViewItem item = new ListViewItem("Q" + (i + 1).ToString());
                for (int j = 0; j < keys.Count; ++j)
                {
                    string s = values[i][j];
                    ListViewItem.ListViewSubItem sub = item.SubItems.Add(s);
                    if (s.Equals("")) sub.BackColor = Color.LightGray;
                    else sub.BackColor = Color.White;
                }
                item.UseItemStyleForSubItems = false;
                lvwGrading.Items.Add(item);
            }
        }
    }
}