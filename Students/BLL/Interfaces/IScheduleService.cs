using BLL.DTO;

namespace BLL.Interfaces
{
    public interface IScheduleService : IService<ScheduleDTO>, IServiceAsync<ScheduleDTO>
    {
    }
}
