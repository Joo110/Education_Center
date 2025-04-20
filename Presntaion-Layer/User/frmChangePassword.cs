using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Center.User
{
    public partial class frmChangePassword : Form
    {

        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            ucUserCard1.LoadUserInfoByPersonID(UserID);
        }

        private void _ResetFields()
        {
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();

            txtCurrentPassword.Focus();
        }

        private void _ChangePassword()
        {
            if (ClsUser.ChangePassword(clsGlobal.CurrentUser.UserID.GetValueOrDefault(),txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("Password Changed Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _ResetFields();
            }
            else
            {
                MessageBox.Show("An Error Occurred, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsStandardMessages.ShowValidationErrorMessage();
                return;
            }

            _ChangePassword();
        }
    }
}
