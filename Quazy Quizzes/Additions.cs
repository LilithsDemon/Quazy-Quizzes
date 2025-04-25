using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conn;
using MySqlConnector;
using QQColourScheme;
using QQStoredProcedures;
using UserData;


namespace Quazy_Quizzes
{
    public partial class Additions : Form
    {

        int courseID = 1;
        int userRole = 1; // 0 = student, 1 = lecturer, 2 = admin
        private List<Button> _primaryButtons = new List<Button>();
        private List<Button> _emergencyButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();
        private List<DataGridView> _dataGrids = new List<DataGridView>();
        private List<Control> _adminElements = new List<Control>();
        public Additions()
        {
            InitializeComponent();
            // Grouping UI elements into categories
            _stdText = new List<Label> { HeaderLbl, StudentLbl, LecturerLbl };
            _primaryButtons = new List<Button> { AddStudentBtn, AddLecturerBtn, ChangeThemeBtn };
            _emergencyButtons = new List<Button> { BackBtn };
            _dataGrids = new List<DataGridView> { UsersInCourse };
            _adminElements = new List<Control> { LecturerComboBox, AddLecturerBtn, LecturerLbl };
            
            LoadPotentialLecturers();
            LoadPotentialStudents(courseID);
            PopulateEnrolledUsersGrid(courseID);
            LoadElementsForRole();


        }
        private void LoadElementsForRole()
        {
            // Hide or show elements based on user role
            if (userRole == 1) // Student
            {
                foreach (Control control in _adminElements)
                {
                    control.Visible = false;
                }
            }
            else if (userRole == 2) // Lecturer
            {
                foreach (Control control in _adminElements)
                {
                    control.Visible = true;
                }
            }
        }
        //toggle between light and dark mode
        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);
            colourScheme.SetColourSchemeHeader(HeaderLbl);
            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemeEmergencyButtons(_emergencyButtons);
            colourScheme.SetColourSchemePrimaryText(_stdText);
        }

        private void Additions_Load(object sender, EventArgs e)
        {
            PopulateEnrolledUsersGrid(courseID);
            LoadPotentialStudents(courseID);
            LecturerComboBox.Visible = false;
            AddLecturerBtn.Visible = false;
            if (userRole == 2)
            {
                // Hide the lecturer controls if the user is a student
                LecturerComboBox.Visible = true;
                AddLecturerBtn.Visible = true;
                LoadPotentialLecturers();
            }


        }
        private void PopulateEnrolledUsersGrid(int courseID)
        {
            try
            {
                //Get data from database
                DataTable enrolledUsers = GetEnrolledUsers(courseID);

                //Clear the grid
                UsersInCourse.Rows.Clear();
                UsersInCourse.Columns.Clear();
                //Bind to DataGridView
                UsersInCourse.DataSource = enrolledUsers;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private DataTable GetEnrolledUsers(int courseID)
        {

            
            DataTable dataTable = new DataTable();
            var handler = new ConnectionHandler();

            string sql = @"
        SELECT 
            u.FirstName, 
            u.LastName 
        FROM Users u
        INNER JOIN UserToCourse uc ON u.UserID = uc.UserID
        WHERE uc.CourseID = @courseID;
    ";

            string[] paramNames = { "@courseID" };
            string[] parameters = { courseID.ToString() };

            using (var reader = handler.ExectuteQuery(sql, paramNames, parameters))
            {
                dataTable.Load(reader);
            }

            return dataTable;
        }
        private void LoadPotentialStudents(int courseID)
        {
            try
            {
                DataTable dt = new DataTable();
                var handler = new ConnectionHandler();

                
                string sql = @"
           SELECT
    `Users`.`UserID`,
    `Users`.`UserName`
FROM
    `Users`
WHERE
    `Users`.`Role` = 0 
    AND `Users`.`Active` = 1 
    AND `Users`.`UserID` NOT IN (
        SELECT
            `UserID`
        FROM
            `UserToCourse`
        WHERE
            `CourseID` = @courseID
              )";

                string[] paramNames = { "@courseID" };
                string[] parameters = { courseID.ToString() };

                using (var reader = handler.ExectuteQuery(sql, paramNames, parameters))
                {
                    dt.Load(reader);
                }

                StudentComboBox.DisplayMember = "UserName";
                StudentComboBox.ValueMember = "UserID";
                StudentComboBox.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}");
            }
        }
    
        

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            //insert the student into the database using StudentComboBox.value
            if (StudentComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a user first!");
                return;
            }

            
            int userId = (int)StudentComboBox.SelectedValue;

            try
            {
                bool success = EnrollUserInCourse(userId, courseID);

                if (success)
                {
                    MessageBox.Show("User enrolled successfully!");
                    PopulateEnrolledUsersGrid(courseID); // Refresh grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error enrolling user: {ex.Message}");
            }
        }
        private bool EnrollUserInCourse(int userID, int courseId)
        {
            var handler = new ConnectionHandler();

            string sql = @"
        INSERT INTO UserToCourse (UserID, CourseID)
        VALUES (@userID, @courseID);";

            string[] paramNames = { "@userID", "@courseID" };
            string[] parameters = { userID.ToString(), courseId.ToString() };

            return handler.ExectuteCommand(sql, paramNames, parameters);
        }

        //load the potential lecturers
        private void LoadPotentialLecturers()
        {
            try
            {
                DataTable dt = GetAllLecturers();
                LecturerComboBox.DisplayMember = "UserName";
                LecturerComboBox.ValueMember = "UserID";
                LecturerComboBox.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading lecturers: {ex.Message}");
            }
        }
        private DataTable GetAllLecturers()
        {
            DataTable dataTable = new DataTable();
            var handler = new ConnectionHandler();

            string sql = @"
        SELECT UserID, UserName 
        FROM Users 
        WHERE Role = 1 
          AND Active = 1;";

            using (var reader = handler.ExecuteQueryNoParams(sql))
            {
                dataTable.Load(reader);
            }

            return dataTable;
        }


        private void AddLecturerBtn_Click(object sender, EventArgs e)
        {//insert the lecturer into the database using LecturerComboBox.value
            if (LecturerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a user first!");
                return;
            }
            int userId = (int)LecturerComboBox.SelectedValue;
            try
            {
                bool success = EnrollUserInCourse(userId, courseID);
                if (success)
                {
                    MessageBox.Show("User enrolled successfully!");
                    PopulateEnrolledUsersGrid(courseID); // Refresh grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error enrolling user: {ex.Message}");
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerDashboard lecturerDashboard = new LecturerDashboard();
            lecturerDashboard.Show();
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
}
