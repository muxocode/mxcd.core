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
        long Id { get; set; }
    }
}
