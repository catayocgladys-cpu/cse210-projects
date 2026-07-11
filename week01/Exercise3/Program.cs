using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        // outer loop to replay the entire game
        while (playAgain == "yes")
        {
            // Generate random magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            // Inner loop for active guessing
            while (guess != magicNumber)
            {
                // Ask for input and parse to integer
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());  
                guessCount++;

                // Check if the guess is correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The magic number was {magicNumber}.");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask to play again
            Console.WriteLine("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Thanks for playing!");        
    }
}