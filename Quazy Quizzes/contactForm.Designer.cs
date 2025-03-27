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
        private Button _btnBack, _btnToggleTheme, _btnSubmit;
        private Label _lblSubject, _lblMessage, _lblCounter, _lblEmail;
        private RichTextBox _txtMessage, _txtEmail, _txtSubject;
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
            // Title label at the top of the form
            this._lblTitle = new System.Windows.Forms.Label();
            this._lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this._lblTitle.BackColor = Color.FromArgb(0, 229, 255);
            this._lblTitle.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            this._lblTitle.ForeColor = Color.Black;
            this._lblTitle.Location = new Point(0, 0);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new Size(1280, 80);
            this._lblTitle.TabIndex = 1;
            this._lblTitle.Text = "Contact Us";
            this._lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Back button to navigate to the previous form
            this._btnBack = new System.Windows.Forms.Button();
            this._btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this._btnBack.BackColor = Color.FromArgb(0, 178, 204);
            this._btnBack.FlatStyle = FlatStyle.Flat;
            this._btnBack.Font = new Font("Microsoft Sans Serif", 18F);
            this._btnBack.ForeColor = Color.White;
            this._btnBack.Location = new Point(20, 20);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new Size(120, 40);
            this._btnBack.TabIndex = 2;
            this._btnBack.Text = "Back";
            this._btnBack.UseVisualStyleBackColor = false;
            this._btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            // Toggle theme button to switch between light and dark modes
            this._btnToggleTheme = new System.Windows.Forms.Button();
            this._btnToggleTheme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this._btnToggleTheme.BackColor = Color.FromArgb(0, 178, 204);
            this._btnToggleTheme.FlatStyle = FlatStyle.Flat;
            this._btnToggleTheme.Font = new Font("Microsoft Sans Serif", 18F);
            this._btnToggleTheme.ForeColor = Color.White;
            this._btnToggleTheme.Location = new Point(1108, 20);
            this._btnToggleTheme.Name = "_btnToggleTheme";
            this._btnToggleTheme.Size = new Size(152, 40);
            this._btnToggleTheme.TabIndex = 3;
            this._btnToggleTheme.Text = "Toggle Theme";
            this._btnToggleTheme.UseVisualStyleBackColor = false;
            this._btnToggleTheme.Click += new System.EventHandler(this.ToggleTheme);

            // Subject label
            this._lblSubject = new System.Windows.Forms.Label();
            this._lblSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this._lblSubject.AutoSize = true;
            this._lblSubject.Font = new Font("Microsoft Sans Serif", 18F);
            this._lblSubject.ForeColor = Color.FromArgb(30, 30, 30);
            this._lblSubject.Location = new Point(50, 9);
            this._lblSubject.Name = "_lblSubject";
            this._lblSubject.Size = new Size(205, 29);
            this._lblSubject.TabIndex = 0;
            this._lblSubject.Text = "Message Subject:";

            // Message label
            this._lblMessage = new System.Windows.Forms.Label();
            this._lblMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this._lblMessage.AutoSize = true;
            this._lblMessage.Font = new Font("Microsoft Sans Serif", 18F);
            this._lblMessage.ForeColor = Color.FromArgb(30, 30, 30);
            this._lblMessage.Location = new Point(50, 150);
            this._lblMessage.Name = "_lblMessage";
            this._lblMessage.Size = new Size(175, 29);
            this._lblMessage.TabIndex = 2;
            this._lblMessage.Text = "Your Message:";

            // Message text box
            this._txtMessage = new System.Windows.Forms.RichTextBox();
            this._txtMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this._txtMessage.BackColor = Color.White;
            this._txtMessage.BorderStyle = BorderStyle.FixedSingle;
            this._txtMessage.Font = new Font("Microsoft Sans Serif", 18F);
            this._txtMessage.ForeColor = Color.FromArgb(30, 30, 30);
            this._txtMessage.Location = new Point(50, 190);
            this._txtMessage.MaxLength = 500;
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.Size = new Size(750, 180);
            this._txtMessage.TabIndex = 3;
            this._txtMessage.Text = "";
            this._txtMessage.TextChanged += new System.EventHandler(this.UpdateCharacterCount);

            // Character counter label
            this._lblCounter = new System.Windows.Forms.Label();
            this._lblCounter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this._lblCounter.AutoSize = true;
            this._lblCounter.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            this._lblCounter.ForeColor = Color.FromArgb(30, 30, 30);
            this._lblCounter.Location = new Point(680, 380);
            this._lblCounter.Name = "_lblCounter";
            this._lblCounter.Size = new Size(96, 36);
            this._lblCounter.TabIndex = 4;
            this._lblCounter.Text = "0/500";
            this._lblCounter.Click += new System.EventHandler(this._lblCounter_Click);

            // Submit button
            this._btnSubmit = new System.Windows.Forms.Button();
            this._btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this._btnSubmit.BackColor = Color.FromArgb(0, 178, 204);
            this._btnSubmit.FlatStyle = FlatStyle.Flat;
            this._btnSubmit.Font = new Font("Microsoft Sans Serif", 18F);
            this._btnSubmit.ForeColor = Color.White;
            this._btnSubmit.Location = new Point(310, 420);
            this._btnSubmit.Name = "_btnSubmit";
            this._btnSubmit.Size = new Size(180, 50);
            this._btnSubmit.TabIndex = 5;
            this._btnSubmit.Text = "Submit";
            this._btnSubmit.UseVisualStyleBackColor = false;
            this._btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);

            // Container panel for form elements
            this._containerPanel = new System.Windows.Forms.Panel();
            this._containerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this._containerPanel.BackColor = Color.White;
            this._containerPanel.BorderStyle = BorderStyle.FixedSingle;
            this._containerPanel.Controls.Add(this._txtEmail);
            this._containerPanel.Controls.Add(this._txtSubject);
            this._containerPanel.Controls.Add(this._lblEmail);
            this._containerPanel.Controls.Add(this._lblSubject);
            this._containerPanel.Controls.Add(this._lblMessage);
            this._containerPanel.Controls.Add(this._txtMessage);
            this._containerPanel.Controls.Add(this._lblCounter);
            this._containerPanel.Controls.Add(this._btnSubmit);
            this._containerPanel.Location = new Point(200, 120);
            this._containerPanel.Name = "_containerPanel";
            this._containerPanel.Padding = new Padding(30);
            this._containerPanel.Size = new Size(880, 480);
            this._containerPanel.TabIndex = 0;

            // Email text box
            this._txtEmail = new System.Windows.Forms.RichTextBox();
            this._txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this._txtEmail.BackColor = Color.White;
            this._txtEmail.BorderStyle = BorderStyle.FixedSingle;
            this._txtEmail.Font = new Font("Microsoft Sans Serif", 18F);
            this._txtEmail.Location = new Point(50, 111);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new Size(750, 36);
            this._txtEmail.TabIndex = 9;
            this._txtEmail.Text = "";

            // Subject text box
            this._txtSubject = new System.Windows.Forms.RichTextBox();
            this._txtSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this._txtSubject.BackColor = Color.White;
            this._txtSubject.BorderStyle = BorderStyle.FixedSingle;
            this._txtSubject.Font = new Font("Microsoft Sans Serif", 18F);
            this._txtSubject.Location = new Point(50, 41);
            this._txtSubject.Name = "_txtSubject";
            this._txtSubject.Size = new Size(750, 36);
            this._txtSubject.TabIndex = 8;
            this._txtSubject.Text = "";

            // Email label
            this._lblEmail = new System.Windows.Forms.Label();
            this._lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this._lblEmail.AutoSize = true;
            this._lblEmail.Font = new Font("Microsoft Sans Serif", 18F);
            this._lblEmail.ForeColor = Color.FromArgb(30, 30, 30);
            this._lblEmail.Location = new Point(50, 79);
            this._lblEmail.Name = "_lblEmail";
            this._lblEmail.Size = new Size(131, 29);
            this._lblEmail.TabIndex = 6;
            this._lblEmail.Text = "Your Email";

            // ContactForm properties
            this.BackColor = Color.White;
            this.ClientSize = new Size(1280, 720);
            this.Controls.Add(this._btnToggleTheme);
            this.Controls.Add(this._btnBack);
            this.Controls.Add(this._containerPanel);
            this.Controls.Add(this._lblTitle);
            this.MinimumSize = new Size(800, 600);
            this.Name = "ContactForm";
            this.Text = "Contact Us";
            this._containerPanel.ResumeLayout(false);
            this._containerPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
