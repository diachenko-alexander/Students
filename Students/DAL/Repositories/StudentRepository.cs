using DAL.Context;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(StudentsContext context) : base(context)
        {
        }
    }
}
