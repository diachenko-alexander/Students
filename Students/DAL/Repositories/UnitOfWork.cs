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

        private IStudentRepository _studentRepository;
        private ITrainerRepository _trainerRepository;
        private ICourseRepository _courseRepository;
        private IAuditoryRepository _auditoryRepository;
        private IScheduleRepository _scheduleRepository;

        public UnitOfWork()
        {
            _context = new StudentsContext();
        }

        public IStudentRepository StudentRepository => _studentRepository
            ?? (_studentRepository = new StudentRepository(_context));

        public ITrainerRepository TrainerRepository => _trainerRepository
           ?? (_trainerRepository = new TrainerRepository(_context));

        public ICourseRepository CourseRepository => _courseRepository
           ?? (_courseRepository = new CourseRepository(_context));

        public IAuditoryRepository AuditoryRepository => _auditoryRepository
           ?? (_auditoryRepository = new AuditoryRepository(_context));

        public IScheduleRepository ScheduleRepository => _scheduleRepository
           ?? (_scheduleRepository = new ScheduleRepository(_context));

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
