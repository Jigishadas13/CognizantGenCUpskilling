using System;

class Product
{
    // Auto property
    public string Name { get; set; }

    // Backing field
    private double price;

    // Property with validation
    public double Price
    {
        get { return price; }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Price cannot be negative");
            }
            else
            {
                price = value;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product p = new Product();

        p.Name = "Laptop";

        p.Price = 50000;

        Console.WriteLine("Product Name: " + p.Name);
        Console.WriteLine("Product Price: " + p.Price);

        Console.WriteLine();

        // Negative value
        p.Price = -1000;

        Console.WriteLine("Final Price: " + p.Price);
    }
}