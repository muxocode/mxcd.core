﻿using System;
using System.Threading.Tasks;

namespace mxcd.core.unitOfWork
{
    /// <summary>
    /// Unit of work
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Save pending changes
        /// </summary>
        Task SaveChanges();
        /// <summary>
        /// Discard pending changes
        /// </summary>
        Task DiscardChanges();
    }
}
