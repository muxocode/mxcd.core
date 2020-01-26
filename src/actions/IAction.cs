using System.Threading.Tasks;

namespace mxcd.core.actions
{
    /// <summary>
    /// Moment of the action
    /// </summary>
    public enum ActionTime
    {
        /// <summary>
        /// Before action
        /// </summary>
        before,
        /// <summary>
        /// After action
        /// </summary>
        after,
        /// <summary>
        /// During the action
        /// </summary>
        meanwhile
    }
    /// <summary>
    /// Action interface
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    public interface IAction<in T>
    {
        /// <summary>
        /// Run operation
        /// </summary>
        /// <param name="obj">entity</param>
        /// <param name="actionTime">Action moment</param>
        /// <returns></returns>
        Task Do(T obj, ActionTime actionTime);
    }
}
