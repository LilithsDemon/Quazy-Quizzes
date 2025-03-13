using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quazy_Quizzes
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            int UAL;
            string C1;
            string C2;
            string C3;
            string C4;
            string C5;
            int NoOfCs;
            if (UAL == 1)
            {

                if (NoOfCs == 5)
                {
                    btnCourse1.Text = C1;
                    btnCourse2.Text = C2;
                    btnCourse3.Text = C3;
                    btnCourse4.Text = C4;
                    btnCourse5.Text = C5;
                }
                else if (NoOfCs == 4)
                {

                }
                else if (UAL == 2)
                {
                    lblCourses.Text = "Please select one of your classes";


                }
                else if (UAL == 3)
                {
                    lblCourses.Text = "Welcome Admin, would you like to edit a class, a course or a teacher account";

                }

            }

        private void lblCourses_Click(object sender, EventArgs e)
        {
            
        }
    }
}
