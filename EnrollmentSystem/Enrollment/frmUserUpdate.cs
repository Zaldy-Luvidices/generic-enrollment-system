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
    public partial class frmUserUpdate : Form
    {
        public enum UpdateMode
        {
            ConfigureAdmin,
            AddNew,
            UpdateExisting,
        }

        public bool IsCancelled = true;
        public Ref.UserInfo OutputUser = null;

        private UpdateMode mode = UpdateMode.ConfigureAdmin;
        private Ref.UserInfo modUser = null;
        private bool selfEdit = false;

        public frmUserUpdate(UpdateMode mode, Ref.UserInfo updateUser = null)
        {
            InitializeComponent();

            this.mode = mode;
            modUser = updateUser;
            if ((Global.CurrentUser != null && modUser != null) &&
                Global.CurrentUser.Username.ToLower().Equals(modUser.Username.ToLower())) selfEdit = true;
            setupMode();
        }

        private void setupMode()
        {
            cboAccessType.Items.Clear();
            if (mode == UpdateMode.ConfigureAdmin)
            {
                this.Text = "Configure Admin Account";
                txtUsername.Text = "admin";
                txtOldPassword.Enabled = false;
                txtOldPassword.WaterMarkText = "";
                cboAccessType.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.Admin));
                cboAccessType.SelectedIndex = 0;
                chkUpdatePassword.Checked = true;
                chkUpdatePassword.Enabled = false;
                txtNewPassword.Focus();
            }
            else if (mode == UpdateMode.AddNew)
            {
                this.Text = "Add New User";
                if (Global.CurrentUser == null)
                {
                    MessageBox.Show("Current user data not specified!", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Global.CurrentUser.Access == Ref.AccessTypes.Admin)
                    cboAccessType.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.SuperUser));
                cboAccessType.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.User));
                cboAccessType.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.Viewer));
                cboAccessType.SelectedIndex = cboAccessType.Items.Count - 1;
                txtOldPassword.Enabled = false;
                txtOldPassword.WaterMarkText = "";
                chkUpdatePassword.Checked = true;
                chkUpdatePassword.Enabled = false;
                txtUsername.Focus();
            }
            else if (mode == UpdateMode.UpdateExisting)
            {
                this.Text = "Update User Information";
                if (Global.CurrentUser == null || modUser == null)
                {
                    MessageBox.Show("Not enough user data specified!", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selfEdit)
                { // current user cannot modify his access type, but high ranks can.
                    cboAccessType.Items.Add(Ref.GetStringFromAccess(modUser.Access));
                    cboAccessType.SelectedIndex = 0;
                }
                else
                {
                    if (Global.CurrentUser.Access == Ref.AccessTypes.Admin)
                        cboAccessType.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.SuperUser));
                    cboAccessType.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.User));
                    cboAccessType.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.Viewer));
                    cboAccessType.SelectedItem = Ref.GetStringFromAccess(modUser.Access);
                }

                chkUpdatePassword.Checked = false;
                chkUpdatePassword.Enabled = true;
                txtUsername.Text = modUser.Username;
                txtNotes.Text = modUser.Notes;
                txtUsername.Focus();
            }
        }

        private void cboAccessType_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAccessType.Image = imgListAccess.Images[cboAccessType.Text];
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == txtUsername) picErrorUsername.Visible = false;
            else if (txt == txtOldPassword) picErrorOldPassword.Visible = false;
            else if (txt == txtNewPassword) picErrorNewPassword.Visible = false;
            else if (txt == txtPasswordConfirm) picErrorPasswordConfirm.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                lblStatus.Text = "No username specified";
                picErrorUsername.Visible = true;
                txtUsername.Focus();
                return;
            }

            if (mode == UpdateMode.AddNew && Global.IsUserExists(txtUsername.Text))
            {
                lblStatus.Text = "Specified username already exists";
                picErrorUsername.Visible = true;
                txtUsername.Focus();
                return;
            }

            if (txtOldPassword.Enabled && String.IsNullOrEmpty(txtOldPassword.Text))
            {
                lblStatus.Text = "Please enter your current password";
                picErrorOldPassword.Visible = true;
                txtOldPassword.Focus();
                return;
            }

            if (chkUpdatePassword.Checked && String.IsNullOrEmpty(txtNewPassword.Text))
            {
                lblStatus.Text = "Please enter your new password";
                picErrorNewPassword.Visible = true;
                txtNewPassword.Focus();
                return;
            }

            if (chkUpdatePassword.Checked && String.IsNullOrEmpty(txtPasswordConfirm.Text))
            {
                lblStatus.Text = "Please confirm your new password";
                picErrorPasswordConfirm.Visible = true;
                txtPasswordConfirm.Focus();
                return;
            }

            if (chkUpdatePassword.Checked && !txtNewPassword.Text.Equals(txtPasswordConfirm.Text))
            {
                lblStatus.Text = "Password mismatch";
                picErrorPasswordConfirm.Visible = true;
                txtPasswordConfirm.Focus();
                return;
            }

            if (txtOldPassword.Enabled && !txtOldPassword.Text.Equals(modUser.Password))
            {
                lblStatus.Text = "Incorrect password";
                picErrorOldPassword.Visible = true;
                txtOldPassword.Clear();
                txtOldPassword.Focus();
                return;
            }

            OutputUser = new Ref.UserInfo(
                txtUsername.Text,
                (chkUpdatePassword.Checked ? txtNewPassword.Text : txtOldPassword.Text),
                Ref.GetAccessFromString(cboAccessType.Text),
                txtNotes.Text,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now
            );

            IsCancelled = false;
            this.Close();
        }

        private void chkUpdatePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdatePassword.Checked)
            {
                txtOldPassword.WaterMarkText = "Current Password";
                txtNewPassword.Text = "";
                txtNewPassword.Enabled = true;
                txtPasswordConfirm.Text = "";
                txtPasswordConfirm.Enabled = true;
            }
            else
            {
                txtOldPassword.WaterMarkText = "Password";
                txtNewPassword.Text = "";
                txtNewPassword.Enabled = false;
                txtPasswordConfirm.Text = "";
                txtPasswordConfirm.Enabled = false;
            }
        }
    }
}
