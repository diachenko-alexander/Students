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

        public AuditoryDTO Get(int id)
        {
            return _autoMapper.Map<AuditoryDTO>(_db.AuditoryRepository.Get(id));
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
    }
}
