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
        private int _userRole = 0; // Adjustable for testing: 0 = Student, 1 = Staff, 2 = Admin
        private int _testUserID = 1; // Adjustable for testing different users
        private List<string> _courses = new List<string>();

        public Stats(int courseID = 0)
        {
            InitializeComponent();

            CmbCourses.SelectedIndexChanged += CmbCourses_SelectedIndexChanged;
            CmbExams.SelectedIndexChanged += CmbExams_SelectedIndexChanged;

            _primaryButtons = new List<Button> { BtnBack, BtnTheme };
            _stdText = new List<Label> { LblTitle };
            _dataGrids = new List<DataGridView> { DgvStats };

            // _userRole = GetUserRole(); // Disabled for manual testing with _userRole

            if (_userRole >= 1)
            {
                LblCourse.Visible = true;
                CmbCourses.Visible = true;
                LblExams.Visible = true;
                CmbExams.Visible = true;
                LoadCourses();
                LoadExams();
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
            if (_userRole >= 1)
            {
                LoadExams();
                DgvStats.DataSource = null;
            }
        }

        private void CmbExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_userRole >= 1 && CmbCourses.SelectedItem != null && CmbExams.SelectedItem != null)
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

        private void LoadCourses()
        {
            try
            {
                CmbCourses.DataSource = null;
                CmbCourses.Items.Clear();

                string query = _userRole == 2
                    ? "SELECT CourseID, CourseName FROM Courses"
                    : _userRole == 1
                        ? "SELECT c.CourseID, c.CourseName FROM Courses c INNER JOIN UserToCourse uc ON c.CourseID = uc.CourseID WHERE uc.UserID = @userID"
                        : null;

                if (query == null)
                {
                    return;
                }

                DataTable dt = new DataTable();

                var connectionHandler = new ConnectionHandler();
                using (var connection = connectionHandler.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (_userRole == 1)
                        {
                            command.Parameters.AddWithValue("@userID", _testUserID);
                        }
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                CmbCourses.DataSource = dt;
                CmbCourses.DisplayMember = "CourseName";
                CmbCourses.ValueMember = "CourseID";
                CmbCourses.SelectedIndex = -1;
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
                    CmbExams.DataSource = null;
                    return;
                }
                int selectedCourseID = Convert.ToInt32(drv["CourseID"]);
                if (CmbCourses.SelectedIndex == -1)
                {
                    return;
                }
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
                            command.Parameters.AddWithValue("@userID", _testUserID);
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
