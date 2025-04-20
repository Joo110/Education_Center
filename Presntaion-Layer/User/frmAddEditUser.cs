using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using Educational_Center.Properties;
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
    public partial class frmAddEditUser : Form
    {
        private enum _enMode { AddNew, Update };
        private _enMode _mode = _enMode.AddNew;

        private int? _userID = null;
        private ClsUser _user = null;

        private int? _selectedPersonID = null;

        public frmAddEditUser()
        {
            InitializeComponent();
        }

        public frmAddEditUser(int? userID, bool allowToEditPermissions = true)
        {
            InitializeComponent();

            _userID = userID;
            _mode = _enMode.Update;

            gbPermissions.Enabled = allowToEditPermissions;
            llChangePassword.Enabled = allowToEditPermissions;
            chkActiveUser.Enabled = allowToEditPermissions;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ucPersonCard1._FillPersonData2(int.Parse(txtSearch.Text));
            tpUserData.Enabled = true;
            btnSave.Enabled = true;
        }


        private bool _IsAllItemIsChecked()
        {
            foreach (var item in gbPermissions.Controls)
            {
                if (item is CheckBox chk)
                {
                    if (chk.Tag.ToString() != "-1")
                    {
                        if (!chk.Checked)
                        {
                            return false;
                        }
                    }
                }

            }

            return true;
        }

        private bool _DoesNotSelectAnyPermission()
        {
            // return true if there is no permissions selected, otherwise false

            foreach (var item in gbPermissions.Controls)
            {
                if (item is CheckBox chk)
                {
                    if (chk.Checked)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void _ResetFields()
        {
            ucPersonCard1.Reset();

            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            lblUserID.Text = "[????]";
            chkActiveUser.Checked = true;

            pbIsActive.Image = Resources.question_mark;
        }

        private int _CountPermissions()
        {
            int Permissions = 0;

            if (chkAdmin.Checked)
                return -1;

            if (chkAddUser.Checked)
                Permissions += (int)ClsUser.enPermissions.AddUser;

            if (chkUpdateUser.Checked)
                Permissions += (int)ClsUser.enPermissions.UpdateUser;

            if (chkDeleteUser.Checked)
                Permissions += (int)ClsUser.enPermissions.DeleteUser;

            if (chkListUsers.Checked)
                Permissions += (int)ClsUser.enPermissions.ListUsers;

            return Permissions;
        }

        private void _ResetDefaultValues()
        {
            if (_mode == _enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                _user = new ClsUser();

                tpUserData.Enabled = false;

                _ResetFields();
            }
            else
            {
                lblTitle.Text = "Update User";
            }

            this.Text = lblTitle.Text;
        }

        private void _LoadData()
        {
            _user = new ClsUser();
            if (_userID.HasValue)
            {
                _user = ClsUser._FindByPersonID(_userID.Value);
            }
            else
            {
                MessageBox.Show("User ID is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            groupBox1.Enabled = false;

            if (_user == null)
            {
                clsStandardMessages.ShowMissingDataMessage("user", _userID);

                this.Close();

                return;
            }


            if (_user.PersonID != null)
            {
                int personID;
                if (int.TryParse(_user.PersonID.ToString(), out personID))
                {
                    ucPersonCard1._FillPersonData2(personID);
                }
                else
                {
                    MessageBox.Show("Invalid Person ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Person ID is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tpUserData.Enabled = true;
            txtSearch.Text = _user.PersonID.ToString();
            lblUserID.Text = _user.UserID.ToString();
            txtUsername.Text = _user.UserName;
            txtPassword.Text = _user.Password;
            txtConfirmPassword.Text = _user.Password;
            chkActiveUser.Checked = Convert.ToBoolean(_user.isActive);

            // in update mode, I show the change password link label to allow the user to change his password
            panelPassword.Visible = false;
            chkActiveUser.Location = new System.Drawing.Point(210, 165);
            pbIsActive.Location = new System.Drawing.Point(165, 163);
            llChangePassword.Location = new System.Drawing.Point(165, 216);
            llChangePassword.Visible = true;

            _FillCheckBoxPermissions();
        }

        private void _FillCheckBoxPermissions()
        {
            if (_user.Permissions == -1)
            {
                chkAdmin.Checked = true;
                return;
            }

            foreach (var item in gbPermissions.Controls)
            {
                if (item is CheckBox chk)
                {
                    if (chk.Tag.ToString() != "-1")
                    {
                        if (((Convert.ToInt32(chk.Tag)) & _user.Permissions) == (Convert.ToInt32(chk.Tag)))
                        {
                            chk.Checked = true;
                        }
                    }
                }
            }

        }

        private void _FillUserObjectWithFieldsData()
        {
            _user = new ClsUser();
            _user.UserName = txtUsername.Text.Trim();
            _user.PersonID = int.Parse(txtSearch.Text);
            _user.isActive = chkActiveUser.Checked ? 1 : 0;
            _user.Permissions = _CountPermissions();

            if (_mode == _enMode.AddNew)
            {
                _user.Password = txtPassword.Text.Trim();
            }
        }

        private void _SaveUser()
        {
            if (_selectedPersonID <= 0)
            {
                MessageBox.Show("Please select a valid person before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserObjectWithFieldsData();

            if (_user.PersonID <= 0)
            {
                MessageBox.Show("PersonID must have a valid value before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_user.Save())
            {
                lblTitle.Text = "Update User";
                this.Text = lblTitle.Text;
                lblUserID.Text = _user.UserID.ToString();

                _mode = _enMode.Update;

                clsStandardMessages.ShowSuccess("User");
            }
            else
            {
                clsStandardMessages.ShowError("user");
            }
        }


        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            cbFindBy.SelectedIndex = 0;
            if (_mode == _enMode.Update)
                _LoadData();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            string newUsername = txtUsername.Text.Trim();

            if (string.IsNullOrWhiteSpace(newUsername))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }

            if (txtUsername.Text.Trim().ToLower() != _user.UserName.ToLower() && 
                ClsUser.CheckUserExists(newUsername))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "username is used by another user");
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!panelPassword.Visible)
                return;

            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!panelPassword.Visible)
                return;

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }

            if ((!string.IsNullOrWhiteSpace(txtConfirmPassword.Text.Trim())
                && !string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
                && (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword,
                    "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsStandardMessages.ShowValidationErrorMessage();
                return;
            }

            if (_DoesNotSelectAnyPermission())
            {
                MessageBox.Show("You have to select permissions for the user!",
                       "Permissions Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _SaveUser();
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
            {
                foreach (var item in gbPermissions.Controls)
                {
                    if (item is CheckBox chk)
                    {
                        chk.Checked = true;
                    }
                }
            }
        }

        private void chkAddUser_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
            {
                chkAdmin.Checked = false;
                return;
            }

            chkAdmin.Checked = _IsAllItemIsChecked();
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
            {
                chkAdmin.Checked = false;
                return;
            }

            chkAdmin.Checked = _IsAllItemIsChecked();
        }

        private void llChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword changePassword = new frmChangePassword(_userID.GetValueOrDefault());
            changePassword.ShowDialog();
        }
    }
}
