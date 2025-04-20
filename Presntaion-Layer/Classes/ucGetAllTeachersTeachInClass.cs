using DataBusiness_EC_;
using System;
using System.Data;
using System.Windows.Forms;

namespace Educational_Center.Classes
{
    public partial class ucGetAllTeachersTeachInClass : UserControl
    {
        int? _classID = null;

        public ucGetAllTeachersTeachInClass()
        {
            InitializeComponent();
        }

        public void LoadAllTeachersTeachSubject(int? classID)
        {
            _classID = classID;

            DataTable dtTeachers = clsClasses.GetTeachersByClass(_classID.GetValueOrDefault());

            if (dtTeachers == null || dtTeachers.Rows.Count == 0)
            {
                MessageBox.Show("No teachers found for this class.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvList.DataSource = dtTeachers;
            dgvList.Columns[0].HeaderText = "Teacher ID";
            dgvList.Columns[0].Width = 110;
            dgvList.Columns[1].HeaderText = "Full Name";
            dgvList.Columns[1].Width = 300;
            dgvList.Columns[2].HeaderText = "Class ID";
            dgvList.Columns[2].Width = 120;
            dgvList.Columns[3].HeaderText = "Group ID";
            dgvList.Columns[3].Width = 120;
            dgvList.Columns[4].HeaderText = "Group Name";
            dgvList.Columns[4].Width = 160;
            dgvList.Columns[5].HeaderText = "Subject Name";
            dgvList.Columns[5].Width = 150;
            dgvList.Columns[6].HeaderText = "Grade Name";
            dgvList.Columns[6].Width = 120;

            gbList.Text = "Teachers are teaching in the class";
        }
    }
}