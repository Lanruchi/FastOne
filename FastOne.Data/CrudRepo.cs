/*
 * STEP 3, STEP Three
 * I created the generic repo that all domain repo will use
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FastOne.Data
{
    public class CrudRepo<TEntity> : ICrudRepo<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        private DbSet<TEntity> _entities;

        public CrudRepo(DbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        //create
        public void Add(TEntity entity)
        {
            // _context.Set<TEntity>().Add(entity);
            _entities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            //_context.Set<TEntity>().AddRange(entities);
            _entities.AddRange(entities);
        }

        //read
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            //return _context.Set<TEntity>().Where(predicate);
            return _entities.Where(predicate);
        }

        public TEntity Get(long id)
        {
            //return _context.Set<TEntity>().Find(id);
            return _entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            //return _context.Set<TEntity>().ToList();
            return _entities.ToList();
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            //return _context.Set<TEntity>().SingleOrDefault(predicate);
            return _entities.SingleOrDefault(predicate);
        }

        public Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            //return _context.Set<TEntity>().SingleOrDefaultAsync(predicate);
            return _entities.SingleOrDefaultAsync(predicate);
        }


        //delete
        public void Remove(TEntity entitiy)
        {
            // _context.Set<TEntity>().Remove(entitiy);
            _entities.Remove(entitiy);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            //_context.Set<TEntity>().RemoveRange(entities);
            _entities.RemoveRange(entities);
        }
    }
}
