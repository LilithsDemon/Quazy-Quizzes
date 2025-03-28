using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conn;
using QQStoredProcedures;
using QQContactForm;
using QQColourScheme;
using UserData;
using LogIn;
using Status;
using Registration;

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

        public static User _user = new User();

        // Setting up a light theme class to store the data

        public static ColourScheme _lightTheme = new ColourScheme(
            "#FFFFFF", // Background
            "#11B9D1", // Header background
            "#000000", // Header Text
            "#00E5FF", // Secondary background
            "#FFFFFF", // Card background
            "#000000", // Primary text
            "#FFFFFF", // Secondary text
            new ButtonColourScheme("#00B2CC", "#000000", "#00E2DA"), // Primary button
            new ButtonColourScheme("#FF00FF", "#FFFFFF", "#DD00DD"), // Secondary button
            new ButtonColourScheme("#FF0000", "#FFFFFF", "#DD0000") // Emergency button
        );

        public static ColourScheme _darkTheme = new ColourScheme(
            "#1E1E1E", // Background
            "#00B2CC", // Header background
            "#FFFFFF", // Header Text
            "#00E5FF", // Secondary background
            "#121212", // Card background
            "#FFFFFF", // Primary text
            "#000000", // Secondary text
            new ButtonColourScheme("#00B2CC", "#000000", "#00E2DA"), // Primary button
            new ButtonColourScheme("#FF00FF", "#FFFFFF", "#DD00DD"), // Secondary button
            new ButtonColourScheme("#FF0000", "#FFFFFF", "#DD0000") // Emergency button
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

            /* Quick Test of login
            UserLogin userLogin = new UserLogin("Lucy", "password123");
            CodeStatus codeStatus = userLogin.LoginWOSecurity();
            */

            /* Quick Test of registration
            Register register = new Register("registration_test_user", "test", "user", "test_user@email.com", "password123", 0, false, 1, "Hello World!");
            CodeStatus registerStatus = register.RegisterUser();
            Console.WriteLine(registerStatus._statusCode.ToString() + " | " + registerStatus._statusMessage);
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new Stats());
            
        }
    }
}
