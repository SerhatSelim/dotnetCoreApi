using DataAccessLayer.BaseBehavior;
using DataAccessLayer.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccessLayer.Base
{
    public class BaseEntityRepository<TEntity> : IEntityRepository<TEntity>
         where TEntity : class, new()
    {
        /// <summary>
        /// The context
        /// </summary>
        protected readonly DemoContext Context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEntityRepositoryEFCore{TEntity, TContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BaseEntityRepository(DemoContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public void Add(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);
            this.Context.SaveChanges();
            
        }

        /// <summary>
        /// Adds the range.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void AddRange(IEnumerable<TEntity> entities)
        {
            this.Context.Set<TEntity>().AddRange(entities);
        }

        /// <summary>
        /// Finds the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) => this.Context.Set<TEntity>().Where(predicate);

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public TEntity GetById(int id) => this.Context.Set<TEntity>().Find(id);

 

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Remove(TEntity entity)
        {
            this.Context.Set<TEntity>().Remove(entity);
        }

        /// <summary>
        /// Removes the range.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            this.Context.Set<TEntity>().RemoveRange(entities);
        }

        /// <summary>
        /// Singles the or default.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate) => this.Context.Set<TEntity>().SingleOrDefault(predicate);

   
     }
}

