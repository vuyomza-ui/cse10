using system;

public class ChecklistGoal : Goal
{
    private int _completed;
    private int _target;
    private int _bonus;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int target,
        int bonus)
        : base(name, description, points)
    {
        _completed = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int target,
        int bonus,
        int completed)
        : base(name, description, points)
    {
        _completed = completed;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine(
                "This checklist goal is already complete.");

                return 0;
        }

        _completed++;

        Console.WriteLine("Checklist goal recorded!");

        if (_completed == _target)
        {
            Console.WriteLine("Checklist goal completed!");
            Console.WriteLine($"Bonus: {_bonus} points");

            return GetPoints() + _bonus;
        }

        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _completed >= _target;
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";

        return $"{checkbox} {GetName()} - GetDescription()} " +
               $"Completed {_completed}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|" +
               $"{GetPoints()}|{_target}|{_bonus}|{_completed}";
    }
}