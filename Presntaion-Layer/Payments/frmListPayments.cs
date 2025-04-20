using DataBusiness_EC_;
using Educational_Center.Groups;
using Educational_Center.Students;
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
using System.Configuration;

namespace Educational_Center.Payments
{
    public partial class frmListPayments : Form
    {
        private DataTable _dtAllPayments = new DataTable();
        private int _allPaymentsCount = 0;
        private readonly short _rowsPerPage = 0;

        public frmListPayments()
        {
            InitializeComponent();
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
        }

        private string _GetRealColumnNameInDB()
        {
            switch (cbFilter.Text)
            {
                case "Payment ID":
                    return "PaymentID";

                case "Student ID":
                    return "StudentID";

                case "Group ID":
                    return "GroupID";

                case "Subject Grade-Level ID":
                    return "SubjectGradeLevelID";

                case "Payment Amount":
                    return "PaymentAmount";

                case "Payment Date":
                    return "PaymentDate";

                default:
                    return "None";
            }
        }

        private void _RefreshPaymentsList()
        {
            cbFilter.SelectedIndex = 0;

            _dtAllPayments = clsPayments.GetAllPayments();

            dgvPaymentsList.DataSource = _dtAllPayments;

            lblNumberOfRecords.Text = dgvPaymentsList.Rows.Count.ToString();

            if (dgvPaymentsList.Rows.Count > 0)
            {
                dgvPaymentsList.Columns[0].HeaderText = "Payment ID";
                dgvPaymentsList.Columns[0].Width = 140;

                dgvPaymentsList.Columns[1].HeaderText = "Student ID";
                dgvPaymentsList.Columns[1].Width = 140;

                dgvPaymentsList.Columns[2].HeaderText = "Group ID";
                dgvPaymentsList.Columns[2].Width = 135;

                dgvPaymentsList.Columns[3].HeaderText = "Subject Grade-Level ID";
                dgvPaymentsList.Columns[3].Width = 300;

                dgvPaymentsList.Columns[4].HeaderText = "Payment Amount";
                dgvPaymentsList.Columns[4].Width = 300;

                dgvPaymentsList.Columns[5].HeaderText = "Payment Date";
                dgvPaymentsList.Columns[5].Width = 300;
            }
        }

        private int? _GetNumericValueFromDGV(string columnName)
        {
            return (int?)dgvPaymentsList.CurrentRow.Cells[columnName].Value;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cbFilter.Text != "None");

            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllPayments == null || _dtAllPayments.Rows.Count == 0)
                return;

            string columnName = _GetRealColumnNameInDB();

            if (string.IsNullOrWhiteSpace(txtSearch.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtAllPayments.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvPaymentsList.Rows.Count.ToString();

                return;
            }

            // search with numbers
            _dtAllPayments.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtSearch.Text.Trim());

            lblNumberOfRecords.Text = dgvPaymentsList.Rows.Count.ToString();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // make sure that the user can only enter the numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RefreshPaymentsList();
            cbFilter.SelectedIndex = 0;
        }

        private void frmListPayments_Load(object sender, EventArgs e)
        {
            _RefreshPaymentsList();

            cbFilter.SelectedIndex = 0;
        }

        private void ShowStudentDetailsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmShowStudentsDetails showStudentInfo = new frmShowStudentsDetails(_GetNumericValueFromDGV("StudentsID").GetValueOrDefault());
            showStudentInfo.ShowDialog();
        }

        private void ShowGroupDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmShowGroupInfo showGroupInfo = new frmShowGroupInfo(_GetNumericValueFromDGV("GroupID"));
            showGroupInfo.ShowDialog();
        }

        private void ShowSubjectGradeLevelDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowSubjectGradeLevelInfo showSubjectGradeLevelInfo = new ShowSubjectGradeLevelInfo(_GetNumericValueFromDGV("SubjectGradeLevelID"));
            showSubjectGradeLevelInfo.ShowDialog();
        }
    }
}
