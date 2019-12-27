using System;
using System.Collections.Generic;
using System.Text;

namespace mxcd.core.factory
{
    /// <summary>
    /// Factory pattern
    /// </summary>
    public interface IFactory<in TIn,out TOut>
    {
        /// <summary>
        /// Creates an entity of <typeparamref name="TOut"/>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        TOut Create(TIn obj);
    }
}
