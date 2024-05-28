using System.Data.Entity;

using Logic.Domain;

using Company = Logic.Domain.Company;

namespace DAL
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(string ConnectionString) : base(ConnectionString)
        {

        }

        public static object CompanyRepository { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
