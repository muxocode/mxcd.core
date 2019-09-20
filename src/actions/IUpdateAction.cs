using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.actions
{
    /// <summary>
    /// Action to execute before update an entity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IUpdateAction<in T>
    {
        /// <summary>
        /// Action to execute
        /// </summary>
        /// <param name="obj">entity</param>
        /// <returns></returns>
        Task DoBeforeUpdate(T obj);
    }
}
