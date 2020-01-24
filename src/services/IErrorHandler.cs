using System;
using System.Threading.Tasks;

namespace mxcd.core.services
{
    /// <summary>
    /// Error handler
    /// </summary>
    public interface IErrorHandler
    {
        /// <summary>
        /// Trace an error
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        Task Trace(string message, Exception exception=null);
        /// <summary>
        /// Trace an error
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        Task Trace(Exception exception);

    }
}
