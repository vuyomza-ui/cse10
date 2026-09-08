using Systems;
using Systems.Collections.Generic;


public class Circle
{
    private double _radius;

    // Contructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea()
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}



