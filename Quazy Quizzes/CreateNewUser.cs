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
using Registration;
using Status;

namespace Quazy_Quizzes
{
    public partial class CreateNewUser : Form
    {

        List<Label> _primaryTextLabels = new List<Label>();
        List<Button> _primaryButtons = new List<Button>();
        List<Button> _emergencyButtons = new List<Button>();
        List<TextBox> _textBoxes = new List<TextBox>();
        List<ComboBox> _comboBoxes = new List<ComboBox>();

        int _usersRole = 2; // Used for testing


        public CreateNewUser()
        {
            InitializeComponent();

            this._primaryButtons = new List<Button>() { CreateUserBtn };
            this._primaryTextLabels = new List<Label>() { UsernameLbl, FirstNameLbl, LastNameLbl, EmailLbl, PasswordLbl, SecurityQLbl, SecurityALbl, RoleLbl};
            this._emergencyButtons = new List<Button>() { CancelBtn };
            this._textBoxes = new List<TextBox>() { UsernameInput, FirstNameInput, LastNameInput, EmailInput, PasswordInput, SecurityAInput };
            this._comboBoxes = new List<ComboBox>() { SecurityQCB, RoleCB };

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

            FillSecurityQBox();
            FillRoleBox();
        }
        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemePrimaryButtons(this._primaryButtons);
            colourScheme.SetColourSchemeEmergencyButtons(this._emergencyButtons);
            colourScheme.SetColourSchemePrimaryText(this._primaryTextLabels);
            colourScheme.SetColourSchemeTextBox(this._textBoxes);
            colourScheme.SetColourSchemeComboBox(this._comboBoxes);
        }


        public void FillSecurityQBox()
        {
            SecurityQCB.Items.Clear(); // Clear the combobox before filling it
            string SQL = "SELECT * FROM `SecurityQuestions`;";
            var reader = new ConnectionHandler().ExecuteQueryNoParams(SQL);

            DataTable dt = new DataTable();
            dt.Load(reader);

            SecurityQCB.DataSource = dt;
            SecurityQCB.DisplayMember = "Question"; // Column name to display
            SecurityQCB.ValueMember = "SecurityQID"; // Column name to use as value
            SecurityQCB.SelectedIndex = -1; // Set default selection to no item
        }

        public void FillRoleBox()
        {
            RoleCB.Items.Clear(); // Clear the combobox before filling it
            RoleCB.Items.Add("Student");
            RoleCB.Items.Add("Lecturer");
            if(this._usersRole == 2) RoleCB.Items.Add("Admin");
            RoleCB.SelectedIndex = -1; // Set default selection to no item
            
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            // Checks to make sure that fields are correctly filled in.
            if(string.IsNullOrEmpty(UsernameInput.Text) || string.IsNullOrEmpty(FirstNameInput.Text) || string.IsNullOrEmpty(LastNameInput.Text) || string.IsNullOrEmpty(EmailInput.Text) || string.IsNullOrEmpty(PasswordInput.Text) || string.IsNullOrEmpty(SecurityAInput.Text) || SecurityQCB.SelectedIndex == -1 || RoleCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (UsernameInput.Text.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long.");
                return;
            }
            if (PasswordInput.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }
            if (EmailInput.Text.Length < 5 || !EmailInput.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            if (SecurityAInput.Text.Length < 3)
            {
                MessageBox.Show("Security answer must be at least 3 characters long.");
                return;
            }
            if(RoleCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }
            if (SecurityQCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a security question.");
                return;
            }

            Register register = new Register(
                UsernameInput.Text, //username
                FirstNameInput.Text, //firstname
                LastNameInput.Text, //lastname
                EmailInput.Text, //email
                PasswordInput.Text, //password
                Convert.ToInt32(RoleCB.SelectedValue), //role
                true, // Active status - if made in this section account should be instantly activated
                Convert.ToInt32(SecurityQCB.SelectedValue), // Selected security Question
                SecurityAInput.Text
            );
            CodeStatus registerStatus = register.RegisterUser();
            MessageBox.Show(registerStatus._statusCode.ToString() + " | " + registerStatus._statusMessage, "Create New User");
            if (registerStatus._statusCode == 200)
            {
                // Clear the inputs
                UsernameInput.Text = "";
                FirstNameInput.Text = "";
                LastNameInput.Text = "";
                EmailInput.Text = "";
                PasswordInput.Text = "";
                SecurityAInput.Text = "";
                SecurityQCB.SelectedIndex = -1;
                RoleCB.SelectedIndex = -1;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
