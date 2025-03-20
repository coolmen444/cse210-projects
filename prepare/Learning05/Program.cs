using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();

        Square square1 = new Square("red", 3);
        Rectangle rectangle1 = new Rectangle("blue", 5, 2);
        Circle circle1 = new Circle("yellow", 5);

        shapeList.Add(square1);
        shapeList.Add(rectangle1);
        shapeList.Add(circle1);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}