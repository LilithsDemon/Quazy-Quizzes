using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QQColourScheme;

namespace QQContactForm
{
    public partial class ContactForm : Form
    {
        private bool _isDarkMode = false;
        private ColourScheme _lightMode = new ColourScheme(
            "#FFFFFF", // Background
            "#00E5FF", // Secondary background
            "#1E1E1E", // Primary text
            "#FFFFFF", // Secondary text
            "#FFFFFF", // Input background
            "#1E1E1E", // Input text
            "#00B2CC",  // Button background
            "#FFFFFF",  // Button text
            "#00A2BB",  // Button hover
            "#00B2CC"   // Header background
        );

        private ColourScheme _darkTheme = new ColourScheme(
            "#1E1E1E", // Background
            "#00E5FF", // Secondary background
            "#FFFFFF", // Primary text
            "#121212", // Secondary text
            "#121212", // Input background
            "#FFFFFF", // Input text
            "#00B2CC",  // Button background
            "#FFFFFF",  // Button text
            "#00A2BB",  // Button hover
            "#00B2CC"   // Header background
        );

        private List<Label> _stdText = new List<Label>();
        private List<RichTextBox> _stdInputBox = new List<RichTextBox>();
        private List<Button> _stdButton = new List<Button>();

        public ContactForm()
        {
            InitializeComponent();
            _stdText = new List<Label> {_lblMessage, _lblSubject, _lblEmail, _lblCounter};
            _stdInputBox = new List<RichTextBox> { _txtSubject, _txtMessage, _txtEmail };
            _stdButton = new List<Button> { _btnBack, _btnToggleTheme, _btnSubmit };
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

        private void ToggleTheme(object sender, EventArgs e)
        {
            _isDarkMode = !_isDarkMode;

            if (_isDarkMode)
            {
                this.BackColor = ColorTranslator.FromHtml(_darkTheme._background);
                _containerPanel.BackColor = ColorTranslator.FromHtml(_darkTheme._cardBackground);
                _lblTitle.ForeColor = ColorTranslator.FromHtml(_darkTheme._foregroudText);

                for (int i = 0; i < _stdText.Count; i++)
                {
                    _stdText[i].ForeColor = ColorTranslator.FromHtml(_darkTheme._foregroudText);
                    _stdText[i].BackColor = ColorTranslator.FromHtml(_darkTheme._backgroundText);
                }

                for(int i = 0; i < _stdInputBox.Count; i++)
                {
                    _stdInputBox[i].BackColor = ColorTranslator.FromHtml(_darkTheme._cardBackground);
                    _stdInputBox[i].ForeColor = ColorTranslator.FromHtml(_darkTheme._secondaryTextFg);
                }

                for (int i = 0; i < _stdButton.Count; i++)
                {
                    _stdButton[i].BackColor = ColorTranslator.FromHtml(_darkTheme._buttonBackground);
                }
                return;
            }

            this.BackColor = ColorTranslator.FromHtml(_lightMode._background);
            _containerPanel.BackColor = ColorTranslator.FromHtml(_lightMode._cardBackground);
            _lblTitle.ForeColor = ColorTranslator.FromHtml(_lightMode._foregroudText);

            for (int i = 0; i < _stdText.Count; i++)
            {
                _stdText[i].ForeColor = ColorTranslator.FromHtml(_lightMode._foregroudText);
                _stdText[i].BackColor = ColorTranslator.FromHtml(_lightMode._backgroundText);
            }

            for (int i = 0; i < _stdInputBox.Count; i++)
            {
                _stdInputBox[i].BackColor = ColorTranslator.FromHtml(_lightMode._cardBackground);
                _stdInputBox[i].ForeColor = ColorTranslator.FromHtml(_lightMode._secondaryTextFg);
            }

            for (int i = 0; i < _stdButton.Count; i++)
            {
                _stdButton[i].BackColor = ColorTranslator.FromHtml(_lightMode._buttonBackground);
            }
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
