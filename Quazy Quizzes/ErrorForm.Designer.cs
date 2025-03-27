namespace Quazy_Quizzes
{
    partial class ErrorForm
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
            this.MainLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainLbl
            // 
            this.MainLbl.AutoSize = true;
            this.MainLbl.Location = new System.Drawing.Point(229, 196);
            this.MainLbl.Name = "MainLbl";
            this.MainLbl.Size = new System.Drawing.Size(356, 13);
            this.MainLbl.TabIndex = 0;
            this.MainLbl.Text = "Sorry we could not load Quazy Quizzes at this time, please tery again later!";
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainLbl);
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLbl;
    }
}