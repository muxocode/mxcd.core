using mxcd.core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.test.clases
{
    public class TestUser : IEntity<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        object IEntity.Id => this.Id;
    }
}
