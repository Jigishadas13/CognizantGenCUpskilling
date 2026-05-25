using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public int OrderId { get; set; }

    public string CustomerName { get; set; }

    public double TotalAmount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>()
        {
            new Order { OrderId = 1, CustomerName = "Jigisha", TotalAmount = 5000 },

            new Order { OrderId = 2, CustomerName = "Rahul", TotalAmount = 2000 },

            new Order { OrderId = 3, CustomerName = "Aman", TotalAmount = 7000 }
        };

        // LINQ query
        var result = orders
            .Where(o => o.TotalAmount > 3000)
            .Select(o => new
            {
                o.OrderId,
                o.CustomerName
            });

        Console.WriteLine("Filtered Orders");

        foreach (var item in result)
        {
            Console.WriteLine(item.OrderId + " " + item.CustomerName);
        }
    }
}