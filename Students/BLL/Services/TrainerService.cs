using DAL.Models;
using DAL.Context;
using BLL.DTO;

namespace BLL.Services
{
    public class TrainerService : BaseService
    {
        public void CreateTrainer(PeopleDTO trainertDto)
        {
            using (db = new StudentsDB())
            {
                db.Trainers.Add(iMapper.Map<Trainer>(trainertDto));
                db.SaveChanges();
            }
        }
    }
}
