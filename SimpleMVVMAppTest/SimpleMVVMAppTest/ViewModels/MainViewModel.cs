using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using System.Collections;
using System.Collections.ObjectModel;

namespace SimpleMVVMAppTest.ViewModels
{
    public class MainViewModel:ObservableRecipient
    {
        #region Variablen & Properties
        private Models.SimplePerson person;
        public Models.SimplePerson Person
        { get { return person; }
          set { SetProperty(ref person,value); }
        }
        #endregion
        #region Command's
        public ICommand ClearName { get;}
        public ICommand DeleteChildName { get;}
        public ICommand ResetData { get;}
        #endregion
        #region Konstruktor
        public MainViewModel()  //Konstruktor
        { 
          person= new Models.SimplePerson();
            ClearName = new RelayCommand(ClearNameOfPerson);
            DeleteChildName = new RelayCommand<IList>(DeleteNameOfChildFromList);
            ResetData = new RelayCommand(GenerateSimpleData);
            GenerateSimpleData();
        }
        #endregion
        #region Method's
        private void GenerateSimpleData()
        {
            Person.Surname = "Otto";
            Person.Lastname = "Bismark";
            Person.Childs = new ObservableCollection<string> {
            "Wilhelm", "Marie","Herbert"};
        }    
        
        private void DeleteNameOfChildFromList(IList? obj)
        {
            //ist etwa tricky
            if(obj != null)
            {
                var copyOfSelectedItems=(obj as IList).Cast<object>().ToList();
                foreach (string item in copyOfSelectedItems)
                person.Childs.Remove(item);
            }           
        }

        private void ClearNameOfPerson()
        {
            Person.Lastname = string.Empty;
            Person.Surname = string.Empty;
        }
        #endregion 
    }
}
