using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;

namespace FlashscreenTitel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();

        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            if (progressBar.Value == 99)
            {
                Thread.Sleep(900);
                btnClose_Click(sender, e);
            }

        }

        private void btnClose_Click(object sender, ProgressChangedEventArgs e)
        {
            this.Close();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(40);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
