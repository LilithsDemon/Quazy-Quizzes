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
        private List<Button> _primaryButtons = new List<Button>();
        private List<Label> _stdText = new List<Label>();
        private List<DataGridView> _dataGrids = new List<DataGridView>();

        public Stats()
        {
            InitializeComponent();

            _primaryButtons = new List<Button> { btnBack, btnToggleTheme };
            _stdText = new List<Label> { lblTitle };
            _dataGrids = new List<DataGridView> { dgvStats };

            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

            LoadStats();
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);
            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);
            colourScheme.SetColourSchemePrimaryText(_stdText);
            colourScheme.SetColourSchemeDataGrid(_dataGrids);
        }

        private void LoadStats()
        {
            try
            {
                var con = new ConnectionHandler();
                string procedureName = "GetUserQuizStats";
                string[] paramNames = { "@userID" };
                string[] parameters = { "5" }; // Placeholder _userID value

                var reader = con.StoredQuery(procedureName, paramNames, parameters);
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvStats.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load stats: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnToggleTheme_Click(object sender, EventArgs e)
        {
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
