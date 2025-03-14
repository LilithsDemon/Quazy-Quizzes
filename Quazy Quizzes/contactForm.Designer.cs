using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace QQcontactForm
{
    partial class Form1
    {
        private IContainer components = null;
        private Label lblTitle;
        private Button btnBack, btnToggleTheme, btnSubmit;
        private Label lblSubject, lblMessage, lblCounter;
        private TextBox txtSubject;
        private RichTextBox txtMessage;
        private Panel containerPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnBack = new Button();
            btnToggleTheme = new Button();
            lblSubject = new Label();
            txtSubject = new TextBox();
            lblMessage = new Label();
            txtMessage = new RichTextBox();
            lblCounter = new Label();
            btnSubmit = new Button();
            containerPanel = new Panel();
            txtemail = new TextBox();
            lblEmail = new Label();
            containerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.BackColor = Color.FromArgb(0, 229, 255);
            lblTitle.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1280, 80);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Contact Us";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 178, 204);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 18F);
            btnBack.ForeColor = Color.FromArgb(255, 255, 255);
            btnBack.Location = new Point(20, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 40);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnToggleTheme
            // 
            btnToggleTheme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToggleTheme.BackColor = Color.FromArgb(0, 178, 204);
            btnToggleTheme.FlatStyle = FlatStyle.Flat;
            btnToggleTheme.Font = new Font("Microsoft Sans Serif", 18F);
            btnToggleTheme.ForeColor = Color.FromArgb(255, 255, 255);
            btnToggleTheme.Location = new Point(1108, 20);
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Size = new Size(152, 40);
            btnToggleTheme.TabIndex = 3;
            btnToggleTheme.Text = "Toggle Theme";
            btnToggleTheme.UseVisualStyleBackColor = false;
            btnToggleTheme.Click += ToggleTheme;
            // 
            // lblSubject
            // 
            lblSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Microsoft Sans Serif", 18F);
            lblSubject.ForeColor = Color.FromArgb(30, 30, 30);
            lblSubject.Location = new Point(50, 9);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(205, 29);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Message Subject:";
            // 
            // txtSubject
            // 
            txtSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSubject.BackColor = Color.FromArgb(255, 255, 255);
            txtSubject.BorderStyle = BorderStyle.FixedSingle;
            txtSubject.Font = new Font("Microsoft Sans Serif", 18F);
            txtSubject.ForeColor = Color.FromArgb(30, 30, 30);
            txtSubject.Location = new Point(50, 41);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(750, 35);
            txtSubject.TabIndex = 1;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Microsoft Sans Serif", 18F);
            lblMessage.ForeColor = Color.FromArgb(30, 30, 30);
            lblMessage.Location = new Point(50, 150);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(175, 29);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Your Message:";
            // 
            // txtMessage
            // 
            txtMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMessage.BackColor = Color.FromArgb(255, 255, 255);
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.Font = new Font("Microsoft Sans Serif", 18F);
            txtMessage.ForeColor = Color.FromArgb(30, 30, 30);
            txtMessage.Location = new Point(50, 190);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(750, 180);
            txtMessage.TabIndex = 3;
            txtMessage.Text = "";
            txtMessage.TextChanged += UpdateCharacterCount;
            // 
            // lblCounter
            // 
            lblCounter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            lblCounter.ForeColor = Color.FromArgb(30, 30, 30);
            lblCounter.Location = new Point(680, 380);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(96, 36);
            lblCounter.TabIndex = 4;
            lblCounter.Text = "0/500";
            lblCounter.Click += lblCounter_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.BackColor = Color.FromArgb(0, 178, 204);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 18F);
            btnSubmit.ForeColor = Color.FromArgb(255, 255, 255);
            btnSubmit.Location = new Point(310, 420);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(180, 50);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // containerPanel
            // 
            containerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            containerPanel.BackColor = Color.FromArgb(255, 255, 255);
            containerPanel.BorderStyle = BorderStyle.FixedSingle;
            containerPanel.Controls.Add(txtemail);
            containerPanel.Controls.Add(lblEmail);
            containerPanel.Controls.Add(lblSubject);
            containerPanel.Controls.Add(txtSubject);
            containerPanel.Controls.Add(lblMessage);
            containerPanel.Controls.Add(txtMessage);
            containerPanel.Controls.Add(lblCounter);
            containerPanel.Controls.Add(btnSubmit);
            containerPanel.Location = new Point(200, 120);
            containerPanel.Name = "containerPanel";
            containerPanel.Padding = new Padding(30);
            containerPanel.Size = new Size(880, 480);
            containerPanel.TabIndex = 0;
            // 
            // txtemail
            // 
            txtemail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtemail.BackColor = Color.FromArgb(255, 255, 255);
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Microsoft Sans Serif", 18F);
            txtemail.ForeColor = Color.FromArgb(30, 30, 30);
            txtemail.Location = new Point(50, 111);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(750, 35);
            txtemail.TabIndex = 7;
            txtemail.TextChanged += txtEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 18F);
            lblEmail.ForeColor = Color.FromArgb(30, 30, 30);
            lblEmail.Location = new Point(50, 79);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(131, 29);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Your Email";
            lblEmail.Click += lblEmail_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(btnToggleTheme);
            Controls.Add(btnBack);
            Controls.Add(containerPanel);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Contact Us";
            containerPanel.ResumeLayout(false);
            containerPanel.PerformLayout();
            ResumeLayout(false);
        }
        private Label lblEmail;
        private TextBox txtemail;
    }
}
