using mxcd.core.entities;
using mxcd.core.repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace core.sample
{
    public class User : IEntity
    {
        public object Id { get => new Guid(); set => throw new NotImplementedException(); }
    }

    public class UserRepository : IRepository<User>
    {
        public Task Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete<TKey>(TKey key)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> Get(Expression<Func<User, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get<TKey>(TKey key)
        {
            throw new NotImplementedException();
        }

        public Task<User> Insert(User obj)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(User obj)
        {
            throw new NotImplementedException();
        }
    }

    public class Sample
    {
        void main()
        {
            var repo = new UserRepository();
            var user= repo.Get(new Guid());
        }
    }
}
