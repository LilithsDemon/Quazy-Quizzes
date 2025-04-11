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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.StdntActsBtn = new System.Windows.Forms.Button();
            this.LectrActsBtn = new System.Windows.Forms.Button();
            this.ActGrid = new System.Windows.Forms.DataGridView();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NewUserBtn = new System.Windows.Forms.Button();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.LastLoginLbl = new System.Windows.Forms.Label();
            this.EditActBtn = new System.Windows.Forms.Button();
            this.DisableActBtn = new System.Windows.Forms.Button();
            this.DeleteActBtn = new System.Windows.Forms.Button();
            this.ToggleThemeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ActGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBg
            // 
            this.HeaderBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HeaderBg.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.HeaderBg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeaderBg.Location = new System.Drawing.Point(0, 0);
            this.HeaderBg.Name = "HeaderBg";
            this.HeaderBg.Size = new System.Drawing.Size(1184, 80);
            this.HeaderBg.TabIndex = 2;
            this.HeaderBg.Text = "Lecturer Dashboard";
            this.HeaderBg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidebarBg
            // 
            this.SidebarBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SidebarBg.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarBg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarBg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.SidebarBg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SidebarBg.Location = new System.Drawing.Point(0, 80);
            this.SidebarBg.Name = "SidebarBg";
            this.SidebarBg.Size = new System.Drawing.Size(100, 546);
            this.SidebarBg.TabIndex = 3;
            this.SidebarBg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsersBtn
            // 
            this.UsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersBtn.Location = new System.Drawing.Point(12, 150);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(75, 75);
            this.UsersBtn.TabIndex = 4;
            this.UsersBtn.Text = "Users";
            this.UsersBtn.UseVisualStyleBackColor = true;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // TestsBtn
            // 
            this.TestsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestsBtn.Location = new System.Drawing.Point(12, 300);
            this.TestsBtn.Name = "TestsBtn";
            this.TestsBtn.Size = new System.Drawing.Size(75, 75);
            this.TestsBtn.TabIndex = 5;
            this.TestsBtn.Text = "Tests";
            this.TestsBtn.UseVisualStyleBackColor = true;
            this.TestsBtn.Click += new System.EventHandler(this.TestsBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LogOutBtn.Location = new System.Drawing.Point(12, 450);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 75);
            this.LogOutBtn.TabIndex = 6;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(106, 101);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(1078, 55);
            this.TitleLbl.TabIndex = 7;
            this.TitleLbl.Text = "Title";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StdntActsBtn
            // 
            this.StdntActsBtn.Location = new System.Drawing.Point(300, 175);
            this.StdntActsBtn.Name = "StdntActsBtn";
            this.StdntActsBtn.Size = new System.Drawing.Size(150, 25);
            this.StdntActsBtn.TabIndex = 8;
            this.StdntActsBtn.Text = "Student Accounts";
            this.StdntActsBtn.UseVisualStyleBackColor = true;
            this.StdntActsBtn.Visible = false;
            this.StdntActsBtn.Click += new System.EventHandler(this.StdntActsBtn_Click);
            // 
            // LectrActsBtn
            // 
            this.LectrActsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LectrActsBtn.Location = new System.Drawing.Point(850, 175);
            this.LectrActsBtn.Name = "LectrActsBtn";
            this.LectrActsBtn.Size = new System.Drawing.Size(150, 25);
            this.LectrActsBtn.TabIndex = 9;
            this.LectrActsBtn.Text = "Lecturer Accounts";
            this.LectrActsBtn.UseVisualStyleBackColor = true;
            this.LectrActsBtn.Visible = false;
            this.LectrActsBtn.Click += new System.EventHandler(this.LectrActsBtn_Click);
            // 
            // ActGrid
            // 
            this.ActGrid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ActGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActGrid.Location = new System.Drawing.Point(175, 275);
            this.ActGrid.MultiSelect = false;
            this.ActGrid.Name = "ActGrid";
            this.ActGrid.ReadOnly = true;
            this.ActGrid.Size = new System.Drawing.Size(250, 275);
            this.ActGrid.TabIndex = 11;
            this.ActGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActGrid_CellClick);
            this.ActGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActGrid_RowEnter);
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(600, 275);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(600, 35);
            this.UsernameLbl.TabIndex = 12;
            this.UsernameLbl.Text = "Account Username";
            this.UsernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLbl
            // 
            this.NameLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(600, 325);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(600, 25);
            this.NameLbl.TabIndex = 13;
            this.NameLbl.Text = "Name";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewUserBtn
            // 
            this.NewUserBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewUserBtn.Location = new System.Drawing.Point(575, 570);
            this.NewUserBtn.Name = "NewUserBtn";
            this.NewUserBtn.Size = new System.Drawing.Size(150, 50);
            this.NewUserBtn.TabIndex = 14;
            this.NewUserBtn.Text = "Create New user";
            this.NewUserBtn.UseVisualStyleBackColor = true;
            this.NewUserBtn.Click += new System.EventHandler(this.NewUserBtn_Click);
            // 
            // EmailLbl
            // 
            this.EmailLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(600, 375);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(600, 25);
            this.EmailLbl.TabIndex = 15;
            this.EmailLbl.Text = "Email: ";
            this.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchBar.Location = new System.Drawing.Point(175, 245);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(200, 20);
            this.SearchBar.TabIndex = 16;
            this.SearchBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBar_KeyUp);
            // 
            // SearchLbl
            // 
            this.SearchLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLbl.Location = new System.Drawing.Point(175, 225);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(59, 16);
            this.SearchLbl.TabIndex = 17;
            this.SearchLbl.Text = "Search...";
            this.SearchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastLoginLbl
            // 
            this.LastLoginLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LastLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLoginLbl.Location = new System.Drawing.Point(600, 425);
            this.LastLoginLbl.Name = "LastLoginLbl";
            this.LastLoginLbl.Size = new System.Drawing.Size(600, 25);
            this.LastLoginLbl.TabIndex = 18;
            this.LastLoginLbl.Text = "Last Login: ";
            this.LastLoginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditActBtn
            // 
            this.EditActBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditActBtn.Location = new System.Drawing.Point(700, 515);
            this.EditActBtn.Name = "EditActBtn";
            this.EditActBtn.Size = new System.Drawing.Size(100, 30);
            this.EditActBtn.TabIndex = 19;
            this.EditActBtn.Text = "Edit Account";
            this.EditActBtn.UseVisualStyleBackColor = true;
            this.EditActBtn.Click += new System.EventHandler(this.EditActBtn_Click);
            // 
            // DisableActBtn
            // 
            this.DisableActBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DisableActBtn.Location = new System.Drawing.Point(850, 515);
            this.DisableActBtn.Name = "DisableActBtn";
            this.DisableActBtn.Size = new System.Drawing.Size(100, 30);
            this.DisableActBtn.TabIndex = 20;
            this.DisableActBtn.Text = "Disable Account";
            this.DisableActBtn.UseVisualStyleBackColor = true;
            this.DisableActBtn.Click += new System.EventHandler(this.DisableActBtn_Click);
            // 
            // DeleteActBtn
            // 
            this.DeleteActBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeleteActBtn.Location = new System.Drawing.Point(1000, 515);
            this.DeleteActBtn.Name = "DeleteActBtn";
            this.DeleteActBtn.Size = new System.Drawing.Size(100, 30);
            this.DeleteActBtn.TabIndex = 21;
            this.DeleteActBtn.Text = "Delete Account";
            this.DeleteActBtn.UseVisualStyleBackColor = true;
            this.DeleteActBtn.Click += new System.EventHandler(this.DeleteActBtn_Click);
            // 
            // ToggleThemeBtn
            // 
            this.ToggleThemeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToggleThemeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ToggleThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleThemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ToggleThemeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ToggleThemeBtn.Location = new System.Drawing.Point(950, 20);
            this.ToggleThemeBtn.Name = "ToggleThemeBtn";
            this.ToggleThemeBtn.Size = new System.Drawing.Size(200, 40);
            this.ToggleThemeBtn.TabIndex = 22;
            this.ToggleThemeBtn.Text = "Toggle Theme";
            this.ToggleThemeBtn.UseVisualStyleBackColor = false;
            this.ToggleThemeBtn.Click += new System.EventHandler(this.ToggleThemeBtn_Click);
            // 
            // LecturerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 626);
            this.Controls.Add(this.ActGrid);
            this.Controls.Add(this.ToggleThemeBtn);
            this.Controls.Add(this.DeleteActBtn);
            this.Controls.Add(this.DisableActBtn);
            this.Controls.Add(this.EditActBtn);
            this.Controls.Add(this.LastLoginLbl);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.NewUserBtn);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.LectrActsBtn);
            this.Controls.Add(this.StdntActsBtn);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.TestsBtn);
            this.Controls.Add(this.UsersBtn);
            this.Controls.Add(this.SidebarBg);
            this.Controls.Add(this.HeaderBg);
            this.Name = "LecturerDashboard";
            this.Text = "LecturerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.ActGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderBg;
        private System.Windows.Forms.Label SidebarBg;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button TestsBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button StdntActsBtn;
        private System.Windows.Forms.Button LectrActsBtn;
        private System.Windows.Forms.DataGridView ActGrid;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button NewUserBtn;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.Label LastLoginLbl;
        private System.Windows.Forms.Button EditActBtn;
        private System.Windows.Forms.Button DisableActBtn;
        private System.Windows.Forms.Button DeleteActBtn;
        private System.Windows.Forms.Button ToggleThemeBtn;
    }
}