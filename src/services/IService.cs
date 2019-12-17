using mxcd.core.actions;
using mxcd.core.entities;
using mxcd.core.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace mxcd.core.services
{
    /// <summary>
    /// Repository with actions asociated
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IService<T>: IRepository<T> where T : IEntity
    {
        /// <summary>
        /// Get actions
        /// </summary>
        IEnumerable<IGetAction<T>> GetActions { get; }
        /// <summary>
        /// Delete actions
        /// </summary>
        IEnumerable<IDeleteAction<T>> DeleteActions { get; }
        /// <summary>
        /// Update actions
        /// </summary>
        IEnumerable<IUpdateAction<T>> UpdateActions { get; }
        /// <summary>
        /// Inser actions
        /// </summary>
        IEnumerable<IInsertAction<T>> InsertActions { get; }
    }
}
