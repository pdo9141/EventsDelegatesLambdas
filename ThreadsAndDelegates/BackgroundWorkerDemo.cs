﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ThreadsAndDelegates
{
    public partial class BackgroundWorkerDemo : Form
    {
        public BackgroundWorkerDemo()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            Application.Run(new BackgroundWorkerDemo());
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            CancelButton.Enabled = true;
            OutputLabel.Text = "";
            MyBackgroundWorker.RunWorkerAsync();
        }

        private long Calculate(BackgroundWorker instance, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (instance.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                    instance.ReportProgress(i);
                }
            }
            return 0L;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MyBackgroundWorker.CancelAsync();
            CancelButton.Enabled = false;
        }

        private void MyBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Not on a UI thread
            e.Result = Calculate(sender as BackgroundWorker, e);
        }

        private void MyBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbStatus.Value = e.ProgressPercentage;
        }

        private void MyBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StartButton.Enabled = true;
            pbStatus.Value = 0;
            if (!e.Cancelled)
            {
                OutputLabel.Text = "BackgroundWorker Completed!";
            }
            else
            {
                OutputLabel.Text = "Cancelled!";
            }
        }
    }
}
