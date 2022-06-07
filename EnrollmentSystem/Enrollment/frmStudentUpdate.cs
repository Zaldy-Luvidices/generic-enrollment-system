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
    public partial class frmStudentUpdate : Form
    {
        public enum UpdateMode
        {
            AddNew,
            UpdateExisting,
            Preview,
        }

        public bool IsCancelled = true;
        public Ref.StudentInfo OutputStudent = null;

        private UpdateMode mode;
        private Ref.StudentInfo modStudent = null;

        public frmStudentUpdate(UpdateMode mode, Ref.StudentInfo updateStudent = null)
        {
            InitializeComponent();

            cboType.Items.Clear();
            cboType.Items.Add("Enrollee");
            cboType.Items.Add("Student");
            cboType.Items.Add("Graduate");
            cboType.Items.Add("Dropout");

            cboLevel.Items.Clear();
            cboLevel.Items.Add(Ref.LEVEL_ELEM);
            cboLevel.Items.Add(Ref.LEVEL_HIGH);
            cboLevel.Items.Add(Ref.LEVEL_SENIOR_HIGH);

            this.mode = mode;
            this.modStudent = updateStudent;
            setupMode();
        }

        private void setupMode()
        {
            if (mode == UpdateMode.AddNew)
            {
                this.Text = "Add New Student";
                if (Global.CurrentUser == null)
                {
                    MessageBox.Show("Current user data not specified!", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cboType.SelectedIndex = 0;
                cboLevel.SelectedIndex = 0;
                txtStudentID.Focus();
            }
            else if (mode == UpdateMode.UpdateExisting || mode == UpdateMode.Preview)
            {
                this.Text = "Update Student Information";
                if (Global.CurrentUser == null || modStudent == null)
                {
                    MessageBox.Show("Not enough data specified!", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtStudentID.Text = modStudent.StudentID;
                txtLastname.Text = modStudent.Lastname;
                txtFirstname.Text = modStudent.Firstname;
                txtMiddlename.Text = modStudent.Middlename;
                if (modStudent.Level.Equals(Ref.LEVEL_ELEM))
                {
                    cboLevel.SelectedIndex = 0;
                    cboGrade.SelectedIndex = modStudent.Grade - 1;
                }
                else if (modStudent.Level.Equals(Ref.LEVEL_HIGH))
                {
                    cboLevel.SelectedIndex = 1;
                    cboGrade.SelectedIndex = modStudent.Grade - 7;
                }
                else
                {
                    cboLevel.SelectedIndex = 2;
                    cboGrade.SelectedIndex = modStudent.Grade - 11;
                }

                txtSection.Text = modStudent.Section;
                dtpBirthdate.Checked = (modStudent.Birthdate != null);
                if (dtpBirthdate.Checked) dtpBirthdate.Value = (DateTime)modStudent.Birthdate;
                txtContact.Text = modStudent.Contact;
                txtAddress.Text = modStudent.Address;
                cboType.SelectedIndex = modStudent.Type;
                txtNotes.Text = modStudent.Notes;

                if (mode == UpdateMode.Preview)
                {
                    this.Text = "View Student Information";
                    txtStudentID.ReadOnly = true;
                    txtLastname.ReadOnly = true;
                    txtFirstname.ReadOnly = true;
                    txtMiddlename.ReadOnly = true;
                    txtLevel.Text = cboLevel.Text;
                    txtLevel.Visible = true;
                    txtGrade.Text = cboGrade.Text;
                    txtGrade.Visible = true;
                    txtSection.ReadOnly = true;
                    txtBirthdate.Text = Ref.DateToShortString(dtpBirthdate.Value);
                    txtBirthdate.Visible = true;
                    txtContact.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtType.Text = cboType.Text;
                    txtType.Visible = true;
                    txtNotes.ReadOnly = true;
                    btnUpdate.Visible = false;
                    lblStatus.Visible = false;
                }
                txtStudentID.Focus();
            }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == txtLastname) picErrorLastname.Visible = false;
            else if (txt == txtFirstname) picErrorFirstname.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLastname.Text))
            {
                lblStatus.Text = "Lastname must be specified";
                picErrorLastname.Visible = true;
                txtLastname.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtFirstname.Text))
            {
                lblStatus.Text = "Firstname must be specified";
                picErrorFirstname.Visible = true;
                txtFirstname.Focus();
                return;
            }

            OutputStudent = new Ref.StudentInfo();
            if (mode == UpdateMode.UpdateExisting) OutputStudent.ID = modStudent.ID;
            OutputStudent.StudentID = txtStudentID.Text;
            OutputStudent.Lastname = txtLastname.Text;
            OutputStudent.Firstname = txtFirstname.Text;
            OutputStudent.Middlename = txtMiddlename.Text;
            OutputStudent.Level = cboLevel.Text;
            OutputStudent.Grade = Convert.ToInt32(cboGrade.Text);
            OutputStudent.Section = txtSection.Text;
            OutputStudent.Birthdate = dtpBirthdate.Checked ? (DateTime?)dtpBirthdate.Value : null;
            OutputStudent.Contact = txtContact.Text;
            OutputStudent.Address = txtAddress.Text;
            OutputStudent.Type = cboType.SelectedIndex;
            OutputStudent.Notes = txtNotes.Text;

            IsCancelled = false;
            this.Close();
        }

        private void cboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGrade.Items.Clear();
            if (cboLevel.SelectedIndex == 0)
                for (int i = 1; i <= 6; ++i) cboGrade.Items.Add(i.ToString());
            else if (cboLevel.SelectedIndex == 1)
                for (int i = 7; i <= 10; ++i) cboGrade.Items.Add(i.ToString());
            else if (cboLevel.SelectedIndex == 2)
                for (int i = 11; i <= 12; ++i) cboGrade.Items.Add(i.ToString());
            cboGrade.SelectedIndex = 0;
        }
    }
}
