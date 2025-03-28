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
        private System.Windows.Forms.Panel ContainerPanel;

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
            this.ContainerPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStats)).BeginInit();
            this.ContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Black;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(800, 80);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Your Quiz Stats";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(20, 20);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(120, 40);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnTheme
            // 
            this.BtnTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.BtnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BtnTheme.ForeColor = System.Drawing.Color.White;
            this.BtnTheme.Location = new System.Drawing.Point(660, 20);
            this.BtnTheme.Name = "BtnTheme";
            this.BtnTheme.Size = new System.Drawing.Size(120, 40);
            this.BtnTheme.TabIndex = 2;
            this.BtnTheme.Text = "Toggle Theme";
            this.BtnTheme.UseVisualStyleBackColor = false;
            this.BtnTheme.Click += new System.EventHandler(this.BtnToggleTheme_Click);
            // 
            // DgvStats
            // 
            this.DgvStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvStats.BackgroundColor = System.Drawing.Color.White;
            this.DgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStats.Location = new System.Drawing.Point(-1, -1);
            this.DgvStats.Name = "DgvStats";
            this.DgvStats.Size = new System.Drawing.Size(700, 400);
            this.DgvStats.TabIndex = 3;
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerPanel.BackColor = System.Drawing.Color.White;
            this.ContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContainerPanel.Controls.Add(this.DgvStats);
            this.ContainerPanel.Location = new System.Drawing.Point(50, 120);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(700, 400);
            this.ContainerPanel.TabIndex = 4;
            // 
            // Stats
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.BtnTheme);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblTitle);
            this.Name = "Stats";
            this.Text = "Stats";
            ((System.ComponentModel.ISupportInitialize)(this.DgvStats)).EndInit();
            this.ContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}