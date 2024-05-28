using System;
using library;

public class Program
{
    public static void Main()
    {
        IShape triangle = ShapeFactory.CreateShape("triangle", 3, 4, 5);

        if (triangle is Triangle t && t.IsRightTriangle())
        {
            Console.WriteLine("Треугольник является прямоугольным.");
        }
        else
        {
            Console.WriteLine("Треугольник не является прямоугольным.");
        }

        IShape[] shapes = new IShape[]
        {
            ShapeFactory.CreateShape("circle", 5),
            ShapeFactory.CreateShape("triangle", 3, 4, 5),
            ShapeFactory.CreateShape("triangle", 5, 5, 8)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Площадь фигуры: {shape.GetSquare()}");

            if (shape is Triangle triangleShape)
            {
                Console.WriteLine(triangleShape.IsRightTriangle()
                    ? "Треугольник является прямоугольным."
                    : "Треугольник не является прямоугольным.");
            }
        }
    }
}