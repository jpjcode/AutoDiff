using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDiff.Operator
{
    class PowerOperator : IOperator
    {
        public double Diff(Expression u, Expression v, Expression independVar)
        {
            throw new NotImplementedException();
        }

        public double Forward(Expression u, Expression v)
        {
            return Math.Pow(u.Forward(), v.Forward());
        }
    }
}
