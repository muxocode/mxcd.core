using System;
using System.Collections.Generic;
using System.Text;

namespace mxcd.core.services
{
    public interface ICreator<out TOut, in TIn>
    {
        TOut Create(TIn data);
    }

    public interface ICreator<out TOut>
    {
        TOut Create();
    }
}
