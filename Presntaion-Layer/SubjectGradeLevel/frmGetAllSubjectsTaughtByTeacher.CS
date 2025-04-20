using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using Educational_Center.Teachers;
using System;
using System.Data;
using System.Windows.Forms;

namespace Educational_Center.SubjectGradeLevel
{
    public partial class frmGetAllSubjectsTaughtByTeacher : Form
    {
        private clsTeacher _teacher;
        private int? _TeacherID = null;

        public frmGetAllSubjectsTaughtByTeacher(int Teacher)
        {
            InitializeComponent();
            _TeacherID = Teacher;
            _FillComboBoxWithEducationLevels();
            LoadData();

            if (ucGetAllSubjectsTaughtByTeacherID1 != null)
                ucGetAllSubjectsTaughtByTeacherID1.LoadSubjectTeachersIsTeach(_TeacherID);
        }

        private void _FillComboBoxWithEducationLevels()
        {
            DataTable educationLevels = clsEductionLevel.AllOnlyNames();
            comboBox1.Items.Clear();

            foreach (DataRow drTitle in educationLevels.Rows)
            {
                comboBox1.Items.Add(drTitle["LevelName"].ToString());
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void _FillFieldsWithTeacherInfo()
        {
            if (_teacher == null)
                return;

            if (ucPersonCard2 != null)
                ucPersonCard2._FillPersonData2(_teacher.PersonID.GetValueOrDefault());

            label6.Text = _teacher.TeacherID?.ToString() ?? "N/A";
            label12.Text = _teacher.CreatedByUserInfo?.UserName ?? "Unknown";
            textBox1.Text = _teacher.Certifications ?? string.Empty;
            numericUpDown1.Value = _teacher.TeachingExperience ?? 0;

            if (comboBox1 != null)
            {
                string educationLevelName = _teacher.EducationLevelID.HasValue
                    ? clsEductionLevel.GetEducationLeveName(_teacher.EducationLevelID.Value)
                    : string.Empty;

                int index = comboBox1.FindString(educationLevelName);
                comboBox1.SelectedIndex = index >= 0 ? index : 0;
            }
        }

        public void LoadData()
        {
            if (!_TeacherID.HasValue)
            {
                clsStandardMessages.ShowMissingDataMessage("teacher", null);
                Close();
                return;
            }

            _teacher = clsTeacher.FindByTeacherID(_TeacherID ?? 0);

            if (_teacher == null)
            {
                clsStandardMessages.ShowMissingDataMessage("teacher", _TeacherID);
                Close();
                return;
            }

            _FillFieldsWithTeacherInfo();
        }
    }
}