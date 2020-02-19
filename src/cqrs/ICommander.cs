using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.crossapp.cqrs
{
    /// <summary>
    /// Commands for entity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommander<T>
    {
        /// <summary>
        /// Add an item
        /// </summary>
        /// <param name="item">item to add</param>
        Task Add(T item);
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
