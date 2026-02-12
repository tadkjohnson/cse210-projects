using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 3.5));
        shapes.Add(new Rectangle("White", 25, 2));
        shapes.Add(new Circle("Blue", 2.1));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine("--------------------");
        }
    }
}
