using System;

// Abstract class
abstract class Vehicle
{
    public abstract void Drive();
}

// Interface
interface IDrivable
{
    void Start();
}

// Car class
class Car : Vehicle, IDrivable
{
    // Overriding abstract method
    public override void Drive()
    {
        Console.WriteLine("Car is Driving");
    }

    // Interface method
    public void Start()
    {
        Console.WriteLine("Car is Starting");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();

        c.Start();

        c.Drive();

        // Polymorphism
        Vehicle v = new Car();

        v.Drive();
    }
}