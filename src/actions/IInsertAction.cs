using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.actions
{
    /// <summary>
    /// Action to execute after insert an entity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IInsertAction<in T>
    {
        /// <summary>
        /// Action to execute before an insert
        /// </summary>
        /// <param name="obj">entity</param>
        /// <returns></returns>
        Task DoBeforeInsert(T obj);
    }
}
