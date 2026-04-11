using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }
        _isComplete = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string box = _isComplete ? "[X]" : "[ ]";
        return box + " " + GetName() + " (" + GetDescription() + ")";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}
