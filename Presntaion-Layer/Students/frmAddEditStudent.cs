using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using Educational_Center.People;
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
    public partial class frmAddEditStudent : Form
    {
        private enum _enMode { Add, Update }
        private _enMode _mode = _enMode.Add;

        private int _studentID = 0;
        clsStudents _student;

        public frmAddEditStudent()
        {
            InitializeComponent();
            _mode = _enMode.Add;
        }

        public frmAddEditStudent(int StudentID)
        {
            InitializeComponent();
            _studentID = StudentID;
            _mode = _enMode.Update;
        }

        private void _FillComboBoxWithGradeLevels()
        {
            DataTable gradeLevels = clsGradeLevel.GetAllGradeLevelsName();

            foreach (DataRow drTitle in gradeLevels.Rows)
            {
                comboBox1.Items.Add(drTitle["GradeName"].ToString());
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void _ResetFields()
        {
            int UserID = clsGlobal.CurrentUser.UserID.GetValueOrDefault();
            lblStudentID.Text = "[????]";
            lblCreatedByUser.Text = UserID.ToString();
        }

        private void _ResetDefaultValues()
        {
            _FillComboBoxWithGradeLevels();

            if (_mode == _enMode.Add)
            {
                groupBox1.Enabled = true;
                lblTitle.Text = "Add New Student";
                _student = new clsStudents();
                _ResetFields();
            }
            else if(_mode == _enMode.Update)
            {
                groupBox1.Enabled = false;
                lblTitle.Text = "Update Student";
            }

            this.Text = lblTitle.Text;
        }

        private void _FillFieldsWithStudentInfo()
        {
            _ResetDefaultValues();

            txtSearch.Text = _studentID.ToString();
            _student = clsStudents.Find(_studentID);
            ucPersonCard1._FillPersonData2(_student.PersonID);
            lblStudentID.Text = _studentID.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;

            comboBox1.SelectedIndex = comboBox1.FindString(clsGradeLevel.GetGradeLevelName(_student.GradeLevelID));
        }
       

        private void frmAddEditStudent_Load(object sender, EventArgs e)
        {
            if(_mode == _enMode.Update)
            _FillFieldsWithStudentInfo();
        }

        private void _FillStudentObjectWithFieldsData()
        {
            _student.PersonID = int.Parse(txtSearch.Text);
            _student.GradeLevelID = clsGradeLevel.GetGradeLevelID(comboBox1.Text);
            _student.CreatedByUserID = clsGlobal.CurrentUser.UserID;
        }

        public void SaveStudent()
        {
            if (_student == null || _student.Mode == clsStudents.enMode.AddNew)
            {
                _student = new clsStudents();
            }

            _FillStudentObjectWithFieldsData();

            if (_student.SaveNewStudent())
            {
                lblTitle.Text = "Update Student";
                this.Text = lblTitle.Text;
                lblStudentID.Text = _student.StudentID.ToString();

                _mode = _enMode.Update;

                clsStandardMessages.ShowSuccess("Student");

                groupBox1.Enabled = false;
            }
            else
            {
                clsStandardMessages.ShowError("student");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsStandardMessages.ShowValidationErrorMessage();
                return;
            }

            SaveStudent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            ucPersonCard1._FillPersonData2(int.Parse(txtSearch.Text));
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson f = new frmAddEditPerson();
            f.ShowDialog();
        }

        private void laEditPersoninfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
