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

namespace Quazy_Quizzes
{
    public partial class StudentDashboard : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();
        private int _userID = 1; // Used during testing

        public StudentDashboard()
        {
            InitializeComponent();

            this._stdText = new List<Label> { UserWelcomeLbl, PastExamsLbl };
            this._primaryButtons = new List<Button> { QuizSelectorbtn, ChangeThemebtn, ViewAvailableCoursesbtn };
            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
            PopulateExamsTable();
        }

         private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);
            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemePrimaryText(_stdText);
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

        // Populate exam data
        private void PopulateExamsTable()
        {
            // Clear the grid so only new elements will be put in
            CompletedExams.Rows.Clear();
            CompletedExams.Columns.Clear();

            //Make 2 columns, one to show the username, the other to show if the account is active or disabled
            CompletedExams.Columns.Add("ExamName", "Exam Name");
            CompletedExams.Columns.Add("Score", "Score %");

            // Get the data for the exams
            var reader = StoredProcedures.GetUsersExamsWithScores(this._userID);

            while (reader.Read())
            {
                if (reader[1].ToString() != "") // If the user has taken the exam
                {
                    CompletedExams.Rows.Add(reader[0].ToString(), reader[1].ToString()); // Exam name, score
                }
            }
        }
    }
}