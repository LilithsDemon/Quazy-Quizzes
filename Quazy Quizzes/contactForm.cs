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

        public ContactForm()
        {
            InitializeComponent();

            // Grouping UI elements into categories
            _stdText = new List<Label> { _lblMessage, _lblSubject, _lblEmail, LblCounter };
            _stdInputBox = new List<RichTextBox> { TxtSubject, TxtMessage, TxtEmail };
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
            Form1 mainForm = new Form1(); // Create an instance of Form1
            mainForm.Show(); // Show Form1
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
            LblCounter.Text = $"{TxtMessage.Text.Length}/500";
        }

        // Handles the "Submit" button click event to send the form data via email
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Validate that all fields are filled
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

                // Create and configure the email message
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("olitaylorjones@gmail.com"); // Replace with your email
                mail.To.Add("ws330966@weston.ac.uk"); // Recipient email
                mail.Subject = subject;
                mail.Body = $"From: {userEmail}\n\n{body}";
                mail.ReplyToList.Add(new MailAddress(userEmail));

                // Configure the SMTP client
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("olitaylorjones@gmail.com", "zgwwkccuflyjbaoo"), // Replace with your email and app-specific password
                    EnableSsl = true
                };

                // Send the email
                smtp.Send(mail);

                MessageBox.Show("Your message has been submitted and emailed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form fields
                TxtSubject.Clear();
                TxtMessage.Clear();
                TxtEmail.Clear();
                LblCounter.Text = "0/500";
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
