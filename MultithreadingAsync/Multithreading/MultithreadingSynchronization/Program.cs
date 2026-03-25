using System;
using System.Threading;

static class MultithreadingSynchronization
{
    static int sharedCounter = 0;
    static object lockObject = new object();

    static void Main(string[] args)
    {
        Thread thread1 = new Thread(() => IncreaseCounter("Thread1"));
        Thread thread2 = new Thread(() => IncreaseCounter("Thread2"));

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine($"Both threads are done. Final count is {sharedCounter}");


        Console.WriteLine("------------------");


        thread1 = new Thread(() => SynchronizeCounterIncreasement("Thread1"));
        thread2 = new Thread(() => SynchronizeCounterIncreasement("Thread2"));

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine($"Both threads are done. Final count is {sharedCounter}");
    }


    static void IncreaseCounter(string threadName)
    {
        for (int i = 0; i < 10; i++)
        {
            lock (lockObject) // Prevent both threads to try to increase the counter in the same time, but after every increasement it is random to specify who will increase again
            {
                sharedCounter++;
                Console.WriteLine($"{threadName}: Increased counter by 1");
            }

            Thread.Sleep(10); // Give a chance to another thread to increase the counter.
        }
    }

    static void SynchronizeCounterIncreasement(string threadName)
    {
        lock (lockObject) // This way make only one thread to increase the counter 10 times, and after the first thread finish it's own loop the second thread will be able to do his loop
        {
            for (int i = 0; i < 10; i++)
            {
                sharedCounter++;
                Console.WriteLine($"{threadName}: Increased counter by 1");
            }
        }
    }
}