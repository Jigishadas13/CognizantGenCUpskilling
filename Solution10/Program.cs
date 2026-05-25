using System;

class Car
{
    // Properties
    public string Make;
    public string Model;
    public int Year;

    // Default constructor
    public Car()
    {
        Make = "Toyota";
        Model = "Corolla";
        Year = 2020;
    }

    // Parameterized constructor
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Method to display details
    public void Display()
    {
        Console.WriteLine("Make : " + Make);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Year : " + Year);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Object using default constructor
        Car c1 = new Car();

        // Object using parameterized constructor
        Car c2 = new Car("Honda", "City", 2023);

        Console.WriteLine("Car 1 Details");
        c1.Display();

        Console.WriteLine();

        Console.WriteLine("Car 2 Details");
        c2.Display();
    }
}