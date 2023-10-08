using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDiff
{
    class Constant : Expression
    {
        public double Value { get; }

        public Constant()
        {

            Value = 0;
        }

        public Constant(double value)
        {

            Value = value;
        }


        public override double Forward()
        {
            return Value;
        }

        public override double Backward(Expression independVar)
        {
            if (independVar == this)
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
