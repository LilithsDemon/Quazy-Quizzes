using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using QQColourScheme;
using Conn;

namespace Quazy_Quizzes
{
    public partial class Stats : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();
        private List<DataGridView> _dataGrids = new List<DataGridView>();
        private int _userRole;
        private List<string> _courses = new List<string>();

        public Stats()
        {
            InitializeComponent();

            CmbCourses.SelectedIndexChanged += CmbCourses_SelectedIndexChanged;
            CmbExams.SelectedIndexChanged += CmbExams_SelectedIndexChanged;

            _primaryButtons = new List<Button> { BtnBack, BtnTheme };
            _stdText = new List<Label> { LblTitle };
            _dataGrids = new List<DataGridView> { DgvStats };

            _userRole = 1;

            if (_userRole >= 1)
            {
                LblCourse.Visible = true;
                CmbCourses.Visible = true;
                LblExams.Visible = true;
                CmbExams.Visible = true;
                LoadCourses();
                DgvStats.DataSource = null;
            }
            else
            {
                LblCourse.Visible = false;
                CmbCourses.Visible = false;
                LblExams.Visible = false;
                CmbExams.Visible = false;
                LoadStats();
            }

            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnToggleTheme_Click(object sender, EventArgs e)
        {
            Program._isDarkMode = !Program._isDarkMode;
            SetColourScheme(Program._isDarkMode ? Program._darkTheme : Program._lightTheme);
        }

        private void CmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_userRole == 1)
            {
                LoadExams();
                DgvStats.DataSource = null;
            }
        }

        private void CmbExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_userRole == 1 && CmbCourses.SelectedItem != null && CmbExams.SelectedItem != null)
            {
                LoadStats();
            }
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);
            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemePrimaryText(_stdText);
            colourScheme.SetColourSchemeDataGrid(_dataGrids);
            colourScheme.SetColourSchemeLabels(new List<Label> { LblCourse, LblExams });
            LblTitle.ForeColor = ColorTranslator.FromHtml(colourScheme._headerText);
            LblTitle.BackColor = ColorTranslator.FromHtml(colourScheme._headerBackground);
        }

        private int GetUserRole()
        {
            string query = "SELECT `Role` FROM `Users` WHERE `UserID` = @userID";
            int role = 0;

            var connectionHandler = new Conn.ConnectionHandler();
            using (var connection = connectionHandler.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", 1);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        role = Convert.ToInt32(result);
                    }
                }
            }

            return role;
        }

        private void LoadCourses()
        {
            try
            {
                CmbCourses.DataSource = null;
                CmbCourses.Items.Clear();

                string query = "SELECT CourseID, CourseName FROM Courses WHERE CourseID IN (SELECT CourseID FROM UserToCourse WHERE UserID = 1)";
                var reader = new ConnectionHandler().ExecuteQueryNoParams(query);

                DataTable dt = new DataTable();
                dt.Load(reader);

                CmbCourses.DataSource = dt;
                CmbCourses.DisplayMember = "CourseName";
                CmbCourses.ValueMember = "CourseID";
                CmbCourses.SelectedIndex = -1;
                CmbCourses.Refresh();
            }
            catch (Exception)
            {
            }
        }

        private void LoadExams()
        {
            try
            {
                DataRowView drv = CmbCourses.SelectedItem as DataRowView;
                if (drv == null)
                {
                    return;
                }
                int selectedCourseID = Convert.ToInt32(drv["CourseID"]);
                string query = "SELECT `ExamID`, `ExamName` FROM `Exams` WHERE `CourseID` = @courseID";
                DataTable dt = new DataTable();

                var connectionHandler = new ConnectionHandler();
                using (var connection = connectionHandler.GetConnection())
                {
                    connection.Open();

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@courseID", selectedCourseID);

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                CmbExams.DataSource = dt;
                CmbExams.DisplayMember = "ExamName";
                CmbExams.ValueMember = "ExamID";
                CmbExams.SelectedIndex = -1;
                CmbExams.Refresh();
            }
            catch (Exception)
            {
            }
        }

        private void LoadStats()
        {
            try
            {
                string query = _userRole == 1
                    ? @"SELECT u.Username, s.Score FROM Scores s JOIN Users u ON s.UserID = u.UserID WHERE s.ExamID = @examID"
                    : "CALL GetUserQuizStats(@userID)";

                var connectionHandler = new Conn.ConnectionHandler();
                using (var connection = connectionHandler.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (_userRole == 1)
                        {
                            if (CmbExams.SelectedValue == null)
                            {
                                return;
                            }
                            command.Parameters.AddWithValue("@examID", Convert.ToInt32(CmbExams.SelectedValue));
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@userID", 1);
                        }

                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            DgvStats.DataSource = dt;
                        }
                    }
                }

                DgvStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvStats.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception)
            {
            }
        }
    }
}
