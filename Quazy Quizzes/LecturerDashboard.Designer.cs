namespace Quazy_Quizzes
{
    partial class LecturerDashboard
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
            this.HeaderBg = new System.Windows.Forms.Label();
            this.SidebarBg = new System.Windows.Forms.Label();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.TestsBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderBg
            // 
            this.HeaderBg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HeaderBg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.HeaderBg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeaderBg.Location = new System.Drawing.Point(0, 0);
            this.HeaderBg.Name = "HeaderBg";
            this.HeaderBg.Size = new System.Drawing.Size(1280, 80);
            this.HeaderBg.TabIndex = 2;
            this.HeaderBg.Text = "Lecturer Dashboard";
            this.HeaderBg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidebarBg
            // 
            this.SidebarBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SidebarBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SidebarBg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidebarBg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.SidebarBg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SidebarBg.Location = new System.Drawing.Point(-48, 80);
            this.SidebarBg.Name = "SidebarBg";
            this.SidebarBg.Size = new System.Drawing.Size(150, 800);
            this.SidebarBg.TabIndex = 3;
            this.SidebarBg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsersBtn
            // 
            this.UsersBtn.Location = new System.Drawing.Point(12, 150);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(75, 75);
            this.UsersBtn.TabIndex = 4;
            this.UsersBtn.Text = "Users";
            this.UsersBtn.UseVisualStyleBackColor = true;
            // 
            // TestsBtn
            // 
            this.TestsBtn.Location = new System.Drawing.Point(12, 300);
            this.TestsBtn.Name = "TestsBtn";
            this.TestsBtn.Size = new System.Drawing.Size(75, 75);
            this.TestsBtn.TabIndex = 5;
            this.TestsBtn.Text = "Tests";
            this.TestsBtn.UseVisualStyleBackColor = true;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(12, 450);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 75);
            this.LogOutBtn.TabIndex = 6;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            // 
            // LecturerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 626);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.TestsBtn);
            this.Controls.Add(this.UsersBtn);
            this.Controls.Add(this.SidebarBg);
            this.Controls.Add(this.HeaderBg);
            this.Name = "LecturerDashboard";
            this.Text = "LecturerDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HeaderBg;
        private System.Windows.Forms.Label SidebarBg;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button TestsBtn;
        private System.Windows.Forms.Button LogOutBtn;
    }
}