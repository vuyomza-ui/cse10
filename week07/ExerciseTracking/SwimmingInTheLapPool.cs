using System;

public class SwimmingInTheLapPool : Activity
{
    private int _numberOfLaps;

    public SwimmingInTheLapPool(
    DateTime date, 
    int minutes, 
    int numberOfLaps)
    : base(date, minutes)

    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

}