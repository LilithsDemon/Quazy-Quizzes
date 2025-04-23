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

namespace Quazy_Quizzes
{
    public partial class CreateNewCourse : Form
    {
        // This is the form that will be used to create a new course
        // It will be used to create a new course and add it to the database

        private List<Button> _primaryButtons = new List<Button>();
        private List<Label> _primaryTextLabels = new List<Label>();
        private List<TextBox> _textBoxes = new List<TextBox>();
        public CreateNewCourse()
        {
            InitializeComponent();
            this._primaryButtons = new List<Button>() { CreateCourseBtn };
            this._primaryTextLabels = new List<Label>() { CourseNameLbl };
            this._textBoxes = new List<TextBox>() { CourseNameInput };

            // Get page to match colour scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            colourScheme.SetColourSchemePrimaryButtons(this._primaryButtons);
            colourScheme.SetColourSchemePrimaryText(this._primaryTextLabels);
            colourScheme.SetColourSchemeTextBox(this._textBoxes);
        }

        private void CreateCourseBtn_Click(object sender, EventArgs e)
        {
            string courseName = CourseNameInput.Text;
            if (string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please enter a course name.");
                return;
            }

            string sql = "INSERT INTO `Courses`(`CourseID`, `CourseName`) VALUES (null, @CourseName)";
            string[] parameters = { "@CourseName" };
            string[] values = { courseName };
            ConnectionHandler con = new ConnectionHandler();
            try
            {
                bool success = con.ExectuteCommand(sql, parameters, values);
                if (!success) MessageBox.Show("An error occurred while creating the course: A course with this name might already exist!");
                else
                {
                    CourseNameInput.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the course: A course with this name might already exist!");
                return;
            }

        }
    }
}
