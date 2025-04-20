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
    public partial class ShowSubjectGradeLevelInfo : Form
    {
        public ShowSubjectGradeLevelInfo(int? SubjectGradeLevelID)
        {
            InitializeComponent();
            ucSubjectGradeLevelCard1.LoadSubjectGradeLevelInfo(SubjectGradeLevelID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
