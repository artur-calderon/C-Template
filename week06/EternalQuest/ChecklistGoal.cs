using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _amountCompleted;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _amountCompleted += 1;
        int earned = GetPoints();
        if (_amountCompleted >= _target)
        {
            earned += _bonus;
        }
        return earned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string box = IsComplete() ? "[X]" : "[ ]";
        return box + " " + GetName() + " (" + GetDescription() + ") -- Completed " + _amountCompleted + "/" + _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }
}
