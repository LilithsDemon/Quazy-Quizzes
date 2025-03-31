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
            this.ComboBoxExams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuizSelectorbtn = new System.Windows.Forms.Button();
            this.CompletedExams = new System.Windows.Forms.DataGridView();
            this.examName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewAvailableCoursesbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedExams)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxExams
            // 
            this.ComboBoxExams.FormattingEnabled = true;
            this.ComboBoxExams.Location = new System.Drawing.Point(112, 64);
            this.ComboBoxExams.Name = "ComboBoxExams";
            this.ComboBoxExams.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxExams.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select a quiz, Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuizSelectorbtn
            // 
            this.QuizSelectorbtn.Location = new System.Drawing.Point(135, 91);
            this.QuizSelectorbtn.Name = "QuizSelectorbtn";
            this.QuizSelectorbtn.Size = new System.Drawing.Size(75, 23);
            this.QuizSelectorbtn.TabIndex = 2;
            this.QuizSelectorbtn.Text = "Go!";
            this.QuizSelectorbtn.UseVisualStyleBackColor = true;
            this.QuizSelectorbtn.Click += new System.EventHandler(this.QuizSelectorbtn_Click);
            // 
            // CompletedExams
            // 
            this.CompletedExams.BackgroundColor = System.Drawing.Color.White;
            this.CompletedExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompletedExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examName,
            this.ExamScore});
            this.CompletedExams.Location = new System.Drawing.Point(527, 125);
            this.CompletedExams.Name = "CompletedExams";
            this.CompletedExams.Size = new System.Drawing.Size(240, 150);
            this.CompletedExams.TabIndex = 3;
            // 
            // examName
            // 
            this.examName.HeaderText = "Exam Name";
            this.examName.Name = "examName";
            // 
            // ExamScore
            // 
            this.ExamScore.HeaderText = "Score";
            this.ExamScore.Name = "ExamScore";
            // 
            // ViewAvailableCoursesbtn
            // 
            this.ViewAvailableCoursesbtn.Location = new System.Drawing.Point(99, 185);
            this.ViewAvailableCoursesbtn.Name = "ViewAvailableCoursesbtn";
            this.ViewAvailableCoursesbtn.Size = new System.Drawing.Size(156, 23);
            this.ViewAvailableCoursesbtn.TabIndex = 4;
            this.ViewAvailableCoursesbtn.Text = "View Available Courses";
            this.ViewAvailableCoursesbtn.UseVisualStyleBackColor = true;
            this.ViewAvailableCoursesbtn.Click += new System.EventHandler(this.ViewAvailableCoursesbtn_Click);
            // 
            // Student_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewAvailableCoursesbtn);
            this.Controls.Add(this.CompletedExams);
            this.Controls.Add(this.QuizSelectorbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxExams);
            this.Name = "Student_Dashboard";
            this.Text = "Student_Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.CompletedExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxExams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button QuizSelectorbtn;
        private System.Windows.Forms.DataGridView CompletedExams;
        private System.Windows.Forms.DataGridViewTextBoxColumn examName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamScore;
        private System.Windows.Forms.Button ViewAvailableCoursesbtn;
    }
}