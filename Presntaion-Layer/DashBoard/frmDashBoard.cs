using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using Educational_Center.MainMenu;
using Educational_Center.User;
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

namespace Educational_Center.DashBoard
{
    public partial class frmDashBoard : Form
    {
        private LoginScreen _frmLoginForm;
        private FrmMainMenu _frmMainMenu;

        public frmDashBoard(LoginScreen loginScreen, FrmMainMenu mainMenu)
        {
            InitializeComponent();
            _RefreshDataGroups();
            _CountElements();

            GBScheduleOfToday.Text = $"Schedule of Today ({DateTime.Now.DayOfWeek})";

            _frmLoginForm = loginScreen;
            _frmMainMenu = mainMenu;
        }

        private void _CountElements()
        {
            lblNumberOfTeachers.Text = clsTeacher.GetAllTeacherCount().ToString();
            lblNumberOfUsers.Text = ClsUser.GetAllUsersCount().ToString();
            lblNumberOfClasses.Text = clsClasses.GetAllClassesCount().ToString();
        }

        public void _RefreshDataGroups()
        {
            dgvGroupsList.DataSource = clsGroup.GetTodaySchedule();

            label3.Text = dgvGroupsList.Rows.Count.ToString();

            if (dgvGroupsList.Rows.Count > 0)
            {
                dgvGroupsList.Columns[0].HeaderText = "Teacher";
                dgvGroupsList.Columns[0].Width = 280;

                dgvGroupsList.Columns[1].HeaderText = "Subject";
                dgvGroupsList.Columns[1].Width = 150;

                dgvGroupsList.Columns[2].HeaderText = "Class";
                dgvGroupsList.Columns[2].Width = 170;

                dgvGroupsList.Columns[3].HeaderText = "Date";
                dgvGroupsList.Columns[3].Width = 100;

                dgvGroupsList.Columns[4].HeaderText = "Time";
                dgvGroupsList.Columns[4].Width = 120;
            }
        }

        private void tsmShowUserDetails_Click(object sender, EventArgs e)
        {
            frmShowUserInfo F = new frmShowUserInfo(clsGlobal.CurrentUser.UserID.GetValueOrDefault());
            F.ShowDialog();
        }

        private void picInformation_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(picInformation, new Point(0, picInformation.Height));
        }

        private void tsmChangePassword_Click_1(object sender, EventArgs e)
        {
            frmChangePassword f = new frmChangePassword(clsGlobal.CurrentUser.UserID.GetValueOrDefault());
            f.ShowDialog();
        }

        private void tsmSignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmMainMenu.Hide();
            _frmLoginForm.Show();
            this.Close();
        }
    }
}
