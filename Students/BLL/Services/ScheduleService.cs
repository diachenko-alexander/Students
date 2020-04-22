using DAL.Models;
using DAL.Context;
using BLL.DTO;

namespace BLL.Services
{
    public class ScheduleService : BaseService
    {
        public void CreateSchedule(ScheduleDTO scheduleDto)
        {
            using (db = new StudentsDB())
            {
                db.Schedules.Add(iMapper.Map<Schedule>(scheduleDto));
                db.SaveChanges();
            }
        }
    }
}
