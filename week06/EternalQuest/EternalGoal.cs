using System;

public class EternalGoal : Goal
{

    public EternalGoal(string goal, string user, int value)
        : base(goal, user, value)
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine("Eternal goal recorded!");
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetName()}";
    }
}