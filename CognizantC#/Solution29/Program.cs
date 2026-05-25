using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Input: ");

        string userInput = Console.ReadLine();

        // Sanitize input
        string safeInput = WebUtility.HtmlEncode(userInput);

        Console.WriteLine();

        Console.WriteLine("Original Input:");
        Console.WriteLine(userInput);

        Console.WriteLine();

        Console.WriteLine("Sanitized Input:");
        Console.WriteLine(safeInput);
    }
}