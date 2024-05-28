namespace Logic.Interfaces
{
    public interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; }
        ICompanyRepository CompanyRepository { get; }

        void Commit();
    }
}
