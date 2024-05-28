using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GISKommunikation.Models
{
    public interface IPersonalRepository
    {
      //  void CreateData(PersonalModel personalModel);
        IEnumerable<PersonalModel> GetByAll();
        

    }
}
