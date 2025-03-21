namespace Quazy_Quizzes
{
    partial class Load
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.ProgramLbl = new System.Windows.Forms.Label();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.LoadingBgWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Location = new System.Drawing.Point(368, 43);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(80, 13);
            this.WelcomeLbl.TabIndex = 1;
            this.WelcomeLbl.Text = "Welcome To ...";
            this.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgramLbl
            // 
            this.ProgramLbl.AutoSize = true;
            this.ProgramLbl.Location = new System.Drawing.Point(368, 208);
            this.ProgramLbl.Name = "ProgramLbl";
            this.ProgramLbl.Size = new System.Drawing.Size(77, 13);
            this.ProgramLbl.TabIndex = 2;
            this.ProgramLbl.Text = "Quazy Quizzes";
            // 
            // LoadingBar
            // 
            this.LoadingBar.Location = new System.Drawing.Point(358, 314);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(100, 23);
            this.LoadingBar.TabIndex = 3;
            this.LoadingBar.Value = 10;
            // 
            // LoadingBgWorker
            // 
            this.LoadingBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoadingBgWorker_DoWork);
            this.LoadingBgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LoadingBgWorker_RunWorkerCompleted);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.ProgramLbl);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Load";
            this.Text = "Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Label ProgramLbl;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.ComponentModel.BackgroundWorker LoadingBgWorker;
    }
}