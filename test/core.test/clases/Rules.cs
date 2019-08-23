using mxcd.core.rules;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace core.test.clases
{
    public class CorrectRule : IRule<TestUser>
    {
        public async Task<bool> Check(TestUser obj)
        {
            return true;
        }
    }

    public class WrongRule : IRule<TestUser>
    {
        public async Task<bool> Check(TestUser obj)
        {
            return false;
        }
    }
}
