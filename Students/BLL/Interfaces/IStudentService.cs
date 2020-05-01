using BLL.DTO;

namespace BLL.Interfaces
{
   public interface IStudentService : IService<StudentDTO>, IServiceAsync<StudentDTO>
    {
    }
}
