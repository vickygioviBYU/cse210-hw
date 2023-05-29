using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5, "red");
        Console.WriteLine(square.getColor());
        Console.WriteLine(square.getArea());

        Rectangle rect = new Rectangle(10, 2, "blue");
        Console.WriteLine(rect.getColor());
        Console.WriteLine(rect.getArea());

        Circle circle = new Circle(15, "yellow");
        Console.WriteLine(circle.getColor());
        Console.WriteLine(circle.getArea());

        List<Shape> listShapes = new List<Shape>();
        listShapes.Add(square);
        listShapes.Add(rect);
        listShapes.Add(circle);

        foreach (Shape shape in listShapes) {
            Console.WriteLine(shape.getColor());
            Console.WriteLine(shape.getArea());
        }
    }
}