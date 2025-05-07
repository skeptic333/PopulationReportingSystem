using System;
using System.IO;

class Program
{
    static void Main()
    {
        var logPath = "test_output.log";
        File.WriteAllText(logPath, "Test started\n");

        var country = "Testistan,999999";
        File.AppendAllText(logPath, $"Model test: {country}\n");

        Directory.CreateDirectory("test_data");
        var csvPath = "test_data/countries.csv";
        File.WriteAllText(csvPath, $"Name,Population\n{country}");
        File.AppendAllText(logPath, $"CSV export: {Path.GetFullPath(csvPath)}\n");

        File.AppendAllText(logPath, "Test completed\n");
        Console.WriteLine(File.ReadAllText(logPath));
    }
}