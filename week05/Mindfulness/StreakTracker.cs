using System;
using System.IO;

public class StreakTracker
{
    private string _filePath = "usage_count.txt";
    public int TotalUses { get; private set; }

    public StreakTracker()
    {
        LoadCount();
        IncrementCount();
        SaveCount();
    }

    private void LoadCount()
    {
        if (File.Exists(_filePath))
        {
            string content = File.ReadAllText(_filePath);
            if (int.TryParse(content, out int count))
            {
                TotalUses = count;
            }
            else
            {
                TotalUses = 0;
            }
        }
        else
        {
            TotalUses = 0;
        }
    }

    private void IncrementCount()
    {
        TotalUses++;
    }

    private void SaveCount()
    {
        File.WriteAllText(_filePath, TotalUses.ToString());
    }

    public void DisplayUsageMessage()
    {
        Console.WriteLine($"🧘 You've used this mindfulness app {TotalUses} time(s). Keep it up!");
    }
}
