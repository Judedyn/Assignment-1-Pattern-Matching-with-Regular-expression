// “I fixed the variable names to make them consistent, added null-safety so the program will not crash if ReadLine returns null. 
// and added more comments for better documentation.”
using System;
using System.IO.Pipes;
using System.Text.RegularExpressions;

namespace RegexTesterApp
{
    class Program
    {
        static void Main(string[]args)
        {
            // Deafault regex pattern:
            // /d+ means the input must contain at least one digit.
            const string defaulthPattren = @"\d+"; 

            Console.WriteLine("=== Regex TESTER ===");

            while (true)
            {
                // Ask the user for a regex pattern.
                // If the user just presses ENTER, the program will use the default pattern.
                Console.Write("Enter a regular expression (or press ENTER to use the default): ");
                string? patternInput = Console.ReadLine();

                string pattern = string.IsNullOrWhiteSpace(patternInput)
                    ? defaulthPattren
                    : patternInput;

                // Ask the user for input string to test against the regex pattern.
                Console.Write("Enter some input to test against the regex: ");
                string? userinput = Console.ReadLine();

                // Null-safety:
                // If Readline returns null, use an empty string instead
                // so the program does not crash.
                userinput ??= string.Empty;

                try
                {
                    // Check whether the user input matches the regex pattern.
                    bool isMatch = Regex.IsMatch(userinput, pattern);
                    
                    // Display the result of the regex test.
                    Console.WriteLine($"\"{userinput}\" matches \"{pattern}\": {isMatch}");
                }
                catch (ArgumentException ex)
                {
                    // This block handles invalid regex patterns entered by the user.
                    Console.WriteLine($"Invalid regex pattern!");
                    Console.WriteLine($"Error: {ex.Message}");
                }

                // Ask the user if they want to continue or exit the program.
                Console.WriteLine("\nPress ESC to end or any key to try again.");
                ConsoleKeyInfo key = Console.ReadKey(true); 

                if (key.Key == ConsoleKey. Escape)
                {
                    Console.WriteLine("\nExiting...");
                    break;
                }
                // Add a blank line before the next loop for better readability.
                Console.WriteLine();

               
            }
        }
    }
}
