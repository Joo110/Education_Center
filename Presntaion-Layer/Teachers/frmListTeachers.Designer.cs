namespace Educational_Center.Teachers
{
    partial class frmListTeachers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbEducationLevels = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvTeachersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsEditProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowTeacherDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.temDeleteTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAssignToSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.SubjectsHeTeachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersList)).BeginInit();
            this.cmsEditProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderColor = System.Drawing.Color.Gray;
            this.txtSearch.BorderRadius = 17;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtSearch.Location = new System.Drawing.Point(349, 304);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(273, 36);
            this.txtSearch.TabIndex = 226;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbFilter.BorderRadius = 17;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbFilter.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Teacher ID",
            "Name",
            "Gender",
            "Education Level",
            "Age"});
            this.cbFilter.Location = new System.Drawing.Point(109, 304);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(218, 36);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 229;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbGender.BorderRadius = 17;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.ItemHeight = 30;
            this.cbGender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(350, 304);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(118, 36);
            this.cbGender.StartIndex = 0;
            this.cbGender.TabIndex = 227;
            this.cbGender.Visible = false;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // cbEducationLevels
            // 
            this.cbEducationLevels.BackColor = System.Drawing.Color.Transparent;
            this.cbEducationLevels.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbEducationLevels.BorderRadius = 17;
            this.cbEducationLevels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEducationLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEducationLevels.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbEducationLevels.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbEducationLevels.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbEducationLevels.ForeColor = System.Drawing.Color.Black;
            this.cbEducationLevels.ItemHeight = 30;
            this.cbEducationLevels.Location = new System.Drawing.Point(350, 304);
            this.cbEducationLevels.Name = "cbEducationLevels";
            this.cbEducationLevels.Size = new System.Drawing.Size(260, 36);
            this.cbEducationLevels.TabIndex = 228;
            this.cbEducationLevels.Visible = false;
            this.cbEducationLevels.SelectedIndexChanged += new System.EventHandler(this.cbEducationLevels_SelectedIndexChanged);
            // 
            // dgvTeachersList
            // 
            this.dgvTeachersList.AllowUserToAddRows = false;
            this.dgvTeachersList.AllowUserToDeleteRows = false;
            this.dgvTeachersList.AllowUserToOrderColumns = true;
            this.dgvTeachersList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeachersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTeachersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeachersList.ColumnHeadersHeight = 35;
            this.dgvTeachersList.ContextMenuStrip = this.cmsEditProfile;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeachersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeachersList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTeachersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvTeachersList.Location = new System.Drawing.Point(0, 19);
            this.dgvTeachersList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTeachersList.Name = "dgvTeachersList";
            this.dgvTeachersList.ReadOnly = true;
            this.dgvTeachersList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachersList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTeachersList.RowTemplate.Height = 33;
            this.dgvTeachersList.ShowCellToolTips = false;
            this.dgvTeachersList.Size = new System.Drawing.Size(1043, 392);
            this.dgvTeachersList.TabIndex = 234;
            this.dgvTeachersList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvTeachersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvTeachersList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachersList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTeachersList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTeachersList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTeachersList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTeachersList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvTeachersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvTeachersList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTeachersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachersList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTeachersList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTeachersList.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvTeachersList.ThemeStyle.ReadOnly = true;
            this.dgvTeachersList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvTeachersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTeachersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachersList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTeachersList.ThemeStyle.RowsStyle.Height = 33;
            this.dgvTeachersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvTeachersList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsEditProfile
            // 
            this.cmsEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmsEditProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEditProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowTeacherDetails,
            this.toolStripSeparator6,
            this.tsmEditTeacher,
            this.temDeleteTeacher,
            this.toolStripMenuItem1,
            this.tsmAssignToSubject,
            this.SubjectsHeTeachesToolStripMenuItem});
            this.cmsEditProfile.Name = "contextMenuStrip1";
            this.cmsEditProfile.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsEditProfile.Size = new System.Drawing.Size(243, 206);
            // 
            // tsmShowTeacherDetails
            // 
            this.tsmShowTeacherDetails.ForeColor = System.Drawing.Color.White;
            this.tsmShowTeacherDetails.Image = global::Educational_Center.Properties.Resources.show_reservation_323;
            this.tsmShowTeacherDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowTeacherDetails.Name = "tsmShowTeacherDetails";
            this.tsmShowTeacherDetails.Size = new System.Drawing.Size(242, 38);
            this.tsmShowTeacherDetails.Text = "Show Teacher Details";
            this.tsmShowTeacherDetails.Click += new System.EventHandler(this.tsmShowTeacherDetails_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(239, 6);
            // 
            // tsmEditTeacher
            // 
            this.tsmEditTeacher.ForeColor = System.Drawing.Color.White;
            this.tsmEditTeacher.Image = global::Educational_Center.Properties.Resources.edit_reservation32;
            this.tsmEditTeacher.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmEditTeacher.Name = "tsmEditTeacher";
            this.tsmEditTeacher.Size = new System.Drawing.Size(242, 38);
            this.tsmEditTeacher.Text = "Edit";
            this.tsmEditTeacher.Click += new System.EventHandler(this.tsmEditTeacher_Click);
            // 
            // temDeleteTeacher
            // 
            this.temDeleteTeacher.ForeColor = System.Drawing.Color.White;
            this.temDeleteTeacher.Image = global::Educational_Center.Properties.Resources.delete_reservation_401;
            this.temDeleteTeacher.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.temDeleteTeacher.Name = "temDeleteTeacher";
            this.temDeleteTeacher.Size = new System.Drawing.Size(242, 38);
            this.temDeleteTeacher.Text = "Delete";
            this.temDeleteTeacher.Click += new System.EventHandler(this.temDeleteTeacher_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(239, 6);
            // 
            // tsmAssignToSubject
            // 
            this.tsmAssignToSubject.ForeColor = System.Drawing.Color.White;
            this.tsmAssignToSubject.Image = global::Educational_Center.Properties.Resources.assign_to_subject_322;
            this.tsmAssignToSubject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmAssignToSubject.Name = "tsmAssignToSubject";
            this.tsmAssignToSubject.Size = new System.Drawing.Size(242, 38);
            this.tsmAssignToSubject.Text = "Assign To Subject";
            this.tsmAssignToSubject.Click += new System.EventHandler(this.tsmAssignToSubject_Click);
            // 
            // SubjectsHeTeachesToolStripMenuItem
            // 
            this.SubjectsHeTeachesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SubjectsHeTeachesToolStripMenuItem.Image = global::Educational_Center.Properties.Resources.subjects_322;
            this.SubjectsHeTeachesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubjectsHeTeachesToolStripMenuItem.Name = "SubjectsHeTeachesToolStripMenuItem";
            this.SubjectsHeTeachesToolStripMenuItem.Size = new System.Drawing.Size(242, 38);
            this.SubjectsHeTeachesToolStripMenuItem.Text = "Subjects he Teaches";
            this.SubjectsHeTeachesToolStripMenuItem.Click += new System.EventHandler(this.SubjectsHeTeachesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 233;
            this.label1.Text = "Filter By:";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(101, 414);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(27, 20);
            this.lblNumberOfRecords.TabIndex = 236;
            this.lblNumberOfRecords.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 235;
            this.label2.Text = "# Records:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTeachersList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNumberOfRecords);
            this.groupBox1.Location = new System.Drawing.Point(4, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 441);
            this.groupBox1.TabIndex = 237;
            this.groupBox1.TabStop = false;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackgroundImage = global::Educational_Center.Properties.Resources.add_teacher;
            this.btnAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTeacher.Checked = true;
            this.btnAddTeacher.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTeacher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTeacher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTeacher.FillColor = System.Drawing.Color.White;
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddTeacher.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddTeacher.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnAddTeacher.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddTeacher.Location = new System.Drawing.Point(985, 268);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(50, 45);
            this.btnAddTeacher.TabIndex = 232;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::Educational_Center.Properties.Resources.teacher1;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(365, 63);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(325, 169);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 225;
            this.pbImage.TabStop = false;
            // 
            // frmListTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 872);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbEducationLevels);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListTeachers";
            this.Load += new System.EventHandler(this.frmListTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersList)).EndInit();
            this.cmsEditProfile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddTeacher;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private Guna.UI2.WinForms.Guna2ComboBox cbEducationLevels;
        private System.Windows.Forms.PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTeachersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsEditProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmShowTeacherDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmEditTeacher;
        private System.Windows.Forms.ToolStripMenuItem temDeleteTeacher;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmAssignToSubject;
        private System.Windows.Forms.ToolStripMenuItem SubjectsHeTeachesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}