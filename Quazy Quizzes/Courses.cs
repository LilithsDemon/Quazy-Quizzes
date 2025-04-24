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
using System.Xml.Serialization;


namespace Quazy_Quizzes
{
   
    public partial class Courses : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Button> _emergencyButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();
        private List<DataGridView> _dataGrids = new List<DataGridView>();
        private List<Control> _lecturerElements = new List<Control>();
        private List<Control> _studentElements = new List<Control>();

        private int _userRole = 0;
        private int _userID = 1;

        //this is used to get the courseID from passed in data
        public int courseID { get; set; } 
        public Courses(int courseID)
        {
            this.courseID = courseID;
            InitializeComponent();
            //colour scheme lists 
            this._primaryButtons = new List<Button> {  AddNewQuizBtn, LoadQuizBtn };
            this._emergencyButtons = new List<Button> { BtnBack };
            this._stdText = new List<Label> { AllExamLabel, ExamLabel, LeaderboardLbl };
            this._dataGrids = new List<DataGridView> { ExamDataGridView ,LeaderboardDataGrid };
            this._lecturerElements = new List<Control> { AllExamLabel, AddNewQuizBtn};
            this._studentElements = new List<Control> { ExamLabel };
            //get the page to match the colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

            LoadElementsForRole();
            
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemeHeader(HeaderBg);


            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemeEmergencyButtons(_emergencyButtons);
            colourScheme.SetColourSchemePrimaryText(_stdText);
        }

        private void LoadElementsForRole()
        {
            if (this._userRole == 0)
            {
                //student
                foreach (Control control in _lecturerElements)
                {
                    control.Visible = false;
                }
                foreach (Control control in _studentElements)
                {
                    control.Visible = true;
                }
                LoadPendingExams();
            }
            else
            {
                //lecturer
                foreach (Control control in _studentElements)
                {
                    control.Visible = false;
                }
                foreach (Control control in _lecturerElements)
                {
                    control.Visible = true;
                }
                LoadAllExams();
            }
        }

        public void LoadAllExams()
        {

            ExamDataGridView.Rows.Clear();
            ExamDataGridView.Columns.Clear();

            ExamDataGridView.Columns.Add("ExamName", "Exam Name");

            ConnectionHandler connHandler = new ConnectionHandler();

            string sql = "SELECT `ExamName` FROM `Exams` WHERE `CourseID` = @courseID";
            string[] paramNames = { "@courseID" };
            string[] parameters = { courseID.ToString() };
            try
            {
                MySqlDataReader reader = connHandler.ExectuteQuery(sql, paramNames, parameters);

                while (reader.Read()) ExamDataGridView.Rows.Add(reader[0]);

                reader.Close(); 
            }
            catch (Exception ex)
            {
                
            }
        }

        //this will be used to load the exams for the course
        public void LoadPendingExams()
        {
            ExamDataGridView.Rows.Clear();
            ExamDataGridView.Columns.Clear();

            ExamDataGridView.Columns.Add("ExamID", "Exam ID");
            ExamDataGridView.Columns.Add("ExamName", "Exam Name");

            ExamDataGridView.Columns[0].Visible = false;

            ConnectionHandler connHandler = new ConnectionHandler();

            string sql = "SELECT `Exams`.`ExamID` `Exams`.`ExamName`, `Scores`.`Score` FROM `Scores` RIGHT JOIN `Exams` " +
                "ON `Scores`.`ExamID` = `Exams`.`ExamID` JOIN `Courses` " +
                "ON `Exams`.`CourseID` = `Courses`.`CourseID` JOIN `UserToCourse` " +
                "ON `UserToCourse`.`CourseID` = `Courses`.`CourseID` JOIN `Users` " +
                "ON `Users`.`UserID` = `UserToCourse`.`UserID` " +
                "WHERE `Users`.`UserID` = @UserID AND `Courses`.`CourseID` = @CourseID AND `Exams`.`Status` = 1 AND `Score` IS null;";
            string[] paramNames = { "@CourseID", "@UserID" };
            string[] parameters = { courseID.ToString(), this._userID.ToString() };

            try
            {
                MySqlDataReader reader = connHandler.ExectuteQuery(sql, paramNames, parameters);

                while (reader.Read()) ExamDataGridView.Rows.Add(reader[0], reader[1]);
            }
            catch (Exception ex)
            {
               
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

        private void LoadQuizBtn_Click(object sender, EventArgs e)
        {
            int selectedCourseID = Convert.ToInt32(ExamDataGridView.SelectedRows[0].Cells[0].Value);
        }
    }
}
