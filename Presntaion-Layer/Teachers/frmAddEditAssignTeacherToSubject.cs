using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using System;
using System.Data;
using System.Windows.Forms;

namespace Educational_Center.Teachers
{
    public partial class frmAddEditAssignTeacherToSubject : Form
    {
        private enum _enMode { Add, Update }
        private _enMode _mode = _enMode.Add;
        private DataTable _dtAllSubjects = new DataTable();

        private int? _TeacherID = null;
        private clsTeacher _teacher; // يجب التأكد من تهيئة هذا المتغير

        private int? _subjectTeacherID = null;
        private clsSubjectTeacher _subjectTeacher = null;

        public frmAddEditAssignTeacherToSubject()
        {
            InitializeComponent();
        }

        public frmAddEditAssignTeacherToSubject(int TeacherID)
        {
            InitializeComponent();
            _TeacherID = TeacherID;
            _mode = _enMode.Update;
        }

        private void _FillComboBoxWithGradeLevels()
        {
            cbGrades.Items.Clear();

            cbGrades.Items.Add("All");

            DataTable gradeLevels = clsGradeLevel.GetAllGradesName();

            foreach (DataRow drTitle in gradeLevels.Rows)
            {
                cbGrades.Items.Add(drTitle["GradeName"].ToString());
            }
        }

        private void _FillComboBoxWithSubjectsName()
        {
            cbSubjects.Items.Clear();

            cbSubjects.Items.Add("All");

            DataTable subjectNames = clsSubject.GetAllSubjectName();

            foreach (DataRow drTitle in subjectNames.Rows)
            {
                cbSubjects.Items.Add(drTitle["SubjectName"].ToString());
            }

            if (cbSubjects.Items.Count > 0)
                cbSubjects.SelectedIndex = 0;
        }

        private void _RefreshSubjectGradeLevelsList()
        {
            if (_TeacherID == null)
                _dtAllSubjects.Clear();
            else
                _dtAllSubjects = clsSubjectGradeLevel.GetUntaughtSubjects(_TeacherID);

            dgvList.DataSource = _dtAllSubjects;

            if (dgvList.Rows.Count > 0)
            {
                dgvList.Columns[0].HeaderText = "Subject Grade-Level ID";
                dgvList.Columns[0].Width = 250;

                dgvList.Columns[1].HeaderText = "Subject Name";
                dgvList.Columns[1].Width = 170;

                dgvList.Columns[2].HeaderText = "Grade Name";
                dgvList.Columns[2].Width = 170;

                dgvList.Columns[3].HeaderText = "Description";
                dgvList.Columns[3].Width = 270;
            }
        }

        private int? _GetSubjectGradeLevelIDFromDGV()
        {
            return (int?)dgvList.CurrentRow.Cells["SubjectGradeLevelID"].Value;
        }

        private string _GetSubjectNameFromDGV()
        {
            return (string)dgvList.CurrentRow.Cells["SubjectName"].Value;
        }

        private string _GetGradeNameFromDGV()
        {
            return (string)dgvList.CurrentRow.Cells["GradeName"].Value;
        }

        private void _ResetDefaultValues()
        {
            _RefreshSubjectGradeLevelsList();

            if (_mode == _enMode.Add)
            {
                lblTitle.Text = "Assign Teacher to Subject";
                _subjectTeacher = new clsSubjectTeacher();
                _DisableTabPageSubject();

            }
            else
            {
                lblTitle.Text = "Update Teacher Assignment to Subject";
            }

            this.Text = lblTitle.Text;
        }

        private void _DisableTabPageSubject()
        {
            cbGrades.Enabled = false;
            cbSubjects.Enabled = false;
            dgvList.Enabled = false;
            cbFilter.Enabled = false;
            tpSubject.Cursor = Cursors.No;
        }

        private void _EnableTabPageSubject()
        {
            cbGrades.Enabled = true;
            cbSubjects.Enabled = true;
            dgvList.Enabled = true;
            cbFilter.Enabled = true;
            tpSubject.Cursor = Cursors.Default;
        }

