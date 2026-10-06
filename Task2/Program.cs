using System;

class Program
{
    static void Main()
    {
        double radius = 5;

        Console.WriteLine($"PI = {Circle.PI}");
        Console.WriteLine($"Area = {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter = {Circle.CalculatePerimeter(radius)}");
    }
}