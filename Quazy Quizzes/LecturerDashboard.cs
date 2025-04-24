using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;
using QQColourScheme;
using Conn;
using QQStoredProcedures;
using System.Net.Mail;
using System.Security.Principal;
using System.Xml.Serialization;

namespace Quazy_Quizzes
{
    public partial class LecturerDashboard : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Button> _secondaryButtons = new List<Button>();
        private List<Button> _emergencyButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();
        private List<DataGridView> _dataGrids = new List<DataGridView>();
        private List<TextBox> _textBoxes = new List<TextBox>();

        private List<Control> _userPageElements = new List<Control>();
        private List<Control> _testPageElements = new List<Control>();

        private List<Control> _adminsOnly = new List<Control>();

        // Used in testing, should be in user class
        int _usersRole = 2;

        int _usersID = 4; // Used for testing - connected to one existing course

        bool _userPage = true; // true is users page, false is tests pages
        bool _actGridView = false; // False is for students, true is for lecturers

        public LecturerDashboard()
        {
            InitializeComponent();

            if(this._usersRole == 0) // Makes sure student does not load this page
            {
                StudentDashboard studentDashboard = new StudentDashboard();
                studentDashboard.Show();
                this.Hide();
            }

            // Components used for setting colour scheme
            this._primaryButtons = new List<Button> { UsersBtn, TestsBtn, NewUserBtn, NewCourseBtn, NewQuizBtn };
            this._secondaryButtons = new List<Button> { StdntActsBtn, LectrActsBtn, EditActBtn, ToggleThemeBtn, 
                                                        EditQuizBtn, w};
            this._emergencyButtons = new List<Button> { LogOutBtn, DisableActBtn, DeleteActBtn, DeleteQuizBtn, DisableQuizBtn};
            this._stdText = new List<Label> { TitleLbl, UsernameLbl, NameLbl, EmailLbl, LastLoginLbl, ActSearchLbl,
                                               CourseSearchLbl, QuizSearchLbl};
            this._dataGrids = new List<DataGridView> { ActGrid, CourseGrid, QuizGrid };
            this._textBoxes = new List<TextBox> { ActSearchBar, CourseSearchBar, QuizSearchBar };

            this._userPageElements = new List<Control> { StdntActsBtn, LectrActsBtn, ActSearchLbl, ActSearchBar, ActGrid,
                                                         UsernameLbl, NameLbl, EmailLbl, LastLoginLbl, EditActBtn, DisableActBtn,
                                                         DeleteActBtn, NewUserBtn};

            this._testPageElements = new List<Control> { NewCourseBtn, NewQuizBtn, CourseSearchLbl, CourseSearchBar, CourseGrid,
                                                         QuizSearchLbl, QuizSearchBar, QuizGrid,
                                                         w, EditQuizBtn, DeleteQuizBtn, DisableQuizBtn};

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

            // Components that should only be visible to admins
            this._adminsOnly = new List<Control> { StdntActsBtn, LectrActsBtn};

            // Ensure the DataGridView allows row selection
            foreach(DataGridView gridView in  this._dataGrids)
            {
                gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridView.MultiSelect = false;
            }

            LoadPage();
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemeHeader(HeaderBg);
            colourScheme.SetColourSchemeHeader(SidebarBg);

            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemeSecondaryButtons(_secondaryButtons);
            colourScheme.SetColourSchemeEmergencyButtons(_emergencyButtons);
            colourScheme.SetColourSchemePrimaryText(_stdText);
            colourScheme.SetColourSchemeDataGrid(_dataGrids);
            colourScheme.SetColourSchemeTextBox(_textBoxes);
        }

        private void ToggleThemeBtn_Click(object sender, EventArgs e)
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

        private void LoadUserPage()
        {
            foreach (Control control in _testPageElements)
            {
                control.Visible = false;
            }
            foreach (Control control in _userPageElements)
            {
                control.Visible = true;
            }
            HideAdminElements();

            TitleLbl.Text = "User Management";
            ActSearchBar.Text = "";
            FillUserTable((this._actGridView == false) ? 0 : 1);
        }

