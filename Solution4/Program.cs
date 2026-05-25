using System;

// Custom class
class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using var
        var number = 100;
        var message = "Hello C#";

        // Using new()
        Student s1 = new("Jigisha");

        // Printing values and types
        Console.WriteLine("Value: " + number);
        Console.WriteLine("Type : " + number.GetType());

        Console.WriteLine();

        Console.WriteLine("Value: " + message);
        Console.WriteLine("Type : " + message.GetType());

        Console.WriteLine();

        Console.WriteLine("Student Name: " + s1.Name);
        Console.WriteLine("Type        : " + s1.GetType());
    }
}