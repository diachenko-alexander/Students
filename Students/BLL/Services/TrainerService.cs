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
    class TrainerService : ITrainerService
    {
        private readonly IUnitOfWork _db;
        private IMapper _autoMapper = Mapper.Instance;

        public TrainerService(IUnitOfWork db)
        {
            _db = db;
        }

        public IEnumerable<TrainerDTO> GetAll()
        {
            return _autoMapper.Map<IEnumerable<TrainerDTO>>(_db.TrainerRepository.GetAll());
        }
        public async Task<IEnumerable<TrainerDTO>> GetAllAsync()
        {
            return _autoMapper.Map<IEnumerable<TrainerDTO>>(await _db.TrainerRepository.GetAllAsync());
        }

        public TrainerDTO Get(int id)
        {
            return _autoMapper.Map<TrainerDTO>(_db.TrainerRepository.Get(id));
        }

        public async Task<TrainerDTO> GetAsync(int id)
        {
            return _autoMapper.Map<TrainerDTO>(await _db.TrainerRepository.GetAsync(id));
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

        public async Task<TrainerDTO> CreateAsync(TrainerDTO entity)
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
            await _db.SaveAsync();
            return entity;
        }

        public TrainerDTO Update(TrainerDTO entity)
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

        public async Task<TrainerDTO> UpdateAsync(TrainerDTO entity)
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
            await _db.SaveAsync();

            return entity;
        }

        public void Delete(int id)
        {
            var trainer = _db.TrainerRepository.Get(id);

            if (trainer == null)
            {
                throw new ArgumentNullException($"No such trainer with Id: {id}");
            }

            _db.TrainerRepository.Delete(id);
            _db.Save();
        }

        public async Task DeleteAsync(int id)
        {
            var trainer = _db.TrainerRepository.Get(id);

            if (trainer == null)
            {
                throw new ArgumentNullException($"No such trainer with Id: {id}");
            }

            _db.TrainerRepository.Delete(id);
            await _db.SaveAsync();
        }
    }
}
