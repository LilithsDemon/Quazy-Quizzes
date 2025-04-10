namespace Quazy_Quizzes
{
    partial class Courses
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
            this.HeaderBg = new System.Windows.Forms.Label();
            this.ChangeThemeBtn = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LeaderboardLbl = new System.Windows.Forms.Label();
            this.LeaderboadDataGrid = new System.Windows.Forms.DataGridView();
            this.StudentExamsList = new System.Windows.Forms.ListBox();
            this.ExamLabel = new System.Windows.Forms.Label();
            this.AllExams = new System.Windows.Forms.ListBox();
            this.AllExamLabel = new System.Windows.Forms.Label();
            this.AddNewQuizBtn = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboadDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBg
            // 
            this.HeaderBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HeaderBg.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.HeaderBg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeaderBg.Location = new System.Drawing.Point(0, 0);
            this.HeaderBg.Name = "HeaderBg";
            this.HeaderBg.Size = new System.Drawing.Size(800, 80);
            this.HeaderBg.TabIndex = 3;
            this.HeaderBg.Text = "Courses";
            this.HeaderBg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeThemeBtn
            // 
            this.ChangeThemeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeThemeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ChangeThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeThemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ChangeThemeBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeThemeBtn.Location = new System.Drawing.Point(544, 28);
            this.ChangeThemeBtn.Name = "ChangeThemeBtn";
            this.ChangeThemeBtn.Size = new System.Drawing.Size(209, 40);
            this.ChangeThemeBtn.TabIndex = 9;
            this.ChangeThemeBtn.Text = "Toggle Theme";
            this.ChangeThemeBtn.UseVisualStyleBackColor = false;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(53, 28);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(120, 40);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LeaderboardLbl
            // 
            this.LeaderboardLbl.AutoSize = true;
            this.LeaderboardLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardLbl.Location = new System.Drawing.Point(471, 151);
            this.LeaderboardLbl.Name = "LeaderboardLbl";
            this.LeaderboardLbl.Size = new System.Drawing.Size(133, 18);
            this.LeaderboardLbl.TabIndex = 11;
            this.LeaderboardLbl.Text = "Class Leaderboard";
            // 
            // LeaderboadDataGrid
            // 
            this.LeaderboadDataGrid.AllowUserToAddRows = false;
            this.LeaderboadDataGrid.AllowUserToDeleteRows = false;
            this.LeaderboadDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.LeaderboadDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaderboadDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.Score});
            this.LeaderboadDataGrid.Location = new System.Drawing.Point(425, 193);
            this.LeaderboadDataGrid.Name = "LeaderboadDataGrid";
            this.LeaderboadDataGrid.ReadOnly = true;
            this.LeaderboadDataGrid.Size = new System.Drawing.Size(248, 238);
            this.LeaderboadDataGrid.TabIndex = 12;
            // 
            // StudentExamsList
            // 
            this.StudentExamsList.FormattingEnabled = true;
            this.StudentExamsList.Location = new System.Drawing.Point(144, 193);
            this.StudentExamsList.Name = "StudentExamsList";
            this.StudentExamsList.Size = new System.Drawing.Size(240, 238);
            this.StudentExamsList.TabIndex = 13;
            this.StudentExamsList.Visible = false;
            // 
            // ExamLabel
            // 
            this.ExamLabel.AutoSize = true;
            this.ExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamLabel.Location = new System.Drawing.Point(213, 151);
            this.ExamLabel.Name = "ExamLabel";
            this.ExamLabel.Size = new System.Drawing.Size(92, 18);
            this.ExamLabel.TabIndex = 14;
            this.ExamLabel.Text = "Exams to do";
            this.ExamLabel.Visible = false;
            // 
            // AllExams
            // 
            this.AllExams.FormattingEnabled = true;
            this.AllExams.Location = new System.Drawing.Point(144, 193);
            this.AllExams.Name = "AllExams";
            this.AllExams.Size = new System.Drawing.Size(240, 238);
            this.AllExams.TabIndex = 15;
            this.AllExams.Visible = false;
            // 
            // AllExamLabel
            // 
            this.AllExamLabel.AutoSize = true;
            this.AllExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllExamLabel.Location = new System.Drawing.Point(213, 151);
            this.AllExamLabel.Name = "AllExamLabel";
            this.AllExamLabel.Size = new System.Drawing.Size(73, 18);
            this.AllExamLabel.TabIndex = 16;
            this.AllExamLabel.Text = "All Exams";
            this.AllExamLabel.Visible = false;
            // 
            // AddNewQuizBtn
            // 
            this.AddNewQuizBtn.Location = new System.Drawing.Point(37, 212);
            this.AddNewQuizBtn.Name = "AddNewQuizBtn";
            this.AddNewQuizBtn.Size = new System.Drawing.Size(82, 46);
            this.AddNewQuizBtn.TabIndex = 17;
            this.AddNewQuizBtn.Text = "Add new quiz";
            this.AddNewQuizBtn.UseVisualStyleBackColor = true;
            this.AddNewQuizBtn.Click += new System.EventHandler(this.AddNewQuizBtn_Click);
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewQuizBtn);
            this.Controls.Add(this.AllExamLabel);
            this.Controls.Add(this.AllExams);
            this.Controls.Add(this.ExamLabel);
            this.Controls.Add(this.StudentExamsList);
            this.Controls.Add(this.LeaderboadDataGrid);
            this.Controls.Add(this.LeaderboardLbl);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.ChangeThemeBtn);
            this.Controls.Add(this.HeaderBg);
            this.Name = "Courses";
            this.Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboadDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderBg;
        private System.Windows.Forms.Button ChangeThemeBtn;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LeaderboardLbl;
        private System.Windows.Forms.DataGridView LeaderboadDataGrid;
        private System.Windows.Forms.ListBox StudentExamsList;
        private System.Windows.Forms.Label ExamLabel;
        private System.Windows.Forms.ListBox AllExams;
        private System.Windows.Forms.Label AllExamLabel;
        private System.Windows.Forms.Button AddNewQuizBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}