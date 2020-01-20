﻿using mxcd.core.entities;
using mxcd.core.unitOfWork.enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mxcd.core.unitOfWork
{
    /// <summary>
    /// Pending entities
    /// </summary>
    public interface IPending : IDisposable
    {
        /// <summary>
        /// Add a new entity
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="obj">Entity</param>
        Task Add<T>(T obj) where T : class, IEntity;
        /// <summary>
        /// Updates an entiry
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="obj">Entity</param>
        /// <returns></returns>
        Task Update<T>(T obj) where T : class, IEntity;
        /// <summary>
        /// Removes an object
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="obj">Entity</param>
        /// <returns></returns>
        Task Remove<T>(T obj) where T : class, IEntity;
        /// <summary>
        /// Add a new action
        /// </summary>
        Task Add(Action obj);
        /// <summary>
        /// Discard an action
        /// </summary>
        /// <returns></returns>
        Task DiscardActions();
        /// <summary>
        /// Clears the colection
        /// </summary>
        Task Discard();
        /// <summary>
        /// Discard an object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task Discard<T>(params T[] obj) where T : class, IEntity;
        /// <summary>
        /// Get pending objects
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="types">Types to filter</param>
        /// <returns></returns>
        IDictionary<TypePending, IEnumerable<T>> GetEntities<T>(params TypePending[] types) where T : class, IEntity;
        /// <summary>
        /// Get pending objects
        /// </summary>
        /// <param name="types">Types to filter</param>
        /// <returns></returns>
        IDictionary<TypePending, IEnumerable<IEntity>> GetEntities(params TypePending[] types);
        /// <summary>
        /// Get pending actions
        /// </summary>
        /// <returns></returns>
        IEnumerable<Action> GetActions();
    }
}
