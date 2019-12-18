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
        /// Get a specific entity
        /// </summary>
        /// <param name="key">Unique key</param>
        /// <returns></returns>
        Task<T> Get<TKey>(TKey key);
        /// <summary>
        /// Insert a entity
        /// </summary>
        Task Insert(T obj);
        /// <summary>
        /// Update an entity
        /// </summary>
        /// <returns></returns>
        Task Update(T obj);
        /// <summary>
        /// Update by expression
        /// </summary>
        /// <typeparam name="TUpdate">Object type</typeparam>
        /// <param name="expression">expression</param>
        /// <param name="objToUpdate">data to update</param>
        /// <returns></returns>
        Task Update<TUpdate>(Expression<Func<T, bool>> expression, TUpdate objToUpdate);
        /// <summary>
        /// Remove an entity
        /// </summary>
        /// <returns></returns>
        Task Delete(T obj);
        /// <summary>
        /// Remove entities
        /// </summary>
        /// <param name="expression">Expresion</param>
        /// <returns></returns>
        Task Delete(Expression<Func<T, bool>> expression);
        /// <summary>
        /// Remove an entity
        /// </summary>
        /// <param name="key">Unique key</param>
        /// <returns></returns>
        Task Delete<TKey>(TKey key);
    }
}
