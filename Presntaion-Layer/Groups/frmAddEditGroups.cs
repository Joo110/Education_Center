using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using Educational_Center.MettingTimes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Center.Groups
{
    public partial class frmAddEditGroups : Form
    {
        private enum _enMode { AddNew, Update };
        private _enMode _mode = _enMode.AddNew;

        public enum enEntityType { GroupID, ClassID }

        private int? _groupID = null;


        clsTeacher _teacher;
        clsGroup _group;

        private int? _selectedTeacherID = null;
        private int? _selectedClassID = null;

        public frmAddEditGroups()
        {
            InitializeComponent();
        }

        public frmAddEditGroups(int? value, enEntityType entityType)
        {
            InitializeComponent();

            switch (entityType)
            {
                case enEntityType.GroupID:
                    _groupID = value;
                    break;

                case enEntityType.ClassID:
                    _selectedClassID = value;
                    _mode = _enMode.AddNew;
                    return;

                default:
                    _groupID = value;
                    break;
            }

            _mode = _enMode.Update;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int classId))
                ucShowClassesDeatails1.LoadClassInfo(classId);
            else
                MessageBox.Show("Invalid Class ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _FillFieldsWithGroupInfo()
        {
            if (_group == null)
                return;

            lblGroupID.Text = _group.GroupID.ToString();
            label13.Text = _group.TeacherID.ToString();
            lblClassID.Text = _group.ClassID.ToString();
            lblSubjectGradeLevelID.Text = _group.SubjectTeacherInfo.SubjectGradeLevelID.ToString();
            lblMeetingTimeID.Text = _group.MeetingTimeID.ToString();
            lblStudentsCount.Text = _group.StudentCount.ToString();
            lblCreatedByUsername.Text = _group.CreatedByUserInfo.UserName;
        }

        private void _FillFieldsWithTeacherInfo()
        {
            if (_teacher == null)
                return;

            ucPersonCard1._FillPersonData2(_teacher.PersonID);
            lblTeacherID.Text = _teacher.TeacherID.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser?.UserName ?? "Unknown";
            lblCertifications.Text = _teacher.Certifications;
            lblTeachingExperience.Text = _teacher.TeachingExperience.ToString();
            lblCreationDate.Text = _teacher.CreationDate.ToString("yyyy-MM-dd");
            lblEducationLevel.Text = clsEductionLevel.GetEducationLeveName(_teacher.EducationLevelID);
        }

        public void LoadData()
        {
            if (!int.TryParse(textBox1.Text, out int teacherId))
            {
                MessageBox.Show("Invalid Teacher ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _teacher = clsTeacher.FindByTeacherID(teacherId);
            groupBox1.Enabled = false;

            if (_teacher == null)
            {
                clsStandardMessages.ShowMissingDataMessage("teacher", teacherId);
                this.Close();
                return;
            }

            _FillFieldsWithTeacherInfo();
            ucGetAllSubjectsTaughtByTeacher1._LoadSubjectTeacherInfoByID(_teacher.TeacherID.GetValueOrDefault());
        }

        private void _LoadTeacherInfo()
        {
            LoadDataTeacherByID(_selectedTeacherID.GetValueOrDefault());
            _group = new clsGroup();
        }

        public void LoadDataTeacherByID(int TeacherID)
        {         
            _teacher = clsTeacher.FindByTeacherID(TeacherID);
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;

            if (_teacher == null)
            {
                clsStandardMessages.ShowMissingDataMessage("teacher", TeacherID);
                this.Close();
                return;
            }

            _FillFieldsWithTeacherInfo();
            ucGetAllSubjectsTaughtByTeacher1._LoadSubjectTeacherInfoByID(_teacher.TeacherID.GetValueOrDefault());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddMeetingTime_Click(object sender, EventArgs e)
        {
            using (frmAddEditMeetingTime frm = new frmAddEditMeetingTime())
            {
                frm.ShowDialog();
            }
            _RefreshAllMeetingTimeDetails();
        }

        private int? _GetMeetingTimeIDFromDGV()
        {
            return dgvMeetingTimesList.SelectedRows.Count > 0
                ? dgvMeetingTimesList.CurrentRow.Cells["MeetingTimeID"].Value as int?
                : null;
        }

        private void _FillGroupObjectWithFieldsData()
        {
            if (_group == null || _mode == _enMode.AddNew)
                _group = new clsGroup();

            if (!int.TryParse(textBox1.Text, out int teacherID) ||
                !int.TryParse(txtSearch.Text, out int classID))
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _group.TeacherID = teacherID;
            _group.ClassID = classID;
            _group.SubjectTeacherID = ucGetAllSubjectsTaughtByTeacher1.SubjectTeacherID;
            _group.MeetingTimeID = _GetMeetingTimeIDFromDGV();
            _group.CreatedByUserID = clsGlobal.CurrentUser.UserID;
        }

        private void _ShowGroupInfo()
        {
            if (_group == null)
                return;

            lblGroupID.Text = _group.GroupID.ToString();
            lblClassID.Text = _group.ClassID.ToString();
            label13.Text = _group.TeacherID.ToString();
            lblStudentsCount.Text = _group.StudentCount.ToString();
            lblCreatedByUsername.Text =  clsGlobal.CurrentUser.UserName;
            lblSubjectGradeLevelID.Text = ucGetAllSubjectsTaughtByTeacher1?.SubjectGradeLevelID.ToString();
            lblMeetingTimeID.Text = _group.MeetingTimeID.ToString();
        }

        private void _SaveGroup()
        {
            _FillGroupObjectWithFieldsData();

            if (_group.Save())
            {
                lblTitle.Text = "Update Group";
                this.Text = lblTitle.Text;
                _mode = _enMode.Update;
                _ShowGroupInfo();
                clsStandardMessages.ShowSuccess("Group");
            }
            else
            {
                clsStandardMessages.ShowError("group");
            }
        }


        private void SelectMeetingRow(int meetingID)
        {
            foreach (DataGridViewRow row in dgvMeetingTimesList.Rows)
            {
                if (row.Cells["MeetingTimeID"].Value != null &&
                    Convert.ToInt32(row.Cells["MeetingTimeID"].Value) == meetingID)
                {
                    row.Selected = true;
                    dgvMeetingTimesList.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void _ResetDefaultValues()
        {
            if (_selectedClassID.HasValue)
            {
                ucShowClassesDeatails1.LoadClassInfo(_selectedClassID);
                txtSearch.Text = _selectedClassID.ToString();
                groupBox1.Enabled = false;
            }

            if (_mode == _enMode.AddNew)
            {
                lblTitle.Text = "Add New Group";
                _group = new clsGroup();


                lblStudentsCount.Text = "0";
                lblCreatedByUsername.Text = clsGlobal.CurrentUser?.UserName;

            }
            else
            {
                lblTitle.Text = "Update Group";
            }

            this.Text = lblTitle.Text;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsStandardMessages.ShowValidationErrorMessage();
                return;
            }

            _SaveGroup();
        }

        public void _RefreshAllMeetingTimeDetails()
        {
            var data = clsMeetingTime.GetAllMeetingTimeDetails();

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("No meeting times available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgvMeetingTimesList.DataSource = data;
        }

        private void _LoadClassInfo()
        {
            ucShowClassesDeatails1.LoadClassInfo(_selectedClassID);
            _group = new clsGroup();
        }

        private void _LoadData()
        {
            if (_selectedTeacherID.HasValue)
            {
                _LoadTeacherInfo();
                return;
            }

            if (_selectedClassID.HasValue)
            {
                _LoadClassInfo();
                return;
            }

            _group = clsGroup.Find(_groupID);

            if (_group == null)
            {
                clsStandardMessages.ShowMissingDataMessage("group", _groupID);

                this.Close();

                return;
            }
            textBox1.Text = _group.ClassID.ToString();
            txtSearch.Text = _group.TeacherID.ToString();

            LoadDataTeacherByID(_group.TeacherID.GetValueOrDefault());
            ucShowClassesDeatails1.LoadClassInfo(_group.ClassID);           

            _FillFieldsWithGroupInfo();

            SelectMeetingRow(_group.MeetingTimeID.GetValueOrDefault());
        }

        private void frmAddEditGroups_Load(object sender, EventArgs e)
        {
            _RefreshAllMeetingTimeDetails();
            _ResetDefaultValues();

            cbFilterMeetingTimeBy.SelectedIndex = 0;

            if (_mode == _enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
