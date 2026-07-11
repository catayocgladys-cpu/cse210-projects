using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Display the welcome greeting
        DisplayWelcome();

        // 2. Call prompt functions and store their return values
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        // 3. Calculate the mathematical square
        int squaredNumber = SquareNumber(userNumber);

        // 4. Print the final results matching the formatting
        DisplayResult(userName, squaredNumber);
    }

    // --- FUNCTION DEFINITIONS ---

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}