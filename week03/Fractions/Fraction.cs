using System;

public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Constructor with no parameters
    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter
    public Fraction(int topNumber)
    {
        _top = topNumber;
        _bottom = 1;
    }

    // Constructor with two parameters
    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    // Getter and setter for top
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int topNumber)
    {
        _top = topNumber;
    }

    // Getter and setter for bottom
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottomNumber)
    {
        _bottom = bottomNumber;
    }

    // Return fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}