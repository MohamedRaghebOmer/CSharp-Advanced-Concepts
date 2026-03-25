using System;
using System.Threading;
using System.Threading.Tasks;

static class Invoke
{
    static void Main(string[] args)
    {
        Parallel.Invoke(Func1, Func2, Func3);
        Console.WriteLine("\nDone!");
    }

    static void Func1()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Func1 completed it's work.");
    }

    static void Func2()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Func2 completed it's work.");
    }

    static void Func3()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Func3 completed it's work.");
    }
}

