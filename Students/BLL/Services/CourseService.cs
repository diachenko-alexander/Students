using DAL.Models;
using DAL.Context;
using BLL.DTO;

namespace BLL.Services
{
    public class CourseService : BaseService
    {
        public void CreateCourse(CourseDTO courseDto)
        {
            using (db = new StudentsDB())
            {
                db.Courses.Add(iMapper.Map<Course>(courseDto));
                db.SaveChanges();                
            }
        }

        
    }
}
