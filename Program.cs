using System;
using System.Text.RegularExpressions;

namespace RegexTesterApp
{
    class Program
    {
        static void Main(string[]args)
        {
            // at least one digit
            const string defaulthPattren = @"\d+"; 

            Console.WriteLine("=== Regex TESTER ===");

            while (true)
            {
                // Ask regex 
                Console.Write("Enter a regular expression (or press ENTER to use the defaulth): ");
                string patternInput = Console.ReadLine();

                string pattern = string.IsNullOrWhiteSpace(patternInput)
                    ? defaulthPattren
                    : patternInput;

                // Ask for input 
                Console.Write("Enter some input to test against the regex: ");
                string input = Console.ReadLine();

                try
                {
                    // Perform match
                    bool isMatch = Regex.IsMatch(input, pattern);

                    Console.WriteLine($"{input} matches {pattern}: {isMatch}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Invalid regex pattern!");
                    Console.WriteLine($"Error: {ex.Message}");
                }

                // Exit or repeat
                Console.WriteLine("\nPress ESC to end or any key to try again.");
                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey. Escape)
                {
                    Console.WriteLine("\nExiting...");
                    break;
                }
                // Spacing next loop
                Console.WriteLine();

               
            }
        }
    }
}
