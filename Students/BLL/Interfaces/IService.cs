using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IService<TDto>
    {
        IEnumerable<TDto> GetAll();
        Task <IEnumerable<TDto>> GetAllAsync();
        TDto Get(int id);
        Task<TDto> GetAsync(int id);
        TDto Create(TDto entity);
        Task<TDto> CreateAsync(TDto entity);
        TDto Update(TDto entity);
        Task<TDto> UpdateAsync(TDto entity);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
