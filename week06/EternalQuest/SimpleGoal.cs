using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string user, int points)
        : base(name, user, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine("Simple goal completed!");
            return GetPoints();
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";

        return $"{checkbox} {GetName()}";
    }
}