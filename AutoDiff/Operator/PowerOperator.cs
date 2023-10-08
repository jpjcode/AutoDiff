using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoDiff.Operator.OperatorInterfaces;

namespace AutoDiff.Operator
{
    class PowerOperator : IOperator
    {
        public double Diff(Expression u, Expression v, Expression independVar)
        {
            if(u == independVar && v != independVar)
            {
                return ((u.Forward()) * Math.Pow(u.Forward(), v.Forward() - 1)) * u.Backward(independVar);
            }
            
            else if(u != independVar && v == independVar)
            {
                return (Math.Pow(u.Forward(), v.Forward()) * Math.Log(u.Forward())) * v.Backward(independVar);
            }
            else if (u == independVar && v == independVar)
            {
                return (Math.Pow(u.Forward(), u.Forward()) * (1 + Math.Log(u.Forward()))) * u.Backward(independVar);
            }
            else
            {
                return 0;
            }

        }

        public double Forward(Expression u, Expression v)
        {
            return Math.Pow(u.Forward(), v.Forward());
        }
    }
}
