using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace QQContactForm
{
    partial class ContactForm
    {
        // Components used in the form
        private IContainer _components = null;
        private Label _lblTitle;
        private Button BtnBack, BtnToggleTheme, BtnSubmit;
        private Label LblSubject, LblMessage, LblCounter, LblEmail;
        private RichTextBox TxtMessage, TxtEmail, TxtSubject;
        private Panel _containerPanel;

        // Dispose method to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (_components != null))
            {
                _components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize the components of the form
        private void InitializeComponent()
        {
            this._lblTitle = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnToggleTheme = new System.Windows.Forms.Button();
            this.LblSubject = new System.Windows.Forms.Label();
            this.LblMessage = new System.Windows.Forms.Label();
            this.TxtMessage = new System.Windows.Forms.RichTextBox();
            this.LblCounter = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this._containerPanel = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.RichTextBox();
            this.TxtSubject = new System.Windows.Forms.RichTextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this._containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblTitle
            // 
            this._lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this._lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this._lblTitle.ForeColor = System.Drawing.Color.Black;
            this._lblTitle.Location = new System.Drawing.Point(0, 0);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(1280, 80);
            this._lblTitle.TabIndex = 1;
            this._lblTitle.Text = "Contact Us";
            this._lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BtnToggleTheme
            // 
            this.BtnToggleTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnToggleTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.BtnToggleTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToggleTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BtnToggleTheme.ForeColor = System.Drawing.Color.White;
            this.BtnToggleTheme.Location = new System.Drawing.Point(1108, 20);
            this.BtnToggleTheme.Name = "BtnToggleTheme";
            this.BtnToggleTheme.Size = new System.Drawing.Size(152, 40);
            this.BtnToggleTheme.TabIndex = 3;
            this.BtnToggleTheme.Text = "Toggle Theme";
            this.BtnToggleTheme.UseVisualStyleBackColor = false;
            this.BtnToggleTheme.Click += new System.EventHandler(this.ToggleTheme_ButtonClick);
            // 
            // LblSubject
            // 
            this.LblSubject.AutoSize = true;
            this.LblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LblSubject.Location = new System.Drawing.Point(80, 39);
            this.LblSubject.Name = "LblSubject";
            this.LblSubject.Size = new System.Drawing.Size(205, 29);
            this.LblSubject.TabIndex = 0;
            this.LblSubject.Text = "Message Subject:";
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LblMessage.Location = new System.Drawing.Point(80, 180);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(175, 29);
            this.LblMessage.TabIndex = 2;
            this.LblMessage.Text = "Your Message:";
            // 
            // TxtMessage
            // 
            this.TxtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMessage.BackColor = System.Drawing.Color.White;
            this.TxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TxtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtMessage.Location = new System.Drawing.Point(80, 212);
            this.TxtMessage.MaxLength = 500;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(765, 156);
            this.TxtMessage.TabIndex = 3;
            this.TxtMessage.Text = "";
            this.TxtMessage.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // LblCounter
            // 
            this.LblCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCounter.AutoSize = true;
            this.LblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.LblCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LblCounter.Location = new System.Drawing.Point(749, 371);
            this.LblCounter.Name = "LblCounter";
            this.LblCounter.Size = new System.Drawing.Size(96, 36);
            this.LblCounter.TabIndex = 4;
            this.LblCounter.Text = "0/500";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(665, 410);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(180, 50);
            this.BtnSubmit.TabIndex = 5;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // _containerPanel
            // 
            this._containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._containerPanel.BackColor = System.Drawing.Color.White;
            this._containerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._containerPanel.Controls.Add(this.TxtEmail);
            this._containerPanel.Controls.Add(this.TxtSubject);
            this._containerPanel.Controls.Add(this.LblEmail);
            this._containerPanel.Controls.Add(this.LblSubject);
            this._containerPanel.Controls.Add(this.LblMessage);
            this._containerPanel.Controls.Add(this.TxtMessage);
            this._containerPanel.Controls.Add(this.LblCounter);
            this._containerPanel.Controls.Add(this.BtnSubmit);
            this._containerPanel.Location = new System.Drawing.Point(200, 120);
            this._containerPanel.Name = "_containerPanel";
            this._containerPanel.Padding = new System.Windows.Forms.Padding(30);
            this._containerPanel.Size = new System.Drawing.Size(880, 480);
            this._containerPanel.TabIndex = 0;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.BackColor = System.Drawing.Color.White;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TxtEmail.Location = new System.Drawing.Point(80, 141);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(765, 36);
            this.TxtEmail.TabIndex = 9;
            this.TxtEmail.Text = "";
            // 
            // TxtSubject
            // 
            this.TxtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSubject.BackColor = System.Drawing.Color.White;
            this.TxtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TxtSubject.Location = new System.Drawing.Point(80, 71);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(765, 36);
            this.TxtSubject.TabIndex = 8;
            this.TxtSubject.Text = "";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LblEmail.Location = new System.Drawing.Point(80, 109);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(131, 29);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "Your Email";
            // 
            // ContactForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.BtnToggleTheme);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this._containerPanel);
            this.Controls.Add(this._lblTitle);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ContactForm";
            this.Text = "Contact Us";
            this._containerPanel.ResumeLayout(false);
            this._containerPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
