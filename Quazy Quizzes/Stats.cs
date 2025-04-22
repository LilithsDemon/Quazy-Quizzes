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
        // Lists to group UI elements for styling
        private List<Button> _primaryButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();
        private List<DataGridView> _dataGrids = new List<DataGridView>();
        private int _userRole;
        private List<string> _courses = new List<string>();

        public Stats()
        {
            InitializeComponent();

            // Initialize UI element groups
            _primaryButtons = new List<Button> { BtnBack, BtnTheme };
            _stdText = new List<Label> { LblTitle };
            _dataGrids = new List<DataGridView> { DgvStats };

            // Determine user role
            _userRole = GetUserRole();

            if (_userRole == 1) // Staff
            {
                LblCourse.Visible = true;
                CmbCourses.Visible = true;
                LoadCourses();
            }
            else // Student
            {
                LblCourse.Visible = false;
                CmbCourses.Visible = false;
            }

            // Apply the appropriate theme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

            // Load stats
            LoadStats();
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
                    command.Parameters.AddWithValue("@userID", 1); // Placeholder userID

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
            string query = "SELECT CourseName FROM Courses";

            var connectionHandler = new Conn.ConnectionHandler();
            using (var connection = connectionHandler.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _courses.Add(reader["CourseName"].ToString());
                        }
                    }
                }
            }

            CmbCourses.DataSource = _courses;
        }

        // Apply the selected colour scheme to the page
        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);
            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemePrimaryText(_stdText);
            colourScheme.SetColourSchemeDataGrid(_dataGrids);
        }

        // Load quiz stats from the database
        private void LoadStats()
        {
            try
            {
                string procedureName = _userRole == 1 ? "GetCourseStats" : "GetUserQuizStats";
                string query = _userRole == 1
                    ? "CALL " + procedureName + "(@courseName)"
                    : "CALL " + procedureName + "(@userID)";

                var connectionHandler = new Conn.ConnectionHandler();
                using (var connection = connectionHandler.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (_userRole == 1)
                        {
                            command.Parameters.AddWithValue("@courseName", CmbCourses.SelectedItem.ToString());
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@userID", 1); // Placeholder userID
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
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load stats: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the Stats form
        }

        private void BtnToggleTheme_Click(object sender, EventArgs e)
        {
            // Toggle between light and dark themes
            Program._isDarkMode = !Program._isDarkMode;

            if (Program._isDarkMode)
            {
                SetColourScheme(Program._darkTheme);
                return;
            }

            SetColourScheme(Program._lightTheme);
        }

        private void CmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_userRole == 1) LoadStats();
        }
    }
}
