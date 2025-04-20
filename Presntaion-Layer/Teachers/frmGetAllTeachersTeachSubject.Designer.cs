namespace Educational_Center.Teachers
{
    partial class frmGetAllTeachersTeachSubject
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
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ucGetAllTeachersTeachSubject2 = new Educational_Center.Teachers.ucGetAllTeachersTeachSubject();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(720, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(155, 45);
            this.btnClose.TabIndex = 227;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.lblTitle.Location = new System.Drawing.Point(1, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(883, 66);
            this.lblTitle.TabIndex = 226;
            this.lblTitle.Text = "Teachers Teach a Subject";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucGetAllTeachersTeachSubject2
            // 
            this.ucGetAllTeachersTeachSubject2.Location = new System.Drawing.Point(1, 108);
            this.ucGetAllTeachersTeachSubject2.Name = "ucGetAllTeachersTeachSubject2";
            this.ucGetAllTeachersTeachSubject2.Size = new System.Drawing.Size(882, 283);
            this.ucGetAllTeachersTeachSubject2.TabIndex = 228;
            // 
            // frmGetAllTeachersTeachSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 489);
            this.Controls.Add(this.ucGetAllTeachersTeachSubject2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmGetAllTeachersTeachSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGetAllTeachersTeachSubject";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private ucGetAllTeachersTeachSubject ucGetAllTeachersTeachSubject1;
        private ucGetAllTeachersTeachSubject ucGetAllTeachersTeachSubject2;
    }
}