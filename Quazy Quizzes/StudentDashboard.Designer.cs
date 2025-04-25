namespace Quazy_Quizzes
{
    partial class StudentDashboard
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
            this.ComboBoxCourses = new System.Windows.Forms.ComboBox();
            this.CompletedExams = new System.Windows.Forms.DataGridView();
            this.UserWelcomeLbl = new System.Windows.Forms.Label();
            this.PastExamsLbl = new System.Windows.Forms.Label();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.ChangeThemeBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.CourseSelectorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedExams)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxCourses
            // 
            this.ComboBoxCourses.FormattingEnabled = true;
            this.ComboBoxCourses.Location = new System.Drawing.Point(25, 120);
            this.ComboBoxCourses.Name = "ComboBoxCourses";
            this.ComboBoxCourses.Size = new System.Drawing.Size(134, 21);
            this.ComboBoxCourses.TabIndex = 1;
            // 
            // CompletedExams
            // 
            this.CompletedExams.AllowUserToAddRows = false;
            this.CompletedExams.AllowUserToDeleteRows = false;
            this.CompletedExams.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CompletedExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompletedExams.Location = new System.Drawing.Point(356, 117);
            this.CompletedExams.Name = "CompletedExams";
            this.CompletedExams.ReadOnly = true;
            this.CompletedExams.Size = new System.Drawing.Size(240, 150);
            this.CompletedExams.TabIndex = 3;
            // 
            // UserWelcomeLbl
            // 
            this.UserWelcomeLbl.AutoSize = true;
            this.UserWelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserWelcomeLbl.Location = new System.Drawing.Point(22, 89);
            this.UserWelcomeLbl.Name = "UserWelcomeLbl";
            this.UserWelcomeLbl.Size = new System.Drawing.Size(276, 18);
            this.UserWelcomeLbl.TabIndex = 5;
            this.UserWelcomeLbl.Text = "Welcome, Student, select a course!";
            // 
            // PastExamsLbl
            // 
            this.PastExamsLbl.AutoSize = true;
            this.PastExamsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastExamsLbl.Location = new System.Drawing.Point(353, 89);
            this.PastExamsLbl.Name = "PastExamsLbl";
            this.PastExamsLbl.Size = new System.Drawing.Size(243, 18);
            this.PastExamsLbl.TabIndex = 6;
            this.PastExamsLbl.Text = "View the scores on past quizes";
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.HeaderLbl.ForeColor = System.Drawing.Color.Black;
            this.HeaderLbl.Location = new System.Drawing.Point(-12, -8);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(812, 80);
            this.HeaderLbl.TabIndex = 7;
            this.HeaderLbl.Text = "Dashboard";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeThemeBtn
            // 
            this.ChangeThemeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeThemeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ChangeThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeThemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ChangeThemeBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeThemeBtn.Location = new System.Drawing.Point(536, 12);
            this.ChangeThemeBtn.Name = "ChangeThemeBtn";
            this.ChangeThemeBtn.Size = new System.Drawing.Size(209, 40);
            this.ChangeThemeBtn.TabIndex = 8;
            this.ChangeThemeBtn.Text = "Toggle Theme";
            this.ChangeThemeBtn.UseVisualStyleBackColor = false;
            this.ChangeThemeBtn.Click += new System.EventHandler(this.ChangeThemeBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Location = new System.Drawing.Point(100, 12);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(146, 40);
            this.LogOutBtn.TabIndex = 9;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // CourseSelectorBtn
            // 
            this.CourseSelectorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.CourseSelectorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseSelectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseSelectorBtn.ForeColor = System.Drawing.Color.White;
            this.CourseSelectorBtn.Location = new System.Drawing.Point(180, 110);
            this.CourseSelectorBtn.Name = "CourseSelectorBtn";
            this.CourseSelectorBtn.Size = new System.Drawing.Size(117, 37);
            this.CourseSelectorBtn.TabIndex = 10;
            this.CourseSelectorBtn.Text = "Go to course!";
            this.CourseSelectorBtn.UseVisualStyleBackColor = false;
            this.CourseSelectorBtn.Click += new System.EventHandler(this.CourseSelectorBtn_Click_1);
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CourseSelectorBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ChangeThemeBtn);
            this.Controls.Add(this.HeaderLbl);
            this.Controls.Add(this.PastExamsLbl);
            this.Controls.Add(this.UserWelcomeLbl);
            this.Controls.Add(this.CompletedExams);
            this.Controls.Add(this.ComboBoxCourses);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.CompletedExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxCourses;
        private System.Windows.Forms.DataGridView CompletedExams;
        private System.Windows.Forms.Label UserWelcomeLbl;
        private System.Windows.Forms.Label PastExamsLbl;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Button ChangeThemeBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button CourseSelectorBtn;
    }
}