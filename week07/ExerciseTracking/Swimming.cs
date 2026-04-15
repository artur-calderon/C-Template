using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double km = _laps * 50.0 / 1000.0;
        double miles = km * 0.62;
        return miles;
    }

    public override double GetSpeed()
    {
        double minutes = GetMinutes();
        return (GetDistance() / minutes) * 60.0;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetActivityName()
    {
        return "Swimming";
    }
}
