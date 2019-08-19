using mxcd.core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.test.clases
{
    public class User : IEntity
    {
        public long Id { get; set; }
    }

    public class UserDdd : User, IEntityDdd
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }
    }
}
