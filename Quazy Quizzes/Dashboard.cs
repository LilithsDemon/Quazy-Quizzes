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
            
            
        }

        private void lblCourses_Click(object sender, EventArgs e)
        {
            
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            rctxtLeaderboards.Text = "Leaderboards for " + cboCourse.Text + "\n";
            rctxtLeaderboards.Visible = true;
            rctxtLeaderboards.Enabled = true;

        }
    }
}
