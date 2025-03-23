using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Conn;
using Status;

namespace Quazy_Quizzes
{
    public partial class Load : Form
    {
        private int MINIMUM_TIME = 3500;
        private bool _waitedMinimumTime = false;
        private bool _dependanciesChecked = false;

        public Load()
        {
            InitializeComponent();
            this.LoadingBgWorker1.RunWorkerAsync();
            this.LoadingBgWorker2.RunWorkerAsync();
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

        // This is setting up worker 1 with it's arguments
        private void LoadingBgWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            // Start the time-consuming operation.
            e.Result = WaitMinimumtime(bw);

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        // Called when worker 1 has been completed
        private void LoadingBgWorker1_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            _waitedMinimumTime = true;
            Console.WriteLine("Waited");
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
                if (e.Result.ToString() == "True")
                {
                    if(_dependanciesChecked) LoadForm1();
                }
            }
        }

        // This is setting up worker 2 with it's arguments
        private void LoadingBgWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            // Start the time-consuming operation.
            e.Result = CheckDependancies(bw);

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        // Called when worker 2 has been completed
        private void LoadingBgWorker2_RunWorkerCompleted(
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
                _dependanciesChecked = true;
                Console.WriteLine("Dependancies Checked");
                // The operation completed normally.
                if (e.Result.ToString() == "True")
                {
                    if(_waitedMinimumTime) LoadForm1();
                }
                
                if(e.Result.ToString() == "False")
                {
                    LoadErrorForm();
                }
            }
        }

        // Code ran in the background
        private bool WaitMinimumtime(BackgroundWorker BW)
        {
            while (!BW.CancellationPending)
            {
                Thread.Sleep(this.MINIMUM_TIME);
                return true;
            }
            return false;
        }

        private bool CheckDependancies(BackgroundWorker BW)
        {
            while (!BW.CancellationPending)
            {
                if (new ConnectionHandler().CheckConnection()._statusCode != 200) return false;

                // If all dependancies have a value of 200 then everything is correct
                return true;
            }
            return false;
        }
    }
}
