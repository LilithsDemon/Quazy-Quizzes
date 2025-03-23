using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QQColourScheme;

namespace Quazy_Quizzes
{
    public partial class LecturerDashboard : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Button> _secondaryButtons = new List<Button>();
        private List<Button> _emergencyButtons = new List<Button>();

        private List<Label> _textElements = new List<Label>();

        public LecturerDashboard()
        {
            InitializeComponent();

            this._primaryButtons = new List<Button> { UsersBtn, TestsBtn, NewUserBtn };
            this._secondaryButtons = new List<Button> { StdntActsBtn, LectrActsBtn, EditActBtn };
            this._emergencyButtons = new List<Button> { LogOutBtn, DisableActBtn, DeleteActBtn };

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemeHeader(HeaderBg);
            this.SidebarBg.BackColor = ColorTranslator.FromHtml(colourScheme._secondaryBackground);
            this.SidebarBg.ForeColor = ColorTranslator.FromHtml(colourScheme._secondaryText);


            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemeSecondaryButtons(_secondaryButtons);
            colourScheme.SetColourSchemeEmergencyButtons(_emergencyButtons);
        }
    }
}
