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
using UserData;

namespace Quazy_Quizzes
{
    public partial class StudentDashboard : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Button> _emergencyButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();
        private int _userID = 1; // Used during testing

        public StudentDashboard()
        {
            InitializeComponent();

            this._stdText = new List<Label> { UserWelcomeLbl, PastExamsLbl };
            this._primaryButtons = new List<Button> { CourseSelectorBtn , ChangeThemeBtn };
            this._emergencyButtons = new List<Button> { LogOutBtn };
            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
            PopulateExamsTable();
            PopulateCoursesComboBox();
        }

         private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);
            colourScheme.SetColourSchemeHeader(HeaderLbl);
            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemeEmergencyButtons(_emergencyButtons);
            colourScheme.SetColourSchemePrimaryText(_stdText);
        }

        private void CourseSelectorBtn_Click(object sender, EventArgs e)
        {
            //when this is used open the selected course from the combobox
            int courseID = (int)ComboBoxCourses.SelectedValue;
            //open Courses.cs and pass the courseID to it
            Courses courseForm = new Courses(courseID);
            courseForm.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Program._user.ClearData();
            Form1 logInForm = new Form1();
            logInForm.Show();
            this.Hide();
        }

        private void ChangeThemeBtn_Click(object sender, EventArgs e)
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
        //Populate the combobox with the available courses
        private void PopulateCoursesComboBox()
        {
            // Clear the combobox so only new elements will be put in
            ComboBoxCourses.Items.Clear();
            // Get the data for the courses
            var reader = StoredProcedures.GetUsersCourses(this._userID);
            {
                // Convert DataReader to DataTable
                DataTable dt = new DataTable();
                dt.Load(reader);

                ComboBoxCourses.DataSource = dt;
                ComboBoxCourses.DisplayMember = "CourseName";
                ComboBoxCourses.ValueMember = "CourseID";
            }
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