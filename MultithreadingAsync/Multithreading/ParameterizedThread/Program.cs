using System;
using System.Threading;

static class ParameterizedThread
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(() => Method1("thread1"));
        Thread thread2 = new Thread(() => Method2("thread2"));

        // Start both threads.
        thread1.Start();
        thread2.Start();

        // Wait until the two threads rejoin after they have finished their way.
        thread1.Join();
        thread2.Join();

        // Will be executed after thread1 and thread2 are finished due to thread join.
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Main: " + i);
            Thread.Sleep(500);
        }

    }

    static void Method1(string threadName)
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{threadName}: " + i);
            Thread.Sleep(500);
        }
    }

    static void Method2(string threadName)
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{threadName}: " + i);
            Thread.Sleep(500);
        }
    }

}
