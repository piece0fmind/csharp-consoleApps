using ConsoleApps.Classes;
using ConsoleApps.Interfaces;
using ConsoleApps.Utility;
using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleApps;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            /*var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Application started.");*/


            //PerformStackOperations();
            GetMostUsedCharacterInAString();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            Console.WriteLine("Please contact support or try again later.");
        }
    }

    static void PerformStackOperations()
    {
        ICustomStack arrayStack = new StackWithArray(5);
        ICustomStack listStack = new StackWithList();

        Console.WriteLine("Array-based stack operation:");
        StackUtils.PerformStackOperations(arrayStack);

        Console.WriteLine("List-based stack operation:");
        StackUtils.PerformStackOperations(listStack);
    }
    private static void ConfigureServices(ServiceCollection services)
    {
        /*services.AddLogging(configure =>
        {
            configure.AddConsole();
            configure.SetMinimumLevel(LogLevel.Information);
        });*/
    }
    private static void GetMostUsedCharacterInAString()
    {
        var maxCount = 0;
        IStringAnalyzer stringAnalyzer = new StringAnalyzer();

        Console.WriteLine("Enter a string to analyze:");
        string input = Console.ReadLine();

        var mostCommonChars = stringAnalyzer.GetMostFrequentCharacter(input, out maxCount);
        var outputChars = string.Join(", ", mostCommonChars);

        string charLabel = mostCommonChars.Count > 1 ? "characters" : "character";
        string verb = mostCommonChars.Count > 1 ? "are" : "is";

        Console.WriteLine($"The {charLabel} with most number of occurences {verb} {outputChars}. " +
            $"The count is { maxCount}.");
    }
}
