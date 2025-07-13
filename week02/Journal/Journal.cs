using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    //This line creates a new list to store all journal entries
    private List<Entry> _entries = new List<Entry>();

    //This line Adds a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    //This block displays all the entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    //This block saves the current journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    //This block loads journal entries from a file
    public void LoadFromFile(string file)
    {
        _entries.Clear();

        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
                var entry = Entry.FromString(line);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }
        }

        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

