using ShapeLibrary.Interfaces;
namespace ShapeLibrary;

public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double a, double b, double c)
    {
        if (!IsValidTriangle(a, b, c))
            throw new ArgumentException("Invalid triangle sides");

        _sideA = a;
        _sideB = b;
        _sideC = c;
    }

    public double CalculateArea()
    {
        double p = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }

    public bool IsRightTriangle()
    {
        double[] sides = new double[] { _sideA, _sideB, _sideC };
        Array.Sort(sides);

        return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        return a > 0 
            && b > 0 
            && c > 0 
            && a + b > c 
            && a + c > b 
            && b + c > a;
    }
}