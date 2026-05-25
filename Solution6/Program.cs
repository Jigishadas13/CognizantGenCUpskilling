using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        // for loop
        Console.WriteLine("For Loop:");
        for (int i = 0; i < arr.Length; i++)
        {
           

            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\n");

        // foreach loop
        Console.WriteLine("Foreach Loop:");
        foreach (int num in arr)
        {
           
            Console.Write(num + " ");
        }

        Console.WriteLine("\n");

        // while loop
        Console.WriteLine("While Loop:");
        int j = 0;

        while (j < arr.Length)
        {
            Console.Write(arr[j] + " ");
            j++;
        }

        Console.WriteLine("\n");

        // do-while loop
        Console.WriteLine("Do-While Loop:");
        int k = 0;

        do
        {
            Console.Write(arr[k] + " ");
            k++;
        }
        while (k < arr.Length);
    }
}