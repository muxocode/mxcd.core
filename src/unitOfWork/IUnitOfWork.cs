using System;

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
        void SaveChanges();
        /// <summary>
        /// Discard pending changes
        /// </summary>
        void DiscardChanges();
    }
}
