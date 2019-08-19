using core.test.clases;
using mxcd.core.entities;
using mxcd.core.services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xunit;

namespace core.test
{
    class Creator : ICreator<string, int>
    {
        public string Create(int data)
        {
            return data.ToString();
        }
    }

    class Manager : IManager<User>
    {
        public Task<IEnumerable<User>> Get(Expression<Func<User, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(long key)
        {
            throw new NotImplementedException();
        }
    }


    class ManagerWritable : IManagerWritable<User>
    {
        public Task Delete(long key)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> Get(Expression<Func<User, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(long key)
        {
            throw new NotImplementedException();
        }

        public Task Insert(User obj)
        {
            throw new NotImplementedException();
        }

        public Task Patch<P>(P obj)
        {
            throw new NotImplementedException();
        }

        public Task Update(User obj)
        {
            throw new NotImplementedException();
        }
    }

    public class Services
    {
        [Fact]
        public void Creator()
        {
            Assert.Equal("1", new Creator().Create(1));
        }

        [Fact]
        public void Manager()
        {
            Assert.NotNull(new Manager());
        }

        [Fact]
        public void ManagerWritable()
        {
            Assert.NotNull(new ManagerWritable());
        }
    }
}
