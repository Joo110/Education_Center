namespace Educational_Center.Students
{
    partial class frmListStudents
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
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsEditProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowStudentDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAssignToGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbGrades = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.cmsEditProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Student ID",
            "Name",
            "Gender",
            "Grade",
            "Age"});
            this.cbFilter.Location = new System.Drawing.Point(16, 308);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(254, 33);
            this.cbFilter.TabIndex = 221;
            this.cbFilter.Text = "None";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 783);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 226;
            this.label4.Text = "# Records:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 783);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 227;
            this.label1.Text = "???";
            // 
            // cmsEditProfile
            // 
            this.cmsEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmsEditProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEditProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowStudentDetails,
            this.toolStripSeparator6,
            this.tsmEditStudent,
            this.tsmDeleteStudent,
            this.toolStripMenuItem1,
            this.tsmAssignToGroupToolStripMenuItem});
            this.cmsEditProfile.Name = "contextMenuStrip1";
            this.cmsEditProfile.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsEditProfile.Size = new System.Drawing.Size(244, 168);
            // 
            // tsmShowStudentDetails
            // 
            this.tsmShowStudentDetails.ForeColor = System.Drawing.Color.White;
            this.tsmShowStudentDetails.Image = global::Educational_Center.Properties.Resources.show_reservation_321;
            this.tsmShowStudentDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowStudentDetails.Name = "tsmShowStudentDetails";
            this.tsmShowStudentDetails.Size = new System.Drawing.Size(243, 38);
            this.tsmShowStudentDetails.Text = "Show Student Details";
            this.tsmShowStudentDetails.Click += new System.EventHandler(this.tsmShowStudentDetails_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(240, 6);
            // 
            // tsmEditStudent
            // 
            this.tsmEditStudent.ForeColor = System.Drawing.Color.White;
            this.tsmEditStudent.Image = global::Educational_Center.Properties.Resources.edit_reservation321;
            this.tsmEditStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmEditStudent.Name = "tsmEditStudent";
            this.tsmEditStudent.Size = new System.Drawing.Size(243, 38);
            this.tsmEditStudent.Text = "Edit";
            this.tsmEditStudent.Click += new System.EventHandler(this.tsmEditStudent_Click);
            // 
            // tsmDeleteStudent
            // 
            this.tsmDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.tsmDeleteStudent.Image = global::Educational_Center.Properties.Resources.delete_reservation_40;
            this.tsmDeleteStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDeleteStudent.Name = "tsmDeleteStudent";
            this.tsmDeleteStudent.Size = new System.Drawing.Size(243, 38);
            this.tsmDeleteStudent.Text = "Delete";
            this.tsmDeleteStudent.Click += new System.EventHandler(this.tsmDeleteStudent_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(240, 6);
            // 
            // tsmAssignToGroupToolStripMenuItem
            // 
            this.tsmAssignToGroupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tsmAssignToGroupToolStripMenuItem.Image = global::Educational_Center.Properties.Resources.assign_to_subject_321;
            this.tsmAssignToGroupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmAssignToGroupToolStripMenuItem.Name = "tsmAssignToGroupToolStripMenuItem";
            this.tsmAssignToGroupToolStripMenuItem.Size = new System.Drawing.Size(243, 38);
            this.tsmAssignToGroupToolStripMenuItem.Text = "Assign To Group";
            this.tsmAssignToGroupToolStripMenuItem.Click += new System.EventHandler(this.tsmAssignToGroupToolStripMenuItem_Click);
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
            this.cbGender.Location = new System.Drawing.Point(277, 307);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(137, 36);
            this.cbGender.StartIndex = 0;
            this.cbGender.TabIndex = 229;
            this.cbGender.Visible = false;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // cbGrades
            // 
            this.cbGrades.BackColor = System.Drawing.Color.Transparent;
            this.cbGrades.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbGrades.BorderRadius = 17;
            this.cbGrades.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGrades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrades.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbGrades.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbGrades.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbGrades.ForeColor = System.Drawing.Color.Black;
            this.cbGrades.ItemHeight = 30;
            this.cbGrades.Location = new System.Drawing.Point(277, 307);
            this.cbGrades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGrades.Name = "cbGrades";
            this.cbGrades.Size = new System.Drawing.Size(303, 36);
            this.cbGrades.TabIndex = 230;
            this.cbGrades.Visible = false;
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
            this.txtSearch.Location = new System.Drawing.Point(277, 307);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(318, 36);
            this.txtSearch.TabIndex = 231;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToOrderColumns = true;
            this.dgvStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.ColumnHeadersHeight = 40;
            this.dgvStudents.ContextMenuStrip = this.cmsEditProfile;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvStudents.Location = new System.Drawing.Point(6, 365);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudents.RowTemplate.Height = 33;
            this.dgvStudents.ShowCellToolTips = false;
            this.dgvStudents.Size = new System.Drawing.Size(1051, 415);
            this.dgvStudents.TabIndex = 232;
            this.dgvStudents.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvStudents.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStudents.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudents.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvStudents.ThemeStyle.ReadOnly = true;
            this.dgvStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStudents.ThemeStyle.RowsStyle.Height = 33;
            this.dgvStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Educational_Center.Properties.Resources.add_student1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(979, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 62);
            this.button1.TabIndex = 233;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::Educational_Center.Properties.Resources.students_list2;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(369, 36);
            this.pbImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(379, 169);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 212;
            this.pbImage.TabStop = false;
            // 
            // frmListStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 816);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbGrades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListStudents";
            this.Text = "frmListStudents";
            this.Load += new System.EventHandler(this.frmListStudents_Load);
            this.cmsEditProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsEditProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmShowStudentDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmEditStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteStudent;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmAssignToGroupToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private Guna.UI2.WinForms.Guna2ComboBox cbGrades;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStudents;
        private System.Windows.Forms.Button button1;
    }
}