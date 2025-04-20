using DataBusiness_EC_;
using Educational_Center.DashBoard;
using Educational_Center.GlobalClasses;
using Educational_Center.MainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Center
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void llOpenMyProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/Joo110";

            System.Diagnostics.Process.Start(url);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            clsStandardMessages.ShowNotImplementedYet();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            ClsUser user = ClsUser.FindBy(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (user == null || !ClsUser.ExistsByUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                txtUsername.Focus();
                clsStandardMessages.ShowWrongCredentials();
                return;
            }

            if (chkRememberMe.Checked)
            {
                clsGlobal.RememberUsernameAndPassword(txtUsername.Text.Trim(), clsGlobal.Encrypt(txtPassword.Text.Trim()));
            }
            else
            {            
                clsGlobal.RemoveStoredCredential();
            }

            if (user.isActive == 0)
            {
                txtUsername.Focus();
                MessageBox.Show("Your account is not Active, Contact Admin.", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsGlobal.CurrentUser = user;

            this.Hide();
            FrmMainMenu f = new FrmMainMenu(this);
            f.ShowDialog();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            clsStandardMessages.ShowNotImplementedYet();
        }
    }
}
