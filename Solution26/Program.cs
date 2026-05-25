using System;
using System.Threading;

class Program
{
    static int counter = 0;

    static object obj = new object();

    static void Increment()
    {
        for (int i = 0; i < 1000; i++)
        {
            // Prevent race condition
            lock (obj)
            {
                counter++;
            }
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(Increment);

        Thread t2 = new Thread(Increment);

        t1.Start();

        t2.Start();

        t1.Join();

        t2.Join();

        Console.WriteLine("Final Counter Value: " + counter);
    }
}