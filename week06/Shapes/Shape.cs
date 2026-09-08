using System;

public class Shape

{
    private string _color;

    // Constructor
    public Shape(string color);
    {
        _color = color
    }
    
    // Getter

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual string GetArea()
    {
        return 0;
    }

}