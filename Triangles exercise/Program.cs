using System.Windows;
using Triangles_exercise;

var pointA = RequestPoint("A");
var pointB = RequestPoint("B");
var pointC = RequestPoint("C");
var triangle = new Triangle(pointA, pointB, pointC);

Console.WriteLine($"Length of AB is:{triangle.LengthAB.ToString()}");
Console.WriteLine($"Length of BC is:{triangle.LengthBC.ToString()}");
Console.WriteLine($"Length of CA is:{triangle.LengthCA.ToString()}");

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

Console.WriteLine($"Triangle is {(triangle.IsEquilateral() ? "" : "NOT")} Equilateral");
Console.WriteLine($"Triangle is {(triangle.IsIsosceles() ? "" : "NOT")}Isosceles");
Console.WriteLine($"Triangle is {(triangle.IsRight() ? "" : "NOT")}Right");
Console.WriteLine($"Perimeter:{triangle.Perimeter()}");

var perimeter = triangle.Perimeter();
for (var i = 0; i <= perimeter; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);