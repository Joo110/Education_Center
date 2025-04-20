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
using System.Configuration;
using Educational_Center.User;
namespace Educational_Center.Settings
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }


        private static string _PrintDuration(string value, float duration)
        {
            if (duration >= 2)
            {
                return $"{value}  Hours";
            }
            else
            {
                return $"{value}  Hour";
            }
        }

        private string _FixFormattingWhenPrintingDurations(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "N/A";
            }

            if (float.TryParse(value, out float duration))
            {
                return _PrintDuration(value, duration);
            }

            return $"{value}  Hour(s)";
        }

        private void _ShowSystemInfoFromAppConfig()
        {
            string maxPersonAge = ConfigurationManager.AppSettings["MaxPersonAge"];
            string minPersonAge = ConfigurationManager.AppSettings["MinPersonAge"];

            lblOpeningTime.Text = ConfigurationManager.AppSettings["StudyCenterOpeningTime"] ?? "N/A";
            lblClosingTime.Text = ConfigurationManager.AppSettings["StudyCenterClosingTime"] ?? "N/A";
            lblMaxPersonAge.Text = string.IsNullOrWhiteSpace(maxPersonAge) ? "N/A" : $"{maxPersonAge} Years";
            lblMinPersonAge.Text = string.IsNullOrWhiteSpace(minPersonAge) ? "N/A" : $"{minPersonAge} Years";
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
            switch (entityPermissions)
            {
                case ClsUser.enPermissions.AddUser:
                    llAddNewUser.Enabled = true;
                    break;

                case ClsUser.enPermissions.ListUsers:
                    llListUsers.Enabled = true;
                    break;
            }
        }

        private void _DisableDependingOnUserPermissions(ClsUser.enPermissions entityPermissions)
        {
            switch (entityPermissions)
            {
                case ClsUser.enPermissions.AddUser:
                    llAddNewUser.Enabled = false;
                    break;

                case ClsUser.enPermissions.ListUsers:
                    llListUsers.Enabled = false;
                    break;
            }
        }

        private void frmSettings_Load_1(object sender, EventArgs e)
        {
            _ShowSystemInfoFromAppConfig();

            _CheckPermissions(ClsUser.enPermissions.AddUser);
            _CheckPermissions(ClsUser.enPermissions.ListUsers);
        }

        private void llAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditUser f = new frmAddEditUser();
            f.ShowDialog();
        }

        private void llListUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmListUsers f = new frmListUsers();
            f.ShowDialog();

            frmSettings_Load_1(null, null);
        }
    }
}
