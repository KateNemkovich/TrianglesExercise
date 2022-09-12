using System.Windows;
using Triangles_exercise;

var pointA = RequestPoint("A");
var pointB = RequestPoint("B");
var pointC = RequestPoint("C");
var triangle = new Triangle(pointA, pointB, pointC);

Point RequestPoint(string pointName)
{
    var x = RequestCoordinate("x", pointName);
    var y = RequestCoordinate("y", pointName);
    return new Point(x, y);
}

double RequestCoordinate(string coordinate, string pointName)
{
    Console.WriteLine($"Enter coordinate {coordinate} of dot {pointName}:");

    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out var result)) return result;

        Console.WriteLine("Enter data in numerical format");
    }
}

Console.WriteLine($"Length of AB is:{triangle.LengthAB.ToString()}");
Console.WriteLine($"Length of BC is:{triangle.LengthBC.ToString()}");
Console.WriteLine($"Length of CA is:{triangle.LengthCA.ToString()}");