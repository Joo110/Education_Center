using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using Educational_Center.Groups;
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
    public partial class frmListStudents : Form
    {
        private DataTable _dtAllStudents = new DataTable();
        
        public frmListStudents()
        {
            InitializeComponent();
        }

        private void _FillComboBoxWithGradeLevels()
        {
            cbGrades.Items.Clear();

            cbGrades.Items.Add("All");

            DataTable gradeLevels = clsGradeLevel.GetAllGradeLevelsName();

            foreach (DataRow drTitle in gradeLevels.Rows)
            {
                cbGrades.Items.Add(drTitle["GradeName"].ToString());
            }
        }

        private string _GetRealColumnNameInDB()
        {
            switch (cbFilter.Text)
            {
                case "Student ID":
                    return "StudentID";

                case "Name":
                    return "FullName";

                case "Gender":
                    return "Gender";

                case "Grade":
                    return "Grade";

                case "Age":
                    return "Age";

                default:
                    return "None";
            }
        }

        public void _RefreshDataStudents()
        {
            _dtAllStudents = clsStudents.GetStudents();
            dgvStudents.DataSource = _dtAllStudents;

            txtSearch.Text = dgvStudents.Rows.Count.ToString();

            if (dgvStudents.Rows.Count > 0)
            {
                dgvStudents.Columns[0].HeaderText = "StudentID";
                dgvStudents.Columns[0].Width = 250;

                dgvStudents.Columns[1].HeaderText = "FullName";
                dgvStudents.Columns[1].Width = 350;
                
                dgvStudents.Columns[2].HeaderText = "Gendor";
                dgvStudents.Columns[2].Width = 200;
                
                dgvStudents.Columns[3].HeaderText = "DateOfBrith";
                dgvStudents.Columns[3].Width = 300;
            }
        }

        private void frmListStudents_Load(object sender, EventArgs e)
        {
            _FillComboBoxWithGradeLevels();
            _RefreshDataStudents();
            

            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cbFilter.Text != "None") &&
                                (cbFilter.Text != "Gender") &&
                                (cbFilter.Text != "Grade");

            cbGender.Visible = (cbFilter.Text == "Gender");

            cbGrades.Visible = (cbFilter.Text == "Grade");

            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }

            if (cbGender.Visible)
                cbGender.SelectedIndex = 0;

            if (cbGrades.Visible)
                cbGrades.SelectedIndex = 0;
        }

        private int _GetStudentIDFromDGV()
        {
            return (int)dgvStudents.CurrentRow.Cells["StudentID"].Value;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllStudents == null || _dtAllStudents.Rows.Count == 0)
                return;

            string columnName = _GetRealColumnNameInDB();

            if (string.IsNullOrWhiteSpace(txtSearch.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtAllStudents.DefaultView.RowFilter = "";
                label1.Text = dgvStudents.Rows.Count.ToString();

                return;
            }

            if (cbFilter.Text == "Student ID" || cbFilter.Text == "Age")
            {
                // search with numbers
                _dtAllStudents.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtSearch.Text.Trim());
            }
            else
            {
                // search with string
                _dtAllStudents.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", columnName, txtSearch.Text.Trim());
            }

            label1.Text = dgvStudents.Rows.Count.ToString();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Student ID" || cbFilter.Text == "Age")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllStudents == null || _dtAllStudents.Rows.Count == 0)
                return;

            if (cbGrades.Text == "All")
            {
                _dtAllStudents.DefaultView.RowFilter = "";
                label1.Text = dgvStudents.Rows.Count.ToString();

                return;
            }

            _dtAllStudents.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", "Grade", cbGrades.Text);

            label1.Text = dgvStudents.Rows.Count.ToString();
        }



        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllStudents == null || _dtAllStudents.Rows.Count == 0)
                return;

            if (cbGender.Text == "All")
            {
                _dtAllStudents.DefaultView.RowFilter = "";
                label1.Text = dgvStudents.Rows.Count.ToString();

                return;
            }

            _dtAllStudents.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", "Gender", cbGender.Text);

            label1.Text = dgvStudents.Rows.Count.ToString();
        }

        private void tsmShowStudentDetails_Click(object sender, EventArgs e)
        {
            frmShowStudentsDetails f = new frmShowStudentsDetails(_GetStudentIDFromDGV());
            f.ShowDialog();
        }

        private void tsmEditStudent_Click(object sender, EventArgs e)
        {
            frmAddEditStudent f = new frmAddEditStudent(_GetStudentIDFromDGV());
            f.ShowDialog();
        }

        private void tsmDeleteStudent_Click(object sender, EventArgs e)
        {
            if (clsStandardMessages.ShowDeleteConfirmation("student") == DialogResult.No)
                return;

            if (clsStudents.Delete(_GetStudentIDFromDGV()))
            {
                clsStandardMessages.ShowDeletionSuccess("student");

                _RefreshDataStudents();
            }
            else
                clsStandardMessages.ShowDeletionFailure("student", "Please check your permissions and try again.");
        }

        private void tsmAssignToGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditAssignStudentToGroup f = new frmAddEditAssignStudentToGroup(_GetStudentIDFromDGV());
                f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditStudent f = new frmAddEditStudent();
            f.ShowDialog();
            _RefreshDataStudents();
        }
    }
}
