using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Conn;
using QQColourScheme;

namespace Quazy_Quizzes
{
    public partial class Stats : Form
    {
        // Lists to group UI elements for styling
        private List<Button> _primaryButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();
        private List<DataGridView> _dataGrids = new List<DataGridView>();

        public Stats()
        {
            InitializeComponent();

            // Initialize UI element groups
            _primaryButtons = new List<Button> { BtnBack, BtnTheme };
            _stdText = new List<Label> { LblTitle };
            _dataGrids = new List<DataGridView> { DgvStats };

            // Apply the appropriate theme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

            // Load quiz stats into the DataGridView
            LoadStats();
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
                var con = new ConnectionHandler();
                string procedureName = "GetUserQuizStats";
                string[] paramNames = { "@userID" };
                string[] parameters = { "1" }; // Placeholder _userID value

                // Execute the stored procedure and load data into the DataGridView
                var reader = con.StoredQuery(procedureName, paramNames, parameters);
                DataTable dt = new DataTable();
                dt.Load(reader);
                DgvStats.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Handle errors during data loading
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
    }
}
