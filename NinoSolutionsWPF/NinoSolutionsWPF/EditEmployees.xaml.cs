using NinoSolutionsWPF.Data.DataModels;
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
using System.Windows.Shapes;

namespace NinoSolutionsWPF
{
    /// <summary>
    /// Interaktionslogik für EditEmployees.xaml
    /// </summary>
    public partial class EditEmployees : Window
    {
        public EditEmployees()
        {
            InitializeComponent();
        }

        public Persons Persons { get; set; }
        public void ShowEmployee(Persons emp)
        {
            Persons = emp;
            txtEmployeeNumber.Text = $"{Persons.PersNr}";
            txtFirstName.Text=$"{Persons.Vorname}";
            Show();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
