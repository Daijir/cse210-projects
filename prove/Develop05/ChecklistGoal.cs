public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    private int _target;
    public int _bonus;
    public ChecklistGoal(string name, string description, string points, string target, string bonus)
        : base (name, description, points)
    {
        _amountCompleted = 0;
        _target = int.Parse(target);
        _bonus = int.Parse(bonus);
    }

    public override void RecordEvent()
    {
        _amountCompleted ++;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        return $"-- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base._shortName},{base._description},{base._points},{_bonus},{_target},{_amountCompleted}";
    }
}