using Educational_Center.Classes;
using Educational_Center.DashBoard;
using Educational_Center.Groups;
using Educational_Center.Payments;
using Educational_Center.Settings;
using Educational_Center.Students;
using Educational_Center.Subjects;
using Educational_Center.Teachers;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Center.MainMenu
{
    public partial class FrmMainMenu : Form
    {
        private Guna2Button _currentButton;
        private Form _activeForm;
        private LoginScreen _loginScreen;

        public FrmMainMenu(LoginScreen loginScreen)
        {
            InitializeComponent();
            _loginScreen = loginScreen;
        }

        private void _ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Guna2Button)btnSender)
                {
                    _DisableMenuButton();
                    _currentButton = (Guna2Button)btnSender;
                    _currentButton.BackColor = Color.White;
                    _currentButton.ForeColor = Color.FromArgb(53, 41, 123);
                    _currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void _DisableMenuButton()
        {
            Guna2Button gunaButton = new Guna2Button();

            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2Button))
                {
                    gunaButton = (Guna2Button)previousBtn;

                    previousBtn.BackColor = Color.FromArgb(53, 41, 123);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private async void _OpenChildFormAsync(Form childForm, object btnSender)
        {
            await Task.Delay(100);

            _activeForm?.Close();

            _ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForms.Controls.Add(childForm);
            panelChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
                lblTitle.Text = childForm.Tag.ToString();

            else
                lblTitle.Text = childForm.Text;
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _OpenChildFormAsync(new frmDashBoard(_loginScreen, this), sender);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            _OpenChildFormAsync(new frmListStudents(), sender);
        }

        private void bntSubjects_Click(object sender, EventArgs e)
        {
            _OpenChildFormAsync(new frmListSubjectsGradeLevel(), sender);
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            _OpenChildFormAsync(new frmListTeachers(), sender);
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            _OpenChildFormAsync(new frmListClasses(), sender);
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            _OpenChildFormAsync(new frmListGroups(), sender);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            _OpenChildFormAsync(new frmListPayments(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _OpenChildFormAsync(new frmSettings(), sender);
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }
    }
}
