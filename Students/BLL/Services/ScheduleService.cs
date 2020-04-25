using AutoMapper;
using DAL.Models;
using DAL.Context;
using BLL.DTO;

namespace BLL.Services
{
    public class ScheduleService
    {
        private readonly StudentsContext _db;
        private readonly IMapper _mapper = Mapper.Instance;

        //public void CreateSchedule(ScheduleDTO scheduleDto)
        //{
        //    using (db = new StudentsDB())
        //    {
        //        var schedule = iMapper.Map<Schedule>(scheduleDto);
        //        schedule.CourseId = scheduleDto.CourseId;
        //        //schedule.Course.Name = scheduleDto.Course.Name;
        //        //schedule.StartDate = scheduleDto.StartDate;
        //        db.Schedules.Add(schedule);
        //        db.SaveChanges();
        //    }
        }
    }
}
