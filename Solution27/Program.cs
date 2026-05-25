using System;
using System.Threading;

class Program
{
    static object lock1 = new object();

    static object lock2 = new object();

    static void Thread1()
    {
        bool gotLock1 = false;
        bool gotLock2 = false;

        try
        {
            Monitor.TryEnter(lock1, 1000, ref gotLock1);

            if (gotLock1)
            {
                Console.WriteLine("Thread 1 acquired Lock 1");

                Thread.Sleep(500);

                Monitor.TryEnter(lock2, 1000, ref gotLock2);

                if (gotLock2)
                {
                    Console.WriteLine("Thread 1 acquired Lock 2");
                }
                else
                {
                    Console.WriteLine("Thread 1 could not acquire Lock 2");
                }
            }
        }
        finally
        {
            if (gotLock2)
            {
                Monitor.Exit(lock2);
            }

            if (gotLock1)
            {
                Monitor.Exit(lock1);
            }
        }
    }

    static void Thread2()
    {
        bool gotLock1 = false;
        bool gotLock2 = false;

        try
        {
            Monitor.TryEnter(lock2, 1000, ref gotLock2);

            if (gotLock2)
            {
                Console.WriteLine("Thread 2 acquired Lock 2");

                Thread.Sleep(500);

                Monitor.TryEnter(lock1, 1000, ref gotLock1);

                if (gotLock1)
                {
                    Console.WriteLine("Thread 2 acquired Lock 1");
                }
                else
                {
                    Console.WriteLine("Thread 2 could not acquire Lock 1");
                }
            }
        }
        finally
        {
            if (gotLock1)
            {
                Monitor.Exit(lock1);
            }

            if (gotLock2)
            {
                Monitor.Exit(lock2);
            }
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(Thread1);

        Thread t2 = new Thread(Thread2);

        t1.Start();

        t2.Start();

        t1.Join();

        t2.Join();

        Console.WriteLine("Program Finished");
    }
}