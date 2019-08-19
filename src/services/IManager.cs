using mxcd.core.entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mxcd.core.services
{
    public interface IManager<T> where T:IEntity
    {
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> expression = null);
        Task<T> Get(long key);
    }
}
