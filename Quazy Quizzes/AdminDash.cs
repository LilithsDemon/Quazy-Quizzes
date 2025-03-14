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
using MySqlConnector;

namespace Quazy_Quizzes
{
    public partial class AdminDash : Form
    {
        public List<string> TeachersList = new List<string>();

        public AdminDash()
        {
            InitializeComponent();

            //Get the teachers names

            ConnectionHandler con = new ConnectionHandler();
            string getTeachersSQL = "SELECT * FROM `Users` WHERE `Role` = 1;";
            
            var conn = con.GetConnection();
            conn.Open();

            var teachers = con.ExecuteQueryNoParams(getTeachersSQL);
            //Assume it has rows
            while(teachers.Read())
            {
                TeachersList.Add(teachers.GetString("Username"));
            }
            conn.Close();
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
                foreach(string teacher in TeachersList)
                {
                    cboboxOptions.Items.Add(teacher);
                }
                lblRemove.Enabled = true;
                lblRemove.Visible = true;
                cboClasses.Enabled = true;
                cboClasses.Visible = true;
                cboClasses.Items.Add("Test Class");
                string getClassesSQL = "SELECT `Courses`.`CourseName`\r\nFROM `Users` \r\nLEFT JOIN `UserToCourse`\r\nON `Users`.`UserID` = `UserToCourse`.`UserID`\r\nLEFT JOIN `Courses`\r\nON `UserToCourse`.`CourseID` = `Courses`.`CourseID`\r\nWHERE `Users`.`UserName` = " + cboboxOptions.Text + ";";


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
