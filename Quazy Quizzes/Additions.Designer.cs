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
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.ChangeThemeBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersInCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(352, 172);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(121, 21);
            this.StudentComboBox.TabIndex = 0;
            // 
            // LecturerComboBox
            // 
            this.LecturerComboBox.FormattingEnabled = true;
            this.LecturerComboBox.Location = new System.Drawing.Point(352, 258);
            this.LecturerComboBox.Name = "LecturerComboBox";
            this.LecturerComboBox.Size = new System.Drawing.Size(121, 21);
            this.LecturerComboBox.TabIndex = 1;
            // 
            // UsersInCourse
            // 
            this.UsersInCourse.AllowUserToAddRows = false;
            this.UsersInCourse.AllowUserToDeleteRows = false;
            this.UsersInCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersInCourse.Location = new System.Drawing.Point(83, 172);
            this.UsersInCourse.Name = "UsersInCourse";
            this.UsersInCourse.ReadOnly = true;
            this.UsersInCourse.Size = new System.Drawing.Size(245, 150);
            this.UsersInCourse.TabIndex = 2;
            // 
            // StudentLbl
            // 
            this.StudentLbl.AutoSize = true;
            this.StudentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLbl.Location = new System.Drawing.Point(360, 144);
            this.StudentLbl.Name = "StudentLbl";
            this.StudentLbl.Size = new System.Drawing.Size(222, 16);
            this.StudentLbl.TabIndex = 3;
            this.StudentLbl.Text = "Select a student to add to the course";
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(507, 172);
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
            this.LecturerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerLbl.Location = new System.Drawing.Point(360, 228);
            this.LecturerLbl.Name = "LecturerLbl";
            this.LecturerLbl.Size = new System.Drawing.Size(223, 16);
            this.LecturerLbl.TabIndex = 5;
            this.LecturerLbl.Text = "Select a lecturer to add to the course";
            // 
            // AddLecturerBtn
            // 
            this.AddLecturerBtn.Location = new System.Drawing.Point(507, 258);
            this.AddLecturerBtn.Name = "AddLecturerBtn";
            this.AddLecturerBtn.Size = new System.Drawing.Size(85, 23);
            this.AddLecturerBtn.TabIndex = 6;
            this.AddLecturerBtn.Text = "Add Lecturer";
            this.AddLecturerBtn.UseVisualStyleBackColor = true;
            this.AddLecturerBtn.Click += new System.EventHandler(this.AddLecturerBtn_Click);
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HeaderLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.HeaderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeaderLbl.Location = new System.Drawing.Point(0, 0);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(800, 80);
            this.HeaderLbl.TabIndex = 7;
            this.HeaderLbl.Text = "Course Additions";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeThemeBtn
            // 
            this.ChangeThemeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeThemeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ChangeThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeThemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ChangeThemeBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeThemeBtn.Location = new System.Drawing.Point(603, 28);
            this.ChangeThemeBtn.Name = "ChangeThemeBtn";
            this.ChangeThemeBtn.Size = new System.Drawing.Size(185, 40);
            this.ChangeThemeBtn.TabIndex = 9;
            this.ChangeThemeBtn.Text = "Toggle Theme";
            this.ChangeThemeBtn.UseVisualStyleBackColor = false;
            this.ChangeThemeBtn.Click += new System.EventHandler(this.ChangeThemeBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(26, 28);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(146, 40);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Additions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ChangeThemeBtn);
            this.Controls.Add(this.HeaderLbl);
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
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Button ChangeThemeBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}