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
    public partial class frmGetAllTeachersTeachSubject : Form
    {
        private int? _subjectGradeLevelID = null;

        public frmGetAllTeachersTeachSubject(int? subjectGradeLevelID)
        {
            InitializeComponent();
            _subjectGradeLevelID = subjectGradeLevelID;
            if (ucGetAllTeachersTeachSubject2 != null)
            {
                ucGetAllTeachersTeachSubject2.LoadAllTeachersTeachSubject(_subjectGradeLevelID.GetValueOrDefault());
            }
            else
            {
                MessageBox.Show("UserControl ucGetAllTeachersTeachSubject1 is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
