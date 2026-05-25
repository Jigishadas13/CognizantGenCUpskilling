using System;

class Contact
{
    public string? Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Contact? c1 = new Contact();

        c1.Name = "Jigisha";

        Contact? c2 = null;

        // Null-conditional chaining
        Console.WriteLine("Contact 1 Name: " + c1?.Name);

        Console.WriteLine("Contact 2 Name: " + c2?.Name);

        // Null checking
        if (c1?.Name != null)
        {
            Console.WriteLine("Name Exists: " + c1.Name);
        }

        if (c2?.Name == null)
        {
            Console.WriteLine("Contact 2 or Name is Null");
        }
    }
}