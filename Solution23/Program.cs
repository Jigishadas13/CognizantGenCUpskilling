using System;
using System.Threading.Tasks;

class Program
{
    // Async method
    static async Task<string> UploadFile()
    {
        try
        {
            Console.WriteLine("Uploading File...");

            // Wait for 3 seconds
            await Task.Delay(3000);

            return "File Uploaded Successfully";
        }
        catch (Exception e)
        {
            return "Error: " + e.Message;
        }
    }

    static async Task Main(string[] args)
    {
        string result = await UploadFile();

        Console.WriteLine(result);
    }
}