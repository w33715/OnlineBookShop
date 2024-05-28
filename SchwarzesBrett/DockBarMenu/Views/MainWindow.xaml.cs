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

namespace SchwarzesBrett.Views

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
           Application.Current.Shutdown();  
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           MainWindow mainWindow= new MainWindow();
            mainWindow.WindowState= WindowState.Minimized;
        }

       

        private void btnChef_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            ;
            AnzeigenView anzeigenView = new AnzeigenView();
            anzeigenView.ShowDialog();
        }
    }
}
