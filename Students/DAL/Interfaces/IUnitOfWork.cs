using DAL.Models;
using System;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Student> StudentRepository { get; }
        IRepository<Trainer> TrainerRepository { get; }
        IRepository<Course> CourseRepository { get; }
        IRepository<Auditory> AuditoryRepository { get; }
        IRepository<Schedule> ScheduleRepository { get; }

        void Save();
    }
}
