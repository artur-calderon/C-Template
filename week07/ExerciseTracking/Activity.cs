using System;

abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetActivityName()
    {
        return "Activity";
    }

    public string GetSummary()
    {
        string date = _date.ToString("dd MMM yyyy");
        string name = GetActivityName();
        int minutes = _minutes;
        double distance = Math.Round(GetDistance(), 2);
        double speed = Math.Round(GetSpeed(), 2);
        double pace = Math.Round(GetPace(), 2);
        return $"{date} {name} ({minutes} min): Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
    }
}
