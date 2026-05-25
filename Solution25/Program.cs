using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Write sample text to file
        File.WriteAllText("JIGISHAC#.txt", "Hello JIGISHA here");

        // Read using FileStream
        FileStream fs = new FileStream("JIGISHAC#.txt", FileMode.Open, FileAccess.Read);

        byte[] data = new byte[fs.Length];

        fs.Read(data, 0, data.Length);

        string text = Encoding.UTF8.GetString(data);

        Console.WriteLine("File Content:");

        Console.WriteLine(text);

        fs.Close();

        Console.WriteLine();

        // MemoryStream
        MemoryStream ms = new MemoryStream();

        byte[] message = Encoding.UTF8.GetBytes("MemoryStream Data");

        ms.Write(message, 0, message.Length);

        Console.WriteLine("Bytes Written: " + ms.Length);

        ms.Close();
    }
}