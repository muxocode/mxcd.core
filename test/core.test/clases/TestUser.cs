using mxcd.core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.test.clases
{
    public class TestUser : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
