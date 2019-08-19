using System;
using System.Collections.Generic;
using System.Text;

namespace mxcd.core.entities
{
    public interface IEntityDdd: IEntity
    {
        void Insert();
        void Delete();
    }
}
