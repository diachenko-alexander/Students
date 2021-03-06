﻿using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    class CourseService : ICourseService
    {
        private readonly IUnitOfWork _db;
        private IMapper _autoMapper = Mapper.Instance;

        public CourseService(IUnitOfWork db)
        {
            _db = db;
        }

        public IEnumerable<CourseDTO> GetAll()
        {
            return _autoMapper.Map<IEnumerable<CourseDTO>>(_db.CourseRepository.GetAll());
        }

        public async Task<IEnumerable<CourseDTO>> GetAllAsync()
        {
            return _autoMapper.Map<IEnumerable<CourseDTO>>(await _db.CourseRepository.GetAllAsync());
        }

        public CourseDTO Get(int id)
        {
            return _autoMapper.Map<CourseDTO>(_db.CourseRepository.Get(id));
        }
        public async Task<CourseDTO> GetAsync(int id)
        {
            return _autoMapper.Map<CourseDTO>(await _db.CourseRepository.GetAsync(id));
        }

        public CourseDTO Create(CourseDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while creating course");
            }

            var course = _autoMapper.Map<Course>(entity);
            course.Name = entity.Name;
            course.Hours = entity.Hours;

            _db.CourseRepository.Create(course);
            _db.Save();

            return entity;
        }

        public async Task<CourseDTO> CreateAsync(CourseDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while creating course");
            }

            var course = _autoMapper.Map<Course>(entity);
            course.Name = entity.Name;
            course.Hours = entity.Hours;

            _db.CourseRepository.Create(course);
            await _db.SaveAsync();

            return entity;
        }

        public CourseDTO Update(CourseDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while updating course");
            }

            var course = _db.CourseRepository.Get(entity.Id);
            course.Name = entity.Name;
            course.Hours = entity.Hours;

            _db.CourseRepository.Update(course);
            _db.Save();

            return entity;
        }

        public async Task<CourseDTO> UpdateAsync(CourseDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while updating course");
            }

            var course = _db.CourseRepository.Get(entity.Id);
            course.Name = entity.Name;
            course.Hours = entity.Hours;

            _db.CourseRepository.Update(course);
            await _db.SaveAsync();

            return entity;
        }

        public void Delete(int id)
        {
            var course = _db.CourseRepository.Get(id);

            if (course == null)
            {
                throw new ArgumentNullException($"No such course with Id: {id}");
            }

            _db.CourseRepository.Delete(id);
            _db.Save();
        }

        public async Task DeleteAsync(int id)
        {
            var course = _db.CourseRepository.Get(id);

            if (course == null)
            {
                throw new ArgumentNullException($"No such course with Id: {id}");
            }

            _db.CourseRepository.Delete(id);
            await _db.SaveAsync();
        }

    }


}
