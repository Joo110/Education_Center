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

namespace Educational_Center.Students
{
    public partial class ucStudentCard : UserControl
    {
        clsPeople _person;
        clsStudents _Student;

        public ucStudentCard()
        {
            InitializeComponent();
        }


        private void _FillPersonData(int PersonID)
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

        public void LoadStudentInfoStudentID(int StudentID)
        {
          

            _Student = clsStudents.Find(StudentID);
            _FillPersonData(_Student.PersonID.GetValueOrDefault());
            lblStudentID.Text = _Student.StudentID.ToString();
            if (_Student.GradeLevelID == 1)
                lblGradelevel.Text = "6th Grade";
            else if (_Student.GradeLevelID == 2)
                lblGradelevel.Text = "7th Grade";
            else if (_Student.GradeLevelID == 3)
                lblGradelevel.Text = "8th Grade";
            else if (_Student.GradeLevelID == 4)
                lblGradelevel.Text = "9th Grade";
            else if (_Student.GradeLevelID == 5)
                lblGradelevel.Text = "10th Grade";
            else if (_Student.GradeLevelID == 6)
                lblGradelevel.Text = "11th Grade";
            else if (_Student.GradeLevelID == 7)
                lblGradelevel.Text = "12th Grade";
            if (_Student.CreatedByUserID > 0)
                lblIsCreatedByUser.Text = "Admin";
            lblCreationDate.Text = _Student.CreationDate.ToString();                
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(_person.PersonID);
            frmAddEditPerson.ShowDialog();
        }
    }
}
