using AutoDiff.Operator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDiff
{
    public abstract class Expression
    {
        public static int id = 0;

        public int ID { get; set; }

        public Expression()
        {
            ID = id;
            id++;
        }

        public static Equation operator +(Expression left, Expression right)
        {
            return new Equation(left, right, new AddOperator());
        }

        public static Equation operator -(Expression left, Expression right)
        {
            return new Equation(left, right, new SubtractOperator());
        }
        public static Equation operator *(Expression left, Expression right)
        {
            return new Equation(left, right, new MultiplyOperator());
        }

        public static Equation operator /(Expression left, Expression right)
        {
            return new Equation(left, right, new DivideOperator());
        }

        public static Equation Pow(Expression @base, Expression exponent)
        {
            return new Equation(@base, exponent, new DivideOperator());
        }

        public static bool operator ==(Expression left, Expression right)
        {
            if (left.ID == right.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Expression left, Expression right)
        {
            if (left.ID == right.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public virtual double Forward()
        {
            return 0;
        }

        public virtual double Backward(Expression independVar)
        {
            return 0;
        }
    }
}
