namespace Quazy_Quizzes
{
    partial class Additions
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
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.LecturerComboBox = new System.Windows.Forms.ComboBox();
            this.UsersInCourse = new System.Windows.Forms.DataGridView();
            this.StudentLbl = new System.Windows.Forms.Label();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.LecturerLbl = new System.Windows.Forms.Label();
            this.AddLecturerBtn = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UsersInCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(322, 77);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(121, 21);
            this.StudentComboBox.TabIndex = 0;
            // 
            // LecturerComboBox
            // 
            this.LecturerComboBox.FormattingEnabled = true;
            this.LecturerComboBox.Location = new System.Drawing.Point(322, 163);
            this.LecturerComboBox.Name = "LecturerComboBox";
            this.LecturerComboBox.Size = new System.Drawing.Size(121, 21);
            this.LecturerComboBox.TabIndex = 1;
            // 
            // UsersInCourse
            // 
            this.UsersInCourse.AllowUserToDeleteRows = false;
            this.UsersInCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersInCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.Surname});
            this.UsersInCourse.Location = new System.Drawing.Point(53, 77);
            this.UsersInCourse.Name = "UsersInCourse";
            this.UsersInCourse.ReadOnly = true;
            this.UsersInCourse.Size = new System.Drawing.Size(245, 150);
            this.UsersInCourse.TabIndex = 2;
            // 
            // StudentLbl
            // 
            this.StudentLbl.AutoSize = true;
            this.StudentLbl.Location = new System.Drawing.Point(350, 42);
            this.StudentLbl.Name = "StudentLbl";
            this.StudentLbl.Size = new System.Drawing.Size(182, 13);
            this.StudentLbl.TabIndex = 3;
            this.StudentLbl.Text = "Select a student to add to the course";
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(477, 77);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.AddStudentBtn.TabIndex = 4;
            this.AddStudentBtn.Text = "Add Student";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // LecturerLbl
            // 
            this.LecturerLbl.AutoSize = true;
            this.LecturerLbl.Location = new System.Drawing.Point(350, 130);
            this.LecturerLbl.Name = "LecturerLbl";
            this.LecturerLbl.Size = new System.Drawing.Size(182, 13);
            this.LecturerLbl.TabIndex = 5;
            this.LecturerLbl.Text = "Select a lecturer to add to the course";
            // 
            // AddLecturerBtn
            // 
            this.AddLecturerBtn.Location = new System.Drawing.Point(477, 163);
            this.AddLecturerBtn.Name = "AddLecturerBtn";
            this.AddLecturerBtn.Size = new System.Drawing.Size(85, 23);
            this.AddLecturerBtn.TabIndex = 6;
            this.AddLecturerBtn.Text = "Add Lecturer";
            this.AddLecturerBtn.UseVisualStyleBackColor = true;
            this.AddLecturerBtn.Click += new System.EventHandler(this.AddLecturerBtn_Click);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Additions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddLecturerBtn);
            this.Controls.Add(this.LecturerLbl);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.StudentLbl);
            this.Controls.Add(this.UsersInCourse);
            this.Controls.Add(this.LecturerComboBox);
            this.Controls.Add(this.StudentComboBox);
            this.Name = "Additions";
            this.Text = "Additions";
            ((System.ComponentModel.ISupportInitialize)(this.UsersInCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.ComboBox LecturerComboBox;
        private System.Windows.Forms.DataGridView UsersInCourse;
        private System.Windows.Forms.Label StudentLbl;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Label LecturerLbl;
        private System.Windows.Forms.Button AddLecturerBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
    }
}