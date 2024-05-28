using System;

using DAL.Repositories;

using Logic.Interfaces;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private Context _context;
        public UnitOfWork(string connectionString)
        {
            _context = new Context(connectionString);
        }

        public UnitOfWork()
        {
        }

        private IEmployeeRepository _employeeRepository;
        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_context);
                return _employeeRepository;
            }


        }
        private CompanyRepository _companyRepository;
        public ICompanyRepository CompanyRepository
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_context);
                return _companyRepository;
            }

        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }

        public void Dispose()
        {
            ((IDisposable)_context).Dispose();
        }
    }
}
