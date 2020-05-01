using BLL.DTO;

namespace BLL.Interfaces
{
    public interface ICourseService : IService<CourseDTO>, IServiceAsync<CourseDTO>
    {
    }
}
