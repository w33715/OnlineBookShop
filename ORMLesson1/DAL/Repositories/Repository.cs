using System.Collections.Generic;
using System.Linq;

using Logic.Interfaces;

using Identity = Logic.Domain.Identity;





namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : Identity
    {
        public Context _dbContext;
        public Repository(Context context)
        {
            _dbContext = context;
        }
        public T FindById(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
            //selöect top
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Save(T item)
        {
            _dbContext.Set<T>().Add(item);
        }
    }
}
