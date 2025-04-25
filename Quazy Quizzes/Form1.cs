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
            // Set the password character to a star
            txtPassword.PasswordChar = '*';
            if (txtPassword.Text == "Enter your password")
            {
                txtPassword.Text = "";
            }
        }

        private void TxtUsername_Click(object sender, EventArgs e)
        {
            //clears the text ready for the user to enter their username
            if (txtUsername.Text == "Enter your username")
            {
                txtUsername.Text = "";
            }
        }
        private void txtEmail_Click(object sender, EventArgs e)
        {
            //clears the text ready for the user to enter their username
            if (txtEmail.Text == "Enter your email address")
            {
                txtEmail.Text = "";
            }
        }
       
        private void txtFirst_Click(object sender, EventArgs e)
        {
            //clears the text ready for the user to enter their username
            if (txtFirst.Text == "Enter your first name")
            {
                txtFirst.Text = "";
            }
        }
        private void txtSurname_Click(object sender, EventArgs e)
        {
            //clears the text ready for the user to enter their username
            if (txtSurname.Text == "Enter your last name")
            {
                txtSurname.Text = "";
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if(txtEmail.Enabled == false)
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
                
                Form popupForm = new Form
            {
                Size = new Size(300, 200),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

                TextBox SecurityA = new TextBox
                {
                    
                    Size = new Size(200, 50),
                    Location = new Point((popupForm.ClientSize.Width - 200) / 2, (popupForm.ClientSize.Height - 100) / 2),
                    Anchor = AnchorStyles.None,
                    BackColor = ColorTranslator.FromHtml("#00B2CC"),
                    Font = new Font("Orbitron", 18, FontStyle.Regular),
                    ForeColor = ColorTranslator.FromHtml("#FFFFFF")
                };
                

                Button btnSave = new Button
            {
                Text = "Save Q/A",
                Size = new Size(200, 50),
                Location = new Point((popupForm.ClientSize.Width - 200) / 2, (popupForm.ClientSize.Height - 50) / 2),
                Anchor = AnchorStyles.None,
                BackColor = ColorTranslator.FromHtml("#00B2CC"),
                Font = new Font("Orbitron", 18, FontStyle.Regular),
                ForeColor = ColorTranslator.FromHtml("#FFFFFF")
            };
                popupForm.Controls.Add(SecurityA);
                popupForm.Controls.Add(btnSave);
                popupForm.Show();



                /*
                //Here is where it will go if the user was trying to sign up
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string firstName = txtFirst.Text;
                string lastName = txtSurname.Text;
                string email = txtEmail.Text;

                string securityQSql2 = "SELECT * FROM `SecurityQuestions` WHERE `Question` = @question";
                string[] securityQParamNames = { "@question" };
                string[] securityQParameters = { cbSecurityQ.SelectedItem.ToString() };
                try
                {
                    var securityQReader2 = new ConnectionHandler().ExectuteQuery(securityQSql2, securityQParamNames, securityQParameters);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select a security question");
                    return;
                }

                int securityQ = Convert.ToInt32(securityQReader["SecurityQID"]);

                Register register = new Register(username, firstName, lastName, email, password, 0, false , securityQ, securityA);
                CodeStatus registerStatus = register.RegisterUser();
                */
            }


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(txtEmail.Enabled == true)
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
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                UserLogin userLogin = new UserLogin(username, password);
                CodeStatus codeStatus = userLogin.LoginWOSecurity();
                
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

            // If is now supposed to be dark mode
            if (Program._isDarkMode)
            {
                SetColourScheme(Program._darkTheme);
                return;
            }

           SetColourScheme(Program._lightTheme);
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
