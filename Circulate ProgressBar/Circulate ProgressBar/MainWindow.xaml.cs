using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Circulate_ProgressBar
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
        // Start/ Stop Timer
        DispatcherTimer _timer = new DispatcherTimer();
        int counter = 0;
        private void timer_Clock(object sender, EventArgs e)
        {
            counter++;
            txbTimerLabel.Text=counter.ToString();
            if(counter == 100 )
            {
                _timer.Stop();
                txbTimerLabel.Text= "0".ToString();
            }
        }
        private void StartTimer()
        {
            cpBar_uc.Visibility= Visibility.Visible;
            if(counter> 0) 
            {
                _timer.Tick -= timer_Clock;
                counter= 0;            
            }
            _timer.Interval = TimeSpan.FromMilliseconds(188);
                _timer.Tick += timer_Clock;
            _timer.Start();
        }
        private void StopTimer() 
        {
        if(counter> 0) 
            {
                _timer.Tick-= timer_Clock;
                counter= 0;
            }
        _timer.Stop();
            cpBar_uc.Visibility= Visibility.Collapsed;
            txbTimerLabel.Text= "0".ToString();    
        }
        private void StartAnimation() 
        {
            ((Storyboard)cpBar_uc.Resources["ProgressBarAnimation"]).Begin();
        
        }
        private void StopAnimation()
        {
            ((Storyboard)cpBar_uc.Resources["ProgressBarAnimation"]).Stop();
        }

        private void btnStart_Checked(object sender, RoutedEventArgs e)
        {
            StartTimer();
            StartAnimation();
        }

        private void btnStart_Unchecked(object sender, RoutedEventArgs e)
        {
            StopTimer();
            StopAnimation();
        }
        private void Uncheck_Stop(object sender, RoutedEventArgs e)
        {
            btnStart.IsChecked= false;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }
    }
}
