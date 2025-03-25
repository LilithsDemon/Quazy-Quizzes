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
    public partial class QuizEditing : Form
    {

        List<Button> _primaryButtons = new List<Button>();
        List<Button> _secondaryButtons = new List<Button>();
        List<Button> _emergencyButtons = new List<Button>();

        public QuizEditing()
        {
            InitializeComponent();

            _primaryButtons = new List<Button>() { SubmitBtn};
            _secondaryButtons = new List<Button>() { PrevBtn, AddBtn };
            _emergencyButtons = new List<Button>() { HomeBtn };

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        // Chanes the elements to be the correct colours based on the colour scheme given for this page
        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemeSecondaryButtons(_secondaryButtons);
            colourScheme.SetColourSchemeEmergencyButtons(_emergencyButtons);
        }
    }
}
