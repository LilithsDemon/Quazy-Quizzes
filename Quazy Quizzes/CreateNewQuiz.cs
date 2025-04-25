using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QQColourScheme;
using Conn;
using MySqlConnector;

namespace Quazy_Quizzes
{
    public partial class CreateNewQuiz : Form
    {
        private List<Button> _primaryButtons = new List<Button>();
        private List<Label> _primaryTextLabels = new List<Label>();
        private List<TextBox> _textBoxes = new List<TextBox>();
        private List<ComboBox> _comboBoxes = new List<ComboBox>();


        public CreateNewQuiz()
        {
            InitializeComponent();

            this._primaryButtons = new List<Button>() { CreateQuizBtn };
            this._primaryTextLabels = new List<Label>() { QuizNameLbl, CourseNameLbl };
            this._textBoxes = new List<TextBox>() { QuizNameInput };
            this._comboBoxes = new List<ComboBox>() { CourseNameCB };

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

            FillCourseComboBox();
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemePrimaryButtons(this._primaryButtons);
            colourScheme.SetColourSchemePrimaryText(this._primaryTextLabels);
            colourScheme.SetColourSchemeTextBox(this._textBoxes);
            colourScheme.SetColourSchemeComboBox(this._comboBoxes);
        }

        private void FillCourseComboBox()
        {
            // Fill the course combobox with the courses from the database

            var con = new ConnectionHandler();
            MySqlDataReader reader = null;

            try
            {
                if (Program._user._role == 1)
                {
                    string SQL = "SELECT `Courses`.`CourseName` FROM `Courses` LEFT JOIN `UserToCourse` ON `Courses`.`CourseID` = `UserToCourse`.`CourseID`" +
                                 " WHERE `UserToCourse`.`UserID` = @userID;";
                    string[] paramNames = new string[] { "@userID" };
                    string[] parameters = new string[] { Program._user._userID.ToString()};
                    reader = con.ExectuteQuery(SQL, paramNames, parameters);
                }
                else
                {
                    string SQL = "SELECT `CourseName` FROM `Courses`;";
                    reader = con.ExecuteQueryNoParams(SQL);

                }
                while (reader.Read())
                {
                    CourseNameCB.Items.Add(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses");
            }

            if (CourseNameCB.Items.Count > 0)
            {
                CourseNameCB.SelectedItem = CourseNameCB.Items[0];
            }
        }
            

        private void CreateQuizBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(QuizNameInput.Text) || CourseNameCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (QuizNameInput.Text.Length < 3)
            {
                MessageBox.Show("Quiz name must be at least 3 characters long.");
                return;
            }
            string quizName = QuizNameInput.Text;
            string courseName = CourseNameCB.SelectedItem.ToString();

            string sql = "INSERT INTO `Exams`(`ExamID`, `CourseID`, `ExamName`, `Status`) VALUES (null,(SELECT `CourseID` FROM `Courses` WHERE `CourseName` = @courseName LIMIT 1),@quizName,0);";
            string[] paramNames = new string[] { "@courseName", "@quizName" };
            string[] parameters = new string[] { courseName, quizName };
        }
    }
}
