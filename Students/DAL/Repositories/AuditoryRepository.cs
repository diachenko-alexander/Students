using DAL.Context;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class AuditoryRepository : GenericRepository<Auditory>, IAuditoryRepository
    {
        public AuditoryRepository(StudentsContext context) : base(context)
        {

        }
    }
}
