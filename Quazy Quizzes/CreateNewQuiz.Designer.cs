namespace Quazy_Quizzes
{
    partial class CreateNewQuiz
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
            this.QuizNameLbl = new System.Windows.Forms.Label();
            this.CourseNameLbl = new System.Windows.Forms.Label();
            this.CreateQuizBtn = new System.Windows.Forms.Button();
            this.QuizNameInput = new System.Windows.Forms.TextBox();
            this.CourseNameCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // QuizNameLbl
            // 
            this.QuizNameLbl.Location = new System.Drawing.Point(350, 110);
            this.QuizNameLbl.Name = "QuizNameLbl";
            this.QuizNameLbl.Size = new System.Drawing.Size(100, 40);
            this.QuizNameLbl.TabIndex = 0;
            this.QuizNameLbl.Text = "Quiz Name";
            this.QuizNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseNameLbl
            // 
            this.CourseNameLbl.Location = new System.Drawing.Point(350, 220);
            this.CourseNameLbl.Name = "CourseNameLbl";
            this.CourseNameLbl.Size = new System.Drawing.Size(100, 23);
            this.CourseNameLbl.TabIndex = 1;
            this.CourseNameLbl.Text = "Course for the Quiz";
            this.CourseNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateQuizBtn
            // 
            this.CreateQuizBtn.Location = new System.Drawing.Point(340, 350);
            this.CreateQuizBtn.Name = "CreateQuizBtn";
            this.CreateQuizBtn.Size = new System.Drawing.Size(120, 50);
            this.CreateQuizBtn.TabIndex = 2;
            this.CreateQuizBtn.Text = "Create New Quiz";
            this.CreateQuizBtn.UseVisualStyleBackColor = true;
            this.CreateQuizBtn.Click += new System.EventHandler(this.CreateQuizBtn_Click);
            // 
            // QuizNameInput
            // 
            this.QuizNameInput.Location = new System.Drawing.Point(300, 150);
            this.QuizNameInput.Name = "QuizNameInput";
            this.QuizNameInput.Size = new System.Drawing.Size(200, 20);
            this.QuizNameInput.TabIndex = 3;
            // 
            // CourseNameCB
            // 
            this.CourseNameCB.FormattingEnabled = true;
            this.CourseNameCB.Location = new System.Drawing.Point(300, 250);
            this.CourseNameCB.Name = "CourseNameCB";
            this.CourseNameCB.Size = new System.Drawing.Size(200, 21);
            this.CourseNameCB.TabIndex = 4;
            // 
            // CreateNewQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.CourseNameCB);
            this.Controls.Add(this.QuizNameInput);
            this.Controls.Add(this.CreateQuizBtn);
            this.Controls.Add(this.CourseNameLbl);
            this.Controls.Add(this.QuizNameLbl);
            this.Name = "CreateNewQuiz";
            this.Text = "CreateNewQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuizNameLbl;
        private System.Windows.Forms.Label CourseNameLbl;
        private System.Windows.Forms.Button CreateQuizBtn;
        private System.Windows.Forms.TextBox QuizNameInput;
        private System.Windows.Forms.ComboBox CourseNameCB;
    }
}