using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for input and parse to integer
        Console.WriteLine("What is your grade percentage?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer); 

        // Determine base letter grade
        string letter = "";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (+ or -) for the letter grade
        string sign = "";
        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }

        // Handle edge cases (No A+, no F+/F-)
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        // Display the result
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if percent >= 70
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Better luck next time!");
        }
    }
}