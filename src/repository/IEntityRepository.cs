using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace mxcd.crossapp.repository
{
    /// <summary>
    /// Repository pattern for entities
    /// </summary>
    public interface IEntityRepository<T>:IRepository<T>
    {
        /// <summary>
        /// Get a specific entity
        /// </summary>
        /// <param name="key">Unique key</param>
        /// <returns></returns>
        Task<T> Find<TKey>(TKey key);
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
        Task Update<TUpdate>(Expression<Func<T, bool>> expression, TUpdate objToUpdate) where TUpdate:class;
        /// <summary>
        /// Remove entities
        /// </summary>
        /// <param name="expression">Expresion</param>
        /// <returns></returns>
        Task Remove(Expression<Func<T, bool>> expression);
        /// <summary>
        /// Remove an entity
        /// </summary>
        /// <param name="key">Unique key</param>
        /// <returns></returns>
        Task Remove<TKey>(TKey key);
    }
}
