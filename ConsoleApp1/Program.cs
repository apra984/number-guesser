using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayAppInfo();
            GreetUser();
            Random random = new Random();
            int correctGuess = random.Next(1, 10);
            int validGuess;
            bool isGameOver = false;

            while (!isGameOver)
            {
                Console.WriteLine("Guess a number between 1 and 10");

                string playerGuess = Console.ReadLine();

                if (!int.TryParse(playerGuess, out _))
                {
                    Console.WriteLine("That is invalid. Try again");
                    continue;
                }
                validGuess = int.Parse(playerGuess);

                if (validGuess != correctGuess)
                {
                    Console.WriteLine("You guessed {0}", playerGuess);
                    PrintMessage(ConsoleColor.DarkRed, "That is incorrect! Try again..");
                }
                else
                {
                    PrintMessage(ConsoleColor.Green, "You got it. Good job !");
                    Console.WriteLine("Play again? [Y] or [N]");
                    string response = Console.ReadLine().ToUpper();

                    if (response == "Y")
                    {
                        correctGuess = random.Next(1, 10);
                        continue;
                    }
                    else if (response == "N")
                    {
                        isGameOver = true;
                        Console.WriteLine("Thank you for playing ! :)");

                    }
                    else
                    {
                        return;
                    }
                }

            }

        }

        static void PrintMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void DisplayAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Akash Prakash";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to {0} v{1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello {0}, lets play!", input);
        }

    }
}
