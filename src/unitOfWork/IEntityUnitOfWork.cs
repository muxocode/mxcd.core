using mxcd.core.unitOfWork.enums;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace mxcd.core.unitOfWork
{
    /// <summary>
    /// Pending entities
    /// </summary>
    public interface IEntityUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Add a new entity
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="obj">Entity</param>
        Task Add<T>(T obj) where T : class;
        /// <summary>
        /// Updates an entity
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="obj">Entity</param>
        /// <returns></returns>
        Task Update<T>(T obj) where T : class;
        /// <summary>
        /// Updates the entities in the database
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <typeparam name="P">Type</typeparam>
        /// <returns></returns>
        Task Update<T, P>(Expression<Func<T, bool>> filter, P updateData) where T : class where P : class;
        /// <summary>
        /// Removes an object
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="obj">Entity</param>
        /// <returns></returns>
        Task Remove<T>(T obj) where T : class;
        /// <summary>
        /// Remove a set of objects
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task Remove<T>(Expression<Func<T, bool>> filter = null) where T : class;
        /// <summary>
        /// Get pending objects
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="types">Types to filter</param>
        /// <returns></returns>
        IDictionary<TypePending, IEnumerable<T>> GetPendingEntities<T>(params TypePending[] types) where T : class;
        /// <summary>
        /// Get pending objects
        /// </summary>
        /// <param name="types">Types to filter</param>
        /// <returns></returns>
        IDictionary<TypePending, IEnumerable<object>> GetPendingEntities(params TypePending[] types);
    }
}
