using KC.SPARTA.Interface.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC.SPARTA.Rule
{
    public class NARule : IRule
    {
        public int Calculate(int A, int B)
        {
            return (A - B);
        }
    }
}
