using System;

// Custom class (Reference Type)
class Student
{
    public string name;
}

class Program
{
    // Method for Value Type
    static void ChangeValue(int x)
    {
        x = 100;
        Console.WriteLine("Inside ChangeValue method: " + x);
    }

    // Method for Reference Type
    static void ChangeReference(Student s)
    {
        s.name = "Rahul";
        Console.WriteLine("Inside ChangeReference method: " + s.name);
    }

    static void Main(string[] args)
    {
        // VALUE TYPE EXAMPLE
        int num = 10;

        Console.WriteLine("Before ChangeValue method: " + num);

        ChangeValue(num);

        Console.WriteLine("After ChangeValue method: " + num);

        Console.WriteLine();

        // REFERENCE TYPE EXAMPLE
        Student stu = new Student();
        stu.name = "Jigisha";

        Console.WriteLine("Before ChangeReference method: " + stu.name);

        ChangeReference(stu);

        Console.WriteLine("After ChangeReference method: " + stu.name);
    }
}