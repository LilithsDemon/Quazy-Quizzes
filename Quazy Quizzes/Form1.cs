using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quazy_Quizzes
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
            txtUsername.MouseClick += new MouseEventHandler(txtUsername_Click);
            txtPassword.TextChanged += new EventHandler(txtPassword_TextChanged);
            txtUsername.TextChanged += new EventHandler(txtUsername_TextChanged);
            txtPassword.MouseClick += new MouseEventHandler(txtPassword_Click);

        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            // Set the password character to a star
            txtPassword.PasswordChar = '*';
            if (txtPassword.Text == "Enter your password")
            {
                txtPassword.Text = "";
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            //clears the text ready for the user to enter their username
            if (txtUsername.Text == "Enter your username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(txtStudent.Enabled == false)
            {
                //this re-configures the form for studetns to sign up
                btnSignup.Location = new Point(1056, 645);
                btnLogin.Location = new Point(340, 612);
                txtUsername.Location = new Point(966, 280);
                txtPassword.Location = new Point(966, 340);
                txtStudent.Enabled = true;
                txtEmail.Enabled = true;
                txtCourse.Enabled = true;
                txtFirst.Enabled = true;
                txtSurname.Enabled = true;
                txtStudent.Visible = true;
                txtEmail.Visible = true;
                txtCourse.Visible = true;
                txtFirst.Visible = true;
                txtSurname.Visible = true;
                lblIntro.Text = "Please enter your details to\r\nstart enjoying our Quazy \r\nQuizzes now! \r\nWe just need a few of your \r\ndetails and a confirmation\r\nfrom your lecturer and you\r\ncan begin right now!";
                lblTitle.Text = "Sign Up to Quazy Quizzes";
            }
            else
            {
                //Here is where it will go if the user was trying to sign up
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtStudent.Enabled == true)
            {
                // this is validation to check that the form is in login mode and not sign up mode
                txtStudent.Enabled = false;
                txtEmail.Enabled = false;
                txtCourse.Enabled = false;
                txtFirst.Enabled = false;
                txtSurname.Enabled = false;
                txtStudent.Visible = false;
                txtEmail.Visible = false;
                txtCourse.Visible = false;
                txtFirst.Visible = false;
                txtSurname.Visible = false;
                txtUsername.Location = new Point(966, 373);
                txtPassword.Location = new Point(966, 482);
                btnSignup.Location = new Point(340, 612);
                btnLogin.Location = new Point(1065, 612);
                lblIntro.Text = "Quazy Quizzes is a game-\r\nbased learning platform \r\nthat allows users to \r\ncreate, share and play \r\ninteractive quizzes, \r\nserveys and discussions.\r\n";
                lblTitle.Text = "Welcome to Quazy Quizzes";
            }
            else
            {
                //Here is where it will go if the user was trying to login
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this is temporary code to take you to the admin dashboard for testing at the moment. In future this will be implemented within the login system and this will be a button to guide you to an assistance page or a contact form.
            AdminDash adminDash = new AdminDash();
            adminDash.Show();
        }
    }
}
