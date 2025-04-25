using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conn; // Added for ConnectionHandler
using MySqlConnector; // Added for MySqlDataReader

namespace Quazy_Quizzes
{
    public partial class playQuiz : Form
    {
        private int _examID;
        private List<Question> _questions;
        private int _currentQuestionIndex = 0;

        public playQuiz(int examID)
        {
            InitializeComponent();
            this._examID = examID;

            // Debugging message to confirm ExamID
            MessageBox.Show($"playQuiz initialized with ExamID: {examID}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadQuestions();
            DisplayQuestion();
        }

        private void LoadQuestions()
        {
            _questions = new List<Question>();
            string sql = "SELECT `Question`, `CorrectAnswer`, `WrongAnswer1`, `WrongAnswer2`, `WrongAnswer3` FROM `ExamQs` WHERE `ExamID` = @examID";
            string[] paramNames = { "@examID" };
            string[] parameters = { _examID.ToString() };

            try
            {
                MySqlDataReader reader = new ConnectionHandler().ExectuteQuery(sql, paramNames, parameters);
                while (reader.Read())
                {
                    _questions.Add(new Question
                    {
                        Text = reader["Question"].ToString(),
                        Answers = new List<string>
                        {
                            reader["CorrectAnswer"].ToString(),
                            reader["WrongAnswer1"].ToString(),
                            reader["WrongAnswer2"].ToString(),
                            reader["WrongAnswer3"].ToString()
                        },
                        CorrectAnswer = reader["CorrectAnswer"].ToString()
                    });
                }
                reader.Close();

                // Debugging message to confirm questions loaded
                MessageBox.Show($"Loaded {_questions.Count} questions for ExamID: {_examID}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _questions = _questions.OrderBy(q => Guid.NewGuid()).ToList(); // Randomize questions
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading questions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayQuestion()
        {
            if (_currentQuestionIndex >= _questions.Count)
            {
                MessageBox.Show("Quiz completed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            var question = _questions[_currentQuestionIndex];
            QuestionLabel.Text = question.Text;

            var randomizedAnswers = question.Answers.OrderBy(a => Guid.NewGuid()).ToList(); // Randomize answers
            Answer1Radio.Text = randomizedAnswers[0];
            Answer2Radio.Text = randomizedAnswers[1];
            Answer3Radio.Text = randomizedAnswers[2];
            Answer4Radio.Text = randomizedAnswers[3];
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var selectedAnswer = new[] { Answer1Radio, Answer2Radio, Answer3Radio, Answer4Radio }
                .FirstOrDefault(r => r.Checked)?.Text;

            if (selectedAnswer == null)
            {
                MessageBox.Show("Please select an answer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var correctAnswer = _questions[_currentQuestionIndex].CorrectAnswer;
            if (selectedAnswer == correctAnswer)
            {
                MessageBox.Show("Correct!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Wrong! The correct answer was: {correctAnswer}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _currentQuestionIndex++;
            DisplayQuestion();
        }

        private class Question
        {
            public string Text { get; set; }
            public List<string> Answers { get; set; }
            public string CorrectAnswer { get; set; }
        }
    }
}
