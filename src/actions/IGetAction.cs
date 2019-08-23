using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.actions
{
    public interface IGetAction<in T>
    {
        Task DoAfterGet(T obj);
    }
}
