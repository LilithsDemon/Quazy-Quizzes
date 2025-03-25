using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QQColourScheme;
using Quazy_Quizzes;

namespace QQContactForm
{
    public partial class ContactForm : Form
    {

        // Groups of the different components, used when setting the colours for them
        private List<Label> _stdText = new List<Label>();
        private List<RichTextBox> _stdInputBox = new List<RichTextBox>();
        private List<Button> _primaryButton = new List<Button>();
        private List<Button> _secondaryButton = new List<Button>();

        public ContactForm()
        {
            InitializeComponent();
            // The different components in the page sorted into categories
            _stdText = new List<Label> {_lblMessage, _lblSubject, _lblEmail, _lblCounter};
            _stdInputBox = new List<RichTextBox> { _txtSubject, _txtMessage, _txtEmail };
            _primaryButton = new List<Button> { _btnSubmit };
            _secondaryButton = new List<Button> { _btnToggleTheme, _btnBack };


            // Get page to match colour scheme
            if(Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide ContactForm
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
                this.Show(); // Show ContactForm
                popupForm.Close(); // Close the popup form
            };

            popupForm.Controls.Add(btnShowForm);
            popupForm.ShowDialog();
        }

        // Chanes the elements to be the correct colours based on the colour scheme given for this page
        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);
            _containerPanel.BackColor = ColorTranslator.FromHtml(colourScheme._cardBackground);

            colourScheme.SetColourSchemePrimaryText(_stdText);
            colourScheme.SetColourSchemeTextBox(_stdInputBox);
            colourScheme.SetColourSchemePrimaryButtons(_primaryButton);
            colourScheme.SetColourSchemeSecondaryButtons(_secondaryButton);
        }

        // Changes the theme between light and dark mode
        private void ToggleTheme(object sender, EventArgs e)
        {
            Program._isDarkMode = !Program._isDarkMode;

            // If is now supposed to be dark mode
            if (Program._isDarkMode)
            {
                SetColourScheme(Program._darkTheme);
                return;
            }

            SetColourScheme(Program._lightTheme);
        }

        private void UpdateCharacterCount(object sender, EventArgs e)
        {
            _lblCounter.Text = $"{_txtMessage.Text.Length}/500";
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_txtSubject.Text) || string.IsNullOrWhiteSpace(_txtMessage.Text) || (string.IsNullOrWhiteSpace(_txtEmail.Text)))
            {
                MessageBox.Show("Please ensure all fields are filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Your message has been submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _txtSubject.Clear();
                _txtMessage.Clear();
                _txtEmail.Clear();
                _lblCounter.Text = "0/500";
            }
        }

        private void _lblCounter_Click(object sender, EventArgs e)
        {

        }
    }
}
