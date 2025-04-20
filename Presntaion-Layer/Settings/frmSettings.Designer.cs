namespace Educational_Center.Settings
{
    partial class frmSettings
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.llListUsers = new System.Windows.Forms.LinkLabel();
            this.llAddNewUser = new System.Windows.Forms.LinkLabel();
            this.gbList = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMinPersonAge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaxPersonAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClosingTime = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblOpeningTime = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox1.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.llListUsers);
            this.guna2GroupBox1.Controls.Add(this.llAddNewUser);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(93, 490);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(865, 174);
            this.guna2GroupBox1.TabIndex = 207;
            this.guna2GroupBox1.Text = "Manage Users";
            // 
            // llListUsers
            // 
            this.llListUsers.AutoSize = true;
            this.llListUsers.BackColor = System.Drawing.Color.Transparent;
            this.llListUsers.Enabled = false;
            this.llListUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llListUsers.Location = new System.Drawing.Point(500, 93);
            this.llListUsers.Name = "llListUsers";
            this.llListUsers.Size = new System.Drawing.Size(92, 25);
            this.llListUsers.TabIndex = 170;
            this.llListUsers.TabStop = true;
            this.llListUsers.Text = "List Users";
            this.llListUsers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llListUsers_LinkClicked);
            // 
            // llAddNewUser
            // 
            this.llAddNewUser.AutoSize = true;
            this.llAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.llAddNewUser.Enabled = false;
            this.llAddNewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddNewUser.Location = new System.Drawing.Point(219, 93);
            this.llAddNewUser.Name = "llAddNewUser";
            this.llAddNewUser.Size = new System.Drawing.Size(134, 25);
            this.llAddNewUser.TabIndex = 168;
            this.llAddNewUser.TabStop = true;
            this.llAddNewUser.Text = "Add New User";
            this.llAddNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddNewUser_LinkClicked);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.pictureBox4);
            this.gbList.Controls.Add(this.label5);
            this.gbList.Controls.Add(this.lblMinPersonAge);
            this.gbList.Controls.Add(this.pictureBox3);
            this.gbList.Controls.Add(this.label3);
            this.gbList.Controls.Add(this.lblMaxPersonAge);
            this.gbList.Controls.Add(this.pictureBox2);
            this.gbList.Controls.Add(this.label1);
            this.gbList.Controls.Add(this.lblClosingTime);
            this.gbList.Controls.Add(this.pictureBox1);
            this.gbList.Controls.Add(this.label22);
            this.gbList.Controls.Add(this.lblOpeningTime);
            this.gbList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbList.ForeColor = System.Drawing.Color.Black;
            this.gbList.Location = new System.Drawing.Point(93, 251);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(865, 202);
            this.gbList.TabIndex = 206;
            this.gbList.Text = "Manage System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 178;
            this.label5.Text = "Min Person Age:";
            // 
            // lblMinPersonAge
            // 
            this.lblMinPersonAge.AutoSize = true;
            this.lblMinPersonAge.BackColor = System.Drawing.Color.Transparent;
            this.lblMinPersonAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPersonAge.Location = new System.Drawing.Point(631, 121);
            this.lblMinPersonAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinPersonAge.Name = "lblMinPersonAge";
            this.lblMinPersonAge.Size = new System.Drawing.Size(50, 21);
            this.lblMinPersonAge.TabIndex = 179;
            this.lblMinPersonAge.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 175;
            this.label3.Text = "Max Person Age:";
            // 
            // lblMaxPersonAge
            // 
            this.lblMaxPersonAge.AutoSize = true;
            this.lblMaxPersonAge.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxPersonAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPersonAge.Location = new System.Drawing.Point(631, 71);
            this.lblMaxPersonAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxPersonAge.Name = "lblMaxPersonAge";
            this.lblMaxPersonAge.Size = new System.Drawing.Size(50, 21);
            this.lblMaxPersonAge.TabIndex = 176;
            this.lblMaxPersonAge.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 172;
            this.label1.Text = "Closing Time:";
            // 
            // lblClosingTime
            // 
            this.lblClosingTime.AutoSize = true;
            this.lblClosingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblClosingTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosingTime.Location = new System.Drawing.Point(196, 118);
            this.lblClosingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClosingTime.Name = "lblClosingTime";
            this.lblClosingTime.Size = new System.Drawing.Size(50, 21);
            this.lblClosingTime.TabIndex = 173;
            this.lblClosingTime.Text = "[????]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(30, 68);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 21);
            this.label22.TabIndex = 169;
            this.label22.Text = "Opening Time:";
            // 
            // lblOpeningTime
            // 
            this.lblOpeningTime.AutoSize = true;
            this.lblOpeningTime.BackColor = System.Drawing.Color.Transparent;
            this.lblOpeningTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpeningTime.Location = new System.Drawing.Point(196, 68);
            this.lblOpeningTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpeningTime.Name = "lblOpeningTime";
            this.lblOpeningTime.Size = new System.Drawing.Size(50, 21);
            this.lblOpeningTime.TabIndex = 170;
            this.lblOpeningTime.Text = "[????]";
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::Educational_Center.Properties.Resources.manage_groups1;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(365, 32);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(325, 169);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 208;
            this.pbImage.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Educational_Center.Properties.Resources.calendar;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(593, 118);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 180;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Educational_Center.Properties.Resources.calendar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(593, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 177;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Educational_Center.Properties.Resources.end_time;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(158, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 174;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Educational_Center.Properties.Resources.add_reservation_50;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(158, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 171;
            this.pictureBox1.TabStop = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 749);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.gbList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load_1);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.LinkLabel llListUsers;
        private System.Windows.Forms.LinkLabel llAddNewUser;
        private Guna.UI2.WinForms.Guna2GroupBox gbList;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMinPersonAge;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaxPersonAge;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClosingTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblOpeningTime;
    }
}