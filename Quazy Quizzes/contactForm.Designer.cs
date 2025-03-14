using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace QQContactForm
{
    partial class ContactForm
    {
        private IContainer _components = null;
        private Label _lblTitle;
        private Button _btnBack, _btnToggleTheme, _btnSubmit;
        private Label _lblSubject, _lblMessage, _lblCounter, _lblEmail;
        private RichTextBox _txtMessage;
        private Panel _containerPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (_components != null))
            {
                _components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this._lblTitle = new System.Windows.Forms.Label();
            this._btnBack = new System.Windows.Forms.Button();
            this._btnToggleTheme = new System.Windows.Forms.Button();
            this._lblSubject = new System.Windows.Forms.Label();
            this._lblMessage = new System.Windows.Forms.Label();
            this._txtMessage = new System.Windows.Forms.RichTextBox();
            this._lblCounter = new System.Windows.Forms.Label();
            this._btnSubmit = new System.Windows.Forms.Button();
            this._containerPanel = new System.Windows.Forms.Panel();
            this._txtEmail = new System.Windows.Forms.RichTextBox();
            this._txtSubject = new System.Windows.Forms.RichTextBox();
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
            this._btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._btnBack.Location = new System.Drawing.Point(20, 20);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(120, 40);
            this._btnBack.TabIndex = 2;
            this._btnBack.Text = "Back";
            this._btnBack.UseVisualStyleBackColor = false;
            this._btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // _btnToggleTheme
            // 
            this._btnToggleTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnToggleTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this._btnToggleTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnToggleTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._btnToggleTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._btnToggleTheme.Location = new System.Drawing.Point(1108, 20);
            this._btnToggleTheme.Name = "_btnToggleTheme";
            this._btnToggleTheme.Size = new System.Drawing.Size(152, 40);
            this._btnToggleTheme.TabIndex = 3;
            this._btnToggleTheme.Text = "Toggle Theme";
            this._btnToggleTheme.UseVisualStyleBackColor = false;
            this._btnToggleTheme.Click += new System.EventHandler(this.ToggleTheme);
            // 
            // _lblSubject
            // 
            this._lblSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblSubject.AutoSize = true;
            this._lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._lblSubject.Location = new System.Drawing.Point(50, 9);
            this._lblSubject.Name = "_lblSubject";
            this._lblSubject.Size = new System.Drawing.Size(205, 29);
            this._lblSubject.TabIndex = 0;
            this._lblSubject.Text = "Message Subject:";
            // 
            // _lblMessage
            // 
            this._lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblMessage.AutoSize = true;
            this._lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._lblMessage.Location = new System.Drawing.Point(50, 150);
            this._lblMessage.Name = "_lblMessage";
            this._lblMessage.Size = new System.Drawing.Size(175, 29);
            this._lblMessage.TabIndex = 2;
            this._lblMessage.Text = "Your Message:";
            // 
            // _txtMessage
            // 
            this._txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._txtMessage.Location = new System.Drawing.Point(50, 190);
            this._txtMessage.MaxLength = 500;
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.Size = new System.Drawing.Size(750, 180);
            this._txtMessage.TabIndex = 3;
            this._txtMessage.Text = "";
            this._txtMessage.TextChanged += new System.EventHandler(this.UpdateCharacterCount);
            // 
            // _lblCounter
            // 
            this._lblCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lblCounter.AutoSize = true;
            this._lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this._lblCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._lblCounter.Location = new System.Drawing.Point(680, 380);
            this._lblCounter.Name = "_lblCounter";
            this._lblCounter.Size = new System.Drawing.Size(96, 36);
            this._lblCounter.TabIndex = 4;
            this._lblCounter.Text = "0/500";
            this._lblCounter.Click += new System.EventHandler(this._lblCounter_Click);
            // 
            // _btnSubmit
            // 
            this._btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this._btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._btnSubmit.Location = new System.Drawing.Point(310, 420);
            this._btnSubmit.Name = "_btnSubmit";
            this._btnSubmit.Size = new System.Drawing.Size(180, 50);
            this._btnSubmit.TabIndex = 5;
            this._btnSubmit.Text = "Submit";
            this._btnSubmit.UseVisualStyleBackColor = false;
            this._btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // _containerPanel
            // 
            this._containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._containerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._containerPanel.Controls.Add(this._txtEmail);
            this._containerPanel.Controls.Add(this._txtSubject);
            this._containerPanel.Controls.Add(this._lblEmail);
            this._containerPanel.Controls.Add(this._lblSubject);
            this._containerPanel.Controls.Add(this._lblMessage);
            this._containerPanel.Controls.Add(this._txtMessage);
            this._containerPanel.Controls.Add(this._lblCounter);
            this._containerPanel.Controls.Add(this._btnSubmit);
            this._containerPanel.Location = new System.Drawing.Point(200, 120);
            this._containerPanel.Name = "_containerPanel";
            this._containerPanel.Padding = new System.Windows.Forms.Padding(30);
            this._containerPanel.Size = new System.Drawing.Size(880, 480);
            this._containerPanel.TabIndex = 0;
            // 
            // _txtEmail
            // 
            this._txtEmail.BackColor = System.Drawing.Color.White;
            this._txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._txtEmail.Location = new System.Drawing.Point(50, 111);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(750, 36);
            this._txtEmail.TabIndex = 9;
            this._txtEmail.Text = "";
            // 
            // _txtSubject
            // 
            this._txtSubject.BackColor = System.Drawing.Color.White;
            this._txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._txtSubject.Location = new System.Drawing.Point(50, 41);
            this._txtSubject.Name = "_txtSubject";
            this._txtSubject.Size = new System.Drawing.Size(750, 36);
            this._txtSubject.TabIndex = 8;
            this._txtSubject.Text = "";
            // 
            // _lblEmail
            // 
            this._lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblEmail.AutoSize = true;
            this._lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this._lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._lblEmail.Location = new System.Drawing.Point(50, 79);
            this._lblEmail.Name = "_lblEmail";
            this._lblEmail.Size = new System.Drawing.Size(131, 29);
            this._lblEmail.TabIndex = 6;
            this._lblEmail.Text = "Your Email";
            // 
            // ContactForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this._btnToggleTheme);
            this.Controls.Add(this._btnBack);
            this.Controls.Add(this._containerPanel);
            this.Controls.Add(this._lblTitle);
            this.Name = "ContactForm";
            this.Text = "Contact Us";
            this._containerPanel.ResumeLayout(false);
            this._containerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private RichTextBox _txtEmail;
        private RichTextBox _txtSubject;
    }
}
