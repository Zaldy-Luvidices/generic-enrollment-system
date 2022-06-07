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
    public partial class frmAmountInput : Form
    {
        public float? Result = null;

        private float? total = null;
        private float defAmount = 0f;
        private float savedValue = 0f;

        public frmAmountInput(string title, float? total, float defAmount = 0f)
        {
            InitializeComponent();

            this.Text = title;
            if (total != null) lblTotal.Text = ((float)total).ToString("#,0.00");
            else lblTotal.Text = "---.--";
            this.total = total;
            txtPayment.Text = defAmount.ToString("#,0.00");
            this.defAmount = defAmount;
        }

        private void txtPayment_Enter(object sender, EventArgs e)
        {
            savedValue = Convert.ToSingle(txtPayment.Text);
        }

        private void txtPayment_Leave(object sender, EventArgs e)
        {
            float val = 0f;
            try { val = Convert.ToSingle(txtPayment.Text); }
            catch
            {
                MessageBox.Show("Invalid monetary format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                val = savedValue;
            }
            txtPayment.Text = val.ToString("#,0.00"); // regularize format
        }

        private void btnEquate_Click(object sender, EventArgs e)
        {
            txtPayment.Text = lblTotal.Text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            float val = Convert.ToSingle(txtPayment.Text);

            if (val > (float)total &&
                MessageBox.Show("Your input is greater than required amount.\nDo you want to proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                txtPayment.Focus();
                txtPayment.SelectAll();
                return;
            }

            this.Result = Convert.ToSingle(txtPayment.Text);
            this.Close();
        }
    }
}
