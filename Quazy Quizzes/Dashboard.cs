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
    public partial class Dashboard : Form
    {
        private List<Button> _emergencyButtons = new List<Button>();
        public Dashboard()
        {
            InitializeComponent();

            _emergencyButtons = new List<Button> { BackBtn };

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        // Chanes the elements to be the correct colours based on the colour scheme given for this page
        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemeEmergencyButtons(_emergencyButtons);
        }

        private void CboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            rctxtLeaderboards.Text = "Leaderboards for " + cboCourse.Text + "\n";
            rctxtLeaderboards.Visible = true;
            rctxtLeaderboards.Enabled = true;

        }
    }
}
