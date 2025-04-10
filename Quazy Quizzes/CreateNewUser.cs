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

namespace Quazy_Quizzes
{
    public partial class CreateNewUser : Form
    {

        List<Label> _primaryTextLabels = new List<Label>();
        List<Button> _primaryButtons = new List<Button>();
        List<TextBox> _textBoxes = new List<TextBox>();
        List<ComboBox> _comboBoxes = new List<ComboBox>();

        int _usersRole = 2; // Used for testing


        public CreateNewUser()
        {
            InitializeComponent();

            this._primaryButtons = new List<Button>() { CreateUserBtn };
            this._primaryTextLabels = new List<Label>() { UsernameLbl, FirstNameLbl, LastNameLbl, EmailLbl, PasswordLbl, SecurityQLbl, SecurityALbl, RoleLbl};
            this._textBoxes = new List<TextBox>() { UsernameInput, FirstNameInput, LastNameInput, EmailInput, PasswordInput, SecurityAInput };
            this._comboBoxes = new List<ComboBox>() { SecurityQCB, RoleCB };

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        public void FillSecurityQBox()
        {
            
        }

        public void FillRoleBox()
        {

        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemePrimaryButtons(this._primaryButtons);
            colourScheme.SetColourSchemePrimaryText(this._primaryTextLabels);
            colourScheme.SetColourSchemeTextBox(this._textBoxes);
            colourScheme.SetColourSchemeComboBox(this._comboBoxes);
        }
    }
}
