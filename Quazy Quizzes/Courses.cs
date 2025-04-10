using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserData;

namespace Quazy_Quizzes
{

    public partial class Courses : Form
    {
        public Courses()
        {

            InitializeComponent();

            
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            //determine if the user is a student or lecturer with a switch statement
            switch (Program._user._role)
            {
                case 0:
                    //student
                    //hide the add new quiz button
                    AddNewQuizBtn.Visible = false;
                    //hide the all exam list
                    AllExamLabel.Visible = false;
                    AllExams.Visible = false;
                    //make the exam label visible
                    ExamLabel.Visible = true;
                    StudentExamsList.Visible = true;
                    break;
                case 1:
                    //lecturer
                    //the same above but inverted
                    AddNewQuizBtn.Visible = true;
                    AllExamLabel.Visible = true;
                    AllExams.Visible = true;
                    ExamLabel.Visible = false;
                    StudentExamsList.Visible = false;
                    break;
                default:
                    //error
                    MessageBox.Show("Error: User role not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }


        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Hide();
        }

        private void AddNewQuizBtn_Click(object sender, EventArgs e)
        {
            //take the user to add a new quiz but quizzes aren't implemented yet
            //so just show a message box
            MessageBox.Show("Quizzes are not implemented yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
