using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using Educational_Center.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace Educational_Center.People
{
    public partial class frmAddEditPerson : Form
    {
        public Action<int?> PersonIDBack;

        private enum _enMode { Add, Update };
        private _enMode _mode = _enMode.Add;

        private int? _personID = null;
        private clsPeople _person = null;

        public frmAddEditPerson()
        {
            InitializeComponent();
        }

        public frmAddEditPerson(int? personID)
        {
            InitializeComponent();

            _personID = personID;
            _mode = _enMode.Update;
        }


        private void _ResetFields()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Guna2TextBox txtGuna)
                    txtGuna.Clear();
            }

            rbMale.Checked = true;
            pbGender.Image = Resources.gender_male;
        }

        private void _ResetDefaultValues()
        {
            if (_mode == _enMode.Add)
            {
                lblTitle.Text = "Add New Person";
                _person = new clsPeople();
                _ResetFields();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            this.Text = lblTitle.Text;

            //Determine the maximum and minimum age allowed in the system
            //if (byte.TryParse(ConfigurationManager.AppSettings["MaxPersonAge"], out byte maxAge))
            //    dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-maxAge);
            //else
            //    dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //if (byte.TryParse(ConfigurationManager.AppSettings["MinPersonAge"], out byte minAge))
            //    dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-minAge);
            //else
            //    dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-10);
        }

        private void _FillFieldsWithPersonInfo()
        {
            if (_person == null) return;
            lblPersonID.Text = _person.PersonID.ToString();
            txtFirstName.Text = _person.FirstName;
            txtSecondName.Text = _person.SecondName;
            txtThirdName.Text = _person.ThirdName;
            txtLastName.Text = _person.LastName;
            txtAddress.Text = _person.Address;
            txtPhone.Text = _person.PhoneNumber;
            dtpDateOfBirth.Value = _person.DateOfBirth;

            if (_person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
        }

        private void _LoadData()
        {
            _person = new clsPeople();
            _person = clsPeople.FindByPersonID(_personID);

            if (_person == null)
            {
                clsStandardMessages.ShowMissingDataMessage("person", _personID);

                this.Close();
                return;
            }

            _FillFieldsWithPersonInfo();
        }


        private void _ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((Guna2TextBox)sender).Text.Trim()))
            {
                e.Cancel = true;
                MessageBox.Show("This field is required!");
            }
            else
            {
                MessageBox.Show("This field is required!");
            }
        }

        private void _FillPersonObjectWithFieldsData()
        {
            _person.FirstName = txtFirstName.Text.Trim();
            _person.SecondName = txtSecondName.Text.Trim();
            _person.ThirdName = string.IsNullOrWhiteSpace(txtThirdName.Text.Trim()) ? null : txtThirdName.Text.Trim();
            _person.LastName = txtLastName.Text.Trim();
            _person.Address = string.IsNullOrWhiteSpace(txtAddress.Text.Trim()) ? null : txtAddress.Text.Trim();
            _person.PhoneNumber = txtPhone.Text.Trim();
            if (rbMale.Checked)
                _person.Gender = 0;
            else _person.Gender = 1;
            _person.DateOfBirth = dtpDateOfBirth.Value;
        }

        private void _SavePerson()
        {
            _FillPersonObjectWithFieldsData();

            if (_person.Save())
            {
                lblTitle.Text = "Update Person";
                this.Text = lblTitle.Text;
                lblPersonID.Text = _person.PersonID.ToString();

                // change form mode to update
                _mode = _enMode.Update;

                clsStandardMessages.ShowSuccess("Person");

                // Trigger the event to send data back to the caller form
                PersonIDBack?.Invoke(_person?.PersonID);
            }
            else
            {
                clsStandardMessages.ShowError("person");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsStandardMessages.ShowValidationErrorMessage();
                return;
            }

            _SavePerson();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_mode == _enMode.Update)
                _LoadData();

            txtAddress.BorderRadius = 17;
        }
    }
}
