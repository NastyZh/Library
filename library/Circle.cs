namespace library;

public class Circle:IShape
{
    public int Radius { get; }
    
    public Circle(int radius)
    {
        if (radius <= 0) throw new ArgumentException("Radius must be greater than zero.");
        Radius = radius;
    }
    
    public double GetSquare()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}