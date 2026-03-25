using System;
using System.Net;
using System.Threading;

static class ParameterizedThread
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(() => DownloadAndPrint("https://www.cnn.com"));
        Thread thread2 = new Thread(() => DownloadAndPrint("https://www.amazon.com"));
        Thread thread3 = new Thread(() => DownloadAndPrint("https://www.ProgrammingAdvices.com"));

        // Start all threads.
        thread1.Start();
        Console.WriteLine("Thread1 started.");

        thread2.Start();
        Console.WriteLine("Thread2 started");

        thread3.Start();
        Console.WriteLine("Thread3 started.");


        thread1.Join();
        Console.WriteLine("Thread 1 is done.");

        thread2.Join();
        Console.WriteLine("Thread 2 is done.");

        thread3.Join();
        Console.WriteLine("Thread 3 is done.");


        Console.WriteLine("All threads are done.");
    }

    static void DownloadAndPrint(string url)
    {
        string content;

        using (WebClient client = new WebClient())
        {
            Thread.Sleep(500); // Simulate some work by adding a delay.
            content = client.DownloadString(url);
        }

        Console.WriteLine($"{url}: {content.Length} character downloaded.");
    }
}
