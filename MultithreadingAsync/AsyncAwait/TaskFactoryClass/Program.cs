using System;
using System.Threading;
using System.Threading.Tasks;

static class TaskFactoryClass
{
    static async Task Main(string[] args)
    {
        // Define a cancelation token so can stop the task if needed.
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        // Create a task factory with some common configurations.
        TaskFactory taskFactory = new TaskFactory(token, TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);


        Task task1 = taskFactory.StartNew(() =>
        {
            Console.WriteLine("Task1 started...");
            Thread.Sleep(2000); // Simulates a task.
            Console.WriteLine("Task1 completed...");
        });

        Task task2 = taskFactory.StartNew(() =>
        {
            Console.WriteLine("Task2 started...");
            Thread.Sleep(2000); // Simulates a task.
            Console.WriteLine("Task2 completed...");
        });

        try
        {
            await Task.WhenAll(task1, task2);
            Console.WriteLine("All Tasks completed successfully.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
