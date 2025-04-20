using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Center.User
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            ucUserCard1.LoadUserInfoByPersonID(UserID);
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
