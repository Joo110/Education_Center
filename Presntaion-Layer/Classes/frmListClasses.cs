using DataBusiness_EC_;
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

namespace Educational_Center.Classes
{
    public partial class frmListClasses : Form
    {
        private DataTable _dtAllClasses = new DataTable();

        public frmListClasses()
        {
            InitializeComponent();
            _RefreshClassesList();
        }

        private string _GetRealColumnNameInDB()
        {
            switch (cbFilter.Text)
            {
                case "Class ID":
                    return "ClassID";

                case "Class Name":
                    return "ClassName";

                default:
                    return "None";
            }
        }

        private void _RefreshClassesList()
        {
            cbFilter.SelectedIndex = 0;

            _dtAllClasses = clsClasses.AllInPages();

            dgvClassesList.DataSource = _dtAllClasses;

            lblNumberOfRecords.Text = dgvClassesList.Rows.Count.ToString();

            if (dgvClassesList.Rows.Count > 0)
            {
                dgvClassesList.Columns[0].HeaderText = "Class ID";
                dgvClassesList.Columns[0].Width = 110;

                dgvClassesList.Columns[1].HeaderText = "Class Name";
                dgvClassesList.Columns[1].Width = 200;

                dgvClassesList.Columns[2].HeaderText = "Capacity";
                dgvClassesList.Columns[2].Width = 220;
            }
        }

        private int? _GetClassIDFromDGV()
        {
            return (int?)dgvClassesList.CurrentRow.Cells["ClassID"].Value;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
                _RefreshClassesList();

            txtSearch.Visible = (cbFilter.Text != "None");

            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllClasses == null || _dtAllClasses.Rows.Count == 0)
                return;

            string columnName = _GetRealColumnNameInDB();

            if (string.IsNullOrWhiteSpace(txtSearch.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtAllClasses.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvClassesList.Rows.Count.ToString();

                return;
            }

            if (cbFilter.Text == "Class ID")
            {
                // search with numbers
                _dtAllClasses.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtSearch.Text.Trim());
            }
            else
            {
                // search with string
                _dtAllClasses.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", columnName, txtSearch.Text.Trim());
            }

            lblNumberOfRecords.Text = dgvClassesList.Rows.Count.ToString();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Class ID")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void frmListClasses_Load(object sender, EventArgs e)
        {
            _RefreshClassesList();
        }

        private void tsmShowClassDetails_Click(object sender, EventArgs e)
        {
            frmShowClassesDetails frmListClasses = new frmShowClassesDetails(_GetClassIDFromDGV());
            frmListClasses.ShowDialog();
        }

        private void tsmEditClass_Click(object sender, EventArgs e)
        {
            frmAddEditNewCalss f = new frmAddEditNewCalss(_GetClassIDFromDGV());
            f.ShowDialog();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            frmAddEditNewCalss f = new frmAddEditNewCalss();
            f.ShowDialog();
        }

        private void AddGroupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddEditGroups frmAddEditGroups = new frmAddEditGroups(_GetClassIDFromDGV(), frmAddEditGroups.enEntityType.ClassID);
            frmAddEditGroups.ShowDialog();
        }

        private void ShowGroupsAndWhoTeachesInItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGetAllTeachersTeachInClass f = new frmGetAllTeachersTeachInClass(_GetClassIDFromDGV());
            f.ShowDialog();
        }
    }
}
