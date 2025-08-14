using System;

public abstract class Activity
{
    private DateTime _date;
    private double _lengthMinutes;

    protected Activity(DateTime date, double lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime Date => _date;
    public double LengthMinutes => _lengthMinutes;

    public abstract double GetDistance(); // miles
    public abstract double GetSpeed();    // mph
    public abstract double GetPace();     // min per mile

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({LengthMinutes} min): " +
               $"Distance {GetDistance():0.00} miles, " +
               $"Speed {GetSpeed():0.00} mph, " +
               $"Pace: {GetPace():0.00} min/mile";
    }
}
