using System;
using System.Threading.Tasks;

static class Program
{
    static async Task Main(string[] args)
    {
        Task<int> asyncTaskResult = PerformAsyncOperation();

        Console.WriteLine("Doing something else...");

        int result = await PerformAsyncOperation();

        Console.WriteLine($"Result = {result}");
    }

    static async Task<int> PerformAsyncOperation()
    {
        await Task.Delay(2000);
        return 44;
    }
}
