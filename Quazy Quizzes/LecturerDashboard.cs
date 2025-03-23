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

            this._primaryButtons = new List<Button> { UsersBtn, TestsBtn, NewUserBtn };
            this._secondaryButtons = new List<Button> { StdntActsBtn, LectrActsBtn, EditActBtn, ToggleThemeBtn };
            this._emergencyButtons = new List<Button> { LogOutBtn, DisableActBtn, DeleteActBtn };
            this._stdText = new List<Label> { TitleLbl, UsernameLbl, NameLbl, EmailLbl, LastLoginLbl, SearchLbl };

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

            this._adminsOnly = new Control[] { StdntActsBtn, LectrActsBtn};

            if (_usersRole == 1) // If the user is a student
            {
                foreach (Control control in _adminsOnly)
                {
                    control.Visible = false;
                }
            }

            FillUserTable(0); // Should be put into a background worker
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

        private void LoadUserInfo(string username)
        {
            var con = new ConnectionHandler();
            var reader = con.ExectuteQuery("SELECT `FirstName`, `LastName`, `Email`, `LastLogIn` FROM `Users` WHERE `UserName` = @username;", new string[] { "@username" }, new string[] { username });
            reader.Read();
            UsernameLbl.Text = username;
            NameLbl.Text = reader[0].ToString() + " " + reader[1].ToString();
            EmailLbl.Text = "Email: " + reader[2].ToString();
            LastLoginLbl.Text = "Last Login: " + reader[3].ToString();
        }

        private void FillUserTable(int role, string search = "")
        {
            ActGrid.Rows.Clear();
            ActGrid.Columns.Clear();
            ActGrid.Columns.Add("UserName", "Username");
            ActGrid.Columns.Add("Status", "Active");

            var con = new ConnectionHandler();
            MySqlDataReader reader = null;
            try
            {
                if (role == 0) reader = StoredProcedures.GetAllStudents(search);
                else reader = StoredProcedures.GetAllLecturers(search);
            }
            catch (Exception ex)
            {

            }

            while (reader.Read())
            {
                string active = (reader[1].ToString() == "true") ? "Active" : "Inactive";
                ActGrid.Rows.Add(reader[0].ToString(), active);
            }
        }

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

        private void StdntActsBtn_Click(object sender, EventArgs e)
        {
            FillUserTable(0);
        }

        private void LectrActsBtn_Click(object sender, EventArgs e)
        {
            FillUserTable(1);
        }

        private void SearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            FillUserTable((_userPage == false) ? 0 : 1, SearchBar.Text);
        }
    }
}
