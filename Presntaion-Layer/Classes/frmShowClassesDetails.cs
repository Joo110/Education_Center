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
    public partial class frmShowClassesDetails : Form
    {
        int? _ClassID = -1;
        public frmShowClassesDetails(int? ClassID)
        {
            InitializeComponent();
            _ClassID = ClassID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowClassesDetails_Load(object sender, EventArgs e)
        {
            ucShowClassesDeatails1.LoadClassInfo(_ClassID);
        }
    }
}
