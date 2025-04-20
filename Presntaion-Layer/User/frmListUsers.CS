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
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            object dataSource = ClsUser.GetAllUsers();

            var columnsInfo = new[] { ("User ID", 110),
                                     ("Full Name", 300),
                                     ("Username", 140),
                                     ("Gender", 120),
                                     ("Is Active", 160)
                                    };

            ucSubList1.LoadInfo(null, dataSource, columnsInfo);
        }

        private int? _GetUserIDFromList()
        {
            return (int?)ucSubList1.GetIDFromDGV("UserID");
        }

        private void _CheckPermissions(ClsUser.enPermissions entityPermissions)
        {
            if (clsGlobal.CurrentUser?.Permissions == -1)
            {
                _EnableDependingOnUserPermissions(entityPermissions);

                return;
            }

            if (((int)entityPermissions & clsGlobal.CurrentUser?.Permissions) == (int)entityPermissions)
            {
                _EnableDependingOnUserPermissions(entityPermissions);
            }
            else
            {
                _DisableDependingOnUserPermissions(entityPermissions);
            }
        }

        private void _EnableDependingOnUserPermissions(ClsUser.enPermissions entityPermissions)
        {
            if (clsGlobal.CurrentUser?.Permissions == -1)
            {
                tsmShowUserDetails.Enabled = true;
                tsmEditUser.Enabled = true;
                tsmDeleteUser.Enabled = true;
                return;
            }

            switch (entityPermissions)
            {
                case ClsUser.enPermissions.UpdateUser:
                    tsmEditUser.Enabled = true;
                    break;

                case ClsUser.enPermissions.DeleteUser:
                    tsmDeleteUser.Enabled = true;
                    break;
            }
        }

        private void _DisableDependingOnUserPermissions(ClsUser.enPermissions entityPermissions)
        {
            tsmShowUserDetails.Enabled = false;

            switch (entityPermissions)
            {
                case ClsUser.enPermissions.UpdateUser:
                    tsmEditUser.Enabled = false;
                    break;

                case ClsUser.enPermissions.DeleteUser:
                    tsmDeleteUser.Enabled = false;
                    break;
            }
        }

        private void cmsEditProfile_Opening(object sender, CancelEventArgs e)
        {
            cmsEditProfile.Enabled = (ucSubList1.RowsCount > 0);

            if (_GetUserIDFromList() == clsGlobal.CurrentUser.UserID)
            {
                tsmDeleteUser.Enabled = false;
            }
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();

            _CheckPermissions(ClsUser.enPermissions.UpdateUser);
            _CheckPermissions(ClsUser.enPermissions.DeleteUser);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowUserDetails_Click(object sender, EventArgs e)
        {
            frmShowUserInfo showUserInfo = new frmShowUserInfo(_GetUserIDFromList().GetValueOrDefault());
            showUserInfo.ShowDialog();

            frmListUsers_Load(null, null);
        }

        private void tsmEditUser_Click(object sender, EventArgs e)
        {
            bool allowToEditPermissions = clsGlobal.CurrentUser?.Permissions == -1;

            frmAddEditUser editUser = new frmAddEditUser(_GetUserIDFromList(), allowToEditPermissions);
            editUser.ShowDialog();

            frmListUsers_Load(null, null);
        }

        private void tsmDeleteUser_Click(object sender, EventArgs e)
        {
            if (clsStandardMessages.ShowDeleteConfirmation("user") == DialogResult.No)
            {
                return;
            }

            if (ClsUser.Delete(_GetUserIDFromList().GetValueOrDefault()))
            {
                clsStandardMessages.ShowDeletionSuccess("user");
            }
            else
            {
                clsStandardMessages.ShowDeletionFailure("user");
            }
        }
    }
}
