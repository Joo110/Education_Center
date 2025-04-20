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

namespace Educational_Center.Teachers
{
    public partial class ucGetAllTeachersTeachSubject : UserControl
    {
        private int? _subjectGradeLevelID = null;

        public ucGetAllTeachersTeachSubject()
        {
            InitializeComponent();
        }

        public void LoadAllTeachersTeachSubject(int? subjectGradeLevelID)
        {
            _subjectGradeLevelID = subjectGradeLevelID;

            DataTable dataSource = clsSubjectGradeLevel.GetAllTeachersTeachSubject(_subjectGradeLevelID.GetValueOrDefault()) as DataTable;

            if (dataSource == null)
            {
                         MessageBox.Show("No data available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
            }
             
                     dgvList.DataSource = dataSource;

            var columnsInfo = new[]
             {
                 ("Teacher ID", 110),
                 ("Full Name", 300),
                 ("Gender", 120),
                 ("Date Of Birth", 120),
                 ("Education Level", 160),
                 ("Age", 60)
             };
             
                     for (int i = 0; i < columnsInfo.Length && i < dgvList.Columns.Count; i++)
                     {
                         dgvList.Columns[i].HeaderText = columnsInfo[i].Item1;
                         dgvList.Columns[i].Width = columnsInfo[i].Item2;
                     }

                     string subjectName = clsSubject.GetSubjectNameBySubjectGradeLevelID(_subjectGradeLevelID) ?? "Unknown Subject";
            gbList.Text = $"Teachers are teaching {subjectName}";
        }

        private int _GetTeacherIDFromDGV()
        {
            return (int)dgvList.CurrentRow.Cells["TeacherID"].Value;
        }

        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTeacherInfo F = new frmShowTeacherInfo(_GetTeacherIDFromDGV());
              F.ShowDialog();
        }
    }
}
