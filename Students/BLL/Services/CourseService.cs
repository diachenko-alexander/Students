using DAL.Models;
using DAL.Context;
using BLL.DTO;
using AutoMapper;

namespace BLL.Services
{
    public class CourseService
    {

        private readonly StudentsContext _db;
        private readonly IMapper _mapper = AutoMapper.Mapper.Instance;

        
        public CourseService()
        {
            _db = new StudentsContext();
        }

        public void CreateCourse(CourseDTO courseDto)
        {
            
                _db.Courses.Add(_mapper.Map<Course>(courseDto));
                _db.SaveChanges();                
            
        }

        
    }
}
