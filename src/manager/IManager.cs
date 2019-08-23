using mxcd.core.entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace mxcd.core.manager
{
    public interface IManager
    {
        IEnumerable<T> Get<T>(Expression<Func<T, bool>> expression = null);
        T Get<T>(long key) where T:IEntity;
        void Insert<T>(T obj) where T : IEntity;
        void Update<T>(T obj);
        void Delete<T>(long key);
    }
}
