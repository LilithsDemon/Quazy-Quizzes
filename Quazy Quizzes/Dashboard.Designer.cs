namespace Quazy_Quizzes
{
    partial class Dashboard
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblCourses = new System.Windows.Forms.Label();
            this.btnCourse1 = new System.Windows.Forms.Button();
            this.btnCourse2 = new System.Windows.Forms.Button();
            this.btnCourse3 = new System.Windows.Forms.Button();
            this.btnCourse4 = new System.Windows.Forms.Button();
            this.btnCourse5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.Location = new System.Drawing.Point(554, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(514, 46);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Welcome to Quazy Quizzes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quazy_Quizzes.Properties.Resources.BackgroundBox;
            this.pictureBox1.Location = new System.Drawing.Point(111, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1490, 887);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnHome.Location = new System.Drawing.Point(12, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(213, 99);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Return to Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblCourses.Location = new System.Drawing.Point(181, 155);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(297, 29);
            this.lblCourses.TabIndex = 21;
            this.lblCourses.Text = "Select one of your courses";
            this.lblCourses.Click += new System.EventHandler(this.lblCourses_Click);
            // 
            // btnCourse1
            // 
            this.btnCourse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCourse1.Location = new System.Drawing.Point(186, 223);
            this.btnCourse1.Name = "btnCourse1";
            this.btnCourse1.Size = new System.Drawing.Size(184, 58);
            this.btnCourse1.TabIndex = 22;
            this.btnCourse1.Text = "(Course 1)";
            this.btnCourse1.UseVisualStyleBackColor = true;
            // 
            // btnCourse2
            // 
            this.btnCourse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCourse2.Location = new System.Drawing.Point(186, 334);
            this.btnCourse2.Name = "btnCourse2";
            this.btnCourse2.Size = new System.Drawing.Size(184, 58);
            this.btnCourse2.TabIndex = 23;
            this.btnCourse2.Text = "(Course 2)";
            this.btnCourse2.UseVisualStyleBackColor = true;
            // 
            // btnCourse3
            // 
            this.btnCourse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCourse3.Location = new System.Drawing.Point(186, 456);
            this.btnCourse3.Name = "btnCourse3";
            this.btnCourse3.Size = new System.Drawing.Size(184, 58);
            this.btnCourse3.TabIndex = 24;
            this.btnCourse3.Text = "(Course 3)";
            this.btnCourse3.UseVisualStyleBackColor = true;
            // 
            // btnCourse4
            // 
            this.btnCourse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCourse4.Location = new System.Drawing.Point(186, 572);
            this.btnCourse4.Name = "btnCourse4";
            this.btnCourse4.Size = new System.Drawing.Size(184, 58);
            this.btnCourse4.TabIndex = 25;
            this.btnCourse4.Text = "(Course 4)";
            this.btnCourse4.UseVisualStyleBackColor = true;
            // 
            // btnCourse5
            // 
            this.btnCourse5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCourse5.Location = new System.Drawing.Point(186, 683);
            this.btnCourse5.Name = "btnCourse5";
            this.btnCourse5.Size = new System.Drawing.Size(184, 58);
            this.btnCourse5.TabIndex = 26;
            this.btnCourse5.Text = "(Course 5)";
            this.btnCourse5.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 1008);
            this.Controls.Add(this.btnCourse5);
            this.Controls.Add(this.btnCourse4);
            this.Controls.Add(this.btnCourse3);
            this.Controls.Add(this.btnCourse2);
            this.Controls.Add(this.btnCourse1);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dashboard";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Button btnCourse1;
        private System.Windows.Forms.Button btnCourse2;
        private System.Windows.Forms.Button btnCourse3;
        private System.Windows.Forms.Button btnCourse4;
        private System.Windows.Forms.Button btnCourse5;
    }
}