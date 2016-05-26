using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadsAndDelegates
{
    public partial class AsyncGood : Form
    {
        delegate void StartProcessDelegate(int val);
        delegate void ShowProcessDelegate(int val);

        public AsyncGood()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            Application.Run(new AsyncGood());
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var startProcessDel = new StartProcessDelegate(StartProcess);
            startProcessDel.BeginInvoke(100, null, null);
            MessageBox.Show("Done with operation!");
        }

        // Called Asynchronously
        private void StartProcess(int max)
        {
            ShowProgress(0);
            for (int i = 0; i <= max; i++)
            {
                Thread.Sleep(10);
                ShowProgress(i);
            }
        }

        private void ShowProgress(int i)
        {
            if (lblOutput.InvokeRequired)
            {
                // This is hit if a background thread calls ShowProgress()
                var showProgressDel = new ShowProcessDelegate(ShowProgress);
                this.BeginInvoke(showProgressDel, new object[] { i });
            }
            else
            {
                lblOutput.Text = i.ToString();
                pbStatus.Value = i;
            }
        }
    }
}
