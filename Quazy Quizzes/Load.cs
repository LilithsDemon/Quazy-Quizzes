using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Conn;
using Status;

namespace Quazy_Quizzes
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }
        
        public void LoadForm1()
        {
            Form1 form1 = new Form1();
            form1.Location = this.Location;
            form1.StartPosition = FormStartPosition.Manual;
            form1.FormClosing += delegate { this.Show(); };
            form1.Show();
            this.Hide();
        }

        public void LoadErrorForm()
        {
            ErrorForm errorForm = new ErrorForm();
            errorForm.Location = this.Location;
            errorForm.StartPosition = FormStartPosition.Manual;
            errorForm.FormClosing += delegate { this.Show(); };
            errorForm.Show();
            this.Hide();
        }

        private void LoadingBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            // Extract the argument.
            int arg = (int)e.Argument;

            // Start the time-consuming operation.
            e.Result = CheckConnection(bw, 0);

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        // Code ran in the background
        private bool CheckConnection(BackgroundWorker BW, int SleepPeriod)
        {
            CodeStatus checkDbConnection = new ConnectionHandler().CheckConnection();
            if (checkDbConnection._statusCode == 200)
            {
                LoadingBar.Value = 100;
                Console.WriteLine("Load form 1");
                LoadForm1();
                return true;
            }
            else
            {
                Console.WriteLine("Error Form");
                LoadErrorForm();
                return false;
            }
        }
    }
}
