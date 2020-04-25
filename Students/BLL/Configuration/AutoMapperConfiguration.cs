using AutoMapper;
using BLL.DTO;
using DAL.Models;

namespace BLL.Configuration
{
    public class AutoMapperConfiguration : Profile
    {

        public AutoMapperConfiguration()
        {
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Trainer, TrainerDTO>().ReverseMap();
            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<Schedule, ScheduleDTO>().ReverseMap();
        }

        public static void Initialize()
        {
            Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperConfiguration>());
        }
       
    }
}
