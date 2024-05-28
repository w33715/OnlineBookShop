using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
namespace Progress
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static BackgroundWorker bw = null;         // Background task handler
        private static string progressHeaderText = "Pending ...";
        private static string progressMessageText = "Starting ...";
        private static int progressPercentage = 0;
        public MainWindow()
        {
            bw = new BackgroundWorker();
            bw.ProgressChanged += new ProgressChangedEventHandler(bwProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwRunWorkerCompleted);
            SetProgressOptions(true, false);
            InitializeComponent();
        }
        public void SetProgressOptions(bool can, bool rpt)
        {
            bw.WorkerSupportsCancellation = can;
            bw.WorkerReportsProgress = rpt;
        }
        public void AddDoWorkHandler(Action<object, DoWorkEventArgs> fn)
        {
            bw.DoWork += new DoWorkEventHandler(fn);
        }
        public void AddProgressChangedHandler(Action<object, ProgressChangedEventArgs> fn)
        {
            bw.ProgressChanged += new ProgressChangedEventHandler(fn);
        }
        public void AddProgressCompletedHandler(Action<object, RunWorkerCompletedEventArgs> fn)
        {
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(fn);
        }
        public void Start()
        {
            bw.RunWorkerAsync();
        }

        public void UpdateProgress(int pct)
        {

            progressPercentage = pct;
            Thread.Sleep(3000);
            bw.ReportProgress(pct);
            Thread.Sleep(30000);
        }
        public void ChangeStatusMessage(string msg)
        {
            progressMessageText = msg;
            bw.ReportProgress(progressPercentage);
        }
        public void ChangeWindowTitle(string ttl)
        {
            progressHeaderText = ttl;
            bw.ReportProgress(progressPercentage);
        }
        private void initBackgroundWorker(object sender, EventArgs e)
        {
            bw.RunWorkerAsync();
        }
        private void bwProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbHeader.Text = progressHeaderText;
            pbMessage.Text = progressMessageText;
            pbStatus.Value = e.ProgressPercentage;
        }
        private void bwRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Start();
        }
    }
}
