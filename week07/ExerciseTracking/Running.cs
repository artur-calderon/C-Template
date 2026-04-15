using System;

class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
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
        return "Running";
    }
}