        private void LoadTestPage()
        {
            foreach (Control control in _userPageElements)
            {
                control.Visible = false;
            }
            foreach (Control control in _testPageElements)
            {
                control.Visible = true;
            }
            HideAdminElements();

            TitleLbl.Text = "Test Management";
            CourseSearchBar.Text = "";
            QuizSearchBar.Text = "";
            FillCoursesTable();
        }

        private void LoadPage()
        {
            if(this._userPage == false) LoadTestPage();
            else LoadUserPage();
        }

        private void HideAdminElements()
        {
            if (_usersRole == 1) // If the user ia not admin
            {
                foreach (Control control in _adminsOnly)
                {
                    control.Visible = false;
                }
            }
        }


        // Get's information about a user's account based on the username given.
        private void LoadUserInfo(string username)
        {
            var con = new ConnectionHandler();
            var reader = con.ExectuteQuery("SELECT `FirstName`, `LastName`, `Email`, `LastLogIn` FROM `Users` WHERE `UserName` = @username;",
                new string[] { "@username" }, new string[] { username });
            reader.Read();
            UsernameLbl.Text = username;
            NameLbl.Text = reader[0].ToString() + " " + reader[1].ToString();
            EmailLbl.Text = "Email: " + reader[2].ToString();
            LastLoginLbl.Text = "Last Login: " + reader[3].ToString();
        }

        private void FillUserTable(int role, string search = "")
        {
            // Clear the grid so only new elements will be put in
            ActGrid.Rows.Clear();
            ActGrid.Columns.Clear();

            //Make 2 columns, one to show the username, the other to show if the account is active or disabled
            ActGrid.Columns.Add("UserName", "Username");
            ActGrid.Columns.Add("Status", "Active");

            var con = new ConnectionHandler();
            MySqlDataReader reader = null;

            // Get all students or lecturers based on the role given
            try
            {
                if (role == 0) reader = StoredProcedures.GetAllStudents(search);
                else reader = StoredProcedures.GetAllLecturers(search);
            }
            catch (Exception ex)
            {
                // If no rows are returned then return
                return;
            }

            // For each user
            while (reader.Read())
            {
                string active = (reader[1].ToString() == "True") ? "Active" : "Inactive";
                ActGrid.Rows.Add(reader[0].ToString(), active);
            }

            if (ActGrid.Rows.Count > 0)
            {
                ActGrid.Rows[0].Selected = true;
                if (ActGrid.Rows[0].Cells["UserName"].Value == null) return;  
                LoadUserInfo(ActGrid.Rows[0].Cells["UserName"].Value.ToString());
            }
        }

        public void FillCoursesTable(string search = "")
        {
            CourseGrid.Rows.Clear();
            CourseGrid.Columns.Clear();

            CourseGrid.Columns.Add("CourseName", "Course Name");

            var con = new ConnectionHandler();
            MySqlDataReader reader = null;

            try
            {
                if(this._usersRole == 1)
                {
                    string SQL = "SELECT `Courses`.`CourseName` FROM `Courses` LEFT JOIN `UserToCourse` ON `Courses`.`CourseID` = `UserToCourse`.`CourseID`" +
                                 " WHERE `UserToCourse`.`UserID` = @userID; AND `Courses`.`CourseName` LIKE CONCAT('%', @search, '%');";
                    string[] paramNames = new string[] { "@userID", "@search" };
                    string[] parameters = new string[] { this._usersID.ToString(), search };
                    reader = con.ExectuteQuery(SQL, paramNames, parameters);
                } 
                else {
                    string SQL = "SELECT `CourseName` FROM `Courses` WHERE `Courses`.`CourseName` LIKE CONCAT('%', @search, '%');";
                    string[] paramNames = new string[] { "@search" };
                    string[] parameters = new string[] { search };
                    reader = con.ExectuteQuery(SQL, paramNames, parameters);
                 
                }
            }
            catch (Exception ex)
            {
                w.Visible = false;
                EditQuizBtn.Visible = false;
                DisableQuizBtn.Visible = false;
                DeleteQuizBtn.Visible = false;
                return;
            }

            while (reader.Read())
            {
                CourseGrid.Rows.Add(reader[0].ToString());
            }

            if (CourseGrid.Rows.Count > 0)
            {
                CourseGrid.Rows[0].Selected = true;
                if (CourseGrid.Rows[0].Cells["CourseName"].Value == null)
                {
                    w.Visible = false;
                    EditQuizBtn.Visible = false;
                    DisableQuizBtn.Visible = false;
                    DeleteQuizBtn.Visible = false;
                    return;
                }
                w.Visible = true;
                EditQuizBtn.Visible = true;
                DisableQuizBtn.Visible = true;
                DeleteQuizBtn.Visible = true;
            }
            FillQuizzesTable();
        }

