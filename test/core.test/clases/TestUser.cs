using mxcd.core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.test.clases
{
    public class TestUser : IEntity
    {
        public int Id { get; set; }
        object IEntity.Id => this.Id;

    }
}
