using FontAwesome.Sharp;
using GISKommunikation.Views;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GISKommunikation.ViewModels
{
   public class MainViewModel : ViewModelBase
   {
        // Felder
        private ViewModelBase _currentChieldView;
        private string _caption;
        private IconChar _icon;


        public ViewModelBase CurrentChieldView
        {
            get
            {
                return _currentChieldView;
            }
            set
            {
                _currentChieldView = value;
               OnPropertyChanged(nameof(CurrentChieldView));
            }
        } 
        public string Caption
        {
            get 
            {return _caption; }
            set
            { 
                _caption= value; 
                OnPropertyChanged(nameof(Caption));
            }
           
        }
        public IconChar Icon
        {
            get { return _icon; }
            set { _icon= value; OnPropertyChanged(nameof(Icon));}
        }

        // Commands
        public ICommand ShowPersonenViewCommand { get; }
        public ICommand ShowJobsViewCommand { get; }
        public ICommand ShowHauptMenuViewCommand { get; }
        public ICommand ClosePersonViewCommand { get; }
        public ICommand CloseHauptmenuViewCommand { get; }

        public MainViewModel() 
        {
            // Initialize commands
            ShowPersonenViewCommand = new ViewModelCommand(ExecuteShowPersonenViewCommand);
            ShowJobsViewCommand = new ViewModelCommand(ExecuteShowJobsViewCommand);
            ShowHauptMenuViewCommand = new ViewModelCommand(ExecuteShowHauptmenuViewCommand);
            ClosePersonViewCommand = new ViewModelCommand(ExecuteClosePersonViewCommand);
            CloseHauptmenuViewCommand= new ViewModelCommand(ExecuteCloseHauptmenuViewCommand);
            // Defaul view
            // ExecuteShowPersonenViewCommand(null);

        }

        private void ExecuteClosePersonViewCommand(object obj)
        {
            PersonalUserControl personalUserControl = new PersonalUserControl();
            if (personalUserControl!=null)
            {
               personalUserControl.Visibility= Visibility.Collapsed;
            }
        }

        private void ExecuteCloseHauptmenuViewCommand(object obj)
        {
            HauptMenuUserControl hauptMenuUserControl=new HauptMenuUserControl();


          if(hauptMenuUserControl!=null)
            {
                hauptMenuUserControl.Visibility= Visibility.Collapsed;
            }
        }

        private void ExecuteShowHauptmenuViewCommand(object obj)
        {
            
            //MainWindow mainWindown = new MainWindow();
            //mainWindown.btnMenuLeft.Visibility= Visibility.Visible;
            CurrentChieldView = new HauptMenuViewModel();
            HauptMenuUserControl hauptMenuUserControl = new HauptMenuUserControl();
            hauptMenuUserControl.Visibility = Visibility.Visible;


        }

        private void ExecuteShowJobsViewCommand(object obj)
        {
            CurrentChieldView = new JobsViewModel();
            Caption = "Job";
        }

        private void ExecuteShowPersonenViewCommand(object obj)
        {
           
                CurrentChieldView = new PersonenViewModel();
               
          
           
            
            

        }
    }
}
