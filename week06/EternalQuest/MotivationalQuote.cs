using System;
using System.Collections.Generic;

public class MotivationalQuote
{
    private List<string> _quotes = new List<string>
    {
        "Keep going, you’re doing great!",
        "Small progress is still progress.",
        "Believe you can and you’re halfway there.",
        "Consistency beats intensity.",
        "Your future self will thank you.",
        "Success is the sum of small efforts repeated day in and day out.",
        "Dream big, start small, act now.", 
        "Every step you take is a step closer to your goal.",
        "Challenges are what make life interesting; overcoming them is what makes life meaningful.",
    };

    private Random _random = new Random();

    public string GetRandomQuote()
    {
        int index = _random.Next(_quotes.Count);
        return _quotes[index];
    }
}
