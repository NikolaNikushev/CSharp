using System;

class Excercise4TriangleSurface
{
    static double SurfaceOfTriangleWithSideAndAngle(double side, double altitude)
    {
        double S = side * altitude / 2;
        return S;
    }
    static double SurfaceOfTriangleWith3Sides(double side1, double side2, double side3)
    {
        double p = (side1 + side2 + side3) / 2;
        double S = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        return S;
    }
    static double SurfaceOfTriangleWith2SidesAndAngle(double side1, double side2, double angle)
    {
        double side3 = Math.Sqrt(side1 * side1 + side2 * side2 - 2 * side1 * side2 * Math.Cos(angle));
        double S = SurfaceOfTriangleWith3Sides(side1, side2, side3);
        return S;
    }
    static void Main()
    {
        double S = 0;
        Console.Write("Side = ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Altitude = ");
        double altitude = double.Parse(Console.ReadLine());
        S = SurfaceOfTriangleWithSideAndAngle(side1, altitude);
        Console.WriteLine("Surface= {0}", S);
        Console.Write("Side 1 = ");
        side1 = double.Parse(Console.ReadLine());
        Console.Write("Side 2 = ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Side 3 = ");
        double side3 = double.Parse(Console.ReadLine());
        S = SurfaceOfTriangleWith3Sides(side1, side2, side3);
        Console.WriteLine("Surface= {0}", S);
        Console.Write("Side 1 = ");
        side1 = double.Parse(Console.ReadLine());
        Console.Write("Side 2 = ");
        side2 = double.Parse(Console.ReadLine());
        Console.Write("Angle between = ");
        double angle = int.Parse(Console.ReadLine());
        S = SurfaceOfTriangleWith2SidesAndAngle(side1, side2, angle);
        Console.WriteLine("Surface= {0}", S);
        // Why is Cos(any angle) not == to any of the MATH values from real life!?
    }
}
