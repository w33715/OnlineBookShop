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

namespace GISKommunikation.Views
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
           this.WindowState=WindowState.Minimized;
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void btnMenuClose_Click(object sender, RoutedEventArgs e)
        {
             //MenuBorder.Visibility = Visibility.Collapsed;
        }

        private void btnMenuLeft_Click(object sender, RoutedEventArgs e)
        {

        }

       

        private void PersSuche_Click(object sender, RoutedEventArgs e)
       {
        //    btnMenuLeft.Visibility = Visibility.Visible;
            PersonalUserControl personalUserControl= new PersonalUserControl();
           
        }

        private void btnPersSuche_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tgbtnMenu_Click(object sender, RoutedEventArgs e)
        {
            if(tgbtnMenu.IsChecked== true) 
            {
                DckPanelEmpl.Visibility = Visibility.Visible;
                DckPanelJobs.Visibility= Visibility.Visible;


            }
            else
            {
                DckPanelEmpl.Visibility = Visibility.Collapsed;
                DckPanelJobs.Visibility = Visibility.Collapsed;
                //MenuPanel.Width = 80;
                //FilterBorder.Visibility = Visibility.Collapsed;
            }
        }

        private void tgbtnPers_Click(object sender, RoutedEventArgs e)
        {
            if(tgbtnPers.IsChecked== true) 
            {
                MenuPanel.Width = 350;
                FilterBorder.Visibility = Visibility.Visible;


            }
            else
            {
                MenuPanel.Width = 80;
                FilterBorder.Visibility = Visibility.Collapsed;
            }


        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ChBxAlter_Checked(object sender, RoutedEventArgs e)
        {
            if(ChBxAlter.IsChecked==true)
            {
               PanelSlAlter1.Visibility = Visibility.Visible;
                PanelSlAlter2.Visibility = Visibility.Visible;
                txbSlAlter1.Visibility=Visibility.Visible;
                txbSlAlter2.Visibility=Visibility.Visible;
                SlAlter1.Visibility=Visibility.Visible;
                SlAlter2.Visibility=Visibility.Visible;
            }
            
        }

        private void ChBxAlter_Unchecked(object sender, RoutedEventArgs e)
        {
            if (ChBxAlter.IsChecked == false)
            {
                PanelSlAlter1.Visibility = Visibility.Collapsed;
                PanelSlAlter2.Visibility = Visibility.Collapsed;
                txbSlAlter1.Visibility = Visibility.Collapsed;
                txbSlAlter2.Visibility = Visibility.Collapsed;
                SlAlter1.Visibility = Visibility.Collapsed;
                SlAlter2.Visibility = Visibility.Collapsed;
            }
        }

        private void SlAlter2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
        }

        private void tgbtnJobs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