        private void _FillComboBoxWithEducationLevels()
        {
            DataTable educationLevels = clsEductionLevel.AllOnlyNames();
            cbEducationLevels.Items.Clear();

            foreach (DataRow drTitle in educationLevels.Rows)
            {
                cbEducationLevels.Items.Add(drTitle["LevelName"].ToString());
            }

            if (cbEducationLevels.Items.Count > 0)
                cbEducationLevels.SelectedIndex = 0;
        }

        private void _FillFieldsWithTeacherInfo()
        {
            if (_teacher == null)
                return;

            ucPersonCard1._FillPersonData2(_teacher.PersonID);

            lblTeacherID.Text = _teacher.TeacherID.ToString();
            lblCreatedByUser.Text = _teacher.CreatedByUserInfo?.UserName ?? "N/A";
            txtCertifications.Text = _teacher.Certifications ?? "";
            numaricTeachingExperience.Value = (decimal)(_teacher.TeachingExperience ?? 0);

            int index = cbEducationLevels.FindString(clsEductionLevel.GetEducationLeveName(_teacher.EducationLevelID));
            if (index != -1)
                cbEducationLevels.SelectedIndex = index;
        }

        public void LoadData()
        {
            _teacher = clsTeacher.FindByTeacherID(_TeacherID);

            if (_teacher == null)
            {
                clsStandardMessages.ShowMissingDataMessage("teacher", _TeacherID);
                this.Close();
                return;
            }

            groupBox1.Enabled = false;
            txtSearch.Text = _teacher.TeacherID.ToString();
            _FillFieldsWithTeacherInfo();
        }

        private void frmAddEditAssignTeacherToSubject_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _FillComboBoxWithGradeLevels();
            _FillComboBoxWithSubjectsName();
            _FillComboBoxWithEducationLevels();


            cbFilter.SelectedIndex = 0;
            if (_mode == _enMode.Update)
                LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
                _RefreshSubjectGradeLevelsList();

            cbSubjects.Visible = (cbFilter.Text == "Subject");

            cbGrades.Visible = (cbFilter.Text == "Grade Level");

            if (cbSubjects.Visible)
                cbSubjects.SelectedIndex = 0;

            if (cbGrades.Visible)
                cbGrades.SelectedIndex = 0;
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllSubjects == null || _dtAllSubjects.Rows.Count == 0)
                return;

            if (cbSubjects.Text == "All")
            {
                _dtAllSubjects.DefaultView.RowFilter = "";

                return;
            }

            _dtAllSubjects.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", "SubjectName", cbSubjects.Text);
        }

        private void cbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllSubjects == null || _dtAllSubjects.Rows.Count == 0)
                return;

            if (cbGrades.Text == "All")
            {
                _dtAllSubjects.DefaultView.RowFilter = "";

                return;
            }

            _dtAllSubjects.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", "GradeName", cbGrades.Text);
        }

        private void _FillSubjectTeacherObjectWithFieldsData()
        {
            if (_subjectTeacher == null)
            {
                _subjectTeacher = new clsSubjectTeacher();
            }
            _subjectTeacher.TeacherID = _TeacherID;
            _subjectTeacher.SubjectGradeLevelID = _GetSubjectGradeLevelIDFromDGV();
            _subjectTeacher.IsActive = 1;
        }

        private void _SaveSubjectTeacher()
        {
            _FillSubjectTeacherObjectWithFieldsData();

            if (_subjectTeacher.Save())
            {
                lblTitle.Text = "Update Teacher Assignment to Subject";
                this.Text = lblTitle.Text;

                // change form mode to update
                _mode = _enMode.Update;

                clsStandardMessages.ShowSuccess("Subject Teacher");
            }
            else
            {
                clsStandardMessages.ShowError("Subject Teacher");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("You have to select a subject!", "Missing Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (MessageBox.Show($"Are you sure you want to assign the teacher with ID {_TeacherID}" +
                $" to the {_GetSubjectNameFromDGV()} subject for the {_GetGradeNameFromDGV()}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            //if (clsSubjectTeacher.IsTeachingSubject(_selectedTeacherID, _GetSubjectGradeLevelIDFromDGV()))
            //{
            //    MessageBox.Show("This teacher is currently teaching the specified subject.",
            //        "Teacher Subject Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return;
            //}

            _SaveSubjectTeacher();
        }
    }
}