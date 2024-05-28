using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SimpleMVVMAppTest.Models
{
  public class SimplePerson:ObservableObject
  {
        private string lastname;
        private string surname;
        private ObservableCollection <string> childs;
        public string Lastname
        {
            get { return lastname; }
            set { SetProperty(ref lastname,value); }
        }
        public string Surname
        {
            get { return surname; }
            set { SetProperty(ref surname, value); }
        }
        public ObservableCollection<string> Childs
        { get { return childs; }
            set { SetProperty(ref childs, value);}
        }
        public SimplePerson() 
        { 
            childs= new ObservableCollection<string>();
            lastname= string.Empty;
            surname= string.Empty;        
        }           

  }
}
