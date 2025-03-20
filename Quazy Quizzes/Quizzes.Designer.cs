namespace Quazy_Quizzes
{
    partial class Quizzes
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
            this.lblQuizname = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.rbnAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbnAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbnAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbnAnswer4 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuizname
            // 
            this.lblQuizname.AutoSize = true;
            this.lblQuizname.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblQuizname.Location = new System.Drawing.Point(705, 30);
            this.lblQuizname.Name = "lblQuizname";
            this.lblQuizname.Size = new System.Drawing.Size(208, 46);
            this.lblQuizname.TabIndex = 15;
            this.lblQuizname.Text = "QuizName";
            this.lblQuizname.Click += new System.EventHandler(this.lblQuizname_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Green;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblQuestion.Location = new System.Drawing.Point(752, 154);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(180, 46);
            this.lblQuestion.TabIndex = 16;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Magenta;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnNext.Location = new System.Drawing.Point(1349, 716);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(213, 67);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Green;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnPrevious.Location = new System.Drawing.Point(168, 716);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(213, 67);
            this.btnPrevious.TabIndex = 18;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnHome.Location = new System.Drawing.Point(12, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(213, 99);
            this.btnHome.TabIndex = 19;
            this.btnHome.Text = "Return to Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // rbnAnswer1
            // 
            this.rbnAnswer1.AutoSize = true;
            this.rbnAnswer1.BackColor = System.Drawing.Color.Magenta;
            this.rbnAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.rbnAnswer1.Location = new System.Drawing.Point(319, 397);
            this.rbnAnswer1.Name = "rbnAnswer1";
            this.rbnAnswer1.Size = new System.Drawing.Size(177, 43);
            this.rbnAnswer1.TabIndex = 20;
            this.rbnAnswer1.TabStop = true;
            this.rbnAnswer1.Text = "Answer 1";
            this.rbnAnswer1.UseVisualStyleBackColor = false;
            this.rbnAnswer1.CheckedChanged += new System.EventHandler(this.rbnAnswer1_CheckedChanged);
            // 
            // rbnAnswer2
            // 
            this.rbnAnswer2.AutoSize = true;
            this.rbnAnswer2.BackColor = System.Drawing.Color.Magenta;
            this.rbnAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.rbnAnswer2.Location = new System.Drawing.Point(319, 558);
            this.rbnAnswer2.Name = "rbnAnswer2";
            this.rbnAnswer2.Size = new System.Drawing.Size(177, 43);
            this.rbnAnswer2.TabIndex = 21;
            this.rbnAnswer2.TabStop = true;
            this.rbnAnswer2.Text = "Answer 2";
            this.rbnAnswer2.UseVisualStyleBackColor = false;
            this.rbnAnswer2.CheckedChanged += new System.EventHandler(this.rbnAnswer2_CheckedChanged);
            // 
            // rbnAnswer3
            // 
            this.rbnAnswer3.AutoSize = true;
            this.rbnAnswer3.BackColor = System.Drawing.Color.Magenta;
            this.rbnAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.rbnAnswer3.Location = new System.Drawing.Point(932, 397);
            this.rbnAnswer3.Name = "rbnAnswer3";
            this.rbnAnswer3.Size = new System.Drawing.Size(177, 43);
            this.rbnAnswer3.TabIndex = 22;
            this.rbnAnswer3.TabStop = true;
            this.rbnAnswer3.Text = "Answer 3";
            this.rbnAnswer3.UseVisualStyleBackColor = false;
            this.rbnAnswer3.CheckedChanged += new System.EventHandler(this.rbnAnswer3_CheckedChanged);
            // 
            // rbnAnswer4
            // 
            this.rbnAnswer4.AutoSize = true;
            this.rbnAnswer4.BackColor = System.Drawing.Color.Magenta;
            this.rbnAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.rbnAnswer4.Location = new System.Drawing.Point(932, 558);
            this.rbnAnswer4.Name = "rbnAnswer4";
            this.rbnAnswer4.Size = new System.Drawing.Size(177, 43);
            this.rbnAnswer4.TabIndex = 23;
            this.rbnAnswer4.TabStop = true;
            this.rbnAnswer4.Text = "Answer 4";
            this.rbnAnswer4.UseVisualStyleBackColor = false;
            this.rbnAnswer4.CheckedChanged += new System.EventHandler(this.rbnAnswer4_CheckedChanged);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Quizzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 1008);
            this.Controls.Add(this.rbnAnswer4);
            this.Controls.Add(this.rbnAnswer3);
            this.Controls.Add(this.rbnAnswer2);
            this.Controls.Add(this.rbnAnswer1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuizname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Quizzes";
            this.Text = "Quizzes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuizname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.RadioButton rbnAnswer1;
        private System.Windows.Forms.RadioButton rbnAnswer2;
        private System.Windows.Forms.RadioButton rbnAnswer3;
        private System.Windows.Forms.RadioButton rbnAnswer4;
    }
}