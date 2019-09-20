using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.rules
{
    /// <summary>
    /// Rule
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    public interface IRule<T>
    {
        /// <summary>
        /// Check the rule
        /// </summary>
        /// <param name="obj">entity</param>
        /// <returns></returns>
        Task<bool> Check(T obj);
    }
}
