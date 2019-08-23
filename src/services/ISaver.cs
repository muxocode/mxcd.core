using mxcd.core.actions;
using mxcd.core.entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mxcd.core.services
{
    public interface ISaver<T> where T : IEntity
    {

        IEnumerable<IDeleteAction<T>> DeleteActions { get; set; }
        IEnumerable<IUpdateAction<T>> UpdateActions { get; set; }
        IEnumerable<IInsertAction<T>> InsertActions { get; set; }


        Task Delete(long key);
        Task<T> Insert(T obj);
        Task<T> Update(T obj);
        Task<T> Patch<P>(P obj);
    }
}