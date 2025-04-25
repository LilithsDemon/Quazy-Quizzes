using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QQColourScheme;
using Conn;
using Status;
using QQContactForm;
using LogIn;

using Registration;



namespace Quazy_Quizzes
{
    public partial class Form1 : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Button> _secondaryButtons = new List<Button>();

        public Form1()
        {

            InitializeComponent();

            this.FormClosed += Form1_FormClosed;

            _primaryButtons = new List<Button>() { btnSignup, btnLogin };
            _secondaryButtons = new List<Button>() { HelpBtn};

            txtUsername.MouseClick += new MouseEventHandler(TxtUsername_Click);
            txtPassword.TextChanged += new EventHandler(TxtPassword_TextChanged);
            txtUsername.TextChanged += new EventHandler(TxtUsername_TextChanged);
            txtPassword.MouseClick += new MouseEventHandler(TxtPassword_Click);
            txtEmail.MouseClick += new MouseEventHandler(txtEmail_Click);
            txtFirst.MouseClick += new MouseEventHandler(txtFirst_Click);
            txtSurname.MouseClick += new MouseEventHandler(txtSurname_Click);

            string securityQSql = "SELECT * FROM `SecurityQuestions`";
            try
            {
                var securityQReader = new ConnectionHandler().ExecuteQueryNoParams(securityQSql);
                cbSecurityQ.Items.Clear();
                cbSecurityQ.Items.Add("Please enter a 2FA question"); // Update filler text
                cbSecurityQ.SelectedIndex = 0; // Set filler text as default
                while (securityQReader.Read())
                {
                    cbSecurityQ.Items.Add(securityQReader["Question"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Sets Colour Scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Dynamically adjust control positions and sizes
            lblTitle.Width = this.ClientSize.Width;

            int panelSpacing = 20;
            int panelWidth = (this.ClientSize.Width - (3 * panelSpacing)) / 2;
            int panelHeight = this.ClientSize.Height - lblTitle.Height - (2 * panelSpacing);

            InfoPanel.Width = panelWidth;
            InfoPanel.Height = panelHeight;
            InfoPanel.Location = new Point(panelSpacing, lblTitle.Height + panelSpacing);

            ActionPanel.Width = panelWidth;
            ActionPanel.Height = panelHeight;
            ActionPanel.Location = new Point(InfoPanel.Right + panelSpacing, lblTitle.Height + panelSpacing);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
        }
        private void TxtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            if (txtPassword.Text == "Enter your password")
            {
                txtPassword.Text = "";
            }
            txtPassword.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.PasswordChar = '\0'; // Reset password char
                    txtPassword.Text = "Enter your password";
                }
            };
        }

        private void TxtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter your username")
            {
                txtUsername.Text = "";
            }
            txtUsername.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Text = "Enter your username";
                }
            };
        }
        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Enter your email address")
            {
                txtEmail.Text = "";
            }
            txtEmail.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    txtEmail.Text = "Enter your email address";
                }
            };
        }
       
        private void txtFirst_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text == "Enter your first name")
            {
                txtFirst.Text = "";
            }
            txtFirst.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtFirst.Text))
                {
                    txtFirst.Text = "Enter your first name";
                }
            };
        }
        private void txtSurname_Click(object sender, EventArgs e)
        {
            if (txtSurname.Text == "Enter your last name")
            {
                txtSurname.Text = "";
            }
            txtSurname.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtSurname.Text))
                {
                    txtSurname.Text = "Enter your last name";
                }
            };
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private bool RegisterUser(string username, string firstName, string lastName, string email, string password, int securityQ, string securityA)
        {
            Register registerUser = new Register(username, firstName, lastName, email, password, 0, true, securityQ, securityA);
            CodeStatus success = registerUser.RegisterUser();
            if(success._statusCode != 200)
            {
                MessageBox.Show(success._statusMessage);
                return false;
            }
            return true;
        }

        private string HashString(string input)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Enabled == false)
            {
                //this re-configures the form for studetns to sign up
                btnSignup.Location = new Point(869, 632);
                btnLogin.Location = new Point(223, 612);
                txtUsername.Location = new Point(778, 283);
                txtPassword.Location = new Point(778, 338);
                txtEmail.Enabled = true;
                cbSecurityQ.Enabled = true;
                txtFirst.Enabled = true;
                txtSurname.Enabled = true;
                txtEmail.Visible = true;
                cbSecurityQ.Visible = true;
                txtFirst.Visible = true;
                txtSurname.Visible = true;
                lblIntro.Text = "Please enter your details to\r\nstart enjoying our Quazy \r\nQuizzes now! \r\nWe just need a few of your \r\ndetails and a confirmation\r\nfrom your lecturer and you\r\ncan begin right now!";
                lblTitle.Text = "Sign Up to Quazy Quizzes";
                
            }
            else
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == "Enter your username" ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == "Enter your password" ||
                    string.IsNullOrWhiteSpace(txtFirst.Text) || txtFirst.Text == "Enter your first name" ||
                    string.IsNullOrWhiteSpace(txtSurname.Text) || txtSurname.Text == "Enter your last name" ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text == "Enter your email address" ||
                    cbSecurityQ.SelectedIndex == 0 || string.IsNullOrWhiteSpace(cbSecurityQ.Text))
                {
                    MessageBox.Show("Please fill in all fields and select a security question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Prompt for the 2FA answer
                string securityAnswer = PromptForSecurityAnswer();
                if (string.IsNullOrWhiteSpace(securityAnswer))
                {
                    MessageBox.Show("Security answer cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected security question ID
                int securityQ = cbSecurityQ.SelectedIndex; // Assuming the dropdown index matches the SecurityQID

                // Register the user
                bool success = RegisterUser(
                    txtUsername.Text,
                    txtFirst.Text,
                    txtSurname.Text,
                    txtEmail.Text,
                    txtPassword.Text,
                    securityQ,
                    securityAnswer
                );

                if (success)
                {
                    MessageBox.Show("Account registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Reset form to login mode
                    LoginBtn_Click(sender, e);
                }
            }
        }

        private string PromptForSecurityAnswer()
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 300;
                prompt.Height = 150;
                prompt.Text = "Security Answer";

                Label textLabel = new Label() { Left = 20, Top = 20, Text = "Enter your security answer:" };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 240 };

                Button confirmation = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80, DialogResult = DialogResult.OK };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : null;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Enabled == true)
            {
                // this is validation to check that the form is in login mode and not sign up mode
                txtEmail.Enabled = false;
                cbSecurityQ.Enabled = false;
                txtFirst.Enabled = false;
                txtSurname.Enabled = false;
                txtEmail.Visible = false;
                cbSecurityQ.Visible = false;
                txtFirst.Visible = false;
                txtSurname.Visible = false;
                txtUsername.Location = new Point(778, 373);
                txtPassword.Location = new Point(778, 482);
                btnSignup.Location = new Point(223, 612);
                btnLogin.Location = new Point(869, 612);
                lblIntro.Text = "Quazy Quizzes is a game-\r\nbased learning platform \r\nthat allows users to \r\ncreate, share and play \r\ninteractive quizzes, \r\nserveys and discussions.\r\n";
                lblTitle.Text = "Welcome to Quazy Quizzes";
            }
            else
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == "Enter your username" ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == "Enter your password")
                {
                    MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Attempt login
                UserLogin userLogin = new UserLogin(txtUsername.Text, txtPassword.Text);
                CodeStatus loginStatus = userLogin.LoginWOSecurity();

                if (loginStatus._statusCode == 200)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Proceed to the next form or functionality
                    this.Hide();
                    // Example: Open the main dashboard
                    Stats dashboard = new Stats();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show(loginStatus._statusMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            ContactForm mainForm = new ContactForm();
            mainForm.Show();
        }

        private void _btnToggleTheme_Click(object sender, EventArgs e)
        {
            Program._isDarkMode = !Program._isDarkMode;

            // If it is now supposed to be dark mode
            if (Program._isDarkMode)
            {
                ApplyTheme(Program._darkTheme);
                return;
            }

            ApplyTheme(Program._lightTheme);
        }

        private void ApplyTheme(ColourScheme theme)
        {
            // Apply the theme to the form background
            this.BackColor = ColorTranslator.FromHtml(theme._background);

            // Apply the theme to the header
            theme.SetColourSchemeHeader(lblTitle);

            // Apply the theme to primary buttons
            theme.SetColourSchemePrimaryButtons(_primaryButtons);

            // Apply the theme to secondary buttons
            theme.SetColourSchemeSecondaryButtons(_secondaryButtons);

            // Apply the theme to labels
            theme.SetColourSchemePrimaryText(new List<Label> { lblIntro });
            lblIntro.BackColor = ColorTranslator.FromHtml(theme._cardBackground);
            // Apply the theme to panels
            ActionPanel.BackColor = ColorTranslator.FromHtml(theme._cardBackground);
            InfoPanel.BackColor = ColorTranslator.FromHtml(theme._cardBackground);

            // Apply the theme to textboxes
            theme.SetColourSchemeTextBox(new List<RichTextBox>());

            // Apply the theme to dropdowns
            cbSecurityQ.BackColor = ColorTranslator.FromHtml(theme._cardBackground);
            cbSecurityQ.ForeColor = ColorTranslator.FromHtml(theme._primaryText);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using Quazy Quizzes", "Goodbye", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
