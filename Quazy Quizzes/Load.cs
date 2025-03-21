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
            this.LoadingBgWorker.RunWorkerAsync();
        }
        
        public void LoadForm1()
        {
            Form1 form1 = new Form1();
            form1.Location = this.Location;
            form1.StartPosition = FormStartPosition.Manual;
            form1.Show();
            this.Hide();
        }

        public void LoadErrorForm()
        {
            ErrorForm errorForm = new ErrorForm();
            errorForm.Location = this.Location;
            errorForm.StartPosition = FormStartPosition.Manual;
            errorForm.Show();
            this.Hide();
        }

        private void LoadingBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            // Start the time-consuming operation.
            e.Result = CheckConnection(bw, 0);

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void LoadingBgWorker_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                Console.WriteLine("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                Console.WriteLine(String.Format("An error occurred: {0}", e.Error.Message));
            }
            else
            {
                // The operation completed normally.
                if(e.Result.ToString() == "True")
                {
                    LoadingBar.Value = 100;
                    LoadForm1();
                }
                else
                {
                    LoadErrorForm();
                }
            }
        }

        // Code ran in the background
        private bool CheckConnection(BackgroundWorker BW, int SleepPeriod)
        {
            while (!BW.CancellationPending)
            {
                CodeStatus checkDbConnection = new ConnectionHandler().CheckConnection();
                if (checkDbConnection._statusCode == 200) return true;
                return false;
            }
            return false;
        }
    }
}
