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
        // Lists to group UI elements for easier theme management
        private List<Label> _stdText = new List<Label>();
        private List<RichTextBox> _stdInputBox = new List<RichTextBox>();
        private List<Button> _primaryButton = new List<Button>();
        private List<Button> _secondaryButton = new List<Button>();

        // Constructor to initialize the form and apply the appropriate theme
        public ContactForm()
        {
            InitializeComponent();

            // Grouping UI elements into categories
            _stdText = new List<Label> { _lblMessage, _lblSubject, _lblEmail, _lblCounter };
            _stdInputBox = new List<RichTextBox> { _txtSubject, _txtMessage, _txtEmail };
            _primaryButton = new List<Button> { _btnSubmit };
            _secondaryButton = new List<Button> { _btnToggleTheme, _btnBack };

            // Apply the appropriate theme based on the current mode
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        // Handles the "Back" button click event to navigate back to the previous form
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Form popupForm = new Form
            {
                Size = new Size(300, 200),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            // Button to show the contact form again
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
                this.Show(); // Show the contact form
                popupForm.Close(); // Close the popup form
            };

            popupForm.Controls.Add(btnShowForm);
            popupForm.ShowDialog();
        }

        // Applies the given colour scheme to the form and its elements
        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);
            _containerPanel.BackColor = ColorTranslator.FromHtml(colourScheme._cardBackground);

            // Apply colours to grouped elements
            colourScheme.SetColourSchemePrimaryText(_stdText);
            colourScheme.SetColourSchemeTextBox(_stdInputBox);
            colourScheme.SetColourSchemePrimaryButtons(_primaryButton);
            colourScheme.SetColourSchemeSecondaryButtons(_secondaryButton);
        }

        // Toggles between light and dark themes
        private void ToggleTheme(object sender, EventArgs e)
        {
            Program._isDarkMode = !Program._isDarkMode;

            // Apply the appropriate theme
            if (Program._isDarkMode)
            {
                SetColourScheme(Program._darkTheme);
                return;
            }

            SetColourScheme(Program._lightTheme);
        }

        // Updates the character count label as the user types in the message box
        private void UpdateCharacterCount(object sender, EventArgs e)
        {
            _lblCounter.Text = $"{_txtMessage.Text.Length}/500";
        }

        // Handles the "Submit" button click event to send the form data via email
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Validate that all fields are filled
            if (string.IsNullOrWhiteSpace(_txtSubject.Text) ||
                string.IsNullOrWhiteSpace(_txtMessage.Text) ||
                string.IsNullOrWhiteSpace(_txtEmail.Text))
            {
                MessageBox.Show("Please ensure all fields are filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Email details
                string userEmail = _txtEmail.Text;
                string subject = _txtSubject.Text;
                string body = _txtMessage.Text;

                // Create and configure the email message
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("olitaylorjones@gmail.com");
                mail.To.Add("ws330966@weston.ac.uk");
                mail.Subject = subject;
                mail.Body = $"From: {userEmail}\n\n{body}";
                mail.ReplyToList.Add(new MailAddress(userEmail));

                // Configure the SMTP client
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("olitaylorjones@gmail.com", "zgwwkccuflyjbaoo"),
                    EnableSsl = true
                };

                // Send the email
                smtp.Send(mail);

                MessageBox.Show("Your message has been submitted and emailed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form fields
                _txtSubject.Clear();
                _txtMessage.Clear();
                _txtEmail.Clear();
                _lblCounter.Text = "0/500";
            }
            catch (Exception ex)
            {
                // Handle errors during email sending
                MessageBox.Show("Failed to send email.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Placeholder for the counter label click event (currently unused)
        private void _lblCounter_Click(object sender, EventArgs e)
        {
        }
    }
}
