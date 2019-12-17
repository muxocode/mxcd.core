using System;
using System.Collections.Generic;
using System.Text;

namespace mxcd.core.entities
{
    /// <summary>
    /// Entity
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Unique field of entity
        /// </summary>
        object Id { get; set; }
    }

    /// <summary>
    /// Entity
    /// </summary>
    /// <typeparam name="T">Key type</typeparam>
    public interface IEntity<T>:IEntity
    {
        /// <summary>
        /// Unique field of entity
        /// </summary>
        new T Id { get; set; }
    }
}
