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

        int _usersRole = 2;

        public CreateNewUser()
        {
            InitializeComponent();

            this._primaryButtons.Add(CreateUserBtn);

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemePrimaryButtons(this._primaryButtons);
            colourScheme.SetColourSchemePrimaryText(this._primaryTextLabels);
        }
    }
}
