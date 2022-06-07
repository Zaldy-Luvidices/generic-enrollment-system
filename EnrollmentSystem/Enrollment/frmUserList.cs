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
    public partial class frmUserList : Form
    {
        public const string SORT_ALL = "(All)";

        public frmUserList()
        {
            InitializeComponent();

            // possible filters for current user access type
            cboSort.Items.Add(SORT_ALL);
            if (Global.CurrentUser.Access == Ref.AccessTypes.Admin)
                cboSort.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.Admin));
            if (Global.CurrentUser.Access == Ref.AccessTypes.Admin ||
                Global.CurrentUser.Access == Ref.AccessTypes.SuperUser)
                cboSort.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.SuperUser));
            cboSort.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.User));
            cboSort.Items.Add(Ref.GetStringFromAccess(Ref.AccessTypes.Viewer));
            cboSort.SelectedIndex = 0;

            Global.LoadUsers();
            listUsers();
        }

        private void listUsers()
        {
            lvwList.Items.Clear();
            for (int i = 0; i < Global.Users.Count; ++i)
            {
                Ref.UserInfo user = Global.Users[i];
                
                // filter by current user access type
                if (Global.CurrentUser.Access == Ref.AccessTypes.Viewer) continue;
                if (Global.CurrentUser.Access == Ref.AccessTypes.User &&
                    (user.Access == Ref.AccessTypes.Admin ||
                    user.Access == Ref.AccessTypes.SuperUser)) continue;
                if (Global.CurrentUser.Access == Ref.AccessTypes.SuperUser &&
                    user.Access == Ref.AccessTypes.Admin) continue;

                // filter by selected filter
                if (cboSort.Text.Equals(Ref.GetStringFromAccess(Ref.AccessTypes.Admin)) &&
                    user.Access != Ref.AccessTypes.Admin) continue;
                if (cboSort.Text.Equals(Ref.GetStringFromAccess(Ref.AccessTypes.SuperUser)) &&
                    user.Access != Ref.AccessTypes.SuperUser) continue;
                if (cboSort.Text.Equals(Ref.GetStringFromAccess(Ref.AccessTypes.User)) &&
                    user.Access != Ref.AccessTypes.User) continue;
                if (cboSort.Text.Equals(Ref.GetStringFromAccess(Ref.AccessTypes.Viewer)) &&
                    user.Access != Ref.AccessTypes.Viewer) continue;

                addToList(user);
            }

            updateStatus();
        }

        private void updateStatus()
        {
            lblTotal.Text = lvwList.Items.Count.ToString();
            btnEdit.Enabled = (lvwList.Items.Count > 0);
            btnDelete.Enabled = (lvwList.Items.Count > 0);

            if (Global.CurrentUser.Access == Ref.AccessTypes.User ||
                Global.CurrentUser.Access == Ref.AccessTypes.Viewer ||
                Global.CurrentUser.Access == Ref.AccessTypes.Unknown)
            {
                btnNew.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void addToList(Ref.UserInfo user)
        {
            ListViewItem item = new ListViewItem((lvwList.Items.Count + 1).ToString());
            item.SubItems.Add(user.Username);
            item.SubItems.Add(Ref.GetStringFromAccess(user.Access));
            item.SubItems.Add(Ref.DateToShortString(user.DateRegistered));
            item.SubItems.Add(Ref.DateToShortString(user.DateUpdated));
            item.SubItems.Add((user.LastLogin == null) ? "(No record)" : Ref.DateToShortString(user.LastLogin.Value));
            item.SubItems.Add(user.Notes);
            item.BackColor = Ref.GetColorFromAccess(user.Access);
            if (Global.CurrentUser.Username.ToLower().Equals(user.Username.ToLower()))
                item.BackColor = Color.Orange;
            item.Tag = user;
            lvwList.Items.Add(item);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUserUpdate frm = new frmUserUpdate(frmUserUpdate.UpdateMode.AddNew);
            frm.ShowDialog();
            if (!frm.IsCancelled)
            {
                Ref.UserInfo res = frm.OutputUser;
                if (Global.AddUser(res))
                {
                    MessageBox.Show("Account was registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    res.LastLogin = null;
                    addToList(res);
                    updateStatus();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwList.SelectedItems == null || lvwList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the user to update.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lvwList.Focus();
                return;
            }

            Ref.UserInfo selUser = lvwList.SelectedItems[0].Tag as Ref.UserInfo;
            if(Global.CurrentUser.Access == Ref.AccessTypes.SuperUser &&
                selUser.Access == Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("You can't modify [" + Ref.GetStringFromAccess(Ref.AccessTypes.SuperUser) + "] accounts!",
                    "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmUserUpdate frm = new frmUserUpdate(frmUserUpdate.UpdateMode.UpdateExisting, selUser);
            frm.ShowDialog();
            if (frm.IsCancelled) return;
            Ref.UserInfo res = frm.OutputUser;
            Ref.UserInfo updated = Global.UpdateUserData(selUser.Username, res);
            if (updated == null) return;

            // update list
            lvwList.SelectedItems[0].SubItems[1].Text = updated.Username;
            lvwList.SelectedItems[0].SubItems[2].Text = Ref.GetStringFromAccess(updated.Access);
            lvwList.SelectedItems[0].SubItems[4].Text = Ref.DateToShortString(updated.DateUpdated);
            lvwList.SelectedItems[0].SubItems[6].Text = updated.Notes;
            lvwList.SelectedItems[0].BackColor = Ref.GetColorFromAccess(updated.Access);
            lvwList.SelectedItems[0].Tag = updated;
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            listUsers();
            if (lvwList.Items.Count > 0) lvwList.Items[0].Selected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwList.SelectedItems == null || lvwList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the user to delete.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lvwList.Focus();
                return;
            }

            Ref.UserInfo selUser = lvwList.SelectedItems[0].Tag as Ref.UserInfo;

            if (selUser.Access == Ref.AccessTypes.Admin)
            {
                MessageBox.Show("Admin accounts can't be deleted.",
                    "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Global.CurrentUser.Access == Ref.AccessTypes.SuperUser &&
                selUser.Access == Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("You can't delete [" + Ref.GetStringFromAccess(Ref.AccessTypes.SuperUser) + "] accounts!",
                    "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Delete this user?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (!Global.DeleteUser(selUser.Username))
            {
                MessageBox.Show("Error encountered during delete, or user didn't exists!",
                    "Operation Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lvwList.SelectedItems[0].Remove();
            updateStatus();
        }
    }
}
