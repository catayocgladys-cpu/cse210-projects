using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        // Collect inputs
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Calculations for Sum, Max, and Smallest positive
        int sum = 0;
        int max = int.MinValue;
        int smallestPositive = int.MaxValue;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        // Print primary metrics
        double average = ((double)sum) / numbers.Count;
                
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average:F2}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");  

        // Sort and display the list elements
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
                
    }
}