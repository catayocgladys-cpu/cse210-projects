using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the first name 
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Hello, {firstName}!");

        // Get the last name
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();   

        // Display the formatted output
        Console.WriteLine($"Your full name is: {firstName} {lastName}");
    }
}