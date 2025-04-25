namespace Quazy_Quizzes
{
    partial class EditQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonDeleteQuestion;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonToggleTheme;

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
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonDeleteQuestion = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonToggleTheme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.AllowUserToAddRows = false;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(20, 70);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewQuestions.TabIndex = 1;
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(20, 390);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(75, 23);
            this.buttonAddQuestion.TabIndex = 2;
            this.buttonAddQuestion.Text = "Add Question";
            this.buttonAddQuestion.Click += new System.EventHandler(this.ButtonAddQuestion_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(150, 390);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveChanges.TabIndex = 3;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.Click += new System.EventHandler(this.ButtonSaveChanges_Click);
            // 
            // buttonDeleteQuestion
            // 
            this.buttonDeleteQuestion.Location = new System.Drawing.Point(280, 390);
            this.buttonDeleteQuestion.Name = "buttonDeleteQuestion";
            this.buttonDeleteQuestion.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteQuestion.TabIndex = 4;
            this.buttonDeleteQuestion.Text = "Delete Question";
            this.buttonDeleteQuestion.Click += new System.EventHandler(this.ButtonDeleteQuestion_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(20, 20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(0, 1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(802, 54);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonToggleTheme
            // 
            this.buttonToggleTheme.Location = new System.Drawing.Point(700, 20);
            this.buttonToggleTheme.Name = "buttonToggleTheme";
            this.buttonToggleTheme.Size = new System.Drawing.Size(75, 23);
            this.buttonToggleTheme.TabIndex = 5;
            this.buttonToggleTheme.Text = "Toggle Theme";
            this.buttonToggleTheme.Click += new System.EventHandler(this.ButtonToggleTheme_Click);
            // 
            // EditQuiz
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToggleTheme);
            this.Controls.Add(this.dataGridViewQuestions);
            this.Controls.Add(this.buttonAddQuestion);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.buttonDeleteQuestion);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditQuiz";
            this.Text = "Edit Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}