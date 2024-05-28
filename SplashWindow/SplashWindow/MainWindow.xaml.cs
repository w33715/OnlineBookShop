using System;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;


namespace SplashWindow
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        private Thickness myThickness;
        int i = 2;
        private void Timer_Tick(object sender, EventArgs e)
        {
            panelIn.Width += 5;
            lblProzent.Content = Math.Round((panelIn.Width / 750) * 100) + " %";

            if (panelIn.Width >= 750)
            {
                timer.Stop();
                Thread.Sleep(50);
                panelOut.Visibility = Visibility.Collapsed;
                lblProzent.Visibility = Visibility.Collapsed;
                PanelWindow.Background = Brushes.Wheat;
                txtLogo.Foreground = Brushes.Red;
                txtStudioName.FontWeight = FontWeights.Bold;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Start();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Tick += Timer_Tick;
        }
    }
}
