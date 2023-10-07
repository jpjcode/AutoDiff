using AutoDiff.Operator;

namespace AutoDiff
{
    public class Equation : Expression
    {

        public Expression U { get; set; }
        public Expression V { get; set; }

        public IOperator Operator { get; set; }


        public Equation()
        {

        }
        public Equation(Expression u, Expression v, IOperator @operator)
        {
            U = u;
            V = v;
            Operator = @operator;
        }

        public static Equation operator +(Equation left, Equation right)
        {
            return new Equation(left, right, new AddOperator());
        }

        public static Equation operator -(Equation left, Equation right)
        {
            return new Equation(left, right, new SubtractOperator());
        }



        public static Equation operator *(Equation left, Equation right)
        {
            return new Equation(left, right, new MultiplyOperator());
        }

        public static Equation operator /(Equation left, Equation right)
        {
            return new Equation(left, right, new DivideOperator());
        }

        public override double Forward()
        {
            return Operator.Forward(U, V);
        }
        
        public override double Backward(Expression independVar)
        {
            return Operator.Diff(U, V, independVar);
        }
    }
}