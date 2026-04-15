using System;

class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double minutes = GetMinutes();
        return (_speed * minutes) / 60.0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return GetMinutes() / distance;
    }

    public override string GetActivityName()
    {
        return "Cycling";
    }
}
