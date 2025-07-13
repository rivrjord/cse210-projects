using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
    private string _mood;
    private string _location;

    public Entry(string promptText, string entryText, string mood, string location)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
        _location = location;
    }

    //Ths block displays the entry to user
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Location: {_location}");
        Console.WriteLine();
    }

    //Here, I used  the override string funtion since I find it cleaner and more efficient
    public override string ToString()
    {
        return $"{_date}|{_promptText}|{_entryText}|{_mood}|{_location}";
    }

    //This block creates an Entry object from a saved file line
    public static Entry FromString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 5)
        {
            Entry entry = new Entry(parts[1], parts[2], parts[3], parts[4]);
            entry._date = parts[0];
            return entry;
        }
        return null;
    }
}
