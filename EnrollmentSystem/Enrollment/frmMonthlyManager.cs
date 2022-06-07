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
    public partial class frmMonthlyManager : Form
    {
        public bool IsUpdated = false;

        private float savedAmount = 0f;
        private int defYear = -1;

        public frmMonthlyManager(int defYear)
        {
            InitializeComponent();

            this.defYear = defYear;
            Global.LoadMonthlyFees();
            listData();

            cboYear.Items.Clear();
            for (int i = 1980; i < 2100; ++i) cboYear.Items.Add(i.ToString());
            cboYear.Text = DateTime.Now.Year.ToString();
            txtElem.Text = "0.00";
            txtHigh.Text = "0.00";
            txtSHigh.Text = "0.00";
        }

        private void listData()
        {
            List<Ref.MonthlyFeeInfo> sorted = Global.MonthlyFees.ToList();
            sorted.Sort((a,b) => a.Year.CompareTo(b.Year));

            lvwMonthly.Items.Clear();
            int yIndex = -1;
            for (int i = 0; i < sorted.Count; ++i)
            {
                Ref.MonthlyFeeInfo minfo = sorted[i];
                ListViewItem item = new ListViewItem(minfo.Year.ToString(""));
                item.SubItems.Add(minfo.Elem.ToString("#,0.00"));
                item.SubItems.Add(minfo.High.ToString("#,0.00"));
                item.SubItems.Add(minfo.Senior.ToString("#,0.00"));
                item.Name = minfo.ID.ToString();
                lvwMonthly.Items.Add(item);
                if (defYear == minfo.Year) yIndex = i;
            }

            if (yIndex != -1) lvwMonthly.Items[yIndex].Selected = true;
        }

        private void cboYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b') e.Handled = true;
            else e.Handled = false;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            savedAmount = Convert.ToSingle(txt.Text);
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            try { Convert.ToSingle(txt.Text); }
            catch
            {
                MessageBox.Show("Invalid monetary format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt.Text = savedAmount.ToString("#,0.00");
            }
            txt.Text = Convert.ToSingle(txt.Text).ToString("#,0.00"); // regularize format
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboYear.Text))
            {
                MessageBox.Show("You must specify the year for this record.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboYear.Focus();
                return;
            }

            // search if existing record
            int year = Convert.ToInt32(cboYear.Text);
            int ind = -1;
            for (int i = 0; i < Global.MonthlyFees.Count; ++i)
            {
                if (year == Global.MonthlyFees[i].Year)
                {
                    ind = i;
                    break;
                }
            }

            if (ind != -1 &&
                MessageBox.Show("Record by that year already exists, this action will update it.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            Ref.MonthlyFeeInfo minfo = new Ref.MonthlyFeeInfo();
            if (ind != -1) minfo.ID = Global.MonthlyFees[ind].ID;
            minfo.Year = year;
            minfo.Elem = Convert.ToSingle(txtElem.Text);
            minfo.High = Convert.ToSingle(txtHigh.Text);
            minfo.Senior = Convert.ToSingle(txtSHigh.Text);
            minfo.Reserved = 0f;
            if (ind == -1)
            { // add new
                if (Global.AddMonthlyFee(minfo)) listData();
            }
            else
            { // edit existing
                if (Global.UpdateMonthlyFeeData(ind, minfo) != null) listData();
            }

            IsUpdated = true;
        }

        private void lvwTuition_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected) return;

            ListViewItem item = lvwMonthly.SelectedItems[0];
            cboYear.Text = item.SubItems[0].Text;
            txtElem.Text = item.SubItems[1].Text;
            txtHigh.Text = item.SubItems[2].Text;
            txtSHigh.Text = item.SubItems[3].Text;
        }
    }
}
