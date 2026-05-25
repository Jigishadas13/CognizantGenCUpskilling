using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        // Using if else
        if (marks >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Fail");
        }

        // Using switch pattern matching
        string grade = marks switch
        {
            >= 90 => "A",
            >= 75 => "B",
            >= 50 => "C",
            _ => "Fail"
        };

        Console.WriteLine("Grade using switch: " + grade);
    }
}