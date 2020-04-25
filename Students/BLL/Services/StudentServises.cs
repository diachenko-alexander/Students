using DAL.Models;
using DAL.Context;
using BLL.DTO;

namespace BLL.Services
{
   public class StudentServises : BaseService
    {        
        public void CreateStudent (PeopleDTO studentDto)
        {            
            using (db = new StudentsContext())
            {
                db.Students.Add(iMapper.Map<Student>(studentDto));
                db.SaveChanges();
            }
        }
    }
}
