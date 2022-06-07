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
    public partial class frmPortal : Form
    {
        public enum Mode
        {
            Student,
            Parent,
        }

        private Mode mode = Mode.Student;
        private Ref.StudentInfo cStud = null;
        private bool allowUpdate = true;

        public frmPortal(Mode mode)
        {
            InitializeComponent();

            this.mode = mode;
            string title = "PARENTS ";
            if (mode == Mode.Student) title = "STUDENTS ";
            lblPortal.Text = title + "PORTAL";

            allowUpdate = false;
            picParent.Visible = false;
            picStudent.Visible = false;
            if (mode == Mode.Parent)
            {
                picParent.Visible = true;
                this.Text = "Parents Portal";
                int range = 25;
                cboTFYear.Items.Clear();
                cboMPYear.Items.Clear();
                int y = DateTime.Now.Year;
                int ind = 0;
                for (int i = (y - range); i <= (y + range); ++i)
                {
                    cboTFYear.Items.Add(i.ToString());
                    cboMPYear.Items.Add(i.ToString());
                    if (i == y) ind = cboTFYear.Items.Count - 1;
                }
                cboTFYear.SelectedIndex = ind;
                cboMPYear.SelectedIndex = ind;

                cboMPMonth.Items.Clear();
                for (int i = 1; i <= 12; ++i) cboMPMonth.Items.Add(Ref.GetMonthShortString(i));
                cboMPMonth.SelectedIndex = DateTime.Now.Month - 1;
            }
            else if (mode == Mode.Student)
            {
                picStudent.Visible = true;
                this.Text = "Students Portal";
            }
            allowUpdate = true;
        }

        private void setupMode()
        {
            if (mode == Mode.Student)
            {
                lvwGrades.Visible = true;
                tabParent.Visible = false;
            }
            else if (mode == Mode.Parent)
            {
                lvwGrades.Visible = false;
                tabParent.Visible = true;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (btnEnter.Text.Equals("ENTER"))
            { // enter
                cStud = Global.Students.FirstOrDefault((a) =>
                    a.StudentID.ToLower().Equals(txtStudentID.Text.ToLower()) &&
                    a.Lastname.ToLower().Equals(txtLastname.Text.ToLower()) &&
                    a.Firstname.ToLower().Equals(txtFirstname.Text.ToLower()));

                if (cStud == null)
                {
                    MessageBox.Show("Cannot find the student based on input credentials.\nPlease check your entries.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                btnEnter.Text = "DONE";
                txtStudentID.Enabled = false;
                txtLastname.Enabled = false;
                txtFirstname.Enabled = false;
                loadMode();
                setupMode();
            }
            else
            { // clear
                lvwGrades.Visible = false;
                tabParent.Visible = false;
                btnEnter.Text = "ENTER";
                txtStudentID.Enabled = true;
                txtLastname.Enabled = true;
                txtFirstname.Enabled = true;
                txtStudentID.Clear();
                txtLastname.Clear();
                txtFirstname.Clear();
                txtStudentID.Focus();
            }
        }

        private void loadTuition()
        {
            // load tuition
            Ref.TuitionFeeInfo tf = Global.TuitionFees.FirstOrDefault((a) =>
                a.Year == Convert.ToInt32(cboTFYear.Text));
            if (tf == null)
            {
                pnlTFMessage.Visible = true;
                lblTFMessage.Text = "(Due amount for tuition fee of " + cboTFYear.Text + " has not been set.)";
                return;
            }

            float total = 0f;
            if (cStud.Level.Equals(Ref.LEVEL_ELEM)) total = tf.Elem;
            else if (cStud.Level.Equals(Ref.LEVEL_HIGH)) total = tf.High;
            else if (cStud.Level.Equals(Ref.LEVEL_SENIOR_HIGH)) total = tf.Senior;

            Ref.TransTuitionInfo tTrans = Global.TFTransactions.FirstOrDefault((a) =>
                a.StudentID == cStud.ID &&
                a.StudentLevel == cStud.Level &&
                a.Year == Convert.ToInt32(cboTFYear.Text));
            if (tTrans == null)
            {
                pnlTFMessage.Visible = true;
                lblTFMessage.Text = "(No recorded transaction on specified year.)";
                return;
            }

            pnlTFMessage.Visible = false;
            float paid = tTrans.Amount;
            float bal = total - paid;
            lblTFTotal.Text = total.ToString("#,0.00");
            lblTFPaid.Text = paid.ToString("#,0.00");
            lblTFBalance.Text = bal.ToString("#,0.00");
            if (bal == total) lblTFBalance.ForeColor = Color.Orange;
            else if (bal == 0f) lblTFBalance.ForeColor = Color.DodgerBlue;
            else if (bal > 0f) lblTFBalance.ForeColor = Color.Black;
            else if (bal < 0f) lblTFBalance.ForeColor = Color.Green;
        }

        private void loadMonthly()
        {
            // load monthly
            Ref.MonthlyFeeInfo mp = Global.MonthlyFees.FirstOrDefault((a) =>
                a.Year == Convert.ToInt32(cboMPYear.Text));
            if (mp == null)
            {
                pnlMPMessage.Visible = true;
                lblMPMessage.Text = "(Due amount for monthly payment of " + cboMPYear.Text + " has not been set.)";
                return;
            }

            float total = 0f;
            if (cStud.Level.Equals(Ref.LEVEL_ELEM)) total = mp.Elem;
            else if (cStud.Level.Equals(Ref.LEVEL_HIGH)) total = mp.High;
            else if (cStud.Level.Equals(Ref.LEVEL_SENIOR_HIGH)) total = mp.Senior;

            Ref.TransMonthlyInfo mTrans = Global.MPTransactions.FirstOrDefault((a) =>
                a.StudentID == cStud.ID &&
                a.StudentLevel == cStud.Level &&
                a.Year == Convert.ToInt32(cboMPYear.Text) &&
                a.Month == cboMPMonth.SelectedIndex + 1);
            if (mTrans == null)
            {
                pnlMPMessage.Visible = true;
                lblMPMessage.Text = "(No recorded transaction on specified year.)";
                return;
            }

            pnlMPMessage.Visible = false;
            float paid = mTrans.Amount;
            float bal = total - paid;
            lblMPTotal.Text = total.ToString("#,0.00");
            lblMPPaid.Text = paid.ToString("#,0.00");
            lblMPBalance.Text = bal.ToString("#,0.00");
            if (bal == total) lblMPBalance.ForeColor = Color.Orange;
            else if (bal == 0f) lblMPBalance.ForeColor = Color.DodgerBlue;
            else if (bal > 0f) lblMPBalance.ForeColor = Color.Black;
            else if (bal < 0f) lblMPBalance.ForeColor = Color.Green;
        }

        private void loadMode()
        {
            if (!allowUpdate) return;
            if (mode == Mode.Student)
            {
                #region Student Mode
                lvwGrades.Items.Clear();

                List<Ref.GradingInfo> filtered = Global.Gradings.Where((a) =>
                    a.StudentID == cStud.ID &&
                    a.Grade == cStud.Grade &&
                    a.Year == DateTime.Now.Year).ToList();

                // collect all subjects as rows
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

                // display
                for (int i = 0; i < keys.Count; ++i)
                {
                    Ref.SubjectInfo sub = Global.Subjects.FirstOrDefault((a) => a.ID == Convert.ToInt32(keys[i]));
                    string row = "[N/A]";
                    if (sub != null) row = sub.Desciption;

                    ListViewItem item = new ListViewItem(row);
                    item.UseItemStyleForSubItems = false;
                    ListViewItem.ListViewSubItem s = item.SubItems.Add(values[0][i]);
                    if (s.Text.Equals("")) s.BackColor = Color.LightGray;
                    else s.BackColor = Color.White;
                    s = item.SubItems.Add(values[1][i]);
                    if (s.Text.Equals("")) s.BackColor = Color.LightGray;
                    s = item.SubItems.Add(values[2][i]);
                    if (s.Text.Equals("")) s.BackColor = Color.LightGray;
                    s = item.SubItems.Add(values[3][i]);
                    if (s.Text.Equals("")) s.BackColor = Color.LightGray;
                    lvwGrades.Items.Add(item);
                }
                #endregion
            }
            else if (mode == Mode.Parent)
            {
                loadTuition();
                loadMonthly();
            }
        }

        private void cboTFYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMode();
        }

        private void cboMPYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMode();
        }

        private void cboMPMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMode();
        }
    }
}
