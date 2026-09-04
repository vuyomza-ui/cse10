using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the three constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        // Display fractions and decimal values
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        // Test getters
        Console.WriteLine();
        Console.WriteLine("Testing getters:");
        Console.WriteLine($"Top: {fraction3.GetTop()}");
        Console.WriteLine($"Bottom: {fraction3.GetBottom()}");

        // Test setters
        fraction3.SetTop(6);
        fraction3.SetBottom(7);

        Console.WriteLine();
        Console.WriteLine("After using setters:");
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    

    }
}