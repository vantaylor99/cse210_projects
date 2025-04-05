using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle(2.5, "red"));
        shapes.Add(new Rectangle(2.6, 2.9, "green"));
        shapes.Add(new Square(5.4, "purple"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea():0.00}");
        }



        Square square = new Square(2, "blue");
        Console.WriteLine($"The {square.GetColor()} square has an area of {square.GetArea()}.");
    }
}