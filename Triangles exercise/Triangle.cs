using System.Windows;

namespace Triangles_exercise;

public class Triangle
{
    public Triangle(Point pointA, Point pointB, Point pointC)
    {
        PointA = pointA;
        PointB = pointB;
        PointC = pointC;
        LengthAB = GetSideLength(PointA, PointB);
        LengthBC = GetSideLength(PointB, PointC);
        LengthCA = GetSideLength(PointC, PointA);
    }

    public Point PointA { get; set; }
    public Point PointB { get; set; }
    public Point PointC { get; set; }

    public double LengthAB { get; }

    public double LengthBC { get; }

    public double LengthCA { get; }

    private double GetSideLength(Point point1, Point point2)
    {
        return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
    }

    public bool IsEquilateral()
    {
        return LengthAB.IsAlmostEqual(LengthBC) && LengthAB.IsAlmostEqual(LengthCA);
    }

    public bool IsIsosceles()
    {
        return LengthAB.IsAlmostEqual(LengthBC) || LengthBC.IsAlmostEqual(LengthCA) || LengthAB.IsAlmostEqual(LengthCA);
    }

    public bool IsRight()
    {
        return IsRight(LengthAB, LengthBC, LengthCA) ||
               IsRight(LengthBC, LengthAB, LengthCA) ||
               IsRight(LengthCA, LengthAB, LengthBC);
    }

    private bool IsRight(double length1, double length2, double length3)
    {
        return length1.IsAlmostEqual(Math.Sqrt(Math.Pow(length2, 2) + Math.Pow(length3, 2)));
    }

    public double Perimeter()
    {
        return LengthAB + LengthBC + LengthCA;
    }
}