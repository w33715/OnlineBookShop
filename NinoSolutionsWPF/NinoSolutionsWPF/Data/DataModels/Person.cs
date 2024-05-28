using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinoSolutionsWPF.Data.DataModels
{
  public class Persons
    {
    
       // public int FP_FiktPersNr_ID;
        public int FPersNr;
       public string Aufgen_von;
        public DateTime Aufgen_am;
        public string Kdnr;
        public string Name;
        public string Vorname;
        public DateTime Geburtstag;
        public int PersNr;
       public string Infotext;
        public string PersNr_Upd_von;
        public DateTime PersNr_Upd_am;
       public string Mod_von;
       public string Mod_am;
        
    }
}
