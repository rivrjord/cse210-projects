using System;

public class Swimming : Activity
{
    private int _laps;
    private const double MetersPerLap = 50;
    private const double MetersPerMile = 1609.34;

    public Swimming(DateTime date, double lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double totalMeters = _laps * MetersPerLap;
        return totalMeters / MetersPerMile;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (LengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthMinutes / GetDistance();
    }
}
