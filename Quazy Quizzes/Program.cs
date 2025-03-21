using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conn;
using QQStoredProcedures;
using QQContactForm;
using QQColourScheme;

namespace Quazy_Quizzes
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        // Boolean to store what theme we are using
        public static bool _isDarkMode = false;

        // Setting up a light theme class to store the data
        public static ColourScheme _lightTheme = new ColourScheme(
        "#FFFFFF", // Background
        "#00E5FF", // Secondary background
        "#1E1E1E", // Primary text
        "#FFFFFF", // Secondary text
        "#FFFFFF", // Input background
        "#1E1E1E", // Input text
        "#00B2CC",  // Primary Button background
        "#FF00FF", //Secondary Button Background
        "#FF0000", // Energency Button Background
        "#FFFFFF",  // Button text
        "#00A2BB",  // Button hover
        "#11B9D1"   // Header background
        );

        // Setting up a dark theme class to store the data
        public static ColourScheme _darkTheme = new ColourScheme(
       "#1E1E1E", // Background
       "#00E5FF", // Secondary background
       "#FFFFFF", // Primary text
       "#121212", // Secondary text
       "#121212", // Input background
       "#FFFFFF", // Input text
       "#00B2CC",  // Primary Button background
       "#FF00FF", // Secondary Button Background
       "#FF0000", // Emergency Button Background
       "#FFFFFF",  // Button text
       "#00A2BB",  // Button hover
       "#00B2CC"   // Header background
       );

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
            //Application.Run(new Form1());
            Application.Run(new Load());
        }
    }
}
