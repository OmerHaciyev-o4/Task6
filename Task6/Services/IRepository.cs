using System.Collections.Generic;

namespace Task6.Services
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        T Get(int id);
        List<T> GetAll();
    }
}