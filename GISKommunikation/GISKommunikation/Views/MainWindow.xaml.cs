using System;
using System.Collections;
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
using GISKommunikation.Models;
using GISKommunikation.ViewModels;

namespace GISKommunikation.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IEnumerable filteredList { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            ShowData( );
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
                //DckPanelEmpl.Visibility = Visibility.Visible;
                //DckPanelJobs.Visibility= Visibility.Visible;
                MenuPanel.Width = 350;
                EmplPanel.Visibility= Visibility.Visible;
                JobsPanel.Visibility= Visibility.Visible;
              //FilterPanel.Visibility = Visibility.Visible;
              CirclePanel.Visibility= Visibility.Visible;
            }
            else
            {
                //DckPanelEmpl.Visibility = Visibility.Collapsed;
                //DckPanelJobs.Visibility = Visibility.Collapsed;
                //MenuPanel.Width = 80;
                //FilterBorder.Visibility = Visibility.Collapsed;
                tgbtnPers.IsChecked = false;
                FilterPanel.Visibility = Visibility.Collapsed;
                MenuPanel.Width = 80;
                EmplPanel.Visibility = Visibility.Collapsed;
                JobsPanel.Visibility = Visibility.Collapsed;
                PersonalUserControl personalUserControl=new PersonalUserControl();
                personalUserControl.Visibility = Visibility.Collapsed;
                CirclePanel.Visibility = Visibility.Collapsed;
                //FilterPanel.Visibility = Visibility.Collapsed;
            }
        }

        private void tgbtnPers_Click(object sender, RoutedEventArgs e)
        {
            if(tgbtnPers.IsChecked== true) 
            {
                //MenuPanel.Width = 350;
                FilterPanel.Visibility = Visibility.Visible;


            }
            else
            {
                //MenuPanel.Width = 80;
                FilterPanel.Visibility = Visibility.Collapsed;
            }


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

       
        private void tgbtnJobs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChBxPlz_Checked(object sender, RoutedEventArgs e)
        {
            if (ChBxPlz.IsChecked == true)
            {
                PanelSlPlz1.Visibility = Visibility.Visible;
                PanelSlPlz2.Visibility = Visibility.Visible;
                txbSlPlz1.Visibility = Visibility.Visible;
                txbSlPlz2.Visibility = Visibility.Visible;
                SlPlz1.Visibility = Visibility.Visible;
                SlPlz2.Visibility = Visibility.Visible;
            }
        }

        private void ChBxPlz_Unchecked(object sender, RoutedEventArgs e)
        {
            if (ChBxAlter.IsChecked == false)
            {
                PanelSlPlz1.Visibility = Visibility.Collapsed;
                PanelSlPlz2.Visibility = Visibility.Collapsed;
                txbSlPlz1.Visibility = Visibility.Collapsed;
                txbSlPlz2.Visibility = Visibility.Collapsed;
                SlPlz1.Visibility = Visibility.Collapsed;
                SlPlz2.Visibility = Visibility.Collapsed;
            }
        }
        public void ShowData()

        {
            //PersonalUserControl personalUserControl = new PersonalUserControl();
            //if (personalUserControl.dataGridPersonal.Items.Count != 0)
            //{
            //    txbTimerLabel.Text = personalUserControl.rowcount.ToString();
            //}
            ////personalUserControl.ShowEmployees();
            //return txbTimerLabel.Text;


            //personalUserControl.CreateData();
            //personalUserControl.dataGridPersonal.ItemsSource = personalUserControl.persons;




        }

        public void chBoxServiceL_Checked(object sender, RoutedEventArgs e)
        {
            chBoxServiceL.IsChecked = true;
            PersonalUserControl personalUserControl = new PersonalUserControl();
            personalUserControl.ShowByServiceL();
        }
        //public void ShowBySL()
        //{
        //    PersonalUserControl personalUserControl = new PersonalUserControl();
        //    personalUserControl.sqlDataString = "SELECT * From vwKommPers WHERE Vorname=" + "'Cerkin'";
        //    personalUserControl.CreateData(personalUserControl.sqlDataString);
        //    personalUserControl.ShowByAll();

        //}

        private void chBoxServiceL_Click(object sender, RoutedEventArgs e)
        {
         if(chBoxServiceL.IsChecked==true)
            {
                PersonalUserControl personalUserControl  = new PersonalUserControl();
                 personalUserControl.ShowByServiceL();

            }
              

          

            
        }

        private void chBoxServiceL_Unchecked(object sender, RoutedEventArgs e)
        {
            chBoxServiceL.IsChecked = false;

            PersonalUserControl personalUserControl = new PersonalUserControl();
            personalUserControl.ShowByServiceL();
        }
    }
}
