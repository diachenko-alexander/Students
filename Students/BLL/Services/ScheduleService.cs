using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    class ScheduleService : IScheduleService
    {
        private readonly IUnitOfWork _db;
        private IMapper _autoMapper = Mapper.Instance;

        public ScheduleService()
        {
            _db = new UnitOfWork();
        }

        public IEnumerable<ScheduleDTO> GetAll()
        {
            return _autoMapper.Map<IEnumerable<ScheduleDTO>>(_db.ScheduleRepository.GetAll());
        }
        public async Task<IEnumerable<ScheduleDTO>> GetAllAsync()
        {
            return _autoMapper.Map<IEnumerable<ScheduleDTO>>(await _db.ScheduleRepository.GetAllAsync());
        }

        public ScheduleDTO Get(int id)
        {
            return _autoMapper.Map<ScheduleDTO>(_db.ScheduleRepository.Get(id));
        }

        public async Task<ScheduleDTO> GetAsync(int id)
        {
            return _autoMapper.Map<ScheduleDTO>(await _db.ScheduleRepository.GetAsync(id));
        }

        public ScheduleDTO Create(ScheduleDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while creating schedule");
            }

            var schedule = _autoMapper.Map<Schedule>(entity);
            schedule.CourseId = entity.CourseId;
            schedule.TrainerId = entity.TrainerId;
            schedule.StartDate = entity.StartDate;
            schedule.FinishDate = entity.FinishDate;

            _db.ScheduleRepository.Create(schedule);
            _db.Save();
            return entity;
        }

        public async Task<ScheduleDTO> CreateAsync(ScheduleDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while creating schedule");
            }

            var schedule = _autoMapper.Map<Schedule>(entity);
            schedule.CourseId = entity.CourseId;
            schedule.TrainerId = entity.TrainerId;
            schedule.StartDate = entity.StartDate;
            schedule.FinishDate = entity.FinishDate;

            _db.ScheduleRepository.Create(schedule);
            await _db.SaveAsync();
            return entity;
        }

        public ScheduleDTO Update(ScheduleDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while updating schedule");
            }

            var schedule = _db.ScheduleRepository.Get(entity.Id);
            schedule.CourseId = entity.CourseId;
            schedule.TrainerId = entity.TrainerId;
            schedule.StartDate = entity.StartDate;
            schedule.FinishDate = entity.FinishDate;

            _db.ScheduleRepository.Update(schedule);
            _db.Save();
            return entity;
        }

        public async Task<ScheduleDTO> UpdateAsync(ScheduleDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while updating schedule");
            }

            var schedule = _db.ScheduleRepository.Get(entity.Id);
            schedule.CourseId = entity.CourseId;
            schedule.TrainerId = entity.TrainerId;
            schedule.StartDate = entity.StartDate;
            schedule.FinishDate = entity.FinishDate;

            _db.ScheduleRepository.Update(schedule);
            await _db.SaveAsync();
            return entity;
        }

        public void Delete(int id)
        {
            var schedule = _db.ScheduleRepository.Get(id);

            if (schedule == null)
            {
                throw new ArgumentNullException($"No such schedule with Id: {id}");
            }

            _db.ScheduleRepository.Delete(id);
            _db.Save();
        }

        public async Task DeleteAsync(int id)
        {
            var schedule = _db.ScheduleRepository.Get(id);

            if (schedule == null)
            {
                throw new ArgumentNullException($"No such schedule with Id: {id}");
            }

            _db.ScheduleRepository.Delete(id);
            await _db.SaveAsync();
        }
    }
}
