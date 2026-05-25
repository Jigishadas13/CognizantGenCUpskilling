using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List
        List<string> fruits = new List<string>();

        fruits.Add("Apple");
        fruits.Add("Mango");
        fruits.Add("Orange");

        // Remove item
        fruits.Remove("Mango");

        Console.WriteLine("List Items");

        foreach (string item in fruits)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        // Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(1, "Jigisha");
        students.Add(2, "Rahul");
        students.Add(3, "Aman");

        // Remove item
        students.Remove(2);

        Console.WriteLine("Dictionary Items");

        foreach (var item in students)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}