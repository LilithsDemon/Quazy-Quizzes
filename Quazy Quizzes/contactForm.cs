using System;
using System.Drawing;
using System.Windows.Forms;

namespace QQContactForm
{
    public partial class ContactForm : Form
    {
        private bool _isDarkMode = false;

        public ContactForm()
        {
            InitializeComponent();
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
                this.BackColor = ColorTranslator.FromHtml("#1E1E1E"); // Primary background
                _lblTitle.BackColor = ColorTranslator.FromHtml("#00E5FF"); // Secondary background
                _lblTitle.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                _lblSubject.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                _lblMessage.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                _lblCounter.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                _lblEmail.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                _txtSubject.BackColor = ColorTranslator.FromHtml("#121212");
                _txtSubject.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                _txtEmail.BackColor = ColorTranslator.FromHtml("#121212");
                _txtEmail.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                _txtMessage.BackColor = ColorTranslator.FromHtml("#121212");
                _txtMessage.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                _btnBack.BackColor = ColorTranslator.FromHtml("#00B2CC");
                _btnToggleTheme.BackColor = ColorTranslator.FromHtml("#00B2CC");
                _btnSubmit.BackColor = ColorTranslator.FromHtml("#00B2CC");

                _containerPanel.BackColor = ColorTranslator.FromHtml("#121212");
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#FFFFFF"); // Light background
                _lblTitle.BackColor = ColorTranslator.FromHtml("#00E5FF"); // Secondary background
                _lblTitle.ForeColor = ColorTranslator.FromHtml("#1E1E1E");

                _lblSubject.ForeColor = ColorTranslator.FromHtml("#1E1E1E");
                _lblMessage.ForeColor = ColorTranslator.FromHtml("#1E1E1E");
                _lblCounter.ForeColor = ColorTranslator.FromHtml("#1E1E1E");
                _lblEmail.ForeColor = ColorTranslator.FromHtml("#1E1E1E");

                _txtSubject.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _txtSubject.ForeColor = ColorTranslator.FromHtml("#1E1E1E");

                _txtMessage.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _txtMessage.ForeColor = ColorTranslator.FromHtml("#1E1E1E");

                _txtEmail.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _txtEmail.ForeColor = ColorTranslator.FromHtml("#1E1E1E");

                _btnBack.BackColor = ColorTranslator.FromHtml("#00B2CC");
                _btnToggleTheme.BackColor = ColorTranslator.FromHtml("#00B2");

                _containerPanel.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
        }

        private void UpdateCharacterCount(object sender, EventArgs e)
        {
            _lblCounter.Text = $"{_txtMessage.Text.Length}/500";
        }

        private bool IsLightTheme()
        {
            return true; // Placeholder
        }

        private void LblCounter_Click(object sender, EventArgs e)
        {

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

        private void LblEmail_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
