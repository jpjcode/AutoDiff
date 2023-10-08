using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoDiff.Operator.OperatorInterfaces;

namespace AutoDiff.Operator
{
    class LogOperator : IOperator
    {
        public double Diff(Expression u, Expression v, Expression independVar)
        {
            return v.Backward(independVar) / (Math.Log(u.Forward()) * v.Forward());
        }

        public double Forward(Expression u, Expression v)
        {
            return Math.Log(u.Forward(), v.Forward());
        }
    }
}
