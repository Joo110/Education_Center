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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Educational_Center.Teachers
{
    public partial class frmShowTeacherInfo : Form
    {
        private int _TeacherID = 0;
        clsTeacher _teacher;

        public frmShowTeacherInfo(int TeacherID)
        {
            InitializeComponent();
            _TeacherID = TeacherID;
        }

        private void _FillComboBoxWithEducationLevels()
        {
            DataTable educationLevels = clsEductionLevel.AllOnlyNames();

            foreach (DataRow drTitle in educationLevels.Rows)
            {
                cbEducationLevels.Items.Add(drTitle["LevelName"].ToString());
            }

            if (cbEducationLevels.Items.Count > 0)
                cbEducationLevels.SelectedIndex = 0;
        }

        private void _FillFieldsWithTeacherInfo()
        {
            ucPersonCard1._FillPersonData2(_teacher.PersonID);

            lblTeacherID.Text = _teacher.TeacherID.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
            txtCertifications.Text = _teacher.Certifications;
            numaricTeachingExperience.Value = (decimal)_teacher.TeachingExperience;

            cbEducationLevels.SelectedIndex = cbEducationLevels.
                FindString(clsEductionLevel.GetEducationLeveName(_teacher.EducationLevelID));
        }

        public void LoadData()
        {
            _FillComboBoxWithEducationLevels();
            _teacher = clsTeacher.FindByTeacherID(_TeacherID);


            if (_teacher == null)
            {
                clsStandardMessages.ShowMissingDataMessage("teacher", _TeacherID);

                this.Close();
                return;
            }

            _FillFieldsWithTeacherInfo();
        }

        private void frmShowTeacherInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
