using AutoDiff;
class Program
{
    public static void Main(String[] args)
    {

        Variable x = new Variable(2);
        Variable y = new Variable(2);

        var u = y / x;

        Console.WriteLine(u.Backward(x));
    }

}