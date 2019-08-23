using mxcd.core.rules;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mxcd.core.rules.implementations
{
    public class RuleProcessor<T> : IRuleProcessor<T> where T : class
    {
        public IEnumerable<IRule<T>> Rules { get; set; }

        public RuleProcessor(IEnumerable<IRule<T>> rules)
        {
            this.Rules = rules;
        }

        public async Task<bool> CheckRules(T entity)
        {
            var bResult = true;
            foreach (var rule in Rules)
            {
                bResult &= await rule.Check(entity);
            }

            return bResult;
        }
    }
}
