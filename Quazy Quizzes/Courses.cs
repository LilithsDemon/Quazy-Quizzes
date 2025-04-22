using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserData;
using Conn;
using MySqlConnector;
using QQColourScheme;


namespace Quazy_Quizzes
{
   
    public partial class Courses : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Button> _emergencyButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();

        public int courseID = 0; //used during testing it will be a get ; set ; in the future
        public Courses()
        {

            InitializeComponent();
            //colour scheme lists 
            this._primaryButtons = new List<Button> {  AddNewQuizBtn };
            this._emergencyButtons = new List<Button> { BtnBack };
            this._stdText = new List<Label> { AllExamLabel, ExamLabel };
            //get the page to match the colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

        }
        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemeHeader(HeaderBg);


            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemeEmergencyButtons(_emergencyButtons);
            colourScheme.SetColourSchemePrimaryText(_stdText);
        }
        public void LoadAllExams(int courseID)
        {
            ConnectionHandler connHandler = new ConnectionHandler();


            string sql = @"
        SELECT ExamName 
        FROM Exams 
        WHERE CourseID = @CourseID 
        ORDER BY ExamName;";
            string[] paramNames = { "@CourseID" };
            string[] parameters = { courseID.ToString() };
            try
            {
                MySqlDataReader reader = connHandler.ExectuteQuery(sql, paramNames, parameters);
                AllExams.Items.Clear();

                while (reader.Read())
                {
                    string examName = reader["ExamName"].ToString();
                    AllExams.Items.Add(examName);
                }

                reader.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading exams: " + ex.Message);
            }
        }
        //this will be used to load the exams for the course
        public void LoadPendingExams(int courseID, int userID)
        {
            ConnectionHandler connHandler = new ConnectionHandler();

            string sql = @"
        SELECT Exams.ExamID, Exams.ExamName 
        FROM Exams
        WHERE Exams.CourseID = @CourseID
          AND Exams.Status = TRUE  -- Filter for exams with status = true
          AND Exams.ExamID NOT IN (
              SELECT Scores.ExamID 
              FROM Scores 
              WHERE Scores.UserID = @UserID
          )
        ORDER BY Exams.ExamName;";

            string[] paramNames = { "@CourseID", "@UserID" };
            string[] parameters = { courseID.ToString(), userID.ToString() };

            try
            {
                MySqlDataReader reader = connHandler.ExectuteQuery(sql, paramNames, parameters);
                StudentExamsList.Items.Clear();

                while (reader.Read())
                {
                    Exam exam = new Exam
                    {
                        examID = Convert.ToInt32(reader["ExamID"]),
                        examName = reader["ExamName"].ToString()
                    };
                    StudentExamsList.Items.Add(exam);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending exams: " + ex.Message);
            }
        }
        //this will be used to load the leaderboard for the courses
        public void LoadLeaderboardForCourse(int courseID)
        {
            ConnectionHandler connHandler = new ConnectionHandler();

            
            string sql = @"
        SELECT 
            Users.UserName AS Username
            Scores.Score
        FROM Users
        JOIN Scores ON Users.UserID = Scores.UserID
        JOIN Exams ON Scores.ExamID = Exams.ExamID
        WHERE Exams.CourseID = @CourseID
        ORDER BY Scores.Score DESC;";

            string[] paramNames = { "@CourseID" };
            string[] parameters = { courseID.ToString() };

            try
            {
                MySqlDataReader reader = connHandler.ExectuteQuery(sql, paramNames, parameters);

                
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Username", typeof(string));
                dataTable.Columns.Add("Score", typeof(int));

                //populate the DataTable
                while (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    int score = Convert.ToInt32(reader["Score"]);
                    dataTable.Rows.Add(username, score);
                }

                //bind the data to the datagrid
                LeaderboardDataGrid.DataSource = dataTable;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leaderboard: " + ex.Message);
            }
        }
        private void Courses_Load(object sender, EventArgs e)
        {
            //determine if the user is a student or lecturer with a switch statement
            switch (Program._user._role)
            {
                case 0:
                    //student
                    AddNewQuizBtn.Visible = false;
                    AllExamLabel.Visible = false;
                    AllExams.Visible = false;
                    ExamLabel.Visible = true;
                    StudentExamsList.Visible = true;
                    LoadLeaderboardForCourse(courseID);
                    LoadPendingExams(courseID, Program._user._userID);
                    break;
                case 1:
                    //lecturer
                    //the same above but inverted
                    AddNewQuizBtn.Visible = true;
                    AllExamLabel.Visible = true;
                    AllExams.Visible = true;
                    ExamLabel.Visible = false;
                    StudentExamsList.Visible = false;
                    LoadLeaderboardForCourse(courseID);
                    LoadAllExams(courseID);
                    break;
                case 2:
                    //admin
                    //just show the same as lecturer
                    AddNewQuizBtn.Visible = true;
                    AllExamLabel.Visible = true;
                    AllExams.Visible = true;
                    ExamLabel.Visible = false;
                    StudentExamsList.Visible = false;
                    LoadLeaderboardForCourse(courseID);
                    break;
                default:
                    //error
                    MessageBox.Show("Error: User role not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
           

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //if the user is a student take them to StudentDashboard and if they're a lecturer take them to LecturerDashboard
            //if the user is an admin take them to AdminDash
            switch (Program._user._role)
            {
                case 0:
                    //student
                    StudentDashboard studentDashboard = new StudentDashboard();
                    studentDashboard.Show();
                    break;
                case 1:
                    //lecturer
                    LecturerDashboard lecturerDashboard = new LecturerDashboard();
                    lecturerDashboard.Show();
                    break;
                case 2:
                    //admin
                    AdminDash adminDashboard = new AdminDash();
                    adminDashboard.Show();
                    break;
                default:
                    //error
                    MessageBox.Show("Error: User role not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            //hide this form
            this.Hide();
        }

        private void AddNewQuizBtn_Click(object sender, EventArgs e)
        {
            //take the user to add a new quiz but quizzes aren't implemented yet
            //so just show a message box
            MessageBox.Show("Quizzes are not implemented yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void StudentExamsList_DoubleClick(object sender, EventArgs e)
        {
            if (StudentExamsList.SelectedItem == null) return;

            // Get the selected exam's ID
            Exam selectedExam = (Exam)StudentExamsList.SelectedItem;
            int examId = selectedExam.examID;

            //quizzes aren't implimented yet so just show a message box
            MessageBox.Show("Quizzes are not implemented yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void AllExams_DoubleClick(object sender, EventArgs e)
        {
            if (AllExams.SelectedItem == null) return;

            // Get the selected exam's ID
            Exam selectedExam = (Exam)AllExams.SelectedItem;
            int examId = selectedExam.examID;

            //open the quiz editor but that's not done yet so just show a message box
            MessageBox.Show("Quizzes are not implemented yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
    }
    public class Exam
    {
        public int examID { get; set; }
        public string examName { get; set; }

        public override string ToString()
        {
            return examName; //only shows the name in the list
        }
    }
}
