using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string Email { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create object
        User u1 = new User()
        {
            Name = "Jigisha",
            Age = 20,
            Email = "jigisha@gmail.com"
        };

        // Serialize object to JSON
        string jsonData = JsonSerializer.Serialize(u1);

        // Save JSON to file
        File.WriteAllText("user.json", jsonData);

        Console.WriteLine("JSON Saved to File");

        // Read JSON from file
        string readData = File.ReadAllText("user.json");

        // Deserialize JSON to object
        User u2 = JsonSerializer.Deserialize<User>(readData);

        Console.WriteLine();

        Console.WriteLine("User Details");

        Console.WriteLine("Name: " + u2.Name);

        Console.WriteLine("Age: " + u2.Age);

        Console.WriteLine("Email: " + u2.Email);
    }
}