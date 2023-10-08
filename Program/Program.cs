using AutoDiff;
using System.Diagnostics;

class Program
{
    public static void Main(String[] args)
    {

        Variable x = new Variable(2);
        Variable y = new Variable(4);

        var u = x + x;
        for (int i = 0;i < 1000; i++)
        {
            u = u * x;

        }

        Stopwatch sw = Stopwatch.StartNew();

        sw.Start();
        double value = u.Backward(x);
        value = u.Backward(x);
        sw.Stop();

        Console.WriteLine(sw.ElapsedMilliseconds);
    }

}