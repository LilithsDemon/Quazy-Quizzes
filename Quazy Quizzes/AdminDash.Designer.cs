namespace Quazy_Quizzes
{
    partial class AdminDash
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.cboboxSelect = new System.Windows.Forms.ComboBox();
            this.cboboxOptions = new System.Windows.Forms.ComboBox();
            this.lblRemove = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboClasses = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnLogout.Location = new System.Drawing.Point(25, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(213, 99);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.Location = new System.Drawing.Point(367, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(759, 46);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Welcome admin! What needs doing today";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quazy_Quizzes.Properties.Resources.BackgroundBox;
            this.pictureBox1.Location = new System.Drawing.Point(124, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1490, 887);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblCourses.Location = new System.Drawing.Point(194, 171);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(310, 29);
            this.lblCourses.TabIndex = 30;
            this.lblCourses.Text = "What would you like to edit?";
            // 
            // cboboxSelect
            // 
            this.cboboxSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cboboxSelect.FormattingEnabled = true;
            this.cboboxSelect.Items.AddRange(new object[] {
            "Teachers",
            "Courses",
            "Student profiles"});
            this.cboboxSelect.Location = new System.Drawing.Point(522, 168);
            this.cboboxSelect.Name = "cboboxSelect";
            this.cboboxSelect.Size = new System.Drawing.Size(198, 37);
            this.cboboxSelect.TabIndex = 31;
            this.cboboxSelect.SelectedIndexChanged += new System.EventHandler(this.cboboxSelect_SelectedIndexChanged);
            // 
            // cboboxOptions
            // 
            this.cboboxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cboboxOptions.FormattingEnabled = true;
            this.cboboxOptions.Location = new System.Drawing.Point(734, 168);
            this.cboboxOptions.Name = "cboboxOptions";
            this.cboboxOptions.Size = new System.Drawing.Size(317, 37);
            this.cboboxOptions.TabIndex = 32;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Enabled = false;
            this.lblRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblRemove.Location = new System.Drawing.Point(209, 265);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(564, 29);
            this.lblRemove.TabIndex = 33;
            this.lblRemove.Text = "Would you like to revoke their ownership of a class?";
            this.lblRemove.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnRemove.Location = new System.Drawing.Point(1002, 259);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(139, 40);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // cboClasses
            // 
            this.cboClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cboClasses.FormattingEnabled = true;
            this.cboClasses.Location = new System.Drawing.Point(791, 262);
            this.cboClasses.Name = "cboClasses";
            this.cboClasses.Size = new System.Drawing.Size(188, 37);
            this.cboClasses.TabIndex = 35;
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 1008);
            this.Controls.Add(this.cboClasses);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.cboboxOptions);
            this.Controls.Add(this.cboboxSelect);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminDash";
            this.Text = "AdminDash";
            this.Load += new System.EventHandler(this.AdminDash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.ComboBox cboboxSelect;
        private System.Windows.Forms.ComboBox cboboxOptions;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cboClasses;
    }
}