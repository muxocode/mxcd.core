using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.actions
{
    /// <summary>
    /// Action to execute after get an entity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGetAction<in T>
    {
        /// <summary>
        /// Action to execute
        /// </summary>
        /// <param name="obj">entity</param>
        /// <returns></returns>
        Task DoAfterGet(T obj);
    }
}
