using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.services
{
    public interface ICreator<TOut, in TIn>
    {
        Task<TOut> Create(TIn data);
    }

    public interface ICreator<TOut>
    {
        Task<TOut> Create();
    }
}
