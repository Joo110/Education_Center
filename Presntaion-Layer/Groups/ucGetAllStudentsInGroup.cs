using DataBusiness_EC_;
using System;
using System.Collections;
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
    public partial class ucGetAllStudentsInGroup : UserControl
    {
        private int? _groupID = null;
        private string _groupName = null;

        public ucGetAllStudentsInGroup()
        {
            InitializeComponent();
        }

        private void _LoadInfo(string title)
        {
            DataTable dataSource = clsGroup.GetAllStudentsInGroup(_groupID.GetValueOrDefault());

            if (dataSource.Rows.Count == 0)
            {
                MessageBox.Show("No students found in this group.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvList.DataSource = dataSource;
            gbList.Text = title;

            var columnsInfo = new (string name, int width)[]
            {
        ("Student ID", 110),
        ("Full Name", 300),
        ("Gender", 120),
        ("Date Of Birth", 120),
        ("Grade", 130),
        ("Age", 60)
            };

            for (int i = 0; i < columnsInfo.Length; i++)
            {
                dgvList.Columns[i].HeaderText = columnsInfo[i].name;
                dgvList.Columns[i].Width = columnsInfo[i].width;
            }
        }

        public void LoadAllStudentsInGroup(int? groupID)
        {
            _groupID = groupID;
            _LoadInfo("Students are in the group");
        }

    }
}
