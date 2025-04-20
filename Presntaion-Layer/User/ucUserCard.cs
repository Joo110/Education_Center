using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using Educational_Center.People;
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
    public partial class ucUserCard : UserControl
    {
        ClsUser _user;
        clsPeople _person;

        public ucUserCard()
        {
            InitializeComponent();
        }

        private void _FillPersonData(int UserID)
        {
            _person = clsPeople.Find(UserID);

            lblPersonID.Text = _person.PersonID.ToString();
            lblFullName.Text = _person.FullName;
            lblGender.Text = _person.GenderName;
            lblPhone.Text = _person.PhoneNumber;
            lblDateOfBirth.Text = clsFormat.DateToShort(_person.DateOfBirth);
            lblAddress.Text = _person.Address;
            lblAge.Text = (DateTime.Now.Year - _person.DateOfBirth.Year).ToString();

            if (_person.Gender == 0)
            {
                lblGender.Text = "Male";
            }
            else lblGender.Text = "FeMale";

            llEditPersonInfo.Enabled = true;
        }

        public void Reset()
        {
            _person = null;
            _person = null;

            lblPersonID.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGender.Image = Resources.gender_male;
            lblGender.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblAge.Text = "[????]";
            lblAddress.Text = "[????]";

            llEditPersonInfo.Enabled = false;
        }

        public void LoadUserInfoByPersonID(int UserID)
        {
            _FillPersonData(UserID);

            _user = ClsUser._FindByPersonID(UserID);
            lblUserID.Text = _user.UserID.ToString();
            lblUsername.Text = _user.UserName;
            if (_user.isActive == 1)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
            if (_user.isActive == 1)
            {
                pbIsActive.Image = Resources.active_user;
            }
            else
                pbIsActive.Image = Resources.inactive_user;
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson f = new frmAddEditPerson(_person.PersonID);
            f.ShowDialog();
        }
    }
}
