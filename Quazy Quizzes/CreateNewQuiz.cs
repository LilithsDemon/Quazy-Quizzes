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
            string sql = "SELECT CourseName FROM Courses";
            

        private void CreateQuizBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
