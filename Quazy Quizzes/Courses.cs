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

namespace Quazy_Quizzes
{

    public partial class Courses : Form
    {
        public int courseID = 0; //used during testing it will be a get ; set ; in the future
        public Courses()
        {

            InitializeComponent();

            
        }
        public void LoadLeaderboardForCourse(int courseID)
        {
            ConnectionHandler connHandler = new ConnectionHandler();

            // SQL query (parameterized)
            string sql = @"
        SELECT 
            Users.UserName AS Username
            Scores.Score
        FROM Users
        JOIN Scores ON Users.UserID = Scores.UserID
        JOIN Exams ON Scores.ExamID = Exams.ExamID
        WHERE Exams.CourseID = @CourseID
        ORDER BY Scores.Score DESC;";

            // Parameters (CourseID is an integer)
            string[] paramNames = { "@CourseID" };
            string[] parameters = { courseID.ToString() };

            try
            {
                MySqlDataReader reader = connHandler.ExectuteQuery(sql, paramNames, parameters);

                // Create a DataTable to hold the results
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
            //populate the listboxes
            //populate the leaderboard of all the students in the class arraged by score


        private void BtnBack_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Hide();
        }

        private void AddNewQuizBtn_Click(object sender, EventArgs e)
        {
            //take the user to add a new quiz but quizzes aren't implemented yet
            //so just show a message box
            MessageBox.Show("Quizzes are not implemented yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
