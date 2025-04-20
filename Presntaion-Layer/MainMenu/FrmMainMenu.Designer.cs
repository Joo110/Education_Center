namespace Educational_Center.MainMenu
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPayments = new Guna.UI2.WinForms.Guna2Button();
            this.bntSubjects = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudents = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnClasses = new Guna.UI2.WinForms.Guna2Button();
            this.btnGroups = new Guna.UI2.WinForms.Guna2Button();
            this.btnTeachers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.panelChildForms = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForms.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnPayments);
            this.panelMenu.Controls.Add(this.bntSubjects);
            this.panelMenu.Controls.Add(this.btnStudents);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnClasses);
            this.panelMenu.Controls.Add(this.btnGroups);
            this.panelMenu.Controls.Add(this.btnTeachers);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(218, 749);
            this.panelMenu.TabIndex = 21;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnPayments.BorderRadius = 22;
            this.btnPayments.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPayments.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPayments.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnPayments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Image = global::Educational_Center.Properties.Resources.payments_white_64;
            this.btnPayments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayments.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnPayments.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPayments.Location = new System.Drawing.Point(0, 570);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPayments.Size = new System.Drawing.Size(218, 43);
            this.btnPayments.TabIndex = 30;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseTransparentBackground = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // bntSubjects
            // 
            this.bntSubjects.BackColor = System.Drawing.Color.Transparent;
            this.bntSubjects.BorderRadius = 22;
            this.bntSubjects.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bntSubjects.CheckedState.FillColor = System.Drawing.Color.White;
            this.bntSubjects.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bntSubjects.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bntSubjects.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bntSubjects.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntSubjects.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bntSubjects.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bntSubjects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bntSubjects.ForeColor = System.Drawing.Color.White;
            this.bntSubjects.Image = global::Educational_Center.Properties.Resources.subjects_white_64;
            this.bntSubjects.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bntSubjects.ImageOffset = new System.Drawing.Point(-5, 0);
            this.bntSubjects.ImageSize = new System.Drawing.Size(40, 40);
            this.bntSubjects.Location = new System.Drawing.Point(0, 360);
            this.bntSubjects.Name = "bntSubjects";
            this.bntSubjects.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bntSubjects.Size = new System.Drawing.Size(218, 43);
            this.bntSubjects.TabIndex = 29;
            this.bntSubjects.Text = "Subjects";
            this.bntSubjects.UseTransparentBackground = true;
            this.bntSubjects.Click += new System.EventHandler(this.bntSubjects_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnStudents.BorderRadius = 22;
            this.btnStudents.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudents.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStudents.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnStudents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudents.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Image = global::Educational_Center.Properties.Resources.students_white_64;
            this.btnStudents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudents.ImageSize = new System.Drawing.Size(35, 35);
            this.btnStudents.Location = new System.Drawing.Point(0, 220);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnStudents.Size = new System.Drawing.Size(218, 43);
            this.btnStudents.TabIndex = 21;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseTransparentBackground = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderRadius = 22;
            this.btnSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSettings.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSettings.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::Educational_Center.Properties.Resources.settings_white_64;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnSettings.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSettings.Location = new System.Drawing.Point(0, 640);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(218, 43);
            this.btnSettings.TabIndex = 18;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseTransparentBackground = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnClasses
            // 
            this.btnClasses.BackColor = System.Drawing.Color.Transparent;
            this.btnClasses.BorderRadius = 22;
            this.btnClasses.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnClasses.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnClasses.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnClasses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClasses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClasses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClasses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClasses.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClasses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClasses.ForeColor = System.Drawing.Color.White;
            this.btnClasses.Image = global::Educational_Center.Properties.Resources.classes_white_64;
            this.btnClasses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClasses.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnClasses.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClasses.Location = new System.Drawing.Point(0, 430);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClasses.Size = new System.Drawing.Size(218, 43);
            this.btnClasses.TabIndex = 23;
            this.btnClasses.Text = "Classes";
            this.btnClasses.UseTransparentBackground = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.BackColor = System.Drawing.Color.Transparent;
            this.btnGroups.BorderRadius = 22;
            this.btnGroups.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGroups.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnGroups.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnGroups.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGroups.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGroups.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGroups.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGroups.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGroups.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGroups.ForeColor = System.Drawing.Color.White;
            this.btnGroups.Image = global::Educational_Center.Properties.Resources.groups_white_64;
            this.btnGroups.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGroups.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnGroups.ImageSize = new System.Drawing.Size(35, 35);
            this.btnGroups.Location = new System.Drawing.Point(0, 500);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGroups.Size = new System.Drawing.Size(218, 43);
            this.btnGroups.TabIndex = 20;
            this.btnGroups.Text = "Groups";
            this.btnGroups.UseTransparentBackground = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.Transparent;
            this.btnTeachers.BorderRadius = 22;
            this.btnTeachers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTeachers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTeachers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnTeachers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTeachers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTeachers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTeachers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTeachers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTeachers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTeachers.ForeColor = System.Drawing.Color.White;
            this.btnTeachers.Image = global::Educational_Center.Properties.Resources.teachers_white_64;
            this.btnTeachers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTeachers.ImageSize = new System.Drawing.Size(35, 35);
            this.btnTeachers.Location = new System.Drawing.Point(0, 290);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTeachers.Size = new System.Drawing.Size(218, 43);
            this.btnTeachers.TabIndex = 22;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseTransparentBackground = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDashboard.BorderRadius = 22;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Educational_Center.Properties.Resources.dashboard_white_64;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(0, 150);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(218, 43);
            this.btnDashboard.TabIndex = 17;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseTransparentBackground = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(218, 124);
            this.panelLogo.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Educational_Center.Properties.Resources.study_center_white_125;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 124);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Educational";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Center";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderRadius = 22;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::Educational_Center.Properties.Resources.logout_white_64;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(0, 773);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(218, 43);
            this.btnLogOut.TabIndex = 28;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseTransparentBackground = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelChildForms
            // 
            this.panelChildForms.BackColor = System.Drawing.Color.White;
            this.panelChildForms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panelChildForms.BorderRadius = 10;
            this.panelChildForms.Controls.Add(this.panelTitle);
            this.panelChildForms.Location = new System.Drawing.Point(219, 0);
            this.panelChildForms.Name = "panelChildForms";
            this.panelChildForms.Size = new System.Drawing.Size(1136, 977);
            this.panelChildForms.TabIndex = 24;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1136, 50);
            this.panelTitle.TabIndex = 22;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1082, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.panelChildForms);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForms.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Button btnPayments;
        private Guna.UI2.WinForms.Guna2Button bntSubjects;
        private Guna.UI2.WinForms.Guna2Button btnStudents;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnClasses;
        private Guna.UI2.WinForms.Guna2Button btnGroups;
        private Guna.UI2.WinForms.Guna2Button btnTeachers;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel panelChildForms;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}