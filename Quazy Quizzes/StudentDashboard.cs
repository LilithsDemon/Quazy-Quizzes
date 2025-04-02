using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QQStoredProcedures;
using QQColourScheme;
using MySqlConnector;

namespace Quazy_Quizzes
{




    public partial class StudentDashboard : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();

        public StudentDashboard()
        {
            InitializeComponent();

            this._stdText = new List<Label> { UserWelcomeLbl, PastExamsLbl };
            this._primaryButtons = new List<Button> { QuizSelectorbtn, ChangeThemebtn, ViewAvailableCoursesbtn };
            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

         private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);
            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
        }

        private void QuizSelectorbtn_Click(object sender, EventArgs e)
        {
            //when this is used open the selected quiz from the combobox
            int examID = (int)ComboBoxExams.SelectedValue;
            //however because exams aren't implemented yet, this will just show a message box
            MessageBox.Show("This will open the quiz with ID: " + examID);
        }

        private void ViewAvailableCoursesbtn_Click(object sender, EventArgs e)
        {
            //when this is used open the available courses
            //however because courses aren't implemented yet, this will just show a message box
            MessageBox.Show("This will open the available courses");
        }

        private void ChangeThemebtn_Click(object sender, EventArgs e)
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

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            int userID = 2; // to be used during testing
            PopulateExamData(userID);
        }

        // Populate exam data
        private void PopulateExamData(int userID)
        {
            using (MySqlDataReader reader = StoredProcedures.GetUsersExamsWithScores(userID))
            {
                DataTable dt = new DataTable();
                dt.Load(reader);

                //logic to split exams with scores and exams without scores
                DataView dvNoScores = new DataView(dt);
                dvNoScores.RowFilter = "Score = ''";

                DataView dvWithScores = new DataView(dt);
                dvWithScores.RowFilter = "Score <> = ''";

                // Bind to controls
                ComboBoxExams.DataSource = dvNoScores.ToTable();
                ComboBoxExams.DisplayMember = "ExamName";
                ComboBoxExams.ValueMember = "ExamID";

                CompletedExams.DataSource = dvWithScores.ToTable();
            }
        }
    }
}