using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GISKommunikation.Models;

namespace GISKommunikation.ViewModels
{
    public class PersonenViewModel: ViewModelBase
    {
        private string _name;
        private string _vorname;
        private string _plz;
        private string _ort;
        private string _strasse;
        private string _telefon;
        private string _handy;
        private string _email;
        private string _education;
        private string _kdnr;
        private int _age;
        private string _elab;

        public string Name
        { get
            { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            } 
        }
        public string Vorname 
        { get
            {
                return _vorname;
            }
            set
            {
                _vorname = value;
                OnPropertyChanged(nameof(Vorname));
            }
        }
        public string Plz
        { get
            {
                return _plz;
            }
            set
            {

                _plz = value;
                OnPropertyChanged(nameof(Plz));
            }
        }
        public string Ort 
        { get
            {
                return _ort;
            }
            set
            {
                _ort = value;
                OnPropertyChanged(nameof(Ort));
            }
        }
        public string Strasse 
        { get
            {
                return _strasse;
            }
            set
            {
                _strasse = value;
                OnPropertyChanged(nameof(Strasse));
            }
        }
        public string Telefon 
        { get
            {
                return _telefon;
            }
            set
            {
                _telefon = value;
                OnPropertyChanged(nameof(Telefon));
            }
        }
        public string Handy 
        { get
            {
                return _handy;
            }
            set
            {
                _handy = value;
                OnPropertyChanged(nameof(Handy));
            }
        }
        public string Email
        { get
            {
                return _email;
            }      
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public string Education 
        { get
            {
                return _education;
            }
           set
            {
                _education = value;
                OnPropertyChanged(nameof(_education));
            } 
        }
        public string Kdnr 
        { get
            {
                return _kdnr;
            }
            set
            {
                _kdnr = value;
                OnPropertyChanged(nameof(Kdnr));
            } 
        }
        public int Age 
        { get
            {
                return _age;
            }
           set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        public string Elab 
        {
            get
            {
                return _elab;
            } 
                 set
            {
                _elab = value;
                OnPropertyChanged(nameof(Elab));
            }
        }
       
    }
}
