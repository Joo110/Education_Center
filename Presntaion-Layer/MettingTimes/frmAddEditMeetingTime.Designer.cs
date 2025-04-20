namespace Educational_Center.MettingTimes
{
    partial class frmAddEditMeetingTime
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
            this.label22 = new System.Windows.Forms.Label();
            this.lblMeetingTimeID = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnDate = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            this.guna2DTPEndTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMeetingDays = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(22, 93);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 21);
            this.label22.TabIndex = 219;
            this.label22.Text = "Meeting Time ID:";
            // 
            // lblMeetingTimeID
            // 
            this.lblMeetingTimeID.AutoSize = true;
            this.lblMeetingTimeID.BackColor = System.Drawing.Color.Transparent;
            this.lblMeetingTimeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingTimeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMeetingTimeID.Location = new System.Drawing.Point(194, 93);
            this.lblMeetingTimeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetingTimeID.Name = "lblMeetingTimeID";
            this.lblMeetingTimeID.Size = new System.Drawing.Size(41, 21);
            this.lblMeetingTimeID.TabIndex = 220;
            this.lblMeetingTimeID.Text = "N/A";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 15;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(181, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(133, 38);
            this.btnClose.TabIndex = 218;
            this.btnClose.Text = "Close";
            this.btnClose.TextOffset = new System.Drawing.Point(0, -1);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Controls.Add(this.guna2DateTimePicker1);
            this.guna2GroupBox1.Controls.Add(this.btnDate);
            this.guna2GroupBox1.Controls.Add(this.date);
            this.guna2GroupBox1.Controls.Add(this.guna2DTPEndTime);
            this.guna2GroupBox1.Controls.Add(this.dtpStartTime);
            this.guna2GroupBox1.Controls.Add(this.pictureBox3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.pictureBox2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.pictureBox5);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.cbMeetingDays);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(10, 122);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(436, 254);
            this.guna2GroupBox1.TabIndex = 216;
            this.guna2GroupBox1.Text = "Meeting Time Information";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 17;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.CustomFormat = "d/M/yyyy";
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(176, 198);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(233, 36);
            this.guna2DateTimePicker1.TabIndex = 238;
            this.guna2DateTimePicker1.Value = new System.DateTime(2025, 3, 1, 7, 27, 26, 400);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.Transparent;
            this.btnDate.BackgroundImage = global::Educational_Center.Properties.Resources.calendar;
            this.btnDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDate.Location = new System.Drawing.Point(128, 204);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(31, 26);
            this.btnDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDate.TabIndex = 237;
            this.btnDate.TabStop = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(40, 206);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(48, 21);
            this.date.TabIndex = 236;
            this.date.Text = "Date:";
            // 
            // guna2DTPEndTime
            // 
            this.guna2DTPEndTime.BorderRadius = 17;
            this.guna2DTPEndTime.Checked = true;
            this.guna2DTPEndTime.CustomFormat = "hh:mm tt";
            this.guna2DTPEndTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2DTPEndTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2DTPEndTime.ForeColor = System.Drawing.Color.White;
            this.guna2DTPEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DTPEndTime.Location = new System.Drawing.Point(176, 151);
            this.guna2DTPEndTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DTPEndTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DTPEndTime.Name = "guna2DTPEndTime";
            this.guna2DTPEndTime.ShowUpDown = true;
            this.guna2DTPEndTime.Size = new System.Drawing.Size(162, 36);
            this.guna2DTPEndTime.TabIndex = 235;
            this.guna2DTPEndTime.Value = new System.DateTime(2024, 4, 21, 1, 59, 36, 606);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.BorderRadius = 17;
            this.dtpStartTime.Checked = true;
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtpStartTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpStartTime.ForeColor = System.Drawing.Color.White;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(176, 102);
            this.dtpStartTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(162, 36);
            this.dtpStartTime.TabIndex = 215;
            this.dtpStartTime.Value = new System.DateTime(2024, 4, 21, 1, 59, 36, 606);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Educational_Center.Properties.Resources.end_time;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(128, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 234;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 233;
            this.label2.Text = "End Time:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Educational_Center.Properties.Resources.start_time;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(128, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 232;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 231;
            this.label1.Text = "Start Time:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Educational_Center.Properties.Resources.calendar;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(128, 56);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 230;
            this.pictureBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 229;
            this.label9.Text = "Meeting Days:";
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
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cbMeetingDays.Location = new System.Drawing.Point(176, 52);
            this.cbMeetingDays.Name = "cbMeetingDays";
            this.cbMeetingDays.Size = new System.Drawing.Size(162, 36);
            this.cbMeetingDays.StartIndex = 0;
            this.cbMeetingDays.TabIndex = 228;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BorderRadius = 15;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnSave.ImageSize = new System.Drawing.Size(23, 23);
            this.btnSave.Location = new System.Drawing.Point(319, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(133, 38);
            this.btnSave.TabIndex = 217;
            this.btnSave.Text = "Save";
            this.btnSave.TextOffset = new System.Drawing.Point(0, -1);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(449, 59);
            this.lblTitle.TabIndex = 215;
            this.lblTitle.Text = "Find Student";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Educational_Center.Properties.Resources.id;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(156, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 221;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddEditMeetingTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblMeetingTimeID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditMeetingTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditMeetingTime";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblMeetingTimeID;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cbMeetingDays;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnDate;
        private System.Windows.Forms.Label date;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DTPEndTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}