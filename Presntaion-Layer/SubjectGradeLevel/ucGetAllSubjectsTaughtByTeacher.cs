using DataBusiness_EC_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Center.SubjectGradeLevel
{
    public partial class ucGetAllSubjectsTaughtByTeacher : UserControl
    {

        public int? SubjectTeacherID { get; private set; }
        public int? SubjectGradeLevelID => _GetSubjectGradeLevelIDFromDGV();

        public ucGetAllSubjectsTaughtByTeacher()
        {
            InitializeComponent();
            dgvList.SelectionChanged += dgvList_SelectionChanged;
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedValues();
        }

        private void UpdateSelectedValues()
        {
            if (dgvList.CurrentRow != null)
            {
                SubjectTeacherID = _GetSubjectTeacherIDFromDGV();
            }
            else
            {
                SubjectTeacherID = null;
            }
        }

        private int? _GetSubjectGradeLevelIDFromDGV()
        {
            return dgvList.CurrentRow?.Cells[2].Value is int value ? value : (int?)null;
        }

        private int? _GetSubjectTeacherIDFromDGV()
        {
            return dgvList.CurrentRow?.Cells[0].Value is int value ? value : (int?)null;
        }

        public void _LoadSubjectTeacherInfoByID(int? TeacherID)
        {
            dgvList.DataSource = clsSubjectTeacher.GetSubjectsByTeacher(TeacherID);

            if (dgvList.Columns.Count >= 6)
            {
                dgvList.Columns[0].HeaderText = "Subject Teacher ID";
                dgvList.Columns[0].Width = 250;

                dgvList.Columns[1].HeaderText = "Teacher ID";
                dgvList.Columns[1].Width = 250;

                dgvList.Columns[2].HeaderText = "Subject Grade Level ID";
                dgvList.Columns[2].Width = 250;

                dgvList.Columns[3].HeaderText = "Subject Name";
                dgvList.Columns[3].Width = 350;

                dgvList.Columns[4].HeaderText = "Assignment Date";
                dgvList.Columns[4].Width = 350;

                dgvList.Columns[5].HeaderText = "Is Active";
                dgvList.Columns[5].Width = 250;
            }

            UpdateSelectedValues();
        }

    }
}
