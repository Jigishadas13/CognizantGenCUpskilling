using System;

class Program
{
    // ref parameter
    static void ChangeRef(ref int x)
    {
        x = x + 10;
    }

    // out parameter
    static void ChangeOut(out int y)
    {
        y = 50;
    }

    // in parameter
    static void ChangeIn(in int z)
    {
        Console.WriteLine("Value inside in method: " + z);

        // z cannot be modified here
    }

    static void Main(string[] args)
    {
        // ref example
        int a = 20;

        Console.WriteLine("Before ref method: " + a);
        ChangeRef(ref a);
        Console.WriteLine("After ref method: " + a);

        Console.WriteLine();

        // out example
        int b;

        ChangeOut(out b);
        Console.WriteLine("Value after out method: " + b);

        Console.WriteLine();

        // in example
        int c = 30;

        Console.WriteLine("Before in method: " + c);
        ChangeIn(in c);
        Console.WriteLine("After in method: " + c);
    }
}