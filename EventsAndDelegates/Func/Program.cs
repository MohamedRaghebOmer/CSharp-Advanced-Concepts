using System;

namespace FuncDelegate
{
    internal static class Program
    {
        static event Func <int, int> SquareDelegate;

        static int Square(int x)
        {
            return x * x;
        }

        static void Main(string[] args)
        {
            SquareDelegate = Square;
            Console.WriteLine(SquareDelegate?.Invoke(5));
        }
    }
}
