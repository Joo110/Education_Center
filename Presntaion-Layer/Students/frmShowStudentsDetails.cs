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
    public partial class frmShowStudentsDetails : Form
    {
        public frmShowStudentsDetails(int StudentID)
        {
            InitializeComponent();
            ucStudentCard1.LoadStudentInfoStudentID(StudentID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
