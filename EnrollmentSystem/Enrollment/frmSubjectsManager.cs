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
    public partial class frmSubjectsManager : Form
    {
        private List<Ref.SubjectInfo> subElems = null;
        private List<Ref.SubjectInfo> subHighs = null;
        private List<Ref.SubjectInfo> subSeniors = null;

        private ListView selGradeList = null;

        public frmSubjectsManager()
        {
            InitializeComponent();

            subElems = Global.Subjects.Where((a) => a.Level.Equals(Ref.LEVEL_ELEM)).ToList();
            subHighs = Global.Subjects.Where((a) => a.Level.Equals(Ref.LEVEL_HIGH)).ToList();
            subSeniors = Global.Subjects.Where((a) => a.Level.Equals(Ref.LEVEL_SENIOR_HIGH)).ToList();

            listData();
            tabLevel.SelectedIndex = 0;
            tabGradesElem.SelectedIndex = 0;
            selGradeList = lvw1;
            listAvailSubjects();
        }

        private void listData()
        {
            bool hasMissingItems = false;
            for (int i = 0; i < 12; ++i)
            {
                Ref.SubjectMapInfo map = Global.SubjectMaps[i];
                ListView lvw = null;
                switch (i)
                {
                    case 0: lvw = lvw1; break;
                    case 1: lvw = lvw2; break;
                    case 2: lvw = lvw3; break;
                    case 3: lvw = lvw4; break;
                    case 4: lvw = lvw5; break;
                    case 5: lvw = lvw6; break;
                    case 6: lvw = lvw7; break;
                    case 7: lvw = lvw8; break;
                    case 8: lvw = lvw9; break;
                    case 9: lvw = lvw10; break;
                    case 10: lvw = lvw11; break;
                    case 11: lvw = lvw12; break;
                }
                if (String.IsNullOrEmpty(map.Subjects)) continue;

                List<string> sIds = map.Subjects.Split(',').ToList();
                if (sIds.Count == 0) continue;

                lvw.Items.Clear();
                bool hasDeleted = false;
                for (int s = sIds.Count - 1; s >= 0; --s)
                {
                    int id = Convert.ToInt32(sIds[s]);
                    Ref.SubjectInfo sub = null;
                    if(i >= 0 && i <= 5) sub = subElems.FirstOrDefault((a) => a.ID == id);
                    if (i >= 6 && i <= 9) sub = subHighs.FirstOrDefault((a) => a.ID == id);
                    if (i >= 10 && i <= 11) sub = subSeniors.FirstOrDefault((a) => a.ID == id);
                    if (sub == null)
                    {
                        sIds.RemoveAt(s);
                        hasDeleted = true;
                        continue;
                    }

                    ListViewItem item = new ListViewItem(sub.Code);
                    item.SubItems.Add(sub.Desciption);
                    item.SubItems.Add(sub.PassingGrade.ToString());
                    item.Name = sub.ID.ToString();
                    lvw.Items.Add(item);
                }

                if (lvw.Items.Count > 0) lvw.Items[0].Selected = true;

                if (hasDeleted)
                { // update database
                    string s = String.Join(",", sIds);
                    Global.UpdateSubjectMapData(i + 1, s);
                    hasMissingItems = true;
                }
            }

            if (hasMissingItems)
                MessageBox.Show("Reference to some subjects could not be found.\n" +
                    "They will automatically be removed to the mapping table.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void listAvailSubjects()
        {
            ComboBox cbo = null;
            List<Ref.SubjectInfo> subs = null;
            if (tabLevel.SelectedIndex == 0)
            {
                cbo = cboElem;
                subs = subElems;
            }
            else if (tabLevel.SelectedIndex == 1)
            {
                cbo = cboHigh;
                subs = subHighs;
            }
            else if (tabLevel.SelectedIndex == 2)
            {
                cbo = cboSenior;
                subs = subSeniors;
            }

            cbo.Items.Clear();
            for (int i = 0; i < subs.Count; ++i)
            {
                Ref.SubjectInfo sub = subs[i];
                if (!selGradeList.Items.ContainsKey(sub.ID.ToString()))
                    cbo.Items.Add("[" + sub.Code + "] " + sub.Desciption + " (" + sub.ID.ToString("0000") + ")");
            }
            cbo.Sorted = true;
            if (cbo.Items.Count > 0) cbo.SelectedIndex = 0;
        }

        private string collectAllID(string append = null)
        {
            List<string> ids = new List<string>();
            for (int i = 0; i < selGradeList.Items.Count; ++i)
                ids.Add(selGradeList.Items[i].Name);
            if (append != null) ids.Add(append);
            return String.Join(",", ids.ToArray());
        }

        private string collectAllID(int remove = -1)
        {
            List<string> ids = new List<string>();
            for (int i = 0; i < selGradeList.Items.Count; ++i)
                if (remove != -1 && i == remove) continue;
                else ids.Add(selGradeList.Items[i].Name);
            return String.Join(",", ids.ToArray());
        }

        private void tabLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabLevel.SelectedIndex == 0)
            {
                if (tabGradesElem.SelectedIndex == 0) selGradeList = lvw1;
                else if (tabGradesElem.SelectedIndex == 1) selGradeList = lvw2;
                else if (tabGradesElem.SelectedIndex == 2) selGradeList = lvw3;
                else if (tabGradesElem.SelectedIndex == 3) selGradeList = lvw4;
                else if (tabGradesElem.SelectedIndex == 4) selGradeList = lvw5;
                else if (tabGradesElem.SelectedIndex == 5) selGradeList = lvw6;
            }
            else if (tabLevel.SelectedIndex == 1)
            {
                if (tabGradesHigh.SelectedIndex == 0) selGradeList = lvw7;
                else if (tabGradesHigh.SelectedIndex == 1) selGradeList = lvw8;
                else if (tabGradesHigh.SelectedIndex == 2) selGradeList = lvw9;
                else if (tabGradesHigh.SelectedIndex == 3) selGradeList = lvw10;
            }
            else if (tabLevel.SelectedIndex == 2)
            {
                if (tabGradesSenior.SelectedIndex == 0) selGradeList = lvw11;
                else if (tabGradesSenior.SelectedIndex == 1) selGradeList = lvw12;
            }
            listAvailSubjects();
        }

        private void tabGradesHigh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabGradesHigh.SelectedIndex == 0) selGradeList = lvw7;
            else if (tabGradesHigh.SelectedIndex == 1) selGradeList = lvw8;
            else if (tabGradesHigh.SelectedIndex == 2) selGradeList = lvw9;
            else if (tabGradesHigh.SelectedIndex == 3) selGradeList = lvw10;
            listAvailSubjects();
        }

        private void tabGradesElem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabGradesElem.SelectedIndex == 0) selGradeList = lvw1;
            else if (tabGradesElem.SelectedIndex == 1) selGradeList = lvw2;
            else if (tabGradesElem.SelectedIndex == 2) selGradeList = lvw3;
            else if (tabGradesElem.SelectedIndex == 3) selGradeList = lvw4;
            else if (tabGradesElem.SelectedIndex == 4) selGradeList = lvw5;
            else if (tabGradesElem.SelectedIndex == 5) selGradeList = lvw6;
            listAvailSubjects();
        }

        private void tabGradesSenior_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabGradesSenior.SelectedIndex == 0) selGradeList = lvw11;
            else if (tabGradesSenior.SelectedIndex == 1) selGradeList = lvw12;
            listAvailSubjects();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can map subjects.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Button btn = sender as Button;
            Ref.SubjectInfo sub = null;
            if (btn == btnElemAdd)
            {
                if (cboElem.SelectedIndex < 0)
                {
                    MessageBox.Show("No item to add.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string str = cboElem.Text;
                str = str.Substring(str.Length - 5, 4); // 0000
                int id = Convert.ToInt32(str.TrimStart('0'));
                sub = subElems.FirstOrDefault((a) => a.ID == id);
            }
            else if (btn == btnHighAdd)
            {
                if (cboHigh.SelectedIndex < 0)
                {
                    MessageBox.Show("No item to add.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string str = cboHigh.Text;
                str = str.Substring(str.Length - 5, 4); // 0000
                int id = Convert.ToInt32(str.TrimStart('0'));
                sub = subHighs.FirstOrDefault((a) => a.ID == id);
            }
            else if (btn == btnSeniorAdd)
            {
                if (cboSenior.SelectedIndex < 0)
                {
                    MessageBox.Show("No item to add.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string str = cboSenior.Text;
                str = str.Substring(str.Length - 5, 4); // 0000
                int id = Convert.ToInt32(str.TrimStart('0'));
                sub = subSeniors.FirstOrDefault((a) => a.ID == id);
            }

            if (sub == null)
            {
                MessageBox.Show("Cannot identify subject.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // update database
            int grade = Convert.ToInt32(selGradeList.Name.Substring(3, selGradeList.Name.Length - 3)); // 1-based
            string newSubs = collectAllID(sub.ID.ToString());
            if (Global.UpdateSubjectMapData(grade, newSubs))
            {
                if (btn == btnElemAdd)
                {
                    int i = cboElem.SelectedIndex;
                    cboElem.Items.RemoveAt(i);
                    if (cboElem.Items.Count > 0)
                    {
                        if (i >= cboElem.Items.Count) i = cboElem.Items.Count - 1;
                        cboElem.SelectedIndex = i;
                    }
                }
                else if (btn == btnHighAdd)
                {
                    int i = cboHigh.SelectedIndex;
                    cboHigh.Items.RemoveAt(i);
                    if (cboHigh.Items.Count > 0)
                    {
                        if (i >= cboHigh.Items.Count) i = cboHigh.Items.Count - 1;
                        cboHigh.SelectedIndex = i;
                    }
                }
                else if (btn == btnSeniorAdd)
                {
                    int i = cboSenior.SelectedIndex;
                    cboSenior.Items.RemoveAt(i);
                    if (cboSenior.Items.Count > 0)
                    {
                        if (i >= cboSenior.Items.Count) i = cboSenior.Items.Count - 1;
                        cboSenior.SelectedIndex = i;
                    }
                }

                ListViewItem item = new ListViewItem(sub.Code);
                item.SubItems.Add(sub.Desciption);
                item.SubItems.Add(sub.PassingGrade.ToString());
                item.Name = sub.ID.ToString();
                selGradeList.Items.Add(item);
                selGradeList.Items[selGradeList.Items.Count - 1].Selected = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.Access != Ref.AccessTypes.Admin &&
                Global.CurrentUser.Access != Ref.AccessTypes.SuperUser)
            {
                MessageBox.Show("Only [Admin] and [Superuser] accounts can map subjects.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (selGradeList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No selected item to delete.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // update database
            int grade = Convert.ToInt32(selGradeList.Name.Substring(3, selGradeList.Name.Length - 3)); // 1-based
            int ind = selGradeList.SelectedIndices[0];
            string newSubs = collectAllID(ind);
            if (Global.UpdateSubjectMapData(grade, newSubs))
            {
                selGradeList.Items.RemoveAt(ind);
                if (selGradeList.Items.Count > 0)
                {
                    if (ind >= selGradeList.Items.Count) ind = selGradeList.Items.Count - 1;
                    selGradeList.Items[ind].Selected = true;
                }
                listAvailSubjects();
            }
        }
    }
}
