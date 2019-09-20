using mxcd.core.rules;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mxcd.core.rules.implementations
{
    /// <summary>
    /// Rule processor
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    public class RuleProcessor<T> : IRuleProcessor<T> where T : class
    {
        /// <summary>
        /// Object that checks the rules of T entity
        /// </summary>
        public IEnumerable<IRule<T>> Rules { get; set; }
        /// <summary>
        /// Create a RuleProcessor
        /// </summary>
        /// <param name="rules">Rules to check</param>
        public RuleProcessor(IEnumerable<IRule<T>> rules)
        {
            this.Rules = rules;
        }

        /// <summary>
        /// Check rules
        /// </summary>
        /// <param name="entity">entity</param>
        /// <returns></returns>
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
