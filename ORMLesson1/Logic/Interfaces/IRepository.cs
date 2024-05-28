using System.Collections.Generic;

using Logic.Domain;

namespace Logic.Interfaces
{
    public interface IRepository<T> where T : Identity
    {
        T FindById(int id);
        List<T> GetAll();
        void Save(T item);
    }
}
