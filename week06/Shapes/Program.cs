using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        // Create a list of Shape objects
        List<Shape> shapes = new List<Shape>();

        // Add different types of shapes
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // Iterate through all the shapes
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}