using System;

public class Running : Activity
{
    private double _distanceMiles;

    public Running(DateTime date, double lengthMinutes, double distanceMiles)
        : base(date, lengthMinutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return _distanceMiles;
    }

    public override double GetSpeed()
    {
        return _distanceMiles / (LengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthMinutes / _distanceMiles;
    }
}
