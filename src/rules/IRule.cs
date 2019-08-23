using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.rules
{
    public interface IRule<T>
    {
        Task<bool> Check(T obj);
    }
}
