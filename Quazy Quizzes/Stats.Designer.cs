namespace Quazy_Quizzes
{
    partial class Stats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnTheme;
        private System.Windows.Forms.DataGridView DgvStats;

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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnTheme = new System.Windows.Forms.Button();
            this.DgvStats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStats)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(800, 80);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Your Quiz Stats";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(20, 20);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 40);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnTheme
            // 
            this.BtnTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTheme.Location = new System.Drawing.Point(680, 20);
            this.BtnTheme.Name = "BtnTheme";
            this.BtnTheme.Size = new System.Drawing.Size(100, 40);
            this.BtnTheme.TabIndex = 2;
            this.BtnTheme.Text = "Toggle Theme";
            this.BtnTheme.UseVisualStyleBackColor = true;
            this.BtnTheme.Click += new System.EventHandler(this.BtnToggleTheme_Click);
            // 
            // DgvStats
            // 
            this.DgvStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStats.Location = new System.Drawing.Point(50, 100);
            this.DgvStats.Name = "DgvStats";
            this.DgvStats.Size = new System.Drawing.Size(700, 300);
            this.DgvStats.TabIndex = 3;
            // 
            // Stats
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvStats);
            this.Controls.Add(this.BtnTheme);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblTitle);
            this.Name = "Stats";
            this.Text = "Stats";
            ((System.ComponentModel.ISupportInitialize)(this.DgvStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}