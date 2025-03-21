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
        public List<string> _teachersList = new List<string>();

        public AdminDash()
        {
            InitializeComponent();

            //Get the teachers' names
            

            ConnectionHandler con = new ConnectionHandler();
            string getTeachersSQL = "SELECT * FROM `Users` WHERE `Role` = 1;";

            var reader = con.ExecuteQueryNoParams(getTeachersSQL);
            while (reader.Read())
            {
                _teachersList.Add(reader["UserName"].ToString());
            }
            
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {
            

        }

        private void cboboxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cboboxSelect.SelectedIndex == 0)
            {
                //Teacher profiles
                //Making it so the combo boxes for revoking the teacher profiles become visible and enabled
                
                cboboxOptions.Items.Add("Test Teacher");
                foreach(string teacher in _teachersList)
                {
                    cboboxOptions.Items.Add(teacher);
                }
                lblRemove.Enabled = true;
                lblRemove.Visible = true;
                cboClasses.Enabled = true;
                cboClasses.Visible = true;
                cboboxSelect.Visible = true;
                cboboxSelect.Enabled = true;
                cboClasses.Items.Add("Test Class");
                //sql to fetch the classes via coursename and find ones associated with the teacher
                string getClassesSQL = "SELECT `Courses`.`CourseName`\r\nFROM `Users` \r\nLEFT JOIN `UserToCourse`\r\nON `Users`.`UserID` = `UserToCourse`.`UserID`\r\nLEFT JOIN `Courses`\r\nON `UserToCourse`.`CourseID` = `Courses`.`CourseID`\r\nWHERE `Users`.`UserName` = " + cboboxOptions.Text + ";";


            }
            else if (cboboxSelect.SelectedIndex == 1)
            {

                //shows courses and allows admins to edit them, remove discontinued ones or anything else that may be required.
                cboboxOptions.Items.Add("Test course");
            }
            else if (cboboxSelect.SelectedIndex == 2)
            {
                //student profile editing options.
                cboboxOptions.Items.Add("Test Student");
            }
            
        }

        private void cboClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
