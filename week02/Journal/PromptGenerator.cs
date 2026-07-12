
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string> 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned or realized today?",
        "What am I grateful for today?",
        "Describe a challenge I faced and how I overcame it.",
        "What is a goal I want to achieve this week?",
        "Write about a person who has influenced my life positively.",
        "Reflect on a recent accomplishment and how it made me feel.",
        "Describe a place that makes me feel peaceful and why.",
        "What is a habit I want to develop or break?",
        "Write about a memorable experience from my childhood."
    };

    // Pick a random prompt from the list
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];
    }

}