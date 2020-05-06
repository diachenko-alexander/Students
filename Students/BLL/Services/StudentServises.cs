using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentServises : IStudentService
    {
        private readonly IUnitOfWork _db;
        private IMapper _autoMapper = Mapper.Instance;

        public StudentServises(IUnitOfWork db)
        {
            _db = db;
        }

        public IEnumerable<StudentDTO> GetAll()
        {
            return _autoMapper.Map<IEnumerable<StudentDTO>>(_db.StudentRepository.GetAll());
        }

        public async Task<IEnumerable<StudentDTO>> GetAllAsync()
        {
            return _autoMapper.Map<IEnumerable<StudentDTO>>(await _db.StudentRepository.GetAllAsync());
        }

        public StudentDTO Get(int id)
        {
            return _autoMapper.Map<StudentDTO>(_db.StudentRepository.Get(id));
        }

        public async Task<StudentDTO> GetAsync(int id)
        {
            return _autoMapper.Map<StudentDTO>(await _db.StudentRepository.GetAsync(id));
        }

        public StudentDTO Create(StudentDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while creating student");
            }
            var student = _autoMapper.Map<Student>(entity);
            student.FirstName = entity.FirstName;
            student.LastName = entity.LastName;
            student.Birthday = entity.Birthday;
            student.Phone = entity.Phone;
            student.Email = entity.Email;

            _db.StudentRepository.Create(student);
            _db.Save();
            return entity;
        }

        public async Task<StudentDTO> CreateAsync(StudentDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while creating student");
            }
            var student = _autoMapper.Map<Student>(entity);
            student.FirstName = entity.FirstName;
            student.LastName = entity.LastName;
            student.Birthday = entity.Birthday;
            student.Phone = entity.Phone;
            student.Email = entity.Email;

            _db.StudentRepository.Create(student);
            await _db.SaveAsync();
            return entity;
        }

        public StudentDTO Update(StudentDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while updating student");
            }

            var student = _db.StudentRepository.Get(entity.Id);
            student.FirstName = entity.FirstName;
            student.LastName = entity.LastName;
            student.Birthday = entity.Birthday;
            student.Phone = entity.Phone;
            student.Email = entity.Email;

            _db.StudentRepository.Update(student);
            _db.Save();

            return entity;
        }

        public async Task<StudentDTO> UpdateAsync(StudentDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while updating student");
            }

            var student = _db.StudentRepository.Get(entity.Id);
            student.FirstName = entity.FirstName;
            student.LastName = entity.LastName;
            student.Birthday = entity.Birthday;
            student.Phone = entity.Phone;
            student.Email = entity.Email;

            _db.StudentRepository.Update(student);
            await _db.SaveAsync();

            return entity;
        }

        public void Delete(int id)
        {
            var student = _db.StudentRepository.Get(id);

            if (student == null)
            {
                throw new ArgumentNullException($"No such student with Id: {id}");
            }

            _db.StudentRepository.Delete(id);
            _db.Save();
        }

        public async Task DeleteAsync(int id)
        {
            var student = _db.StudentRepository.Get(id);

            if (student == null)
            {
                throw new ArgumentNullException($"No such student with Id: {id}");
            }

            _db.StudentRepository.Delete(id);
            await _db.SaveAsync();
        }
    }
}
