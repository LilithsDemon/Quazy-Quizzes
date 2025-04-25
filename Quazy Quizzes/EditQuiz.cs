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
using QQColourScheme;

namespace Quazy_Quizzes
{
    public partial class EditQuiz : Form
    {
        private ConnectionHandler _connectionHandler;
        private int _selectedExamID;
        private int _examID;
        private int _userID;
        private List<Button> _primaryButtons = new List<Button>();
        private List<DataGridView> _dataGrids = new List<DataGridView>();

        public EditQuiz(int examID)
        {
            InitializeComponent();
            _connectionHandler = new ConnectionHandler();
            _examID = examID;

            // Initialize button and DataGridView lists for styling
            _primaryButtons = new List<Button> { buttonAddQuestion, buttonSaveChanges, buttonDeleteQuestion, buttonBack, buttonToggleTheme };
            _dataGrids = new List<DataGridView> { dataGridViewQuestions };

            // Apply the color scheme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);

            LoadExams();
        }

        private void SetColourScheme(ColourScheme colourScheme)
        {
            // Apply the theme to the form background
            this.BackColor = ColorTranslator.FromHtml(colourScheme._background);

            // Apply the theme to primary buttons
            colourScheme.SetColourSchemePrimaryButtons(_primaryButtons);

            // Apply the theme to the DataGridView
            colourScheme.SetColourSchemeDataGrid(_dataGrids);

            // Apply the theme to the title
            labelTitle.ForeColor = ColorTranslator.FromHtml(colourScheme._headerText);
            labelTitle.BackColor = ColorTranslator.FromHtml(colourScheme._primaryButtonColourScheme._buttonBackground);
        }

        private void LoadExams()
        {
            var reader = _connectionHandler.ExecuteQueryNoParams(
                "SELECT e.ExamID, e.ExamName " +
                "FROM Exams e " +
                "JOIN Courses c ON e.CourseID = c.CourseID " +
                "JOIN UserToCourse uc ON c.CourseID = uc.CourseID"
            );

            var exams = new Dictionary<int, string>();
            while (reader.Read())
            {
                int examID = reader.GetInt32("ExamID");
                string examName = reader.GetString("ExamName");

                // Check if the key already exists before adding
                if (!exams.ContainsKey(examID))
                {
                    exams.Add(examID, examName);
                }
            }

            // If provided examID is valid for the user, use it. Otherwise, pick the first available.
            if (exams.ContainsKey(_examID))
            {
                _selectedExamID = _examID;
                labelTitle.Text = exams[_examID]; // Set the title to the quiz name
            }
            else if (exams.Count > 0)
            {
                _selectedExamID = exams.Keys.First();
                labelTitle.Text = exams[_selectedExamID]; // Set the title to the first available quiz name
            }

            LoadQuestions();
        }

        private void LoadQuestions()
        {
            var reader = _connectionHandler.ExectuteQuery(
                "SELECT ExamQID, Question, CorrectAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3 FROM ExamQs WHERE ExamID = @ExamID",
                new[] { "@ExamID" },
                new[] { _selectedExamID.ToString() }
            );

            var dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridViewQuestions.DataSource = dataTable;
            dataGridViewQuestions.Columns["ExamQID"].Visible = false; // Hide the ExamQID column
        }

