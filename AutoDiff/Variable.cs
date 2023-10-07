using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoDiff.Operator;

namespace AutoDiff
{
    public class Variable : Expression
    {

        public double Value { get; set; }

        public Variable()
        {

            Value = 0;
        }

        public Variable(double value)
        {

            Value = value;
        }



        public override double Forward()
        {
            return Value;
        }

        public override double Backward(Expression independVar)
        {
            if(independVar == this)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
