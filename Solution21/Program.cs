using System;

class Program
{
    static void CheckObject(object obj)
    {
        // Pattern matching using is
        if (obj is int n)
        {
            Console.WriteLine("Integer Value: " + n);
        }
        else if (obj is string s)
        {
            Console.WriteLine("String Value: " + s);
        }
        else
        {
            Console.WriteLine("Unknown Type");
        }

        // Switch pattern matching
        switch (obj)
        {
            case int x:
                Console.WriteLine("Square: " + (x * x));
                break;

            case string y:
                Console.WriteLine("Length: " + y.Length);
                break;

            default:
                Console.WriteLine("No Operation");
                break;
        }
    }

    static void Main(string[] args)
    {
        CheckObject(5);

        Console.WriteLine();

        CheckObject("Hello");
    }
}