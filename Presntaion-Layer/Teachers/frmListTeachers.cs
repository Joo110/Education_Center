using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using Educational_Center.SubjectGradeLevel;
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
    public partial class frmListTeachers : Form
    {
        private DataTable _dtAllTeachers = new DataTable();

        public frmListTeachers()
        {
            InitializeComponent();
        }

        private void _FillComboBoxWithEducationLevels()
        {
            cbEducationLevels.Items.Clear();

            cbEducationLevels.Items.Add("All");

            DataTable educationLevels = clsEductionLevel.AllOnlyNames();

            foreach (DataRow drTitle in educationLevels.Rows)
            {
                cbEducationLevels.Items.Add(drTitle["LevelName"].ToString());
            }
        }

        private string _GetRealColumnNameInDB()
        {
            switch (cbFilter.Text)
            {
                case "Teacher ID":
                    return "TeacherID";

                case "Name":
                    return "FullName";

                case "Gender":
                    return "Gender";

                case "Education Level":
                    return "EducationLevel";

                default:
                    return "None";
            }
        }

        private void _RefreshTeachersList()
        {
            cbFilter.SelectedIndex = 0;

            _dtAllTeachers = clsTeacher.GetTeacherDeatils();

            dgvTeachersList.DataSource = _dtAllTeachers;

            lblNumberOfRecords.Text = dgvTeachersList.Rows.Count.ToString();

            if (dgvTeachersList.Rows.Count > 0)
            {
                dgvTeachersList.Columns[0].HeaderText = "Teacher ID";
                dgvTeachersList.Columns[0].Width = 100;

                dgvTeachersList.Columns[1].HeaderText = "Full Name";
                dgvTeachersList.Columns[1].Width = 300;

                dgvTeachersList.Columns[2].HeaderText = "Gender";
                dgvTeachersList.Columns[2].Width = 80;

                dgvTeachersList.Columns[3].HeaderText = "Date Of Birth";
                dgvTeachersList.Columns[3].Width = 100;

                dgvTeachersList.Columns[4].HeaderText = "Education Level";
                dgvTeachersList.Columns[4].Width = 180;
            }
        }

        private int _GetTeacherIDFromDGV()
        {
            return (int)dgvTeachersList.CurrentRow.Cells["TeacherID"].Value;
        }

        private void frmListTeachers_Load(object sender, EventArgs e)
        {
            _RefreshTeachersList();
            //_FillComboBoxWithEducationLevels();

            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cbFilter.Text != "None") &&
                               (cbFilter.Text != "Gender") &&
                               (cbFilter.Text != "Education Level");

            cbGender.Visible = (cbFilter.Text == "Gender");

            cbEducationLevels.Visible = (cbFilter.Text == "Education Level");

            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }

            if (cbGender.Visible)
                cbGender.SelectedIndex = 0;

            if (cbEducationLevels.Visible)
                cbEducationLevels.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllTeachers == null || _dtAllTeachers.Rows.Count == 0)
                return;

            string columnName = _GetRealColumnNameInDB();

            if (string.IsNullOrWhiteSpace(txtSearch.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtAllTeachers.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvTeachersList.Rows.Count.ToString();

                return;
            }

            if (cbFilter.Text == "Teacher ID" || cbFilter.Text == "Age")
            {
                // search with numbers
                _dtAllTeachers.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtSearch.Text.Trim());
            }
            else
            {
                // search with string
                _dtAllTeachers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", columnName, txtSearch.Text.Trim());
            }

            lblNumberOfRecords.Text = dgvTeachersList.Rows.Count.ToString();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Teacher ID" || cbFilter.Text == "Age")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbEducationLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllTeachers == null || _dtAllTeachers.Rows.Count == 0)
                return;

            if (cbEducationLevels.Text == "All")
            {
                _dtAllTeachers.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvTeachersList.Rows.Count.ToString();

                return;
            }

            // Handling single quotes by escaping them with an additional single quote.
            _dtAllTeachers.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", "EducationLevel", cbEducationLevels.Text.Replace("'", "''"));

            lblNumberOfRecords.Text = dgvTeachersList.Rows.Count.ToString();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllTeachers == null || _dtAllTeachers.Rows.Count == 0)
                return;

            if (cbGender.Text == "All")
            {
                _dtAllTeachers.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvTeachersList.Rows.Count.ToString();

                return;
            }

            _dtAllTeachers.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", "Gender", cbGender.Text);

            lblNumberOfRecords.Text = dgvTeachersList.Rows.Count.ToString();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            frmAddEditTeacher frmAddEditTeacher = new frmAddEditTeacher();
            frmAddEditTeacher.ShowDialog();
            _RefreshTeachersList();
        }

        private void tsmEditTeacher_Click(object sender, EventArgs e)
        {
            frmAddEditTeacher frmAddEditTeacher = new frmAddEditTeacher(_GetTeacherIDFromDGV());
            frmAddEditTeacher.ShowDialog();
            _RefreshTeachersList();
        }

        private void temDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (clsStandardMessages.ShowDeleteConfirmation("student") == DialogResult.No)
                return;

            if (clsTeacher.Delete(_GetTeacherIDFromDGV()))
            {
                clsStandardMessages.ShowDeletionSuccess("student");

                _RefreshTeachersList();
            }
            else
                clsStandardMessages.ShowDeletionFailure("student", "Please check your permissions and try again.");
        }

        private void tsmShowTeacherDetails_Click(object sender, EventArgs e)
        {
            frmShowTeacherInfo f = new frmShowTeacherInfo(_GetTeacherIDFromDGV());
                f.ShowDialog();
        }

        private void tsmAssignToSubject_Click(object sender, EventArgs e)
        {
            frmAddEditAssignTeacherToSubject F = new frmAddEditAssignTeacherToSubject(_GetTeacherIDFromDGV());
            F.ShowDialog();
        }

        private void SubjectsHeTeachesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGetAllSubjectsTaughtByTeacher f = new frmGetAllSubjectsTaughtByTeacher(_GetTeacherIDFromDGV());
                f.ShowDialog();
        }
    }
}
