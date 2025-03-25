namespace Quazy_Quizzes
{
    partial class Form1
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
            this.HelpBtn = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.HelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HelpBtn.ForeColor = System.Drawing.Color.White;
            this.HelpBtn.Location = new System.Drawing.Point(340, 708);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(179, 63);
            this.HelpBtn.TabIndex = 0;
            this.HelpBtn.Text = "Get Help!";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(340, 612);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(179, 63);
            this.btnSignup.TabIndex = 2;
            this.btnSignup.Text = "Sign Up!";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(1057, 612);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(179, 63);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login!";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(966, 373);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(374, 38);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "Enter your username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(966, 482);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(374, 38);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Enter your password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.Black;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblIntro.ForeColor = System.Drawing.Color.White;
            this.lblIntro.Location = new System.Drawing.Point(247, 220);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(414, 234);
            this.lblIntro.TabIndex = 7;
            this.lblIntro.Text = "Quazy Quizzes is a game-\r\nbased learning platform \r\nthat allows users to \r\ncreate" +
    ", share and play \r\ninteractive quizzes, \r\nserveys and discussions.";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStudent
            // 
            this.txtStudent.Enabled = false;
            this.txtStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudent.Location = new System.Drawing.Point(966, 220);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(374, 38);
            this.txtStudent.TabIndex = 8;
            this.txtStudent.Text = "Enter your student number";
            this.txtStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudent.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(966, 399);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(374, 38);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Text = "Enter your email address";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Visible = false;
            // 
            // txtFirst
            // 
            this.txtFirst.Enabled = false;
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirst.Location = new System.Drawing.Point(966, 519);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(374, 38);
            this.txtFirst.TabIndex = 10;
            this.txtFirst.Text = "Enter your first name";
            this.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirst.Visible = false;
            // 
            // txtCourse
            // 
            this.txtCourse.AllowDrop = true;
            this.txtCourse.Enabled = false;
            this.txtCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourse.Location = new System.Drawing.Point(966, 459);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(374, 38);
            this.txtCourse.TabIndex = 9;
            this.txtCourse.Text = "Enter your course title";
            this.txtCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCourse.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSurname.Location = new System.Drawing.Point(966, 579);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(374, 38);
            this.txtSurname.TabIndex = 12;
            this.txtSurname.Text = "Enter your last name";
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSurname.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.Location = new System.Drawing.Point(556, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(514, 46);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Welcome to Quazy Quizzes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quazy_Quizzes.Properties.Resources.BackgroundBox;
            this.pictureBox1.Location = new System.Drawing.Point(111, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1490, 887);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1751, 1008);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

