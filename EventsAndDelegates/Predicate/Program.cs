using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class Program
{
    static Predicate<int> PredicateDelegate = IsEvent;

    static bool IsEvent(int x)
    {
        return x % 2 == 0;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(PredicateDelegate.Invoke(2)); // True
    }
}
