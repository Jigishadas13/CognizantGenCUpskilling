using System;

class Program
{
    // Method with two integers
    static int CalculateTotal(int a, int b)
    {
        return a + b;
    }

    // Method with three doubles
    static double CalculateTotal(double a, double b, double c)
    {
        return a + b + c;
    }

    static void Main(string[] args)
    {
        int sum1 = CalculateTotal(10, 20);
        double sum2 = CalculateTotal(12.5, 10.5, 7.0);

        Console.WriteLine("Total of two integers: " + sum1);
        Console.WriteLine("Total of three doubles: " + sum2);
    }
}