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

        private int _userRole = 1;
        private int _userID = 1;

        private Button PlayQuizBtn;

        //this is used to get the courseID from passed in data
        public int _courseID { get; set; } 
        public Courses(int courseID)
        {
            this._courseID = courseID;
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

            this.PlayQuizBtn = new Button
            {
                Text = "Play Quiz",
                Location = new Point(10, 400), // Adjust location as needed
                Size = new Size(100, 30)
            };
            this.PlayQuizBtn.Click += PlayQuizBtn_Click;
            this.Controls.Add(this.PlayQuizBtn);

            // Add a checkbox column to the ExamDataGridView
            var selectColumn = new DataGridViewCheckBoxColumn
            {
                Name = "SelectColumn",
                HeaderText = "Select",
                Width = 50
            };
            ExamDataGridView.Columns.Add(selectColumn);

            // Handle the CellContentClick event to ensure only one checkbox is selected
            ExamDataGridView.CellContentClick += ExamDataGridView_CellContentClick;

            LoadElementsForRole();
            LoadLeaderboardForCourse();
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemeHeader(HeaderBg);


            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemeEmergencyButtons(_emergencyButtons);
            colourScheme.SetColourSchemePrimaryText(_stdText);
            colourScheme.SetColourSchemeDataGrid(_dataGrids);
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
            string[] parameters = { this._courseID.ToString() };
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

            // Add columns for ExamID, ExamName, and the Select checkbox
            ExamDataGridView.Columns.Add("ExamID", "Exam ID");
            ExamDataGridView.Columns.Add("ExamName", "Exam Name");
            var selectColumn = new DataGridViewCheckBoxColumn
            {
                Name = "SelectColumn",
                HeaderText = "Select",
                Width = 50
            };
            ExamDataGridView.Columns.Add(selectColumn);

            ExamDataGridView.Columns["ExamID"].Visible = false;

            string getAllQuizzesIDSql = "SELECT `Exams`.`ExamID`, `Exams`.`ExamName` FROM `Exams` WHERE `Exams`.`CourseID` = @courseID AND `Exams`.`Status` = 1;";
            string[] allQuizzesParamNames = { "@courseID" };
            string[] allQuizzesParameters = { this._courseID.ToString()};

            string getDoneQuizIDSql = "SELECT `Scores`.`ExamID` FROM `Scores` LEFT JOIN `Exams` ON `Scores`.`ExamID` = `Exams`.`ExamID` " +
                "WHERE `Scores`.`UserID` = @userID AND `Exams`.`CourseID` = @courseID AND `Exams`.`Status` = 1; ";
            string[] doneQuizParamNames = { "@userID", "@courseID" };
            string[] doneQuizParameters = { this._userID.ToString(), this._courseID.ToString() };

            Dictionary<int, string> allQuizzes = new Dictionary<int, string>();

            try
            {
                MySqlDataReader allQuizReader = new ConnectionHandler().ExectuteQuery(getAllQuizzesIDSql, allQuizzesParamNames, allQuizzesParameters);

                while (allQuizReader.Read())
                {
                    allQuizzes.Add(Convert.ToInt32(allQuizReader["ExamID"]), allQuizReader["ExamName"].ToString());
                }
            }
            catch { /*No courses in this course */}

            try
            {
                MySqlDataReader doneQuizReader = new ConnectionHandler().ExectuteQuery(getDoneQuizIDSql, doneQuizParamNames, doneQuizParameters);
                while (doneQuizReader.Read())
                {
                    allQuizzes.Remove(Convert.ToInt32(doneQuizReader["ExamID"]));
                }
            }
            catch { /*This user has done no quizzes in this course */}
            
            foreach (KeyValuePair<int, string> quiz in allQuizzes)
            {
                ExamDataGridView.Rows.Add(quiz.Key, quiz.Value, false);
            }

        }

        //this will be used to load the leaderboard for the courses
        public void LoadLeaderboardForCourse()
        {
            ConnectionHandler connHandler = new ConnectionHandler();

            
            string sql = "SELECT `Users`.`UserName` as 'UserName'," +
                " SUM(`Scores`.`Score`) / (SELECT COUNT(`ExamID`) FROM `Exams` WHERE `Status` = 1 AND `CourseID` = 1) AS 'AverageScore'" +
                " FROM `Scores` " +
                "JOIN `Exams` ON `Exams`.`ExamID` = `Scores`.`ExamID` " +
                "JOIN `Users` ON `Scores`.`UserID` = `Users`.`UserID` " +
                "WHERE `Exams`.`Status` = 1 AND `Exams`.`CourseID` = @courseID AND `Users`.`Role` = 0 " +
                "GROUP BY `Users`.`UserName` " +
                "ORDER BY SUM(`Scores`.`Score`) / (SELECT COUNT(`ExamID`) FROM `Exams` WHERE `Status` = 1 AND `CourseID` = 1) DESC LIMIT 5; ";

            string[] paramNames = { "@courseID" };
            string[] parameters = { this._courseID.ToString() };

            try
            {
                MySqlDataReader reader = connHandler.ExectuteQuery(sql, paramNames, parameters);

                
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Username", typeof(string));
                dataTable.Columns.Add("Avg Score", typeof(int));

                //populate the DataTable
                while (reader.Read())
                {
                    string username = reader["UserName"].ToString();
                    int score = Convert.ToInt32(reader["AverageScore"]);
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
            // not currently implemented
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
            if (ExamDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a quiz to load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure the selected row contains a valid ExamID
            int selectedExamID;
            try
            {
                selectedExamID = Convert.ToInt32(ExamDataGridView.SelectedRows[0].Cells["ExamID"].Value);
            }
            catch
            {
                MessageBox.Show("Invalid selection. Please select a valid quiz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Navigate to the playQuiz page with the selected ExamID
            playQuiz quizPage = new playQuiz(selectedExamID);
            quizPage.Show();
            this.Hide();
        }

        private void PlayQuizBtn_Click(object sender, EventArgs e)
        {
            // Find the selected exam
            DataGridViewRow selectedRow = ExamDataGridView.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells["SelectColumn"].Value != null && Convert.ToBoolean(row.Cells["SelectColumn"].Value) == true);

            if (selectedRow == null)
            {
                MessageBox.Show("Please select a quiz to play.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ExamID of the selected quiz
            int selectedExamID;
            try
            {
                selectedExamID = Convert.ToInt32(selectedRow.Cells["ExamID"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving ExamID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Debugging message to confirm ExamID
            MessageBox.Show($"Selected ExamID: {selectedExamID}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate to the playQuiz page with the selected ExamID
            try
            {
                playQuiz quizPage = new playQuiz(selectedExamID);
                quizPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating to playQuiz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the column exists and is the SelectColumn
            if (ExamDataGridView.Columns["SelectColumn"] == null || e.ColumnIndex != ExamDataGridView.Columns["SelectColumn"].Index || e.RowIndex < 0)
            {
                return;
            }

            // Uncheck all other checkboxes
            foreach (DataGridViewRow row in ExamDataGridView.Rows)
            {
                if (row.Index != e.RowIndex)
                {
                    row.Cells["SelectColumn"].Value = false;
                }
            }
        }
    }
}
