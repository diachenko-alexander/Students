using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IService<TDto>
    {
        IEnumerable<TDto> GetAll();
        TDto Get(int id);
        TDto Create(TDto entity);
        TDto Update(TDto entity);
        void Delete(int id);
    }
}
