using System;

class Test
{
    public int a = 10;

    private int b = 20;

    protected int c = 30;

    public void Show()
    {
        Console.WriteLine("Private Value: " + b);
    }
}

class Child : Test
{
    public void Display()
    {
        Console.WriteLine("Public Value: " + a);

        Console.WriteLine("Protected Value: " + c);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Test t = new Test();

        Console.WriteLine("From Main Class");
        Console.WriteLine(t.a);

        t.Show();

        Child obj = new Child();

        Console.WriteLine("From Child Class");
        obj.Display();
    }
}