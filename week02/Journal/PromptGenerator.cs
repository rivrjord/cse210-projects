using System;
using System.Collections.Generic;

public class PromptGenerator
{
    //This is a list that contains all the available questions
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I most grateful for right now?",
        "What made me laugh today?",
        "What challenge did I face today and how did I handle it?",
        "If I am to describe today in one word, what would it be?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}

