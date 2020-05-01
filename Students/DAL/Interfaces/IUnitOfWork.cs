using DAL.Models;
using System;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository StudentRepository { get; }
        ITrainerRepository TrainerRepository { get; }
        ICourseRepository CourseRepository { get; }
        IAuditoryRepository AuditoryRepository { get; }
        IScheduleRepository ScheduleRepository { get; }

        void Save();
        Task SaveAsync();
    }
}
