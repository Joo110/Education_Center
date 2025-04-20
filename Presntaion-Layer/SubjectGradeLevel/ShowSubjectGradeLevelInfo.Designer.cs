namespace Educational_Center.SubjectGradeLevel
{
    partial class ShowSubjectGradeLevelInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.ucSubjectGradeLevelCard1 = new Educational_Center.SubjectGradeLevel.ucSubjectGradeLevelCard();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(871, 61);
            this.label1.TabIndex = 206;
            this.label1.Text = "Subject Grade-Level Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucSubjectGradeLevelCard1
            // 
            this.ucSubjectGradeLevelCard1.Location = new System.Drawing.Point(15, 75);
            this.ucSubjectGradeLevelCard1.Name = "ucSubjectGradeLevelCard1";
            this.ucSubjectGradeLevelCard1.Size = new System.Drawing.Size(862, 261);
            this.ucSubjectGradeLevelCard1.TabIndex = 207;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(730, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 39);
            this.button1.TabIndex = 208;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowSubjectGradeLevelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucSubjectGradeLevelCard1);
            this.Controls.Add(this.label1);
            this.Name = "ShowSubjectGradeLevelInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Subject Grade Level Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ucSubjectGradeLevelCard ucSubjectGradeLevelCard1;
        private System.Windows.Forms.Button button1;
    }
}