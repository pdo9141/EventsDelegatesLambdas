using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadsAndDelegates
{
    public partial class UsingAThread : Form
    {
        private int _Max;
        delegate void StartProcessHandler();

        public UsingAThread()
        {
            InitializeComponent();
        }

        [STAThread]
        public static void Main()
        {
            Application.Run(new UsingAThread());
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _Max = 100;
            // Start thread
            var t = new Thread(new ThreadStart(StartProcess));
            t.Start();
        }

        private void StartProcess()
        {
            if (pbStatus.InvokeRequired)
            {
                var sph = new StartProcessHandler(StartProcess);
                this.Invoke(sph);
            }
            else
            { 
                this.Refresh();
                this.pbStatus.Maximum = _Max;
                for (int i = 0; i <= _Max; i++)
                {
                    Thread.Sleep(10);
                    this.lblOutput.Text = i.ToString();
                    this.pbStatus.Value = i;
                }
            }
        }
    }
}
