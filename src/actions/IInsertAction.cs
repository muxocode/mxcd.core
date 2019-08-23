using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.actions
{
    public interface IInsertAction<in T>
    {
        Task DoBeforeInsert(T obj);
    }
}
