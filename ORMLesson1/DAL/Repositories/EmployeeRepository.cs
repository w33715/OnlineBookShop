using Logic.Domain;
using Logic.Interfaces;

namespace DAL.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private Context _dbContext;
        public EmployeeRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

    }
}
