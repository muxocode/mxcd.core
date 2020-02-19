using System;
using System.Threading.Tasks;

namespace mxcd.crossapp.unitOfWork
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
        /// <summary>
        /// Add an action to execute before SaveChanges
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Task AddPendingAction(Action action);
    }
}
