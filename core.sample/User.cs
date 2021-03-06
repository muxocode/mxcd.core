﻿using mxcd.crossapp.repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace core.sample
{
    public class User
    {
        public long Id { get; }
    }

    public class UserRepository : IEntityRepository<User>
    {
        public Task Add(User item)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<User> Find<TKey>(TKey key)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> Get(Expression<Func<User, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetSync(Expression<Func<User, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task Remove<TKey>(TKey key)
        {
            throw new NotImplementedException();
        }

        public Task Remove(params User[] items)
        {
            throw new NotImplementedException();
        }

        public Task Update(User obj)
        {
            throw new NotImplementedException();
        }

        public Task Update<TUpdate>(Expression<Func<User, bool>> expression, TUpdate objToUpdate) where TUpdate : class
        {
            throw new NotImplementedException();
        }
    }

    public class Sample
    {
        void main()
        {
            var repo = new UserRepository();
            var user= repo.Find(new Guid());
            repo.Update(x => x.Id > 3, new { name = "Miguel" });
        }
    }
}
