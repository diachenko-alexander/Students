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
    class AuditoryService : IService<AuditoryDTO>
    {
        private readonly IUnitOfWork _db;
        private IMapper _autoMapper = Mapper.Instance;

        public AuditoryService()
        {
            _db = new UnitOfWork();
        }

        public IEnumerable<AuditoryDTO> GetAll()
        {
            return _autoMapper.Map<IEnumerable<AuditoryDTO>>(_db.AuditoryRepository.GetAll());
        }

        public async Task<IEnumerable<AuditoryDTO>> GetAllAsync()
        {
            return _autoMapper.Map<IEnumerable<AuditoryDTO>>(await _db.AuditoryRepository.GetAllAsync());
        }

        public AuditoryDTO Get(int id)
        {
            return _autoMapper.Map<AuditoryDTO>(_db.AuditoryRepository.Get(id));
        }

        public async Task<AuditoryDTO> GetAsync(int id)
        {
            return _autoMapper.Map<AuditoryDTO>(await _db.AuditoryRepository.GetAsync(id));
        }

        public AuditoryDTO Create(AuditoryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while creating auditory");
            }

            var auditory = _autoMapper.Map<Auditory>(entity);
            auditory.Number = entity.Number;
            auditory.Seats = entity.Seats;

            _db.AuditoryRepository.Create(auditory);
            _db.Save();
            return entity;
        }

        public async Task<AuditoryDTO> CreateAsync(AuditoryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while creating auditory");
            }

            var auditory = _autoMapper.Map<Auditory>(entity);
            auditory.Number = entity.Number;
            auditory.Seats = entity.Seats;

            _db.AuditoryRepository.Create(auditory);
            await _db.SaveAsync();
            return entity;
        }

        public AuditoryDTO Update (AuditoryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while updating auditory");
            }

            var auditory = _db.AuditoryRepository.Get(entity.Id);
            auditory.Number = entity.Number;
            auditory.Seats = entity.Seats;

            _db.AuditoryRepository.Update(auditory);
            _db.Save();

            return entity;
        }

        public async Task<AuditoryDTO> UpdateAsync(AuditoryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Null argument while updating auditory");
            }

            var auditory = _db.AuditoryRepository.Get(entity.Id);
            auditory.Number = entity.Number;
            auditory.Seats = entity.Seats;

            _db.AuditoryRepository.Update(auditory);
            await _db.SaveAsync();

            return entity;
        }

        public void Delete(int id)
        {
            var auditory = _db.AuditoryRepository.Get(id);

            if (auditory == null)
            {
                throw new ArgumentNullException($"No such auditory with Id: {id}");
            }

            _db.AuditoryRepository.Delete(id);
            _db.Save();
        }

        public async Task DeleteAsync(int id)
        {
            var auditory = _db.AuditoryRepository.Get(id);

            if (auditory == null)
            {
                throw new ArgumentNullException($"No such auditory with Id: {id}");
            }

            _db.AuditoryRepository.Delete(id);
            await _db.SaveAsync();
        }
    }
}
