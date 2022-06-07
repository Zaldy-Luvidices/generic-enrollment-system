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
    public partial class frmSubjectsRegister : Form
    {
        private ListView selList = null;

        public frmSubjectsRegister()
        {
            InitializeComponent();

            listData();
        }

        private void listData(int selTab = 0)
        {
            lvwElem.Items.Clear();
            lvwHigh.Items.Clear();
            lvwSenior.Items.Clear();

            for (int i = 0; i < Global.Subjects.Count; ++i)
            {
                Ref.SubjectInfo sub = Global.Subjects[i];
                ListViewItem item = new ListViewItem(sub.Code);
                item.SubItems.Add(sub.Desciption);
                item.SubItems.Add(sub.PassingGrade.ToString());
                item.Name = i.ToString();
                item.Tag = sub;
                if (sub.Level.Equals(Ref.LEVEL_ELEM)) lvwElem.Items.Add(item);
                else if (sub.Level.Equals(Ref.LEVEL_HIGH)) lvwHigh.Items.Add(item);
                else if (sub.Level.Equals(Ref.LEVEL_SENIOR_HIGH)) lvwSenior.Items.Add(item);
            }

            tabLevel.SelectedIndex = selTab;
            if (selTab == 0) selList = lvwElem;
            else if (selTab == 1) selList = lvwHigh;
            else if (selTab == 2) selList = lvwSenior;
            if (lvwElem.Items.Count > 0) lvwElem.Items[0].Selected = true;
        }

        private void numPassing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b') e.Handled = true;
            else e.Handled = false;
        }

        private void lvw_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView lvw = sender as ListView;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtCode.Clear();
            numPassing.Value = 0;
            txtDesc.Clear();
            if (!e.IsSelected) return;

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can register subjects.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnSave.Top = btnNew.Top;
            btnSave.Left = btnNew.Left;
            btnSave.Visible = true;
            btnCancel.Visible = true;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            tabLevel.Enabled = false;

            txtCode.Clear();
            txtCode.ReadOnly = false;
            numPassing.Value = 0;
            numPassing.ReadOnly = false;
            txtDesc.Clear();
            txtDesc.ReadOnly = false;
            txtCode.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can edit subject information.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (selList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No item selected to edit.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnSave.Top = btnEdit.Top;
            btnSave.Left = btnEdit.Left;
            btnSave.Visible = true;
            btnCancel.Visible = true;

            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            tabLevel.Enabled = false;

            ListViewItem item = selList.SelectedItems[0];
            txtCode.Text = item.SubItems[0].Text;        
            txtCode.ReadOnly = false;
            numPassing.Value = Convert.ToInt32(item.SubItems[2].Text);
            numPassing.ReadOnly = false;
            txtDesc.Text = item.SubItems[1].Text;
            txtDesc.ReadOnly = false;
            txtCode.SelectAll();
            txtCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int sel = -1;

            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("[Subject Code] cannot be empty.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCode.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("[Subject Description] cannot be empty.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesc.Focus();
                return;
            }

            if (btnSave.Left == btnNew.Left)
            { // new
                Ref.SubjectInfo sub = new Ref.SubjectInfo();
                sub.Code = txtCode.Text;
                sub.PassingGrade = (int)numPassing.Value;
                sub.Desciption = txtDesc.Text;
                if (tabLevel.SelectedIndex == 0) sub.Level = Ref.LEVEL_ELEM;
                else if (tabLevel.SelectedIndex == 1) sub.Level = Ref.LEVEL_HIGH;
                else if (tabLevel.SelectedIndex == 2) sub.Level = Ref.LEVEL_SENIOR_HIGH;
                if (Global.AddSubject(sub))
                {
                    ListViewItem item = new ListViewItem(sub.Code);
                    item.SubItems.Add(sub.Desciption);
                    item.SubItems.Add(sub.PassingGrade.ToString());
                    item.Name = (Global.Subjects.Count - 1).ToString();
                    item.Tag = sub;
                    selList.Items.Add(item);
                    sel = selList.Items.Count - 1;
                }
            }
            else
            { // edit
                ListViewItem item = selList.SelectedItems[0];
                Ref.SubjectInfo sub = (Ref.SubjectInfo)item.Tag;
                sub.Code = txtCode.Text;
                sub.PassingGrade = (int)numPassing.Value;
                sub.Desciption = txtDesc.Text;
                if (Global.UpdateSubjectData(Convert.ToInt32(item.Name), sub) != null)
                {
                    selList.SelectedItems[0].SubItems[0].Text = txtCode.Text;
                    selList.SelectedItems[0].SubItems[1].Text = txtDesc.Text;
                    selList.SelectedItems[0].SubItems[2].Text = numPassing.Value.ToString();
                    sel = selList.SelectedIndices[0];
                }
            }

            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnNew.Enabled = true;
            if (selList.Items.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            tabLevel.Enabled = true;
            if (sel != -1) selList.Items[sel].Selected = true;

            txtCode.Clear();
            numPassing.Value = 0;
            txtDesc.Clear();
            txtCode.ReadOnly = true;
            numPassing.ReadOnly = true;
            txtDesc.ReadOnly = true;
        }

        private void numPassing_Leave(object sender, EventArgs e)
        {
            numPassing.Value = Convert.ToInt32(numPassing.Value); // make sure there's no decimal places
        }

        private void tabLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabLevel.SelectedIndex == 0) selList = lvwElem;
            else if (tabLevel.SelectedIndex == 1) selList = lvwHigh;
            else if (tabLevel.SelectedIndex == 2) selList = lvwSenior;

            btnEdit.Enabled = (selList.Items.Count > 0);
            btnDelete.Enabled = (selList.Items.Count > 0);
            if (selList.Items.Count > 0) selList.Items[0].Selected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can delete subjects.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (selList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No item selected to edit.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (MessageBox.Show("Are you sure you want to delete this subject?\n" +
                "NOTE: Existing grading record with this subject will mark it as [???] in data view. You will not be able to restore it again.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            ListViewItem item = selList.SelectedItems[0];
            if (Global.DeleteSubject(Convert.ToInt32(item.Name)))
            {
                int ind = selList.SelectedIndices[0];
                listData(tabLevel.SelectedIndex);
                if (selList.Items.Count > 0)
                {
                    if (ind >= selList.Items.Count) ind = selList.Items.Count - 1;
                    selList.Items[ind].Selected = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnNew.Enabled = true;
            if (selList.Items.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            tabLevel.Enabled = true;

            txtCode.Clear();
            numPassing.Value = 0;
            txtDesc.Clear();
            txtCode.ReadOnly = true;
            numPassing.ReadOnly = true;
            txtDesc.ReadOnly = true;
        }
    }
}
