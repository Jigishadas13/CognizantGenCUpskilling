using System;

class Person
{
    // Nullable reference types
    public string? Name { get; set; }

    public string? City { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();

        p.Name = null;

        p.City = "Jamshedpur";

        // Null-conditional operator
        Console.WriteLine("Name Length: " + p.Name?.Length);

        // Null-coalescing operator
        Console.WriteLine("Name: " + (p.Name ?? "No Name"));

        Console.WriteLine("City: " + (p.City ?? "No City"));

        // Null checking
        if (p.Name == null)
        {
            Console.WriteLine("Name is Null");
        }
        else
        {
            Console.WriteLine(p.Name);
        }
    }
}