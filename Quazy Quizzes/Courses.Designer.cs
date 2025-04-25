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
            this.LeaderboardDataGrid = new System.Windows.Forms.DataGridView();
            this.ExamLabel = new System.Windows.Forms.Label();
            this.AddNewQuizBtn = new System.Windows.Forms.Button();
            this.AllExamLabel = new System.Windows.Forms.Label();
            this.ExamDataGridView = new System.Windows.Forms.DataGridView();
            this.LoadQuizBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboardDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExamDataGridView)).BeginInit();
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
            this.ChangeThemeBtn.Click += new System.EventHandler(this.ChangeThemeBtn_Click);
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
            this.LeaderboardLbl.Location = new System.Drawing.Point(471, 111);
            this.LeaderboardLbl.Name = "LeaderboardLbl";
            this.LeaderboardLbl.Size = new System.Drawing.Size(133, 18);
            this.LeaderboardLbl.TabIndex = 11;
            this.LeaderboardLbl.Text = "Class Leaderboard";
            // 
            // LeaderboardDataGrid
            // 
            this.LeaderboardDataGrid.AllowUserToAddRows = false;
            this.LeaderboardDataGrid.AllowUserToDeleteRows = false;
            this.LeaderboardDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.LeaderboardDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaderboardDataGrid.Location = new System.Drawing.Point(423, 148);
            this.LeaderboardDataGrid.Name = "LeaderboardDataGrid";
            this.LeaderboardDataGrid.ReadOnly = true;
            this.LeaderboardDataGrid.Size = new System.Drawing.Size(248, 238);
            this.LeaderboardDataGrid.TabIndex = 12;
            // 
            // ExamLabel
            // 
            this.ExamLabel.AutoSize = true;
            this.ExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamLabel.Location = new System.Drawing.Point(213, 111);
            this.ExamLabel.Name = "ExamLabel";
            this.ExamLabel.Size = new System.Drawing.Size(92, 18);
            this.ExamLabel.TabIndex = 14;
            this.ExamLabel.Text = "Exams to do";
            this.ExamLabel.Visible = false;
            // 
            // AddNewQuizBtn
            // 
            this.AddNewQuizBtn.Location = new System.Drawing.Point(38, 168);
            this.AddNewQuizBtn.Name = "AddNewQuizBtn";
            this.AddNewQuizBtn.Size = new System.Drawing.Size(82, 46);
            this.AddNewQuizBtn.TabIndex = 17;
            this.AddNewQuizBtn.Text = "Add new quiz";
            this.AddNewQuizBtn.UseVisualStyleBackColor = true;
            this.AddNewQuizBtn.Click += new System.EventHandler(this.AddNewQuizBtn_Click);
            // 
            // AllExamLabel
            // 
            this.AllExamLabel.AutoSize = true;
            this.AllExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllExamLabel.Location = new System.Drawing.Point(213, 111);
            this.AllExamLabel.Name = "AllExamLabel";
            this.AllExamLabel.Size = new System.Drawing.Size(73, 18);
            this.AllExamLabel.TabIndex = 16;
            this.AllExamLabel.Text = "All Exams";
            this.AllExamLabel.Visible = false;
            // 
            // ExamDataGridView
            // 
            this.ExamDataGridView.AllowUserToAddRows = false;
            this.ExamDataGridView.AllowUserToDeleteRows = false;
            this.ExamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamDataGridView.Location = new System.Drawing.Point(142, 148);
            this.ExamDataGridView.Name = "ExamDataGridView";
            this.ExamDataGridView.ReadOnly = true;
            this.ExamDataGridView.Size = new System.Drawing.Size(238, 238);
            this.ExamDataGridView.TabIndex = 18;
            // 
            // LoadQuizBtn
            // 
            this.LoadQuizBtn.Location = new System.Drawing.Point(177, 415);
            this.LoadQuizBtn.Name = "LoadQuizBtn";
            this.LoadQuizBtn.Size = new System.Drawing.Size(164, 23);
            this.LoadQuizBtn.TabIndex = 19;
            this.LoadQuizBtn.Text = "Load Selected Quiz";
            this.LoadQuizBtn.UseVisualStyleBackColor = true;
            this.LoadQuizBtn.Click += new System.EventHandler(this.LoadQuizBtn_Click);
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadQuizBtn);
            this.Controls.Add(this.ExamDataGridView);
            this.Controls.Add(this.AddNewQuizBtn);
            this.Controls.Add(this.AllExamLabel);
            this.Controls.Add(this.ExamLabel);
            this.Controls.Add(this.LeaderboardDataGrid);
            this.Controls.Add(this.LeaderboardLbl);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.ChangeThemeBtn);
            this.Controls.Add(this.HeaderBg);
            this.Name = "Courses";
            this.Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboardDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExamDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderBg;
        private System.Windows.Forms.Button ChangeThemeBtn;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LeaderboardLbl;
        private System.Windows.Forms.DataGridView LeaderboardDataGrid;
        private System.Windows.Forms.Label ExamLabel;
        private System.Windows.Forms.Button AddNewQuizBtn;
        private System.Windows.Forms.Label AllExamLabel;
        private System.Windows.Forms.DataGridView ExamDataGridView;
        private System.Windows.Forms.Button LoadQuizBtn;
    }
}