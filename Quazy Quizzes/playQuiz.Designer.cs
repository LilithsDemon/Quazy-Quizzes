namespace Quazy_Quizzes
{
    partial class playQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RadioButton Answer1Radio;
        private System.Windows.Forms.RadioButton Answer2Radio;
        private System.Windows.Forms.RadioButton Answer3Radio;
        private System.Windows.Forms.RadioButton Answer4Radio;
        private System.Windows.Forms.Button SubmitButton;

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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Answer1Radio = new System.Windows.Forms.RadioButton();
            this.Answer2Radio = new System.Windows.Forms.RadioButton();
            this.Answer3Radio = new System.Windows.Forms.RadioButton();
            this.Answer4Radio = new System.Windows.Forms.RadioButton();
            this.SubmitButton = new System.Windows.Forms.Button();

            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Location = new System.Drawing.Point(10, 10);
            this.QuestionLabel.Size = new System.Drawing.Size(780, 50);
            this.QuestionLabel.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            this.QuestionLabel.Text = "Question";

            // 
            // Answer1Radio
            // 
            this.Answer1Radio.Location = new System.Drawing.Point(10, 70);
            this.Answer1Radio.Size = new System.Drawing.Size(780, 30);
            this.Answer1Radio.Text = "Answer 1";

            // 
            // Answer2Radio
            // 
            this.Answer2Radio.Location = new System.Drawing.Point(10, 110);
            this.Answer2Radio.Size = new System.Drawing.Size(780, 30);
            this.Answer2Radio.Text = "Answer 2";

            // 
            // Answer3Radio
            // 
            this.Answer3Radio.Location = new System.Drawing.Point(10, 150);
            this.Answer3Radio.Size = new System.Drawing.Size(780, 30);
            this.Answer3Radio.Text = "Answer 3";

            // 
            // Answer4Radio
            // 
            this.Answer4Radio.Location = new System.Drawing.Point(10, 190);
            this.Answer4Radio.Size = new System.Drawing.Size(780, 30);
            this.Answer4Radio.Text = "Answer 4";

            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(10, 230);
            this.SubmitButton.Size = new System.Drawing.Size(100, 30);
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);

            // 
            // playQuiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.Answer1Radio);
            this.Controls.Add(this.Answer2Radio);
            this.Controls.Add(this.Answer3Radio);
            this.Controls.Add(this.Answer4Radio);
            this.Controls.Add(this.SubmitButton);
            this.Text = "playQuiz";
        }

        #endregion
    }
}