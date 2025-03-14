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
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.rctxtLeaderboards = new System.Windows.Forms.RichTextBox();
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
            this.btnHome.Text = "Logout";
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
            // cboCourse
            // 
            this.cboCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(504, 152);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(257, 37);
            this.cboCourse.TabIndex = 22;
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
            // 
            // rctxtLeaderboards
            // 
            this.rctxtLeaderboards.Enabled = false;
            this.rctxtLeaderboards.Location = new System.Drawing.Point(1220, 293);
            this.rctxtLeaderboards.Name = "rctxtLeaderboards";
            this.rctxtLeaderboards.Size = new System.Drawing.Size(284, 362);
            this.rctxtLeaderboards.TabIndex = 23;
            this.rctxtLeaderboards.Text = "";
            this.rctxtLeaderboards.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 1008);
            this.Controls.Add(this.rctxtLeaderboards);
            this.Controls.Add(this.cboCourse);
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
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.RichTextBox rctxtLeaderboards;
    }
}