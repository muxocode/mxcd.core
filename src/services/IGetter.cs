using mxcd.core.actions;
using mxcd.core.entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.services
{
    public interface IGetter<T> where T:IEntity
    {
        IEnumerable<IGetAction<T>> Actions { get; set; }
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> expression = null);
        Task<T> Get(long key);
    }
}
