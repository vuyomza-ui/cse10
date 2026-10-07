using System;

public abstract class Goal
{
    private string _name;
    private string _user;
    private int _points;

    public Goal(string name, string user, int points)
    {
        _name = name;
        _user = user;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetUser()
    {
        return _user;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract int RecordEvent();

    public abstract string GetDetailsString();

    public virtual bool IsComplete()
    {
        return false;
    }

    public abstract string GetStringRepresentation();
}