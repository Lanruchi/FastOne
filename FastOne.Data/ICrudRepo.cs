using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FastOne.Data
{
    public interface ICrudRepo<TEntity> where TEntity : class
    {
        //Create
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        //Read
        TEntity Get(long id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        //Delete
        void Remove(TEntity entitiy);
        void RemoveRange(IEnumerable<TEntity> entities);


    }
}
