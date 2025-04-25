namespace Quazy_Quizzes
{
    partial class CreateNewCourse
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
            this.CourseNameLbl = new System.Windows.Forms.Label();
            this.CourseNameInput = new System.Windows.Forms.TextBox();
            this.CreateCourseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseNameLbl
            // 
            this.CourseNameLbl.Location = new System.Drawing.Point(365, 180);
            this.CourseNameLbl.Name = "CourseNameLbl";
            this.CourseNameLbl.Size = new System.Drawing.Size(70, 13);
            this.CourseNameLbl.TabIndex = 0;
            this.CourseNameLbl.Text = "CourseName";
            this.CourseNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseNameInput
            // 
            this.CourseNameInput.Location = new System.Drawing.Point(300, 200);
            this.CourseNameInput.Name = "CourseNameInput";
            this.CourseNameInput.Size = new System.Drawing.Size(200, 20);
            this.CourseNameInput.TabIndex = 1;
            // 
            // CreateCourseBtn
            // 
            this.CreateCourseBtn.Location = new System.Drawing.Point(340, 350);
            this.CreateCourseBtn.Name = "CreateCourseBtn";
            this.CreateCourseBtn.Size = new System.Drawing.Size(120, 50);
            this.CreateCourseBtn.TabIndex = 2;
            this.CreateCourseBtn.Text = "Create Course";
            this.CreateCourseBtn.UseVisualStyleBackColor = true;
            this.CreateCourseBtn.Click += new System.EventHandler(this.CreateCourseBtn_Click);
            // 
            // CreateNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.CreateCourseBtn);
            this.Controls.Add(this.CourseNameInput);
            this.Controls.Add(this.CourseNameLbl);
            this.Name = "CreateNewCourse";
            this.Text = "CreateNewCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseNameLbl;
        private System.Windows.Forms.TextBox CourseNameInput;
        private System.Windows.Forms.Button CreateCourseBtn;
    }
}