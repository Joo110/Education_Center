using DataBusiness_EC_;
using System;
using System.Data;
using System.Windows.Forms;

namespace Educational_Center.Teachers
{
    public partial class ucGetAllSubjectsTaughtByTeacherID : UserControl
    {
        private int? TeacherID = null;

        public ucGetAllSubjectsTaughtByTeacherID()
        {
            InitializeComponent();
        }

        public void LoadSubjectTeachersIsTeach(int? subjectGradeLevelID)
        {
            if (!subjectGradeLevelID.HasValue)
            {
                MessageBox.Show("Invalid subject grade level ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TeacherID = subjectGradeLevelID;

            DataTable dataSource = clsSubjectTeacher.GetSubjectsByTeacher(TeacherID.Value) as DataTable;

            if (dataSource == null || dataSource.Rows.Count == 0)
            {
                MessageBox.Show("No data available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvList.DataSource = dataSource;

            var columnsInfo = new[]
             {
                 ("Subject TeacherID", 250),
                 ("TeacherID", 150),
                 ("subjectGradeLevelID", 150),
                 ("Subject Name", 180),
                 ("Assigment Date", 200),
                 ("Is Active", 150)
             };

            for (int i = 0; i < columnsInfo.Length && i < dgvList.Columns.Count; i++)
            {
                dgvList.Columns[i].HeaderText = columnsInfo[i].Item1;
                dgvList.Columns[i].Width = columnsInfo[i].Item2;
            }
        }

        private int _GetTeacherIDFromDGV()
        {
            if (dgvList.CurrentRow?.Cells["TeacherID"].Value is int teacherID)
                return teacherID;

            throw new InvalidOperationException("No valid TeacherID selected.");
        }
    }
}