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
    public partial class frmTuitionManager : Form
    {
        public bool IsUpdated = false;

        private float savedAmount = 0f;
        private int defYear = -1;

        public frmTuitionManager(int defYear)
        {
            InitializeComponent();

            this.defYear = defYear;
            Global.LoadTuitionFees();
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
            List<Ref.TuitionFeeInfo> sorted = Global.TuitionFees.ToList();
            sorted.Sort((a,b) => a.Year.CompareTo(b.Year));

            lvwTuition.Items.Clear();
            int yIndex = -1;
            for (int i = 0; i < sorted.Count; ++i)
            {
                Ref.TuitionFeeInfo tinfo = sorted[i];
                ListViewItem item = new ListViewItem(tinfo.Year.ToString(""));
                item.SubItems.Add(tinfo.Elem.ToString("#,0.00"));
                item.SubItems.Add(tinfo.High.ToString("#,0.00"));
                item.SubItems.Add(tinfo.Senior.ToString("#,0.00"));
                item.Name = tinfo.ID.ToString();
                lvwTuition.Items.Add(item);
                if (defYear == tinfo.Year) yIndex = i;
            }

            if (yIndex != -1) lvwTuition.Items[yIndex].Selected = true;
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

            int year = Convert.ToInt32(cboYear.Text);
            int ind = -1;
            for (int i = 0; i < Global.TuitionFees.Count; ++i)
            {
                if (year == Global.TuitionFees[i].Year)
                {
                    ind = i;
                    break;
                }
            }

            if (ind != -1 &&
                MessageBox.Show("Record by that year already exists, this action will update it.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            Ref.TuitionFeeInfo tinfo = new Ref.TuitionFeeInfo();
            if (ind != -1) tinfo.ID = Global.TuitionFees[ind].ID;
            tinfo.Year = year;
            tinfo.Elem = Convert.ToSingle(txtElem.Text);
            tinfo.High = Convert.ToSingle(txtHigh.Text);
            tinfo.Senior = Convert.ToSingle(txtSHigh.Text);
            tinfo.Reserved = 0f;
            if (ind == -1)
            { // add new
                if (Global.AddTuitionFee(tinfo)) listData();
            }
            else
            { // edit existing
                if (Global.UpdateTuitionFeeData(ind, tinfo) != null) listData();
            }

            IsUpdated = true;
        }

        private void lvwTuition_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected) return;
            
            ListViewItem item = lvwTuition.SelectedItems[0];
            cboYear.Text = item.SubItems[0].Text;
            txtElem.Text = item.SubItems[1].Text;
            txtHigh.Text = item.SubItems[2].Text;
            txtSHigh.Text = item.SubItems[3].Text;
        }
    }
}
