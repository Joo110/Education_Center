namespace Educational_Center.User
{
    partial class frmShowUserInfo
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
            this.LaShowUserInfo = new System.Windows.Forms.Label();
            this.btnClose1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucUserCard1 = new Educational_Center.User.ucUserCard();
            this.SuspendLayout();
            // 
            // LaShowUserInfo
            // 
            this.LaShowUserInfo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaShowUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.LaShowUserInfo.Location = new System.Drawing.Point(2, 2);
            this.LaShowUserInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LaShowUserInfo.Name = "LaShowUserInfo";
            this.LaShowUserInfo.Size = new System.Drawing.Size(871, 61);
            this.LaShowUserInfo.TabIndex = 202;
            this.LaShowUserInfo.Text = "Show User Info";
            this.LaShowUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose1
            // 
            this.btnClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose1.BorderRadius = 20;
            this.btnClose1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnClose1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnClose1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose1.ForeColor = System.Drawing.Color.White;
            this.btnClose1.Image = global::Educational_Center.Properties.Resources.close__2_;
            this.btnClose1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose1.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnClose1.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose1.Location = new System.Drawing.Point(705, 567);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnClose1.Size = new System.Drawing.Size(155, 45);
            this.btnClose1.TabIndex = 204;
            this.btnClose1.Text = "Close";
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // ucUserCard1
            // 
            this.ucUserCard1.Location = new System.Drawing.Point(5, 79);
            this.ucUserCard1.Name = "ucUserCard1";
            this.ucUserCard1.Size = new System.Drawing.Size(862, 447);
            this.ucUserCard1.TabIndex = 205;
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 620);
            this.Controls.Add(this.ucUserCard1);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.LaShowUserInfo);
            this.Name = "frmShowUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowUserInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LaShowUserInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose1;
        private ucUserCard ucUserCard1;
    }
}