using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using Guna.UI2.WinForms;
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
    public partial class frmAddEditAssignStudentToGroup : Form
    {
        private DataTable _dtAllGroups = new DataTable();
        private enum _enMode { AddNew, Update };
        private _enMode _mode = _enMode.AddNew;

        public enum enEntityType { StudentID, GroupID, StudentGroupID }

        private int? _studentGroupID = null;
        private clsStudentGroups _studentGroup = null;

        private int? _selectedStudentID = null;
        private int? _groupID = null;

        public frmAddEditAssignStudentToGroup(int StudentID)
        {
            InitializeComponent();
            _selectedStudentID = StudentID;
            _mode = _enMode.AddNew;
            btnSave.Enabled = true;
        }

        private void _FillComboBoxWithSubjectsName()
        {
            cbSubjectNames.Items.Clear();

            cbSubjectNames.Items.Add("All");

            DataTable subjectNames = clsSubject.GetAllSubjectName();

            foreach (DataRow drTitle in subjectNames.Rows)
            {
                cbSubjectNames.Items.Add(drTitle["SubjectName"].ToString());
            }
        }

        private void _FillComboBoxWithGroupNames()
        {
            cbGroupNames.Items.Clear();

            cbGroupNames.Items.Add("All");

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                cbGroupNames.Items.Add(letter);
            }
        }

        private string _GetRealColumnNameInDB()
        {
            switch (cbFilter.Text)
            {
                case "Group ID":
                    return "GroupID";

                case "Group Name":
                    return "GroupName";

                case "Class Name":
                    return "ClassName";

                case "Teacher Name":
                    return "TeacherName";

                case "Subject Name":
                    return "SubjectName";

                case "Meeting Days":
                    return "MeetingDays";

                default:
                    return "None";
            }
        }

        private void _RefreshGroupsList()
        {
            if (_groupID.HasValue)
                return;

            if (_selectedStudentID != null)
                _dtAllGroups = clsStudentGroups.GetAvailableGroups(_selectedStudentID.GetValueOrDefault());

            dgvGroupsList.DataSource = _dtAllGroups;

            if (dgvGroupsList.Rows.Count > 0)
            {
                dgvGroupsList.Columns[0].HeaderText = "Group ID";
                dgvGroupsList.Columns[0].Width = 110;

                dgvGroupsList.Columns[1].HeaderText = "Class Name";
                dgvGroupsList.Columns[1].Width = 200;

                dgvGroupsList.Columns[2].HeaderText = "Teacher Name";
                dgvGroupsList.Columns[2].Width = 250;

                dgvGroupsList.Columns[3].HeaderText = "Subject Name";
                dgvGroupsList.Columns[3].Width = 200;

                dgvGroupsList.Columns[4].HeaderText = "Grade Name";
                dgvGroupsList.Columns[4].Width = 170;

                dgvGroupsList.Columns[5].HeaderText = "Start Time";
                dgvGroupsList.Columns[5].Width = 120;

                dgvGroupsList.Columns[6].HeaderText = "End Time";
                dgvGroupsList.Columns[6].Width = 120;

                dgvGroupsList.Columns[7].HeaderText = "Meeting Days";
                dgvGroupsList.Columns[7].Width = 120;

                dgvGroupsList.Columns[8].HeaderText = "Students Count";
                dgvGroupsList.Columns[8].Width = 160;

                dgvGroupsList.Columns[9].HeaderText = "Fees";
                dgvGroupsList.Columns[9].Width = 100;

                dgvGroupsList.Columns[10].HeaderText = "Is Active";
                dgvGroupsList.Columns[10].Width = 80;
            }
        }

        private int? _GetGroupIDFromDGV()
        {
            return (int?)dgvGroupsList?.CurrentRow?.Cells["GroupID"]?.Value;
        }

        private decimal? _GetFeesFromDGV()
        {
            return (decimal?)dgvGroupsList?.CurrentRow?.Cells["Fees"]?.Value ?? null;
        }

        private void _FilterComboBox(Guna2ComboBox comboBox, string entityName)
        {
            if (_dtAllGroups == null || _dtAllGroups.Rows.Count == 0 || comboBox == null)
                return;

            if (comboBox.Text == "All")
            {
                _dtAllGroups.DefaultView.RowFilter = "";

                return;
            }

            _dtAllGroups.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", entityName, comboBox.Text);
        }
        

        private void _DisableTabPageSubject()
        {
            cbGroupNames.Enabled = false;
            cbMeetingDays.Enabled = false;
            cbSubjectNames.Enabled = false;
            txtSearch.Enabled = false;
            dgvGroupsList.Enabled = false;
            cbFilter.Enabled = false;
            tpGroup.Cursor = Cursors.No;
        }

        private void _EnableTabPageSubject()
        {
            cbGroupNames.Enabled = true;
            cbMeetingDays.Enabled = true;
            cbSubjectNames.Enabled = true;
            txtSearch.Enabled = true;
            dgvGroupsList.Enabled = true;
            cbFilter.Enabled = true;
            tpGroup.Cursor = Cursors.Default;
        }

        private void _LoadData()
        {
            if (_selectedStudentID.HasValue)
            {
                ucStudentCard1.LoadStudentInfoStudentID(_selectedStudentID.GetValueOrDefault());
                groupBox1.Enabled = false;
                _studentGroup = new clsStudentGroups();
                return;
            }

            _studentGroup = clsStudentGroups.Find(_studentGroupID);
            groupBox1.Enabled = false;

            if (_studentGroup == null)
            {
                clsStandardMessages.ShowMissingDataMessage("Student Group", _studentGroupID);
                this.Close();
                return;
            }

            ucStudentCard1.LoadStudentInfoStudentID(_studentGroup.StudentID.GetValueOrDefault());
        }

        private void _FillStudentGroupObjectWithFieldsData()
        {
            if (_studentGroup == null)
                _studentGroup = new clsStudentGroups();

            _studentGroup.StudentID = _selectedStudentID;

            if (dgvGroupsList.Rows.Count > 0)
                _studentGroup.GroupID = _GetGroupIDFromDGV();
            else if (_groupID.HasValue)
                _studentGroup.GroupID = _groupID;

            _studentGroup.IsActive = true;
            _studentGroup.CreatedByUserID = clsGlobal.CurrentUser?.UserID;
        }

        private void _SaveStudentGroup()
        {
            _FillStudentGroupObjectWithFieldsData();

            if (_studentGroup.Save())
            {
                lblTitle.Text = "Update Student Assignment to Group";
                this.Text = lblTitle.Text;

                // change form mode to update
                _mode = _enMode.Update;

                clsStandardMessages.ShowSuccess("Student Group");

            }
            else
            {
                clsStandardMessages.ShowError("Student Group");
            }
            }  

            private void frmAddEditAssignStudentToGroup_Load(object sender, EventArgs e)
        {
            if (_selectedStudentID.HasValue)
            {
                textBox1.Text = _selectedStudentID.Value.ToString();
                ucStudentCard1.LoadStudentInfoStudentID(_selectedStudentID.GetValueOrDefault());
                groupBox1.Enabled = false;
                _RefreshGroupsList();
            }
            else
            {
                MessageBox.Show("No student ID selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Group ID")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbGroupNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterComboBox(cbGroupNames, "GroupName");
        }

        private void cbMeetingDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterComboBox(cbMeetingDays, "MeetingDays");
        }

        private void cbSubjectNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterComboBox(cbSubjectNames, "SubjectName");
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
                _RefreshGroupsList();

            txtSearch.Visible = (cbFilter.Text != "None") &&
                                (cbFilter.Text != "Group Name") &&
                                (cbFilter.Text != "Subject Name") &&
                                (cbFilter.Text != "Meeting Days") &&
                                (cbFilter.Text != "Is Active");

            cbGroupNames.Visible = (cbFilter.Text == "Group Name");
            cbSubjectNames.Visible = (cbFilter.Text == "Subject Name");
            cbMeetingDays.Visible = (cbFilter.Text == "Meeting Days");

            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }

            if (cbGroupNames.Visible)
                cbGroupNames.SelectedIndex = 0;

            if (cbSubjectNames.Visible)
                cbSubjectNames.SelectedIndex = 0;

            if (cbMeetingDays.Visible)
                cbMeetingDays.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_groupID.HasValue && dgvGroupsList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("You have to select a subject!", "Missing Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            decimal? fees = _GetFeesFromDGV();
            decimal displayFees = (fees) ?? (clsGroup.GetSubjectFeesByGroupID(_groupID));

            string message = $"The student with ID {_selectedStudentID} has to pay {displayFees:C2}. Are you sure " +
                             $"you want to assign them to the group with ID {_groupID ?? _GetGroupIDFromDGV()}?";

            if (MessageBox.Show(message, "Confirm",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            _SaveStudentGroup();
        }
    }
}
