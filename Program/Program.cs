using AutoDiff;
class Program
{
    public static void Main(String[] args)
    {

        Variable x = new Variable(9);
        Variable y = new Variable(10);

        var u = x - y;

        Console.WriteLine(u.Backward(x));
    }

}