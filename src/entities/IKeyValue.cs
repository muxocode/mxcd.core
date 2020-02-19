using System;
using System.Collections.Generic;
using System.Text;

namespace mxcd.crossapp.entities
{
    /// <summary>
    /// Keyname + value
    /// </summary>
    /// <typeparam name="T">Value Type</typeparam>
    public interface IKeyValue<T>
    {
        /// <summary>
        /// Key name
        /// </summary>
        string KeyName { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        T Value { get; set; }
    }
    /// <summary>
    /// Keyname + value
    /// </summary>
    public interface IKeyValue:IKeyValue<string>
    {

    }
}
