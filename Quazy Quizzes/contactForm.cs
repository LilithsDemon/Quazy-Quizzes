using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using QQColourScheme;
using Quazy_Quizzes;

namespace QQContactForm
{
    public partial class ContactForm : Form
    {
        private List<Label> _stdText = new List<Label>();
        private List<RichTextBox> _stdInputBox = new List<RichTextBox>();
        private List<Button> _primaryButton = new List<Button>();
        private List<Button> _secondaryButton = new List<Button>();

        public ContactForm()
        {
            InitializeComponent();
            _stdText = new List<Label> { _lblMessage, _lblSubject, _lblEmail, LblCounter };
            _stdInputBox = new List<RichTextBox> { TxtSubject, TxtMessage, TxtEmail };
            _primaryButton = new List<Button> { _btnSubmit };
            _secondaryButton = new List<Button> { _btnToggleTheme, _btnBack };

            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form popupForm = new Form
            {
                Size = new Size(300, 200),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Button btnShowForm = new Button
            {
                Text = "Show Contact Form",
                Size = new Size(200, 50),
                Location = new Point((popupForm.ClientSize.Width - 200) / 2, (popupForm.ClientSize.Height - 50) / 2),
                Anchor = AnchorStyles.None,
                BackColor = ColorTranslator.FromHtml("#00B2CC"),
                Font = new Font("Orbitron", 18, FontStyle.Regular),
                ForeColor = ColorTranslator.FromHtml("#FFFFFF")
            };
            btnShowForm.Click += (s, args) =>
            {
                this.Show();
                popupForm.Close();
            };

            popupForm.Controls.Add(btnShowForm);
            popupForm.ShowDialog();
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);
            _containerPanel.BackColor = ColorTranslator.FromHtml(colourScheme._cardBackground);

            colourScheme.SetColourSchemePrimaryText(_stdText);
            colourScheme.SetColourSchemeTextBox(_stdInputBox);
            colourScheme.SetColourSchemePrimaryButtons(_primaryButton);
            colourScheme.SetColourSchemeSecondaryButtons(_secondaryButton);
        }

        private void ToggleTheme(object sender, EventArgs e)
        {
            Program._isDarkMode = !Program._isDarkMode;

            if (Program._isDarkMode)
            {
                SetColourScheme(Program._darkTheme);
                return;
            }

            SetColourScheme(Program._lightTheme);
        }

        private void UpdateCharacterCount(object sender, EventArgs e)
        {
            LblCounter.Text = $"{TxtMessage.Text.Length}/500";
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSubject.Text) ||
                string.IsNullOrWhiteSpace(TxtMessage.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("Please ensure all fields are filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Email details
                string userEmail = TxtEmail.Text;
                string subject = TxtSubject.Text;
                string body = TxtMessage.Text;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("olitaylorjones@gmail.com");
                mail.To.Add("ws330966@weston.ac.uk");
                mail.Subject = subject;
                mail.Body = $"From: {userEmail}\n\n{body}";
                mail.ReplyToList.Add(new MailAddress(userEmail));

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("olitaylorjones@gmail.com", "zgwwkccuflyjbaoo"),
                    EnableSsl = true
                };

                smtp.Send(mail);

                MessageBox.Show("Your message has been submitted and emailed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtSubject.Clear();
                TxtMessage.Clear();
                TxtEmail.Clear();
                LblCounter.Text = "0/500";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _lblCounter_Click(object sender, EventArgs e)
        {
        }
    }
}
