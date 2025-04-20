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
    public partial class frmGetAllTeachersTeachInClass : Form
    {
        public frmGetAllTeachersTeachInClass(int? ClassID)
        {
            InitializeComponent();
            ucGetAllTeachersTeachInClass1.LoadAllTeachersTeachSubject(ClassID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
