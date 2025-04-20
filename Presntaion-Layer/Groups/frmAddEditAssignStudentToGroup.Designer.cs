namespace Educational_Center.Groups
{
    partial class frmAddEditAssignStudentToGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFindBy = new System.Windows.Forms.ComboBox();
            this.tpGroup = new System.Windows.Forms.TabPage();
            this.gbSelectGroup = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbGroupNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbMeetingDays = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSubjectNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGroupsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ucStudentCard1 = new Educational_Center.Students.ucStudentCard();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpGroup.SuspendLayout();
            this.gbSelectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 2);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(946, 78);
            this.lblTitle.TabIndex = 212;
            this.lblTitle.Text = "Assign Student To Group";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tpGroup);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(10, 90);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(926, 596);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 215;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ucStudentCard1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFindBy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 118);
            this.groupBox1.TabIndex = 183;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::Educational_Center.Properties.Resources.find_person_502;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Checked = true;
            this.btnFind.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.White;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnFind.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnFind.ImageSize = new System.Drawing.Size(45, 45);
            this.btnFind.Location = new System.Drawing.Point(598, 44);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(50, 33);
            this.btnFind.TabIndex = 147;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 32);
            this.textBox1.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 143;
            this.label2.Text = "Find By:";
            // 
            // cbFindBy
            // 
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.Location = new System.Drawing.Point(99, 46);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.Size = new System.Drawing.Size(187, 32);
            this.cbFindBy.TabIndex = 0;
            // 
            // tpGroup
            // 
            this.tpGroup.BackColor = System.Drawing.Color.White;
            this.tpGroup.Controls.Add(this.gbSelectGroup);
            this.tpGroup.Location = new System.Drawing.Point(4, 44);
            this.tpGroup.Name = "tpGroup";
            this.tpGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tpGroup.Size = new System.Drawing.Size(918, 613);
            this.tpGroup.TabIndex = 1;
            this.tpGroup.Text = "Group Info";
            // 
            // gbSelectGroup
            // 
            this.gbSelectGroup.BackColor = System.Drawing.Color.White;
            this.gbSelectGroup.Controls.Add(this.txtSearch);
            this.gbSelectGroup.Controls.Add(this.cbGroupNames);
            this.gbSelectGroup.Controls.Add(this.cbMeetingDays);
            this.gbSelectGroup.Controls.Add(this.cbSubjectNames);
            this.gbSelectGroup.Controls.Add(this.cbFilter);
            this.gbSelectGroup.Controls.Add(this.label1);
            this.gbSelectGroup.Controls.Add(this.dgvGroupsList);
            this.gbSelectGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelectGroup.ForeColor = System.Drawing.Color.Black;
            this.gbSelectGroup.Location = new System.Drawing.Point(25, 22);
            this.gbSelectGroup.Name = "gbSelectGroup";
            this.gbSelectGroup.Size = new System.Drawing.Size(862, 574);
            this.gbSelectGroup.TabIndex = 5;
            this.gbSelectGroup.Text = "Group Information";
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
            this.txtSearch.Location = new System.Drawing.Point(362, 64);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(273, 36);
            this.txtSearch.TabIndex = 230;
            this.txtSearch.Visible = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cbGroupNames
            // 
            this.cbGroupNames.BackColor = System.Drawing.Color.Transparent;
            this.cbGroupNames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbGroupNames.BorderRadius = 17;
            this.cbGroupNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGroupNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbGroupNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbGroupNames.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbGroupNames.ForeColor = System.Drawing.Color.Black;
            this.cbGroupNames.ItemHeight = 30;
            this.cbGroupNames.Location = new System.Drawing.Point(362, 64);
            this.cbGroupNames.Name = "cbGroupNames";
            this.cbGroupNames.Size = new System.Drawing.Size(139, 36);
            this.cbGroupNames.TabIndex = 236;
            this.cbGroupNames.Visible = false;
            this.cbGroupNames.SelectedIndexChanged += new System.EventHandler(this.cbGroupNames_SelectedIndexChanged);
            // 
            // cbMeetingDays
            // 
            this.cbMeetingDays.BackColor = System.Drawing.Color.Transparent;
            this.cbMeetingDays.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbMeetingDays.BorderRadius = 17;
            this.cbMeetingDays.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMeetingDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeetingDays.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbMeetingDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbMeetingDays.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbMeetingDays.ForeColor = System.Drawing.Color.Black;
            this.cbMeetingDays.ItemHeight = 30;
            this.cbMeetingDays.Items.AddRange(new object[] {
            "All",
            "Daily",
            "STT",
            "MW"});
            this.cbMeetingDays.Location = new System.Drawing.Point(362, 64);
            this.cbMeetingDays.Name = "cbMeetingDays";
            this.cbMeetingDays.Size = new System.Drawing.Size(139, 36);
            this.cbMeetingDays.StartIndex = 0;
            this.cbMeetingDays.TabIndex = 235;
            this.cbMeetingDays.Visible = false;
            this.cbMeetingDays.SelectedIndexChanged += new System.EventHandler(this.cbMeetingDays_SelectedIndexChanged);
            // 
            // cbSubjectNames
            // 
            this.cbSubjectNames.BackColor = System.Drawing.Color.Transparent;
            this.cbSubjectNames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbSubjectNames.BorderRadius = 17;
            this.cbSubjectNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubjectNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubjectNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbSubjectNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbSubjectNames.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbSubjectNames.ForeColor = System.Drawing.Color.Black;
            this.cbSubjectNames.ItemHeight = 30;
            this.cbSubjectNames.Location = new System.Drawing.Point(362, 64);
            this.cbSubjectNames.Name = "cbSubjectNames";
            this.cbSubjectNames.Size = new System.Drawing.Size(211, 36);
            this.cbSubjectNames.TabIndex = 234;
            this.cbSubjectNames.Visible = false;
            this.cbSubjectNames.SelectedIndexChanged += new System.EventHandler(this.cbSubjectNames_SelectedIndexChanged);
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
            "Group ID",
            "Group Name",
            "Class Name",
            "Teacher Name",
            "Subject Name",
            "Meeting Days"});
            this.cbFilter.Location = new System.Drawing.Point(104, 64);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(218, 36);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 233;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 229;
            this.label1.Text = "Filter By:";
            // 
            // dgvGroupsList
            // 
            this.dgvGroupsList.AllowUserToAddRows = false;
            this.dgvGroupsList.AllowUserToDeleteRows = false;
            this.dgvGroupsList.AllowUserToOrderColumns = true;
            this.dgvGroupsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGroupsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGroupsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvGroupsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvGroupsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGroupsList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupsList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvGroupsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGroupsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvGroupsList.Location = new System.Drawing.Point(20, 113);
            this.dgvGroupsList.Name = "dgvGroupsList";
            this.dgvGroupsList.ReadOnly = true;
            this.dgvGroupsList.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGroupsList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGroupsList.RowTemplate.Height = 33;
            this.dgvGroupsList.ShowCellToolTips = false;
            this.dgvGroupsList.Size = new System.Drawing.Size(822, 444);
            this.dgvGroupsList.TabIndex = 213;
            this.dgvGroupsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvGroupsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvGroupsList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGroupsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGroupsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGroupsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGroupsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGroupsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvGroupsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvGroupsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGroupsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGroupsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGroupsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGroupsList.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvGroupsList.ThemeStyle.ReadOnly = true;
            this.dgvGroupsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvGroupsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGroupsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGroupsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGroupsList.ThemeStyle.RowsStyle.Height = 33;
            this.dgvGroupsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvGroupsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ucStudentCard1
            // 
            this.ucStudentCard1.Location = new System.Drawing.Point(5, 123);
            this.ucStudentCard1.Name = "ucStudentCard1";
            this.ucStudentCard1.Size = new System.Drawing.Size(910, 419);
            this.ucStudentCard1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 20;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Educational_Center.Properties.Resources.close__2_;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(615, 693);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(155, 44);
            this.btnClose.TabIndex = 217;
            this.btnClose.Text = "Close";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BorderRadius = 20;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Educational_Center.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(781, 693);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(155, 44);
            this.btnSave.TabIndex = 216;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditAssignStudentToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditAssignStudentToGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditAssignStudentToGroup";
            this.Load += new System.EventHandler(this.frmAddEditAssignStudentToGroup_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpGroup.ResumeLayout(false);
            this.gbSelectGroup.ResumeLayout(false);
            this.gbSelectGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Students.ucStudentCard ucStudentCard1;
        private System.Windows.Forms.TabPage tpGroup;
        private Guna.UI2.WinForms.Guna2GroupBox gbSelectGroup;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbGroupNames;
        private Guna.UI2.WinForms.Guna2ComboBox cbMeetingDays;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubjectNames;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGroupsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFindBy;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
    }
}