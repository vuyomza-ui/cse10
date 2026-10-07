using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string user, int points)
        : base(name, user, points)
    {
        _isComplete = false;
    }

    pulic SimpleGoal(string name, string user, int points, bool is Complete)
        : base(name, user, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine("Simple goal completed!");
            return GetPoints();
        }

        Console.WriteLine("This goal has already been completed.");
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";

        return $"{checkbox} {GetName()} - {GetUser()}";
    }

    public override string getStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetUser}|{GetPoints()}|{_isComplete}";
    }
}