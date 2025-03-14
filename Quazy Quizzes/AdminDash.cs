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
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
                     

        }

        private void AdminDash_Load(object sender, EventArgs e)
        {

        }

        private void cboboxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboboxSelect.SelectedIndex == 0)
            {
                //Teacher profiles
                cboboxOptions.Items.Add("Test Teacher");
            }
            else if (cboboxSelect.SelectedIndex == 1)
            {
                //Courses
                cboboxOptions.Items.Add("Test course");
            }
            else if (cboboxSelect.SelectedIndex == 2)
            {
                //student profile
                cboboxOptions.Items.Add("Test Student");
            }
            
        }
    }
}
