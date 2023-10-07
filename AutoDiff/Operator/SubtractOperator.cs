using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDiff.Operator
{
    class SubtractOperator : IOperator
    {
        public double Diff(Expression u, Expression v, Expression independVar)
        {
            return u.Backward(independVar) - v.Backward(independVar);
        }

        public double Forward(Expression u, Expression v)
        {
            return u.Forward() - v.Forward();
        }
    }
}
