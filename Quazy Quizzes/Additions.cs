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
using QQStoredProcedures;
using UserData;


namespace Quazy_Quizzes
{
    public partial class Additions : Form
    {

        int courseID = 1;
        int userRole = 1; // 0 = student, 1 = lecturer, 2 = admin
        public Additions()
        {
            InitializeComponent();
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
            SELECT u.UserID, u.UserName 
            FROM Users u
            WHERE u.Role = 0 
              AND u.Active = 1
              AND u.UserID NOT IN (
                  SELECT UserID 
                  FROM UserToCourse 
                  WHERE CourseID = @courseID
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
    }
}
