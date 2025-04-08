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
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.ChangeThemeBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LeaderBoardLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentExamList = new System.Windows.Forms.ListBox();
            this.AllQuizzesList = new System.Windows.Forms.ListBox();
            this.AllQuizzesLbl = new System.Windows.Forms.Label();
            this.StudentQuizzesLbl = new System.Windows.Forms.Label();
            this.AddNewQuizBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.HeaderLbl.ForeColor = System.Drawing.Color.Black;
            this.HeaderLbl.Location = new System.Drawing.Point(1, 0);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(812, 80);
            this.HeaderLbl.TabIndex = 8;
            this.HeaderLbl.Text = "Courses";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeThemeBtn
            // 
            this.ChangeThemeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeThemeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ChangeThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeThemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ChangeThemeBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeThemeBtn.Location = new System.Drawing.Point(546, 28);
            this.ChangeThemeBtn.Name = "ChangeThemeBtn";
            this.ChangeThemeBtn.Size = new System.Drawing.Size(209, 40);
            this.ChangeThemeBtn.TabIndex = 9;
            this.ChangeThemeBtn.Text = "Toggle Theme";
            this.ChangeThemeBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(31, 28);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(124, 40);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // LeaderBoardLbl
            // 
            this.LeaderBoardLbl.AutoSize = true;
            this.LeaderBoardLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderBoardLbl.Location = new System.Drawing.Point(528, 137);
            this.LeaderBoardLbl.Name = "LeaderBoardLbl";
            this.LeaderBoardLbl.Size = new System.Drawing.Size(91, 18);
            this.LeaderBoardLbl.TabIndex = 12;
            this.LeaderBoardLbl.Text = "Leaderboard";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Score});
            this.dataGridView1.Location = new System.Drawing.Point(449, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(247, 243);
            this.dataGridView1.TabIndex = 13;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // StudentExamList
            // 
            this.StudentExamList.FormattingEnabled = true;
            this.StudentExamList.Location = new System.Drawing.Point(202, 163);
            this.StudentExamList.Name = "StudentExamList";
            this.StudentExamList.Size = new System.Drawing.Size(202, 251);
            this.StudentExamList.TabIndex = 14;
            this.StudentExamList.Visible = false;
            // 
            // AllQuizzesList
            // 
            this.AllQuizzesList.FormattingEnabled = true;
            this.AllQuizzesList.Location = new System.Drawing.Point(202, 163);
            this.AllQuizzesList.Name = "AllQuizzesList";
            this.AllQuizzesList.Size = new System.Drawing.Size(202, 251);
            this.AllQuizzesList.TabIndex = 15;
            this.AllQuizzesList.Visible = false;
            // 
            // AllQuizzesLbl
            // 
            this.AllQuizzesLbl.AutoSize = true;
            this.AllQuizzesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllQuizzesLbl.Location = new System.Drawing.Point(269, 137);
            this.AllQuizzesLbl.Name = "AllQuizzesLbl";
            this.AllQuizzesLbl.Size = new System.Drawing.Size(78, 18);
            this.AllQuizzesLbl.TabIndex = 16;
            this.AllQuizzesLbl.Text = "All quizzes";
            // 
            // StudentQuizzesLbl
            // 
            this.StudentQuizzesLbl.AutoSize = true;
            this.StudentQuizzesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentQuizzesLbl.Location = new System.Drawing.Point(251, 137);
            this.StudentQuizzesLbl.Name = "StudentQuizzesLbl";
            this.StudentQuizzesLbl.Size = new System.Drawing.Size(105, 18);
            this.StudentQuizzesLbl.TabIndex = 17;
            this.StudentQuizzesLbl.Text = "Quizzes to do ";
            // 
            // AddNewQuizBtn
            // 
            this.AddNewQuizBtn.Location = new System.Drawing.Point(58, 263);
            this.AddNewQuizBtn.Name = "AddNewQuizBtn";
            this.AddNewQuizBtn.Size = new System.Drawing.Size(97, 56);
            this.AddNewQuizBtn.TabIndex = 18;
            this.AddNewQuizBtn.Text = "Add new quiz";
            this.AddNewQuizBtn.UseVisualStyleBackColor = true;
            this.AddNewQuizBtn.Click += new System.EventHandler(this.AddNewQuizBtn_Click);
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewQuizBtn);
            this.Controls.Add(this.StudentQuizzesLbl);
            this.Controls.Add(this.AllQuizzesLbl);
            this.Controls.Add(this.AllQuizzesList);
            this.Controls.Add(this.StudentExamList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LeaderBoardLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ChangeThemeBtn);
            this.Controls.Add(this.HeaderLbl);
            this.Name = "Courses";
            this.Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Button ChangeThemeBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LeaderBoardLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.ListBox StudentExamList;
        private System.Windows.Forms.ListBox AllQuizzesList;
        private System.Windows.Forms.Label AllQuizzesLbl;
        private System.Windows.Forms.Label StudentQuizzesLbl;
        private System.Windows.Forms.Button AddNewQuizBtn;
    }
}