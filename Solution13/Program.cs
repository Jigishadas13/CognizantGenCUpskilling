using System;

// Record with init properties
record Employee
{
    public int Id { get; init; }

    public string Name { get; init; }

    public double Salary { get; init; }
}

class Program
{
    static void Main(string[] args)
    {
        // Original record
        Employee e1 = new Employee
        {
            Id = 1,
            Name = "Jigisha",
            Salary = 50000
        };

        // Modified copy using with
        Employee e2 = e1 with
        {
            Salary = 60000
        };

        Console.WriteLine("Original Employee");
        Console.WriteLine(e1.Id + " " + e1.Name + " " + e1.Salary);

        Console.WriteLine();

        Console.WriteLine("Modified Employee");
        Console.WriteLine(e2.Id + " " + e2.Name + " " + e2.Salary);
    }
}