using mxcd.core.entities;
using System.Threading.Tasks;

namespace mxcd.core.services
{
    public interface IManagerWritable<T>:IManager<T> where T : IEntity
    {
        Task Delete(long key);
        Task Insert(T obj);
        Task Update(T obj);
        Task Patch<P>(P obj);
    }
}