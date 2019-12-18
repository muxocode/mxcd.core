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
        public long Id { get; }

        object IEntity.Id => this.Id;
    }

    public class UserRepository : IEntityRepository<User>
    {
        public Task Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Expression<Func<User, bool>> expression)
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

        public Task Insert(User obj)
        {
            throw new NotImplementedException();
        }

        public Task Update(User obj)
        {
            throw new NotImplementedException();
        }

        public Task Update<TUpdate>(Expression<Func<User, bool>> expression, TUpdate objToUpdate)
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
            repo.Update(x => x.Id > 3, new { name = "Miguel" });
        }
    }
}
