using System;

class Program
{
    static void Main(string[] args)
    {
        // This block enables the user to repeat as many times as they want 
        string interest = "";
        while (interest != "no")
        {
            // This block generates a random number from 1 to 100(included)
            Random randomGenrator = new Random();
            int magicNumber = randomGenrator.Next(1, 101);

            int userGuess = -1;
            int guessCount = 0;

            // This block loops the guess until it matches the random number picked by the computer
            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                userGuess = int.Parse(userInput);

                guessCount = guessCount + 1;

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses to get it!");
                }
            }
            Console.Write("Would you like to try again? (yes/no) ");
            interest = Console.ReadLine();
        }
    }
}