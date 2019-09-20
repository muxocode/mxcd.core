using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.actions
{
    /// <summary>
    /// Action to execute before delete an entity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDeleteAction<in T>
    {
        /// <summary>
        /// Action to execute
        /// </summary>
        /// <param name="obj">entity</param>
        /// <returns></returns>
        Task DoBeforeDelete(T obj);
    }
}
