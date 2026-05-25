using System;
using System.Diagnostics;
using System.IO;

class Logger
{
    public static void WriteLog(string message)
    {
        Console.WriteLine(message);

        Trace.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create file listener
        TextWriterTraceListener fileLog =
            new TextWriterTraceListener("log.txt");

        Trace.Listeners.Add(fileLog);

        Logger.WriteLog("Program Started");

        Logger.WriteLog("Logging Message");

        Logger.WriteLog("Program Ended");

        // Save logs to file
        Trace.Flush();

        Trace.Close();

        Console.WriteLine("Logs Written to File");
    }
}