using System.Linq;

using Logic.Domain;
using Logic.Interfaces;

namespace DAL.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {

        public CompanyRepository(Context context) : base(context)
        {
            _dbContext = context;
        }
        public void SaveCompany(Company company)
        {
            _dbContext.Companies.Add(company);
        }
        public Company FindRecentCompany()
        {
            return _dbContext.Companies.FirstOrDefault();

        }
    }
}
