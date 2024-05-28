using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace GISKommunikation.Models
{
    public class PersonalModel
    {
        public string? Name { get; set; }
        public string? Vorname { get; set; }
        public string? Plz { get; set; }
        public string? Ort { get; set; }
        public string Strasse { get; set; }
        public string? Telefon { get; set; }
        public string? Handy { get; set; }
        public string? Email { get; set; }
        public string? Education { get; set; }
        public string? Kdnr { get; set; }
        public int Age { get; set; }
        public string? Elab { get; set;}
       
    }
}
