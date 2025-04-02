using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QQStoredProcedures;

namespace Quazy_Quizzes
{




    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void QuizSelectorbtn_Click(object sender, EventArgs e)
        {
            //when this is used open the selected quiz from the combobox
            int examID = (int)ComboBoxExams.SelectedValue;
            //however because exams aren't implemented yet, this will just show a message box
            MessageBox.Show("This will open the quiz with ID: " + examID);
        }
        private void ViewAvailableCoursesbtn_Click(object sender, EventArgs e)
        {
            //when this is used open the available courses
            //however because courses aren't implemented yet, this will just show a message box
            MessageBox.Show("This will open the available courses");
        }
        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            int userID = 2; // to be used during testing
            PopulateExamData(userID);
        }

        // Populate exam data
        private void PopulateExamData(int userID)
        {

            using (MySqlDataReader reader = StoredProcedures.GetUsersExamsWithScores(userID))
            {
                DataTable dt = new DataTable();
                dt.Load(reader);

                //logic to split exams with scores and exams without scores
                DataView dvNoScores = new DataView(dt);
                dvNoScores.RowFilter = "Score = ''";

                DataView dvWithScores = new DataView(dt);
                dvWithScores.RowFilter = "Score <> = ''";

                // Bind to controls
                ComboBoxExams.DataSource = dvNoScores.ToTable();
                ComboBoxExams.DisplayMember = "ExamName";
                ComboBoxExams.ValueMember = "ExamID";

                CompletedExams.DataSource = dvWithScores.ToTable();
            }
        }
    }
}