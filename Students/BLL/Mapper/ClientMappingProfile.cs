using AutoMapper;
using AutoMapper.EquivalencyExpression;
using BLL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    class ClientMappingProfile : Profile
    {
        public ClientMappingProfile()
        {
            CreateMap<Student, PeopleDTO>().ReverseMap();
            CreateMap<Trainer, PeopleDTO>().ReverseMap().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<Course, CourseDTO>().ReverseMap().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id)); ;
            CreateMap<Schedule, ScheduleDTO>().ReverseMap().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id)); ;
        }

            
    }
}
