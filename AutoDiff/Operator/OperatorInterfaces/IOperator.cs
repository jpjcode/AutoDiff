using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDiff.Operator.OperatorInterfaces
{
    public interface IOperator
    {

        public double Forward(Expression u, Expression v);
        public double Diff(Expression u, Expression v, Expression independVar);
    }
}
