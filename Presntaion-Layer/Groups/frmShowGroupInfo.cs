using System;
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
    public partial class frmShowGroupInfo : Form
    {
        int? _GroupID;
        public frmShowGroupInfo(int? GroupID)
        {
            InitializeComponent();
            _GroupID = GroupID;
            ucGroupInfo1.LoadGroupInfo(GroupID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
