using Microsoft.EntityFrameworkCore;
using NinoSolutionsWPF.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinoSolutionsWPF.Data
{
   public class NiniSolutionsDB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=IGOR-LAPTOP; Initial Catalog=GIS2000; Trusted_Connection=True");
        }

        public DbSet <Persons> Persons { get; set; }   

    }
}
