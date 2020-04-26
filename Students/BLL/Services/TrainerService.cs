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
    class TrainerService : IService<TrainerDTO>
    {
        private readonly IUnitOfWork _db;
        private IMapper _autoMapper = Mapper.Instance;

        public TrainerService()
        {
            _db = new UnitOfWork();
        }

        public IEnumerable<TrainerDTO> GetAll()
        {
            return _autoMapper.Map<IEnumerable<TrainerDTO>>(_db.TrainerRepository.GetAll());
        }

        public TrainerDTO Get(int id)
        {
            return _autoMapper.Map<TrainerDTO>(_db.TrainerRepository.Get(id));
        }

        public TrainerDTO Create(TrainerDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while creating trainer");
            }

            var trainer = _autoMapper.Map<Trainer>(entity);
            trainer.FirstName = entity.FirstName;
            trainer.LastName = entity.LastName;
            trainer.Birthday = entity.Birthday;
            trainer.Phone = entity.Phone;
            trainer.Email = entity.Email;

            _db.TrainerRepository.Create(trainer);
            _db.Save();
            return entity;
        }

        public TrainerDTO Update (TrainerDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while updating trainer");
            }

            var trainer = _db.TrainerRepository.Get(entity.Id);

            if (trainer == null)
            {
                throw new ArgumentNullException($"No such trainer with Id: {entity.Id}");
            }

            trainer.FirstName = entity.FirstName;
            trainer.LastName = entity.LastName;
            trainer.Birthday = entity.Birthday;
            trainer.Phone = entity.Phone;
            trainer.Email = entity.Email;

            _db.TrainerRepository.Update(trainer);
            _db.Save();

            return entity;
        }

        public void Delete( int id)
        {
            var trainer = _db.TrainerRepository.Get(id);
            
            if (trainer == null)
            {
                throw new ArgumentNullException($"No such trainer with Id: {id}");
            }

            _db.TrainerRepository.Delete(id);
            _db.Save();
        }
    }
}
