using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square = new Square("Red", 25);
        Rectangle rectangle = new Rectangle("purple", 35, 45);
        Circle circle = new Circle(23, "white blue");
        Console.WriteLine($"The area of the square is {square.GetArea()} and its color: {square.GetColor()}");
        Console.WriteLine($"The area of the rectangle is {rectangle.GetArea()} and its color: {rectangle.GetColor()}");
        Console.WriteLine($"The area of the circle is {circle.GetArea()} and its color: {circle.GetColor()}");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (Shape sh in shapes)
        {
            Console.WriteLine($"The area of the shape is {sh.GetArea()} and its color {sh.GetColor()}");
        }
    }
}