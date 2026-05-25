using System;

class Program
{
    // Method returning tuple
    static (int, string) GetData()
    {
        return (101, "Jigisha");
    }

    static void Main(string[] args)
    {
        // Deconstructing tuple
        (int id, string name) = GetData();

        Console.WriteLine("Id: " + id);

        Console.WriteLine("Name: " + name);
    }
}