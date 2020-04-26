using DAL.Context;
using DAL.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

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

        public IQueryable<TEntity> GetAll()
        {
            return _entity;
        }

        public TEntity Get(int id)
        {
            return _entity.Find(id);
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
