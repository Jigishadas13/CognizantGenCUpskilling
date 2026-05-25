using System;

class Program
{
    static void CalculateFactorial(int num)
    {
        // Local function
        int Factorial(int n)
        {
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            return fact;
        }

        int result = Factorial(num);

        Console.WriteLine("Factorial of " + num + " is: " + result);
    }

    static void Main(string[] args)
    {
        CalculateFactorial(5);
    }
}