        public void FillQuizzesTable(string search = "")
        {
            QuizGrid.Rows.Clear();
            QuizGrid.Columns.Clear();

            QuizGrid.Columns.Add("QuizName", "Quiz Name");
            QuizGrid.Columns.Add("QuizStatus", "Status");

            var con = new ConnectionHandler();
            MySqlDataReader reader = null;

            try
            {
                string SQL = "SELECT `Exams`.`ExamName`, `Exams`.`Status` FROM `Exams` LEFT JOIN `Courses` ON `Exams`.`CourseID` = `Courses`.`CourseID`" +
                             " WHERE `Courses`.`CourseName` = @courseName AND `Exams`.`ExamName` LIKE CONCAT('%', @search, '%');";
                string[] paramNames = new string[] { "@courseName", "@search" };
                string[] parameters = new string[] { CourseGrid.SelectedRows[0].Cells["CourseName"].Value.ToString(), search };
                reader = con.ExectuteQuery(SQL, paramNames, parameters);
            }
            catch (Exception ex)
            {
                EditQuizBtn.Visible = false;
                DisableQuizBtn.Visible = false;
                DeleteQuizBtn.Visible = false;
                return;
            }
            while (reader.Read())
            {
                string active = (reader[1].ToString() == "True") ? "Active" : "Inactive";
                QuizGrid.Rows.Add(reader[0].ToString(), active);
            }
            if (QuizGrid.Rows.Count > 0)
            {
                QuizGrid.Rows[0].Selected = true;
                if (QuizGrid.Rows[0].Cells["QuizName"].Value == null)
                {
                    EditQuizBtn.Visible = false;
                    DisableQuizBtn.Visible = false;
                    DeleteQuizBtn.Visible = false;
                    return;
                }
                if (QuizGrid.Rows[0].Cells["QuizStatus"].Value.ToString() == "Active") ChangeQuizStatusBtn(true);
                else ChangeQuizStatusBtn(false);
            }
            EditQuizBtn.Visible = true;
            DisableQuizBtn.Visible = true;
            DeleteQuizBtn.Visible = true;
        }


        // Changes the text of the disable/enable account button based on the current state of the account
        private void ChangeActStatusBtn(bool actState)
        {
            // if param is true then the account is active
            if (actState) {
                DisableActBtn.Text = "Disable Account";
                if (Program._isDarkMode) Program._darkTheme.SetColourSchemeEmergencyButtons(DisableActBtn);
                else if (!Program._isDarkMode) Program._lightTheme.SetColourSchemeEmergencyButtons(DisableActBtn);
                return;
            }
            DisableActBtn.Text = "Enable Account";
            if (Program._isDarkMode) Program._darkTheme.SetColourSchemePrimaryButtons(DisableActBtn);
            else if (!Program._isDarkMode) Program._lightTheme.SetColourSchemePrimaryButtons(DisableActBtn);
        }



        // Fill table with Students
        private void StdntActsBtn_Click(object sender, EventArgs e)
        {
            this._actGridView = false;
            FillUserTable(0);
        }

        // Fill the table with Lecturers
        private void LectrActsBtn_Click(object sender, EventArgs e)
        {
            this._actGridView = true;
            FillUserTable(1);
        }

