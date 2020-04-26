using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentsContext _context;
        private bool _disposed;

        private GenericRepository<Student> _studentRepository;
        private GenericRepository<Trainer> _trainerRepository;
        private GenericRepository<Course> _courseRepository;
        private GenericRepository<Auditory> _auditoryRepository;
        private GenericRepository<Schedule> _scheduleRepository;

        public UnitOfWork()
        {
            _context = new StudentsContext();
        }

        public IRepository<Student> StudentRepository => _studentRepository
            ?? (_studentRepository = new GenericRepository<Student>(_context));

        public IRepository<Trainer> TrainerRepository => _trainerRepository
           ?? (_trainerRepository = new GenericRepository<Trainer>(_context));

        public IRepository<Course> CourseRepository => _courseRepository
           ?? (_courseRepository = new GenericRepository<Course>(_context));

        public IRepository<Auditory> AuditoryRepository => _auditoryRepository
           ?? (_auditoryRepository = new GenericRepository<Auditory>(_context));

        public IRepository<Schedule> ScheduleRepository => _scheduleRepository
           ?? (_scheduleRepository = new GenericRepository<Schedule>(_context));

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
