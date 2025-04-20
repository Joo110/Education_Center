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

namespace Educational_Center.Teachers
{
    public partial class frmAddEditTeacher : Form
    {
        private enum _enMode { Add, Update }
        private _enMode _mode = _enMode.Add;

        private int _TeacherID = 0;
        clsTeacher _teacher;

        public frmAddEditTeacher()
        {
            InitializeComponent();
            _mode = _enMode.Add;
        }

        public frmAddEditTeacher(int TeacherID)
        {
            InitializeComponent();
            _TeacherID = TeacherID;
            _mode = _enMode.Update;
        }

        private void _FillComboBoxWithEducationLevels()
        {
            DataTable educationLevels =  clsEductionLevel.AllOnlyNames();

            foreach (DataRow drTitle in educationLevels.Rows)
            {
                cbEducationLevels.Items.Add(drTitle["LevelName"].ToString());
            }

            if (cbEducationLevels.Items.Count > 0)
                cbEducationLevels.SelectedIndex = 0;
        }

        private void _ResetDefaultValues()
        {
            _FillComboBoxWithEducationLevels();

            if (_mode == _enMode.Add)
            {
                lblTitle.Text = "Add New Teacher";
                _teacher = new clsTeacher();
            }
            else
            {
                lblTitle.Text = "Update Teacher";
            }

            this.Text = lblTitle.Text;
        }


        private void _FillFieldsWithTeacherInfo()
        {
            ucPersonCard1._FillPersonData2(_teacher.PersonID);

            lblTeacherID.Text = _teacher.TeacherID.ToString();
            lblCreatedByUser.Text = _teacher.CreatedByUserInfo?.UserName;
            txtCertifications.Text = _teacher.Certifications;
            numaricTeachingExperience.Value = (decimal)_teacher.TeachingExperience;

            cbEducationLevels.SelectedIndex = cbEducationLevels.
                FindString(clsEductionLevel.GetEducationLeveName(_teacher.EducationLevelID));
        }

        public void LoadData()
        {
            _teacher = clsTeacher.FindByTeacherID(_TeacherID);
            groupBox1.Enabled = false;

            if (_teacher == null)
            {              
                clsStandardMessages.ShowMissingDataMessage("teacher", _TeacherID);

                this.Close();
                return;
            }

            txtSearch.Text = _teacher.PersonID.ToString();
            _FillFieldsWithTeacherInfo();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            ucPersonCard1._FillPersonData2(int.Parse(txtSearch.Text));
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
        }

        private void frmAddEditTeacher_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_mode == _enMode.Update)
                LoadData();
        }

        private void _FillTeacherObjectWithFieldsData()
        {
            _teacher.PersonID = int.Parse(txtSearch.Text);
            _teacher.EducationLevelID = clsEductionLevel.GetEducationLeveID(cbEducationLevels.Text);
            _teacher.TeachingExperience = (byte?)numaricTeachingExperience.Value;
            _teacher.Certifications = txtCertifications.Text.Trim();
            _teacher.CreatedByUserID = clsGlobal.CurrentUser?.UserID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillTeacherObjectWithFieldsData();

            if (_teacher.Save())
            {
                // Update UI elements
                lblTitle.Text = "Update Teacher";
                this.Text = lblTitle.Text;
                lblTeacherID.Text = _teacher.TeacherID.ToString();

                // Change form mode to update
                _mode = _enMode.Update;

                clsStandardMessages.ShowSuccess("Teacher");

                groupBox1.Enabled = false;
            }
            else
            {
                clsStandardMessages.ShowError("teacher");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
