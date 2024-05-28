namespace library;

public class ShapeFactory
{
    public static Circle CreateCircle(int r)
    {
        return new Circle(r);
    }

    public static Triangle CreateTriangle(double a, double b, double c)
    {
        return new Triangle(a, b, c);
    }

    public static IShape CreateShape(string shapeType, params double[] parameters)
    {
        return shapeType.ToLower() switch
        {
            "circle" when parameters.Length == 1 => new Circle((int)parameters[0]),
            "triangle" when parameters.Length == 3 => new Triangle(parameters[0], parameters[1], parameters[2]),
            _ => throw new ArgumentException("Invalid shape type or parameters")
        };
    }
}