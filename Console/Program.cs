using ShapeLibrary;
using ShapeLibrary.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        IShape[] shapes = new IShape[] { new Circle(10), new Triangle(3, 4, 5) };
        // Для вычисления площади фигуры без знания типа фигуры в compile-time использован полиморфизм.
        foreach (IShape shape in shapes)
        {
            Console.WriteLine("Area: " + shape.CalculateArea());
            if (shape is Triangle triangle && triangle.IsRightTriangle())
            {
                Console.WriteLine("This is a right triangle");
            }
        }
    }
}