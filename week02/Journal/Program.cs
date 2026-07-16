using System;

// Creativity Explanation: In this program, I have added a "Mood" attribute to each Entry. The user is prompted to record their current mood, which is then saved to and loaded from the file along with the traditional journal data. This is displayed in the DisplayAll() method as well.        

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string userChoice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (userChoice != "5")
        {
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? (Enter 1-5): ");
            userChoice = Console.ReadLine();
            
            if (userChoice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\n{prompt}");
                Console.Write(">");
                string response = Console.ReadLine();

                Console.Write("What is your mood today? ");
                string mood = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                myJournal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");

            }
        }
    }
}