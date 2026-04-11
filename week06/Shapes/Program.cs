using System;

class Program
{
    static void Main(string[] args)
    {
        // Test individual shapes
        Square s = new Square("Blue", 5);
        Console.WriteLine(s.GetColor());
        Console.WriteLine(s.GetArea());

        // List of polymorphic shapes
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Green", 4));
        shapes.Add(new Rectangle("Red", 5, 3));
        shapes.Add(new Circle("Purple", 2));

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}