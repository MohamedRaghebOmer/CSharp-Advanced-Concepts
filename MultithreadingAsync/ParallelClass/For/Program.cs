using System;
using System.Threading.Tasks;

static class For
{
    static void Main(string[] args)
    {
        Parallel.For(0, 10, i =>
        {
            Console.WriteLine($"Executing parallel number {i} for thread id = {Task.CurrentId}");
            Task.Delay(5000).Wait(); // Simulate some work.
        });

        Console.WriteLine("All iterations completed");
    }
}

