namespace Quazy_Quizzes
{
    partial class CreateNewUser
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
            this.CreateUserBtn = new System.Windows.Forms.Button();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.SecurityQLbl = new System.Windows.Forms.Label();
            this.SecurityQCB = new System.Windows.Forms.ComboBox();
            this.SecurityALbl = new System.Windows.Forms.Label();
            this.SecurityAInput = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.RoleCB = new System.Windows.Forms.ComboBox();
            this.RoleLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateUserBtn
            // 
            this.CreateUserBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateUserBtn.AutoSize = true;
            this.CreateUserBtn.Location = new System.Drawing.Point(325, 600);
            this.CreateUserBtn.Name = "CreateUserBtn";
            this.CreateUserBtn.Size = new System.Drawing.Size(150, 50);
            this.CreateUserBtn.TabIndex = 9;
            this.CreateUserBtn.Text = "Create New user";
            this.CreateUserBtn.UseVisualStyleBackColor = true;
            this.CreateUserBtn.Click += new System.EventHandler(this.CreateUserBtn_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameInput.Location = new System.Drawing.Point(325, 55);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(150, 20);
            this.UsernameInput.TabIndex = 1;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLbl.Location = new System.Drawing.Point(325, 27);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(150, 25);
            this.UsernameLbl.TabIndex = 2;
            this.UsernameLbl.Text = "Username";
            this.UsernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstNameLbl.Location = new System.Drawing.Point(325, 97);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(150, 25);
            this.FirstNameLbl.TabIndex = 4;
            this.FirstNameLbl.Text = "First Name";
            this.FirstNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstNameInput.Location = new System.Drawing.Point(325, 125);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(150, 20);
            this.FirstNameInput.TabIndex = 2;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameLbl.Location = new System.Drawing.Point(325, 170);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(150, 25);
            this.LastNameLbl.TabIndex = 6;
            this.LastNameLbl.Text = "Last Name";
            this.LastNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameInput.Location = new System.Drawing.Point(325, 198);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(150, 20);
            this.LastNameInput.TabIndex = 3;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLbl.Location = new System.Drawing.Point(325, 313);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(150, 25);
            this.PasswordLbl.TabIndex = 8;
            this.PasswordLbl.Text = "Password";
            this.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordInput.Location = new System.Drawing.Point(325, 341);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(150, 20);
            this.PasswordInput.TabIndex = 5;
            // 
            // SecurityQLbl
            // 
            this.SecurityQLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecurityQLbl.Location = new System.Drawing.Point(325, 380);
            this.SecurityQLbl.Name = "SecurityQLbl";
            this.SecurityQLbl.Size = new System.Drawing.Size(150, 25);
            this.SecurityQLbl.TabIndex = 10;
            this.SecurityQLbl.Text = "Security Question";
            this.SecurityQLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecurityQCB
            // 
            this.SecurityQCB.FormattingEnabled = true;
            this.SecurityQCB.Location = new System.Drawing.Point(325, 408);
            this.SecurityQCB.Name = "SecurityQCB";
            this.SecurityQCB.Size = new System.Drawing.Size(150, 21);
            this.SecurityQCB.TabIndex = 6;
            // 
            // SecurityALbl
            // 
            this.SecurityALbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecurityALbl.Location = new System.Drawing.Point(325, 444);
            this.SecurityALbl.Name = "SecurityALbl";
            this.SecurityALbl.Size = new System.Drawing.Size(150, 25);
            this.SecurityALbl.TabIndex = 13;
            this.SecurityALbl.Text = "Security Answer";
            this.SecurityALbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecurityAInput
            // 
            this.SecurityAInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecurityAInput.Location = new System.Drawing.Point(325, 472);
            this.SecurityAInput.Name = "SecurityAInput";
            this.SecurityAInput.Size = new System.Drawing.Size(150, 20);
            this.SecurityAInput.TabIndex = 7;
            // 
            // EmailLbl
            // 
            this.EmailLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailLbl.Location = new System.Drawing.Point(325, 249);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(150, 25);
            this.EmailLbl.TabIndex = 15;
            this.EmailLbl.Text = "Email";
            this.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailInput
            // 
            this.EmailInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailInput.Location = new System.Drawing.Point(325, 277);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(150, 20);
            this.EmailInput.TabIndex = 4;
            // 
            // RoleCB
            // 
            this.RoleCB.FormattingEnabled = true;
            this.RoleCB.Location = new System.Drawing.Point(322, 539);
            this.RoleCB.Name = "RoleCB";
            this.RoleCB.Size = new System.Drawing.Size(150, 21);
            this.RoleCB.TabIndex = 8;
            // 
            // RoleLbl
            // 
            this.RoleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleLbl.Location = new System.Drawing.Point(322, 511);
            this.RoleLbl.Name = "RoleLbl";
            this.RoleLbl.Size = new System.Drawing.Size(150, 25);
            this.RoleLbl.TabIndex = 16;
            this.RoleLbl.Text = "Role";
            this.RoleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(30, 27);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 50);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RoleCB);
            this.Controls.Add(this.RoleLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.SecurityALbl);
            this.Controls.Add(this.SecurityAInput);
            this.Controls.Add(this.SecurityQCB);
            this.Controls.Add(this.SecurityQLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.CreateUserBtn);
            this.Name = "CreateNewUser";
            this.Text = "CreateNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateUserBtn;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label SecurityQLbl;
        private System.Windows.Forms.ComboBox SecurityQCB;
        private System.Windows.Forms.Label SecurityALbl;
        private System.Windows.Forms.TextBox SecurityAInput;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.ComboBox RoleCB;
        private System.Windows.Forms.Label RoleLbl;
        private System.Windows.Forms.Button CancelBtn;
    }
}