using System.Windows;
using WPF_MVVM.Models;
using WPF_MVVM.ViewModels;

namespace WPF_MVVM
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        public App(Hotel hotel)
        {
            _hotel = new Hotel("Sheraton Suites");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
