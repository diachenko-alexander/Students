using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();        
        T Get(int id);        
        T Create(T entity);        
        T Update(T entity);        
        void Delete(int id);
        
    }
}
