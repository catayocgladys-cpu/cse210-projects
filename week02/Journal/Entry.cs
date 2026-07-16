using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    // creative string: tracking mood 
    public string _mood; 

    // Display the individual entry neatly
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine(" -------------------------");
    }
}
        