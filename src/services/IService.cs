using mxcd.core.entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mxcd.core.services
{
    /// <summary>
    /// Repository with actions asociated
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IService<T> where T : IEntity
    {
        /// <summary>
        /// Get a set of entities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> Get<TKey>();
        /// <summary>
        /// Get a specific entity
        /// </summary>
        /// <param name="key">Unique key</param>
        /// <returns></returns>
        Task<T> Get<TKey>(TKey key);
        /// <summary>
        /// Update an entity
        /// </summary>
        /// <returns></returns>
        Task Update(T obj);
        /// <summary>
        /// Insert an entity
        /// </summary>
        /// <returns></returns>
        Task<T> Insert(T obj);
        /// <summary>
        /// Remove an entity
        /// </summary>
        /// <param name="key">Unique key</param>
        /// <returns></returns>
        Task Remove<TKey>(TKey key);
        /// <summary>
        /// Remove an entity
        /// </summary>
        /// <returns></returns>
        Task Remove(T obj);
    }
}
