using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;


namespace BLL.Services
{
    class ScheduleService : IService<ScheduleDTO>
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

        public ScheduleDTO Get(int id)
        {
            return _autoMapper.Map<ScheduleDTO>(_db.ScheduleRepository.Get(id));
        }

        public ScheduleDTO Create (ScheduleDTO entity)
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

        public ScheduleDTO Update (ScheduleDTO entity)
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

        public void Delete (int id)
        {
            var schedule = _db.ScheduleRepository.Get(id);

            if (schedule == null)
            {
                throw new ArgumentNullException($"No such schedule with Id: {id}");
            }

            _db.ScheduleRepository.Delete(id);
            _db.Save();
        }
    }
}
