using System;
using System.IO;
<<<<<<< HEAD
using Population.Models;
using Population.DataAccess;
using Population.BusinessLogic;

class Program 
{
    static void Main()
    {
        // 1. Initialize
        var logPath = "test_output.log";
        File.WriteAllText(logPath, "=== TEST STARTED ===\n");

        // 2. Model Test
        var testCountry = new Country { 
            Name = "Testistan", 
            Population = 999999 
        };
        LogResult(logPath, $"✅ MODEL TEST: {testCountry.Name} | Pop: {testCountry.Population}");

        // 3. DataAccess Test
        try {
            var repo = new CountryRepository();
            repo.AddCountry(testCountry);
            LogResult(logPath, "✅ DATAACCESS: Record added successfully");
        } catch (Exception ex) {
            LogResult(logPath, $"❌ DATAACCESS ERROR: {ex.Message}");
        }

        // 4. CSV Export Test
        var csvPath = "test_data/countries.csv";
        Directory.CreateDirectory("test_data");
        File.WriteAllText(csvPath, $"Name,Population\n{testCountry.Name},{testCountry.Population}");
        LogResult(logPath, $"📁 CSV EXPORT: {Path.GetFullPath(csvPath)}");

        // 5. Final Report
        LogResult(logPath, $"=== TEST COMPLETED ===");
        Console.WriteLine(File.ReadAllText(logPath)); // Show log in console
    }

    static void LogResult(string path, string message)
    {
        File.AppendAllText(path, $"[{DateTime.Now}] {message}\n");
=======

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
>>>>>>> develop
    }
}