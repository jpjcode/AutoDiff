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

        public static Equation operator +(Variable left, Variable right)
        {
            return new Equation(left, right, new AddOperator());
        }
        public static Equation operator +(Expression left, Variable right)
        {
            return new Equation(left, right, new AddOperator());
        }
        public static Equation operator +(Variable left, Expression right)
        {
            return new Equation(left, right, new AddOperator());
        }


        public static Equation operator -(Variable left, Variable right)
        {
            return new Equation(left, right, new SubtractOperator());
        }
        public static Equation operator -(Expression left, Variable right)
        {
            return new Equation(left, right, new SubtractOperator());
        }
        public static Equation operator -(Variable left, Expression right)
        {
            return new Equation(left, right, new SubtractOperator());
        }




        public static Equation operator *(Variable left, Variable right)
        {
            return new Equation(left, right, new MultiplyOperator());
        }
        public static Equation operator *(Expression left, Variable right)
        {
            return new Equation(left, right, new MultiplyOperator());
        }
        public static Equation operator *(Variable left, Expression right)
        {
            return new Equation(left, right, new MultiplyOperator());
        }


        public static Equation operator /(Variable left, Variable right)
        {
            return new Equation(left, right, new DivideOperator());
        }
        public static Equation operator /(Expression left, Variable right)
        {
            return new Equation(left, right, new DivideOperator());
        }
        public static Equation operator /(Variable left, Expression right)
        {
            return new Equation(left, right, new DivideOperator());
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