        // When the search bar is used it will get the data based on the search
        private void ActSearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            FillUserTable((_actGridView == false) ? 0 : 1, ActSearchBar.Text);
        }
        
        // When the search bar is used it will get the data based on the search

        private void CourseSearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            FillCoursesTable(CourseSearchBar.Text);
        }

        // When the search bar is used it will get the data based on the search
        private void QuizSearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            FillQuizzesTable(QuizSearchBar.Text);
        }

        private void CourseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is not on the header row
            {
                DataGridViewRow row = CourseGrid.Rows[e.RowIndex];
                if (row.Cells["CourseName"].Value == null) return;
                string courseName = row.Cells["CourseName"].Value.ToString();
                FillQuizzesTable();
            }
        }

        private void CourseGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is not on the header row
            {
                DataGridViewRow row = CourseGrid.Rows[e.RowIndex];
                if (row.Cells["CourseName"].Value == null) return;
                string courseName = row.Cells["CourseName"].Value.ToString();
                FillQuizzesTable();
            }
        }

        // If a cell is clicked it will load the users data for that user
        private void ActGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is not on the header row
            {
                DataGridViewRow row = ActGrid.Rows[e.RowIndex];
                if (row.Cells["UserName"].Value == null) return;
                string username = row.Cells["UserName"].Value.ToString();
                if (row.Cells["Status"].Value.ToString() == "Active") ChangeActStatusBtn(true);
                else ChangeActStatusBtn(false);
                LoadUserInfo(username);
            }
        }

        // When a row is entered it loads that users data.
        private void ActGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (ActGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ActGrid.SelectedRows[0];
                if (row.Cells["UserName"].Value == null) return;
                string username = row.Cells["UserName"].Value.ToString();
                if (row.Cells["Status"].Value.ToString() == "Active") ChangeActStatusBtn(true);
                else ChangeActStatusBtn(false);
                LoadUserInfo(username);
            }
        }

        private void QuizGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is not on the header row
            {
                DataGridViewRow row = QuizGrid.Rows[e.RowIndex];
                if (row.Cells["QuizName"].Value == null) return;
                if (row.Cells["QuizStatus"].Value.ToString() == "Active") ChangeQuizStatusBtn(true);
                else ChangeQuizStatusBtn(false);
            }
        }

        private void QuizGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (QuizGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = QuizGrid.SelectedRows[0];
                if (row.Cells["QuizName"].Value == null) return;
                if (row.Cells["QuizStatus"].Value.ToString() == "Active") ChangeQuizStatusBtn(true);
                else ChangeQuizStatusBtn(false);
            }
        }

        private void EditActBtn_Click(object sender, EventArgs e)
        {
            // Needs to open an edit account menu
        }

        private void DisableActBtn_Click(object sender, EventArgs e)
        {
            string disableActSQL = "UPDATE `Users` SET `Active`=@status WHERE `Username`=@username";
            string[] paramNames = new string[] { "@status", "@username" };
            string[] parameters = new string[] { (DisableActBtn.Text == "Enable Account") ? "1" : "0", UsernameLbl.Text};

            var runSql = new ConnectionHandler().ExectuteCommand(disableActSQL, paramNames, parameters);
            if(!runSql) MessageBox.Show("Failed to disable/enable account");

            FillUserTable((_actGridView == false) ? 0 : 1, ActSearchBar.Text);
            ChangeActStatusBtn((DisableActBtn.Text == "Enable Account") ? true : false);
        }

        private void DeleteActBtn_Click(object sender, EventArgs e)
        {
            // Make a dialog box to make sure user does want to delete the user
            var confirmDeletion = MessageBox.Show($"Are you sure you want to delete this user : {UsernameLbl.Text}","Delete User",MessageBoxButtons.YesNoCancel);
            if (confirmDeletion != DialogResult.Yes) return;

            // Set up SQL to delete the user selected
            string deleteActSQL = "DELETE FROM `Users` WHERE `UserName`=@username";
            string[] paramNames = new string[] { "@username" };
            string[] parameters = new string[] { UsernameLbl.Text };

            // Run SQL
            var runSQL = new ConnectionHandler().ExectuteCommand(deleteActSQL, paramNames, parameters);
            if (!runSQL) MessageBox.Show("Failed to delete account"); // If SQL failed

            FillUserTable((_actGridView == false) ? 0 : 1, ActSearchBar.Text);
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            CreateNewUser newUser = new CreateNewUser();
            newUser.Show();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            if (this._userPage == true) return;
            this._userPage = true;
            LoadPage();
        }

        private void TestsBtn_Click(object sender, EventArgs e)
        {
            if (this._userPage == false) return;
            this._userPage = false;
            LoadPage();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Program._user.ClearData();
            Form1 logInForm = new Form1();
            logInForm.Show();
            this.Hide();
        }

        private void ViewCourseStatsBtn_Click(object sender, EventArgs e)
        {
            // Load the courses page, this page should be able to edit the name of the course if the person is a lecturer or an admin not made yet
        }

        private void EditQuizBtn_Click(object sender, EventArgs e)
        {
            // Load the edit quiz page does not exist yer
        }

        private void DeleteQuizBtn_Click(object sender, EventArgs e)
        {
            // Make a dialog box to make sure user does want to delete the user
            var confirmDeletion = MessageBox.Show($"Are you sure you want to delete this quiz : {QuizGrid.SelectedCells[0].Value} from the course: {CourseGrid.SelectedCells[0].Value}", "Delete Quiz", MessageBoxButtons.YesNoCancel);
            if (confirmDeletion != DialogResult.Yes) return;

            // Set up SQL to delete the user selected
            string deleteActSQL = "DELETE Exams FROM Exams JOIN Courses ON Exams.`CourseID` = Courses.`CourseID` WHERE Exams.`ExamName` = @examName AND Courses.`CourseName` = @courseName;";
            string[] paramNames = new string[] { "@examName", "@courseName" };
            string[] parameters = new string[] { QuizGrid.SelectedCells[0].Value.ToString(), CourseGrid.SelectedCells[0].Value.ToString() };

            // Run SQL
            var runSQL = new ConnectionHandler().ExectuteCommand(deleteActSQL, paramNames, parameters);
            if (!runSQL) MessageBox.Show("Failed to delete exam"); // If SQL failed

            FillQuizzesTable(QuizSearchBar.Text);
        }

        // Changes the text of the disable/enable account button based on the current state of the account
        private void ChangeQuizStatusBtn(bool quizState)
        {
            // if param is true then the account is active
            if (quizState)
            {
                DisableQuizBtn.Text = "Disable Selected Quiz";
                if (Program._isDarkMode) Program._darkTheme.SetColourSchemeEmergencyButtons(DisableQuizBtn);
                else if (!Program._isDarkMode) Program._lightTheme.SetColourSchemeEmergencyButtons(DisableQuizBtn);
                return;
            }
            DisableQuizBtn.Text = "Enable Selected Quiz";
            if (Program._isDarkMode) Program._darkTheme.SetColourSchemePrimaryButtons(DisableQuizBtn);
            else if (!Program._isDarkMode) Program._lightTheme.SetColourSchemePrimaryButtons(DisableQuizBtn);
        }

        private void NewQuizBtn_Click(object sender, EventArgs e)
        {

        }

        private void NewCourseBtn_Click(object sender, EventArgs e)
        {
            CreateNewCourse newCourseForm = new CreateNewCourse();
            newCourseForm.Show();
        }

        private void DisableQuizBtn_Click(object sender, EventArgs e)
        {
            string disableQuizSQL = "UPDATE `Exams` LEFT JOIN `Courses` ON `Courses`.`CourseID` = `Exams`.`CourseID`" +
                " SET `Status`=@status WHERE `Exams`.`ExamName` = @examName AND `Courses`.`CourseName` =" +
                " @courseName;";
            string[] paramNames = new string[] { "@status", "@examName", "@courseName" };
            string[] parameters = new string[] { (DisableQuizBtn.Text == "Enable Selected Quiz") ? "1" : "0", QuizGrid.SelectedCells[0].Value.ToString(), CourseGrid.SelectedCells[0].Value.ToString() };

            var runSql = new ConnectionHandler().ExectuteCommand(disableQuizSQL, paramNames, parameters);
            if (!runSql) MessageBox.Show("Failed to disable/enable quiz");

            FillQuizzesTable(QuizSearchBar.Text);
        }
    }
}
