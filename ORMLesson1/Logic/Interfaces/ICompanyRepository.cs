using Logic.Domain;

namespace Logic.Interfaces
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Company FindRecentCompany();
        void SaveCompany(Company company);
    }
}
