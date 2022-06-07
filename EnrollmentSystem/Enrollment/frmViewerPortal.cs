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
    public partial class frmViewerPortal : Form
    {
        private frmMain caller = null;

        public frmViewerPortal(frmMain caller)
        {
            InitializeComponent();

            this.caller = caller;
        }

        private void btnPortalParent_Click(object sender, EventArgs e)
        {
            caller.btnPortalParent_Click(this, null);
        }

        private void btnPortalStudent_Click(object sender, EventArgs e)
        {
            caller.btnPortalStudent_Click(this, null);
        }

        private void btnSwitchUser_Click(object sender, EventArgs e)
        {
            caller.toolUsersSwitch_Click(this, null);
        }
    }
}
