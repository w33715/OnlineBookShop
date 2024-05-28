using FontAwesome.Sharp;
using GISKommunikation.Models;
using GISKommunikation.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GISKommunikation.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Windows.Controls;

namespace GISKommunikation.ViewModels
{
   public class MainViewModel : ViewModelBase
   {
        // Felder
        private ViewModelBase _currentChieldView;
        private PersonalModel _currentList;
        private string _caption;
        private IconChar _icon;
      private IList<PersonalModel> _personalList;
        public IList<PersonalModel> PersonalList
        {
            get { return _personalList; }
            set { _personalList = value;
                OnPropertyChanged(nameof(PersonalList));
            }
        }
     
    

    public PersonalModel CurrentList
        { 
            get
            { return _currentList; }
            set 
            {
                _currentList = value;
                OnPropertyChanged(nameof(CurrentList));

            
            }
        }


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
        //public ICommand GetByAllViewCommand { get; }
       
        
       

        public MainViewModel() 
        {
           
            // Initialize commands
            ShowPersonenViewCommand = new ViewModelCommand(ExecuteShowPersonenViewCommand);
            ShowJobsViewCommand = new ViewModelCommand(ExecuteShowJobsViewCommand);
            ShowHauptMenuViewCommand = new ViewModelCommand(ExecuteShowHauptmenuViewCommand);
            ClosePersonViewCommand = new ViewModelCommand(ExecuteClosePersonViewCommand);
            CloseHauptmenuViewCommand= new ViewModelCommand(ExecuteCloseHauptmenuViewCommand);
            //GetByAllViewCommand=new ViewModelCommand(ExecuteGetByAllViewCommand);
            // Defaul view
          // ExecuteShowPersonenViewCommand(null);
          
            //LoadAllData();
        }

       
        private void ExecuteClosePersonViewCommand(object obj)
        {
           
        }

        private void ExecuteCloseHauptmenuViewCommand(object obj)
        {
           
        }

        private void ExecuteShowHauptmenuViewCommand(object obj)
        {
            
          

        }

        private void ExecuteShowJobsViewCommand(object obj)
        {
            CurrentChieldView = new JobsViewModel();
            Caption = "Job";
        }

        public void ExecuteShowPersonenViewCommand(object obj)
        {

            CurrentChieldView = new PersonenViewModel();
            //LoadAllData();
        }
    }
}
