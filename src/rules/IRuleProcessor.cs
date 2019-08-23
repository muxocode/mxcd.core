using System.Collections.Generic;
using System.Threading.Tasks;

namespace mxcd.core.rules
{
    public interface IRuleProcessor<T> where T:class
    {
        IEnumerable<IRule<T>> Rules { get; }
        Task<bool> CheckRules(T entity);
    }
}
