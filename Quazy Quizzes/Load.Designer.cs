using System.ComponentModel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.LoadingBgWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LoadingBgWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(281, 54);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(267, 42);
            this.WelcomeLbl.TabIndex = 1;
            this.WelcomeLbl.Text = "Welcome To ...";
            this.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Location = new System.Drawing.Point(358, 314);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(100, 23);
            this.LoadingBar.TabIndex = 3;
            this.LoadingBar.Value = 10;
            // 
            // LoadingBgWorker1
            // 
            this.LoadingBgWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoadingBgWorker1_DoWork);
            this.LoadingBgWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LoadingBgWorker1_RunWorkerCompleted);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImageLocation = "";
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(39, 127);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(721, 141);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // LoadingBgWorker2
            // 
            this.LoadingBgWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoadingBgWorker2_DoWork);
            this.LoadingBgWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LoadingBgWorker2_RunWorkerCompleted);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.WelcomeLbl);
            this.Name = "Load";
            this.Text = "Load";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.ComponentModel.BackgroundWorker LoadingBgWorker1;
        private System.Windows.Forms.PictureBox Logo;
        private System.ComponentModel.BackgroundWorker LoadingBgWorker2;
    }
}