        private void ButtonAddQuestion_Click(object sender, EventArgs e)
        {
            using (Form addQuestionForm = new Form())
            {
                addQuestionForm.Width = 400;
                addQuestionForm.Height = 300;
                addQuestionForm.Text = "Add New Question";

                Label lblQuestion = new Label() { Left = 20, Top = 20, Text = "Question:" };
                TextBox txtQuestion = new TextBox() { Left = 120, Top = 20, Width = 240 };

                Label lblCorrectAnswer = new Label() { Left = 20, Top = 60, Text = "Correct Answer:" };
                TextBox txtCorrectAnswer = new TextBox() { Left = 120, Top = 60, Width = 240 };

                Label lblWrongAnswer1 = new Label() { Left = 20, Top = 100, Text = "Wrong Answer 1:" };
                TextBox txtWrongAnswer1 = new TextBox() { Left = 120, Top = 100, Width = 240 };

                Label lblWrongAnswer2 = new Label() { Left = 20, Top = 140, Text = "Wrong Answer 2:" };
                TextBox txtWrongAnswer2 = new TextBox() { Left = 120, Top = 140, Width = 240 };

                Label lblWrongAnswer3 = new Label() { Left = 20, Top = 180, Text = "Wrong Answer 3:" };
                TextBox txtWrongAnswer3 = new TextBox() { Left = 120, Top = 180, Width = 240 };

                Button btnSubmit = new Button() { Text = "Submit", Left = 280, Width = 80, Top = 220, DialogResult = DialogResult.OK };
                addQuestionForm.Controls.Add(lblQuestion);
                addQuestionForm.Controls.Add(txtQuestion);
                addQuestionForm.Controls.Add(lblCorrectAnswer);
                addQuestionForm.Controls.Add(txtCorrectAnswer);
                addQuestionForm.Controls.Add(lblWrongAnswer1);
                addQuestionForm.Controls.Add(txtWrongAnswer1);
                addQuestionForm.Controls.Add(lblWrongAnswer2);
                addQuestionForm.Controls.Add(txtWrongAnswer2);
                addQuestionForm.Controls.Add(lblWrongAnswer3);
                addQuestionForm.Controls.Add(txtWrongAnswer3);
                addQuestionForm.Controls.Add(btnSubmit);

                if (addQuestionForm.ShowDialog() == DialogResult.OK)
                {
                    string question = txtQuestion.Text;
                    string correctAnswer = txtCorrectAnswer.Text;
                    string wrongAnswer1 = txtWrongAnswer1.Text;
                    string wrongAnswer2 = txtWrongAnswer2.Text;
                    string wrongAnswer3 = txtWrongAnswer3.Text;

                    if (string.IsNullOrWhiteSpace(question) || string.IsNullOrWhiteSpace(correctAnswer) ||
                        string.IsNullOrWhiteSpace(wrongAnswer1) || string.IsNullOrWhiteSpace(wrongAnswer2) ||
                        string.IsNullOrWhiteSpace(wrongAnswer3))
                    {
                        MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _connectionHandler.ExectuteCommand(
                        "INSERT INTO ExamQs (ExamID, Question, CorrectAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) VALUES (@ExamID, @Question, @CorrectAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)",
                        new[] { "@ExamID", "@Question", "@CorrectAnswer", "@WrongAnswer1", "@WrongAnswer2", "@WrongAnswer3" },
                        new[] { _selectedExamID.ToString(), question, correctAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3 }
                    );

                    LoadQuestions(); // Refresh the questions grid
                }
            }
        }

        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            var dataTable = (DataTable)dataGridViewQuestions.DataSource;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    _connectionHandler.ExectuteCommand(
                        "INSERT INTO ExamQs (ExamID, Question, CorrectAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) VALUES (@ExamID, @Question, @CorrectAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)",
                        new[] { "@ExamID", "@Question", "@CorrectAnswer", "@WrongAnswer1", "@WrongAnswer2", "@WrongAnswer3" },
                        new[] { _selectedExamID.ToString(), row["Question"].ToString(), row["CorrectAnswer"].ToString(), row["WrongAnswer1"].ToString(), row["WrongAnswer2"].ToString(), row["WrongAnswer3"].ToString() }
                    );
                }
                else if (row.RowState == DataRowState.Modified)
                {
                    _connectionHandler.ExectuteCommand(
                        "UPDATE ExamQs SET Question = @Question, CorrectAnswer = @CorrectAnswer, WrongAnswer1 = @WrongAnswer1, WrongAnswer2 = @WrongAnswer2, WrongAnswer3 = @WrongAnswer3 WHERE ExamQID = @ExamQID",
                        new[] { "@Question", "@CorrectAnswer", "@WrongAnswer1", "@WrongAnswer2", "@WrongAnswer3", "@ExamQID" },
                        new[] {
                            row["Question"].ToString(),
                            row["CorrectAnswer"].ToString(),
                            row["WrongAnswer1"].ToString(),
                            row["WrongAnswer2"].ToString(),
                            row["WrongAnswer3"].ToString(),
                            row["ExamQID"].ToString()
                        }
                    );
                }
            }
            LoadQuestions();
        }

        private void ButtonDeleteQuestion_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewQuestions.SelectedRows)
            {
                var examQID = selectedRow.Cells["ExamQID"].Value.ToString();
                _connectionHandler.ExectuteCommand(
                    "DELETE FROM ExamQs WHERE ExamQID = @ExamQID",
                    new[] { "@ExamQID" },
                    new[] { examQID }
                );
                dataGridViewQuestions.Rows.Remove(selectedRow);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the current window
            LecturerDashboard lecturerDashboard = new LecturerDashboard();
            lecturerDashboard.Show(); // Open the lecturer dashboard
        }

        private void ButtonToggleTheme_Click(object sender, EventArgs e)
        {
            Program._isDarkMode = !Program._isDarkMode;

            // Apply the new theme
            if (Program._isDarkMode) SetColourScheme(Program._darkTheme);
            else SetColourScheme(Program._lightTheme);
        }

        private void EditQuiz_Resize(object sender, EventArgs e)
        {
            int padding = 20;

            // Adjust the title label
            labelTitle.Width = this.ClientSize.Width;
            labelTitle.Height = 50;

            // Adjust the DataGridView
            dataGridViewQuestions.Width = this.ClientSize.Width - (2 * padding);
            dataGridViewQuestions.Height = this.ClientSize.Height - labelTitle.Height - 150;
            dataGridViewQuestions.Location = new Point(padding, labelTitle.Bottom + padding);

            // Adjust the buttons
            int buttonWidth = 120;
            int buttonHeight = 30;
            int buttonSpacing = 10;

            buttonAddQuestion.Size = new Size(buttonWidth, buttonHeight);
            buttonSaveChanges.Size = new Size(buttonWidth, buttonHeight);
            buttonDeleteQuestion.Size = new Size(buttonWidth, buttonHeight);
            buttonBack.Size = new Size(buttonWidth, buttonHeight);
            buttonToggleTheme.Size = new Size(buttonWidth, buttonHeight);

            int buttonY = dataGridViewQuestions.Bottom + padding;
            buttonAddQuestion.Location = new Point(padding, buttonY);
            buttonSaveChanges.Location = new Point(buttonAddQuestion.Right + buttonSpacing, buttonY);
            buttonDeleteQuestion.Location = new Point(buttonSaveChanges.Right + buttonSpacing, buttonY);
            buttonBack.Location = new Point(padding, padding);
            buttonToggleTheme.Location = new Point(this.ClientSize.Width - buttonWidth - padding, padding);
        }
    }
}
