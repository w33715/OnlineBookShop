using NinoSolutionsWPF.Data;
using NinoSolutionsWPF.Data.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace NinoSolutionsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Persons> persons= new List<Persons>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnGetEmployees_Click(object sender, RoutedEventArgs e)
        {
            GetEmployees();
        }
        void GetEmployees() 
        { 
            var db= new NiniSolutionsDB();
            persons=db.Persons.ToList();
            dgPersons.ItemsSource = persons;
            lblEmployees.Content = $"Employee(s):{persons.Count}";
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           var row=sender as DataGridRow;
            var emp= row.DataContext as Persons;
            MessageBox.Show($"Diese Person ist {emp.Name}!");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetEmployees();
        }
    }
}
