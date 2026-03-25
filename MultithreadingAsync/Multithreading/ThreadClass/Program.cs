using System;
using System.Threading;

static class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(Method1);
        thread1.Start(); // Start an isolated thread.


        Thread thread2 = new Thread(Method2);
        thread2.Start(); // Start another isolated thread.

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

    static void Method1()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Method1: " + i);
            Thread.Sleep(500);
        }
    }

    static void Method2()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Method2: " + i);
            Thread.Sleep(500);
        }
    }
}