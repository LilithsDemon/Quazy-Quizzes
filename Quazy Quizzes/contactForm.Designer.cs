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
        private Button _btnBack, _btnToggleTheme, BtnSubmit;
        private Label _lblSubject, _lblMessage, LblCounter, _lblEmail;
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
            this._btnBack = new System.Windows.Forms.Button();
            this._btnToggleTheme = new System.Windows.Forms.Button();
            this._lblSubject = new System.Windows.Forms.Label();
            this._lblMessage = new System.Windows.Forms.Label();
            this.TxtMessage = new System.Windows.Forms.RichTextBox();
            this.LblCounter = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this._containerPanel = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.RichTextBox();
            this.TxtSubject = new System.Windows.Forms.RichTextBox();
            this._lblEmail = new System.Windows.Forms.Label();
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
            // _btnBack
            // 
            this._btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this._btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._btnBack.ForeColor = System.Drawing.Color.White;
            this._btnBack.Location = new System.Drawing.Point(20, 20);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(120, 40);
            this._btnBack.TabIndex = 2;
            this._btnBack.Text = "Back";
            this._btnBack.UseVisualStyleBackColor = false;
            this._btnBack.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // _btnToggleTheme
            // 
            this._btnToggleTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnToggleTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this._btnToggleTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnToggleTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._btnToggleTheme.ForeColor = System.Drawing.Color.White;
            this._btnToggleTheme.Location = new System.Drawing.Point(1108, 20);
            this._btnToggleTheme.Name = "_btnToggleTheme";
            this._btnToggleTheme.Size = new System.Drawing.Size(152, 40);
            this._btnToggleTheme.TabIndex = 3;
            this._btnToggleTheme.Text = "Toggle Theme";
            this._btnToggleTheme.UseVisualStyleBackColor = false;
            this._btnToggleTheme.Click += new System.EventHandler(this.ToggleTheme_ButtonClick);
            // 
            // _lblSubject
            // 
            this._lblSubject.AutoSize = true;
            this._lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._lblSubject.Location = new System.Drawing.Point(80, 39);
            this._lblSubject.Name = "_lblSubject";
            this._lblSubject.Size = new System.Drawing.Size(205, 29);
            this._lblSubject.TabIndex = 0;
            this._lblSubject.Text = "Message Subject:";
            // 
            // _lblMessage
            // 
            this._lblMessage.AutoSize = true;
            this._lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._lblMessage.Location = new System.Drawing.Point(80, 180);
            this._lblMessage.Name = "_lblMessage";
            this._lblMessage.Size = new System.Drawing.Size(175, 29);
            this._lblMessage.TabIndex = 2;
            this._lblMessage.Text = "Your Message:";
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
            this.LblCounter.Click += new System.EventHandler(this.CounterLabel_Click);
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
            this._containerPanel.Controls.Add(this._lblEmail);
            this._containerPanel.Controls.Add(this._lblSubject);
            this._containerPanel.Controls.Add(this._lblMessage);
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
            // _lblEmail
            // 
            this._lblEmail.AutoSize = true;
            this._lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._lblEmail.Location = new System.Drawing.Point(80, 109);
            this._lblEmail.Name = "_lblEmail";
            this._lblEmail.Size = new System.Drawing.Size(131, 29);
            this._lblEmail.TabIndex = 6;
            this._lblEmail.Text = "Your Email";
            // 
            // ContactForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this._btnToggleTheme);
            this.Controls.Add(this._btnBack);
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
