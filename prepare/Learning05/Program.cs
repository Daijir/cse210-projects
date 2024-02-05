using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("red", 7);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("blue", 5, 4);
        shapes.Add(rectangle);
        Circle circle = new Circle("pink", 5);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}