using System;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string user, int points)
        : base(goal, user, points)
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine("Eternal goal recorded!");
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} - {GetUser()}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGaol|{GetName}|{GetUser()}|{GetPoints()}";
    }
}