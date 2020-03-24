using System;

// Namespace
namespace NumberGuess
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set up vars
            string appName = "Number Guess";
            string appVersion = "1.0.0";
            string appAuthor = "Cameron Nepe";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }
    }
}
