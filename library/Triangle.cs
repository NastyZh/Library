namespace library;

public class Triangle:IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }
    public double P { get; }
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0) throw new ArgumentException("Sides must be greater than zero.");
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA) throw new ArgumentException("The given sides do not form a valid triangle.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        P = (sideA + sideB + sideC)/2;
    }
    
    public double GetSquare()
    {
        return  Math.Sqrt(P * (P - SideA) * (P - SideB) * (P - SideC));
    }
    
    public bool IsRightTriangle()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
    }
}