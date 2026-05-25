using System;

class Person(string name, int age, string city)
{
    // Auto-implemented properties
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public string City { get; set; } = city;

    // Method to display full information
    public void DisplayInfo()
    {
        Console.WriteLine("Person Details:");
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Age  : " + Age);
        Console.WriteLine("City : " + City);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object using primary constructor
        Person p1 = new Person("Jigisha", 20, "Jamshedpur");

        // Displaying details
        p1.DisplayInfo();
    }
}