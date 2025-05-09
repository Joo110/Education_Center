﻿namespace Educational_Center.Subjects
{
    partial class frmListSubjectsGradeLevel
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
            this.dgvSubjectsGradeLevelsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsEditProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowSubjectDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.WhoTeachesItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSubjects = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbGrades = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSubject = new Guna.UI2.WinForms.Guna2Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectsGradeLevelsList)).BeginInit();
            this.cmsEditProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubjectsGradeLevelsList
            // 
            this.dgvSubjectsGradeLevelsList.AllowUserToAddRows = false;
            this.dgvSubjectsGradeLevelsList.AllowUserToDeleteRows = false;
            this.dgvSubjectsGradeLevelsList.AllowUserToOrderColumns = true;
            this.dgvSubjectsGradeLevelsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjectsGradeLevelsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubjectsGradeLevelsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSubjectsGradeLevelsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubjectsGradeLevelsList.ColumnHeadersHeight = 35;
            this.dgvSubjectsGradeLevelsList.ContextMenuStrip = this.cmsEditProfile;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjectsGradeLevelsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubjectsGradeLevelsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubjectsGradeLevelsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvSubjectsGradeLevelsList.Location = new System.Drawing.Point(7, 302);
            this.dgvSubjectsGradeLevelsList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSubjectsGradeLevelsList.Name = "dgvSubjectsGradeLevelsList";
            this.dgvSubjectsGradeLevelsList.ReadOnly = true;
            this.dgvSubjectsGradeLevelsList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjectsGradeLevelsList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubjectsGradeLevelsList.RowTemplate.Height = 33;
            this.dgvSubjectsGradeLevelsList.ShowCellToolTips = false;
            this.dgvSubjectsGradeLevelsList.Size = new System.Drawing.Size(1043, 444);
            this.dgvSubjectsGradeLevelsList.TabIndex = 248;
            this.dgvSubjectsGradeLevelsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvSubjectsGradeLevelsList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjectsGradeLevelsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvSubjectsGradeLevelsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvSubjectsGradeLevelsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjectsGradeLevelsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.ReadOnly = true;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvSubjectsGradeLevelsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjectsGradeLevelsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.RowsStyle.Height = 33;
            this.dgvSubjectsGradeLevelsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvSubjectsGradeLevelsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsEditProfile
            // 
            this.cmsEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmsEditProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEditProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowSubjectDetails,
            this.toolStripSeparator6,
            this.tsmEditSubject,
            this.WhoTeachesItToolStripMenuItem});
            this.cmsEditProfile.Name = "contextMenuStrip1";
            this.cmsEditProfile.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsEditProfile.Size = new System.Drawing.Size(240, 124);
            // 
            // tsmShowSubjectDetails
            // 
            this.tsmShowSubjectDetails.ForeColor = System.Drawing.Color.White;
            this.tsmShowSubjectDetails.Image = global::Educational_Center.Properties.Resources.show_reservation_322;
            this.tsmShowSubjectDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowSubjectDetails.Name = "tsmShowSubjectDetails";
            this.tsmShowSubjectDetails.Size = new System.Drawing.Size(239, 38);
            this.tsmShowSubjectDetails.Text = "Show Subject Details";
            this.tsmShowSubjectDetails.Click += new System.EventHandler(this.tsmShowSubjectDetails_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(236, 6);
            // 
            // tsmEditSubject
            // 
            this.tsmEditSubject.ForeColor = System.Drawing.Color.White;
            this.tsmEditSubject.Image = global::Educational_Center.Properties.Resources.edit_reservation322;
            this.tsmEditSubject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmEditSubject.Name = "tsmEditSubject";
            this.tsmEditSubject.Size = new System.Drawing.Size(239, 38);
            this.tsmEditSubject.Text = "Edit";
            this.tsmEditSubject.Click += new System.EventHandler(this.tsmEditSubject_Click);
            // 
            // WhoTeachesItToolStripMenuItem
            // 
            this.WhoTeachesItToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.WhoTeachesItToolStripMenuItem.Image = global::Educational_Center.Properties.Resources.Notes_321;
            this.WhoTeachesItToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.WhoTeachesItToolStripMenuItem.Name = "WhoTeachesItToolStripMenuItem";
            this.WhoTeachesItToolStripMenuItem.Size = new System.Drawing.Size(239, 38);
            this.WhoTeachesItToolStripMenuItem.Text = "Who Teaches it?";
            this.WhoTeachesItToolStripMenuItem.Click += new System.EventHandler(this.WhoTeachesItToolStripMenuItem_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(338, 259);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(273, 36);
            this.txtSearch.TabIndex = 241;
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
            "Subject Grade Level ID",
            "Subject Name",
            "Grade Level"});
            this.cbFilter.Location = new System.Drawing.Point(90, 259);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(218, 36);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 244;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // cbSubjects
            // 
            this.cbSubjects.BackColor = System.Drawing.Color.Transparent;
            this.cbSubjects.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbSubjects.BorderRadius = 17;
            this.cbSubjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubjects.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbSubjects.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbSubjects.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbSubjects.ForeColor = System.Drawing.Color.Black;
            this.cbSubjects.ItemHeight = 30;
            this.cbSubjects.Location = new System.Drawing.Point(338, 259);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(260, 36);
            this.cbSubjects.TabIndex = 242;
            this.cbSubjects.Visible = false;
            this.cbSubjects.SelectedIndexChanged += new System.EventHandler(this.cbSubjects_SelectedIndexChanged);
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
            this.cbGrades.Location = new System.Drawing.Point(338, 259);
            this.cbGrades.Name = "cbGrades";
            this.cbGrades.Size = new System.Drawing.Size(260, 36);
            this.cbGrades.TabIndex = 243;
            this.cbGrades.Visible = false;
            this.cbGrades.SelectedIndexChanged += new System.EventHandler(this.cbGrades_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 249;
            this.label1.Text = "Filter By:";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(85, 751);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(28, 16);
            this.lblNumberOfRecords.TabIndex = 251;
            this.lblNumberOfRecords.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 749);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 250;
            this.label2.Text = "Records:";
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackgroundImage = global::Educational_Center.Properties.Resources.add_subject;
            this.btnAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSubject.Checked = true;
            this.btnAddSubject.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSubject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSubject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSubject.FillColor = System.Drawing.Color.White;
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddSubject.ForeColor = System.Drawing.Color.White;
            this.btnAddSubject.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddSubject.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnAddSubject.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddSubject.Location = new System.Drawing.Point(934, 250);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(113, 45);
            this.btnAddSubject.TabIndex = 247;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::Educational_Center.Properties.Resources.subject;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(350, 52);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(325, 169);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 240;
            this.pbImage.TabStop = false;
            // 
            // frmListSubjectsGradeLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 777);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSubjectsGradeLevelsList);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.cbSubjects);
            this.Controls.Add(this.cbGrades);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListSubjectsGradeLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListSubjectsGradeLevel";
            this.Load += new System.EventHandler(this.frmListSubjectsGradeLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectsGradeLevelsList)).EndInit();
            this.cmsEditProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvSubjectsGradeLevelsList;
        private Guna.UI2.WinForms.Guna2Button btnAddSubject;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubjects;
        private Guna.UI2.WinForms.Guna2ComboBox cbGrades;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsEditProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmShowSubjectDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmEditSubject;
        private System.Windows.Forms.ToolStripMenuItem WhoTeachesItToolStripMenuItem;
    }
}