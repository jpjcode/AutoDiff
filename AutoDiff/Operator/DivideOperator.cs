using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDiff.Operator
{
    class DivideOperator : IOperator
    {
        public double Diff(Expression u, Expression v, Expression independVar)
        {
            
            return 0;
        }

        public double Forward(Expression u, Expression v)
        {
            return u.Forward() / v.Forward();
        }
    }
}
