﻿using DAL.Context;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly StudentsContext _context;
        private DbSet<TEntity> _entity;

        public GenericRepository(StudentsContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }


        public IEnumerable<TEntity> GetAll()
        {
            return _entity;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

        public TEntity Get(int id)
        {
            return _entity.Find(id);
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _entity.FindAsync(id);
        }

        public TEntity Create(TEntity entity)
        {
            _entity.Add(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            if (entity == null)
            {
                return null;
            }

            _entity.AddOrUpdate(entity);
            return entity;
        }

        public void Delete(int id)
        {
            TEntity entity = _entity.Find(id);
            if (entity != null)
            {
                _entity.Remove(entity);
            }
        }

    }
}
