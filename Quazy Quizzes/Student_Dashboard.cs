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




    public partial class Student_Dashboard : Form
    {
        public Student_Dashboard()
        {
            InitializeComponent();
        }

        private void QuizSelectorbtn_Click(object sender, EventArgs e)
        {

        }

        private void Student_Dashboard_Load(object sender, EventArgs e)
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
                comboBoxExams.DataSource = dvNoScores.ToTable();
                comboBoxExams.DisplayMember = "ExamName"; 
                comboBoxExams.ValueMember = "ExamID";

                completedExams.DataSource= dvWithScores.ToTable();
            }
        }
    }
}