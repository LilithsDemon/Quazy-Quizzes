using System;
using System.Drawing;
using System.Windows.Forms;

namespace QQcontactForm
{
    public partial class Form1 : Form
    {
        private bool isDarkMode = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form1
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
                this.Show(); // Show Form1
                popupForm.Close(); // Close the popup form
            };

            popupForm.Controls.Add(btnShowForm);
            popupForm.ShowDialog();
        }

        private void ToggleTheme(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                this.BackColor = ColorTranslator.FromHtml("#1E1E1E"); // Primary background
                lblTitle.BackColor = ColorTranslator.FromHtml("#00E5FF"); // Secondary background
                lblTitle.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                lblSubject.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                lblMessage.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                lblCounter.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                lblEmail.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                txtSubject.BackColor = ColorTranslator.FromHtml("#121212");
                txtSubject.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                txtemail.BackColor = ColorTranslator.FromHtml("#121212");
                txtemail.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                txtMessage.BackColor = ColorTranslator.FromHtml("#121212");
                txtMessage.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                btnBack.BackColor = ColorTranslator.FromHtml("#00B2CC");
                btnToggleTheme.BackColor = ColorTranslator.FromHtml("#00B2CC");
                btnSubmit.BackColor = ColorTranslator.FromHtml("#00B2CC");

                containerPanel.BackColor = ColorTranslator.FromHtml("#121212");
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#FFFFFF"); // Light background
                lblTitle.BackColor = ColorTranslator.FromHtml("#00E5FF"); // Secondary background
                lblTitle.ForeColor = ColorTranslator.FromHtml("#1E1E1E");

                lblSubject.ForeColor = ColorTranslator.FromHtml("#1E1E1E");
                lblMessage.ForeColor = ColorTranslator.FromHtml("#1E1E1E");
                lblCounter.ForeColor = ColorTranslator.FromHtml("#1E1E1E");
                lblEmail.ForeColor = ColorTranslator.FromHtml("#1E1E1E");

                txtSubject.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                txtSubject.ForeColor = ColorTranslator.FromHtml("#1E1E1E");

                txtMessage.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                txtMessage.ForeColor = ColorTranslator.FromHtml("#1E1E1E");

                txtemail.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                txtemail.ForeColor = ColorTranslator.FromHtml("#1E1E1E");

                btnBack.BackColor = ColorTranslator.FromHtml("#00B2CC");
                btnToggleTheme.BackColor = ColorTranslator.FromHtml("#00B2");

                containerPanel.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
        }

        private void UpdateCharacterCount(object sender, EventArgs e)
        {
            lblCounter.Text = $"{txtMessage.Text.Length}/500";
        }

        private bool IsLightTheme()
        {
            return true; // Placeholder
        }

        private void lblCounter_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text) || string.IsNullOrWhiteSpace(txtMessage.Text) || (string.IsNullOrWhiteSpace(txtemail.Text)))
            {
                MessageBox.Show("Please ensure all fields are filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Your message has been submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSubject.Clear();
                txtMessage.Clear();
                txtemail.Clear();
                lblCounter.Text = "0/500";
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
