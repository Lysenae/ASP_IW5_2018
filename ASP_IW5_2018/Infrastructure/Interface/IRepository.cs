using System.Collections.Generic;

namespace ASP_IW5_2018.Infrastructure.Interface
{
    public interface IRepository<T>
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T item);
        void Add(IList<T> items);
        void Remove(T item);
        void Remove(IList<T> items);
    }
}
