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

namespace Quazy_Quizzes
{
    public partial class LecturerDashboard : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Button> _secondaryButtons = new List<Button>();
        private List<Button> _emergencyButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();

        private Control[] _adminsOnly;

        // Used in testing, should be in user class
        int _usersRole = 2;

        bool _userPage = false; // False is student account, True is lecturer account

        public LecturerDashboard()
        {
            InitializeComponent();

            // Components used for setting colour scheme
            this._primaryButtons = new List<Button> { UsersBtn, TestsBtn, NewUserBtn };
            this._secondaryButtons = new List<Button> { StdntActsBtn, LectrActsBtn, EditActBtn, ToggleThemeBtn };
            this._emergencyButtons = new List<Button> { LogOutBtn, DisableActBtn, DeleteActBtn };
            this._stdText = new List<Label> { TitleLbl, UsernameLbl, NameLbl, EmailLbl, LastLoginLbl, SearchLbl };

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

            // Components that should only be visible to admins
            this._adminsOnly = new Control[] { StdntActsBtn, LectrActsBtn};

            // If the user is not an admin then hide the admin only components
            // Role of 0 is ignored as students should not be able to get on to the lecturer dashboard
            if (_usersRole == 1) // If the user is a student
            {
                foreach (Control control in _adminsOnly)
                {
                    control.Visible = false;
                }
            }

            FillUserTable(0); // Should be put into a background worker

            // Ensure the DataGridView allows row selection
            ActGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ActGrid.MultiSelect = false;
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
                string active = (reader[1].ToString() == "true") ? "Active" : "Inactive";
                ActGrid.Rows.Add(reader[0].ToString(), active);
            }

            if (ActGrid.Rows.Count > 0)
            {
                ActGrid.Rows[0].Selected = true;
                LoadUserInfo(ActGrid.Rows[0].Cells["UserName"].Value.ToString());
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
                LoadUserInfo(username);
            }
        }

        // Fill table with Students
        private void StdntActsBtn_Click(object sender, EventArgs e)
        {
            FillUserTable(0);
        }

        // Fill the table with Lecturers
        private void LectrActsBtn_Click(object sender, EventArgs e)
        {
            FillUserTable(1);
        }

        // When the search bar is used it will get the data based on the search
        private void SearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            FillUserTable((_userPage == false) ? 0 : 1, SearchBar.Text);
        }

        // When a row is entered it loads that users data.
        private void ActGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (ActGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ActGrid.SelectedRows[0];
                if (row.Cells["UserName"].Value == null) return;
                string username = row.Cells["UserName"].Value.ToString();
                LoadUserInfo(username);
            }
        }
    }
}
