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
            this.QuizSelectorbtn = new System.Windows.Forms.Button();
            this.ComboBoxExams = new System.Windows.Forms.ComboBox();
            this.ViewAvailableCoursesbtn = new System.Windows.Forms.Button();
            this.CompletedExams = new System.Windows.Forms.DataGridView();
            this.ChangeThemebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedExams)).BeginInit();
            this.SuspendLayout();
            // 
            // QuizSelectorbtn
            // 
            this.QuizSelectorbtn.Location = new System.Drawing.Point(77, 94);
            this.QuizSelectorbtn.Name = "QuizSelectorbtn";
            this.QuizSelectorbtn.Size = new System.Drawing.Size(75, 23);
            this.QuizSelectorbtn.TabIndex = 0;
            this.QuizSelectorbtn.Text = "Go to quiz!";
            this.QuizSelectorbtn.UseVisualStyleBackColor = true;
            this.QuizSelectorbtn.Click += new System.EventHandler(this.QuizSelectorbtn_Click);
            // 
            // ComboBoxExams
            // 
            this.ComboBoxExams.FormattingEnabled = true;
            this.ComboBoxExams.Location = new System.Drawing.Point(54, 56);
            this.ComboBoxExams.Name = "ComboBoxExams";
            this.ComboBoxExams.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxExams.TabIndex = 1;
            // 
            // ViewAvailableCoursesbtn
            // 
            this.ViewAvailableCoursesbtn.Location = new System.Drawing.Point(54, 135);
            this.ViewAvailableCoursesbtn.Name = "ViewAvailableCoursesbtn";
            this.ViewAvailableCoursesbtn.Size = new System.Drawing.Size(134, 23);
            this.ViewAvailableCoursesbtn.TabIndex = 2;
            this.ViewAvailableCoursesbtn.Text = "View Available Courses";
            this.ViewAvailableCoursesbtn.UseVisualStyleBackColor = true;
            // 
            // CompletedExams
            // 
            this.CompletedExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompletedExams.Location = new System.Drawing.Point(302, 56);
            this.CompletedExams.Name = "CompletedExams";
            this.CompletedExams.Size = new System.Drawing.Size(240, 150);
            this.CompletedExams.TabIndex = 3;
            // 
            // ChangeThemebtn
            // 
            this.ChangeThemebtn.Location = new System.Drawing.Point(68, 183);
            this.ChangeThemebtn.Name = "ChangeThemebtn";
            this.ChangeThemebtn.Size = new System.Drawing.Size(93, 23);
            this.ChangeThemebtn.TabIndex = 4;
            this.ChangeThemebtn.Text = "Change Theme";
            this.ChangeThemebtn.UseVisualStyleBackColor = true;
            this.ChangeThemebtn.Click += new System.EventHandler(this.ChangeThemebtn_Click);
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeThemebtn);
            this.Controls.Add(this.CompletedExams);
            this.Controls.Add(this.ViewAvailableCoursesbtn);
            this.Controls.Add(this.ComboBoxExams);
            this.Controls.Add(this.QuizSelectorbtn);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.CompletedExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuizSelectorbtn;
        private System.Windows.Forms.ComboBox ComboBoxExams;
        private System.Windows.Forms.Button ViewAvailableCoursesbtn;
        private System.Windows.Forms.DataGridView CompletedExams;
        private System.Windows.Forms.Button ChangeThemebtn;
    }
}