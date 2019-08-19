using core.test.clases;
using mxcd.core.entities;
using System;
using Xunit;

namespace core.test
{

    public class Entities
    {
        [Fact]
        public void Entity()
        {
            Assert.NotNull(new User());
        }

        [Fact]
        public void EntityDdd()
        {
            Assert.NotNull(new UserDdd());
        }
    }
}
