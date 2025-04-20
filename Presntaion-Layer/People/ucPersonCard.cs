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

namespace Educational_Center.People
{
    public partial class ucPersonCard : UserControl
    {
        clsPeople _person;

        public ucPersonCard()
        {
            InitializeComponent();
        }


        public void _FillPersonData(int StudentID)
        {
            _person = clsPeople.FindByStudentID(StudentID);

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


        public void _FillPersonData2(int? PersonID)
        {
            _person = clsPeople.FindByPersonID(PersonID);

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

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(_person.PersonID);
            frmAddEditPerson.ShowDialog();
        }
    }
}
