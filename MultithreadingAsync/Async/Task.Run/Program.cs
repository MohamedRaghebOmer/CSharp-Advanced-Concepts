using System;
using System.Threading;
using System.Threading.Tasks;

static class TaskDotRun
{
    static async Task Main(string[] args)
    {
        Task task1 = Task.Run(() => SimulateTask("Task1"));
        Task task2 = Task.Run(() => SimulateTask("Task2"));

        Console.WriteLine("Doing another work....");

        await Task.WhenAll(task1, task2);

        Console.WriteLine("All Task completed successfully.");
    }

    static void SimulateTask(string taskName)
    {
        Console.WriteLine($"{taskName} started...");
        Thread.Sleep(3000);
        Console.WriteLine($"{taskName} completed.");
    }

}
