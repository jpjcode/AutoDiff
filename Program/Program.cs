using AutoDiff;
class Program
{
    public static void Main(String[] args)
    {

        Variable x = new Variable(1);
        Variable y = new Variable(10);

        var u = x * x;

        Console.WriteLine(u.Backward(x));
    }

}