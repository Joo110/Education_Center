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
    public partial class frmGetAllStudentsInGroup : Form
    {
        private int? _groupID = null;
        private string _groupName = null;

        public frmGetAllStudentsInGroup(int? groupID)
        {
            InitializeComponent();

            _groupID = groupID;

            ucGetAllStudentsInGroup1.LoadAllStudentsInGroup(groupID);
        }
    }
}
