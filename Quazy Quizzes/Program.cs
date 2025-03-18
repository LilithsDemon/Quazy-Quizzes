using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conn;
using QQStoredProcedures;

namespace Quazy_Quizzes
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            /* Quick Test of stored procedures
            var reader = StoredProcedures.GetAllCourseExamsWithScores(1, 1);
            while (reader.Read())
            {
                string examName = reader[0].ToString();
                string examScore = (reader[1].ToString() == "") ? "null" : reader[1].ToString();
                Console.WriteLine(examName + " " + examScore);
            }
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
