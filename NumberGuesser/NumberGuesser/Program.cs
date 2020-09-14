using System;
using System.ComponentModel;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
            while (true)
            {
                Random Randoms = new Random();
                int CorrectNumber = Randoms.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != CorrectNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColourMessage(ConsoleColor.Red, "Please use actual number!");
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != CorrectNumber)
                    {
                        PrintColourMessage(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }
                PrintColourMessage(ConsoleColor.Green, "You are correct!");
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "N")
                {
                    return;
                }
            }
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            String inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }

        static void GetAppInfo()
        {
            String appName = "NumberGuesser";
            String appVersion = "1.0.0";
            String appAuthor = "Felgiks";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
        
        static void PrintColourMessage(ConsoleColor colour, string message)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
