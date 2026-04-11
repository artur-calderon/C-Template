using System;

public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    // String used to save the goal to a file
    public virtual string GetStringRepresentation()
    {
        return $"Goal|{_shortName}|{_description}|{_points}";
    }
}
