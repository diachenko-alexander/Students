using BLL.DTO;

namespace BLL.Interfaces
{
    public interface ITrainerService : IService<TrainerDTO>, IServiceAsync<TrainerDTO>
    {
    }
}
