using mxcd.core.entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.repository
{
    /// <summary>
    /// Repository pattern
    /// </summary>
    public interface IRepository<T> where T:IEntity
    {
        /// <summary>
        /// Get a set os entities
        /// </summary>
        /// <param name="expression">Filter</param>
        /// <returns></returns>
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> expression = null);
        /// <summary>
        /// Insert a entity
        /// </summary>
        /// <param name="obj">entity</param>
        Task<T> Insert(T obj);
        /// <summary>
        /// Update an entity
        /// </summary>
        /// <param name="obj">entity</param>
        /// <returns></returns>
        Task<T> Update(T obj);
        /// <summary>
        /// Remove an entity
        /// </summary>
        /// <returns></returns>
        Task Delete(T obj);
    }
    /// <summary>
    /// Repository pattern
    /// </summary>
    public interface IRepository<T, TKey>: IRepository<T> where T : IEntity<TKey>
    {
        /// <summary>
        /// Get a specific entity
        /// </summary>
        /// <param name="key">Unique key</param>
        /// <returns></returns>
        Task<T> Get(TKey key);
        /// <summary>
        /// Remove an entity
        /// </summary>
        /// <param name="key">Unique key</param>
        /// <returns></returns>
        Task Delete(TKey key);
    }
}
