using System;

class Student
{
    // Required properties
    public required string Name { get; set; }

    public required int RollNo { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Initializing required properties
        Student s1 = new Student
        {
            Name = "Jigisha",
            RollNo = 101
        };

        Console.WriteLine("Name: " + s1.Name);

        Console.WriteLine("Roll No: " + s1.RollNo);

        // This will give compiler error
        /*
        Student s2 = new Student
        {
            Name = "Rahul"
        };
        */
    }
}