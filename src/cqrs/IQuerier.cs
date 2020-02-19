using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.crossapp.cqrs
{
    /// <summary>
    /// Querirer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQuerier<T>
    {
        /// <summary>
        /// Gets a collection of T
        /// </summary>
        /// <param name="expression">filter</param>
        /// <returns></returns>
        Task<IEnumerable<T>> Get(Expression<Func<T>> expression = null);
        /// <summary>
        /// Gets a entity
        /// </summary>
        /// <typeparam name="TKey">Type of key</typeparam>
        /// <param name="key">Unique key</param>
        /// <returns></returns>
        Task<T> Get<TKey>(TKey key);
    }
}
