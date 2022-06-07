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
    public partial class frmLogIn : Form
    {
        public bool FirstRun = false;

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            picErrorUsername.Visible = false;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            picErrorPassword.Visible = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                lblStatus.Text = "No username specified";
                picErrorUsername.Visible = true;
                txtUsername.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                lblStatus.Text = "No password specified";
                picErrorPassword.Visible = true;
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            for (int i = 0; i < Global.Users.Count; ++i)
            {
                Ref.UserInfo user = Global.Users[i];
                if (user.Username.ToLower().Equals(txtUsername.Text.ToLower()))
                { // found, check password
                    if (user.Password.Equals(txtPassword.Text))
                    { // login ok
                        lblStatus.Text = "Login success!";
                        Global.CurrentUser = user;
                        Global.UpdateUserLogin(user.Username);
                        this.Close();
                    }
                    else
                    {
                        lblStatus.Text = "Invalid password";
                        picErrorPassword.Visible = true;
                        txtPassword.Clear();
                        txtPassword.Focus();
                        return;
                    }
                    break;
                }
            }

            lblStatus.Text = "Username didn't exists";
            picErrorUsername.Visible = true;
            txtUsername.Focus();
        }

        private void frmLogIn_Shown(object sender, EventArgs e)
        {
            if (!Global.OpenConnection())
            {
                Global.CurrentUser = null;
                this.Close();
                return;
            }

            Global.LoadUsers();
            if (Global.Users.Count < 1)
            { // first use, register admin
                MessageBox.Show("Initial Setup: 1 of 5\n\n" +
                    "Please register [Admin] account for first time use.\n" +
                    "This will be the only [Admin] account of the system.",
                    "Initialization", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bool toExit = false;
                while (true)
                {
                    frmUserUpdate frm = new frmUserUpdate(frmUserUpdate.UpdateMode.ConfigureAdmin);
                    frm.ShowDialog();
                    if (!frm.IsCancelled)
                    {
                        Ref.UserInfo user = frm.OutputUser;
                        if (Global.AddUser(user))
                        {
                            MessageBox.Show("Admin account registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Global.CurrentUser = user;
                            toExit = true;
                            FirstRun = true;
                        } // else: keep this form displayed after error message
                    }
                    else
                    {
                        if (MessageBox.Show("You need to configure Admin account for the first time.",
                            "Invalid Operation",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
                            toExit = true;
                        else continue;
                    }

                    break;
                }

                if (toExit) this.Close();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
