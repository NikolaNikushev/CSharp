using System;
using System.Collections.Generic;

class Excercise11AddTwoPolynomials
{
    static void PrintPolynom(int x2, int x1, int y)
    {
        Console.WriteLine("{0}x^2 + {1}x + {2}", x2, x1, y);
    }
    static int Sum(int value1, int value2)
    {
        int sum;
        sum = value1 + value2;
        return sum;
    }
    static int Substract(int value1, int value2)
    {
        int sub;
        sub = value1 - value2;
        return sub;
    }
    static int Multiply(int value1, int value2)
    {
        int pro;
        pro = value1 * value2;
        return pro;
    }
    static void Main()
    {
        Console.WriteLine("Enter 1-st polynomial: ");
        Console.WriteLine("Enter the missing coefficents ( Y ): ");
        int[,] coefficents = new int[3, 2];
        Console.Write(" Yx^2 = ");
        coefficents[0, 0]=int.Parse(Console.ReadLine());
        Console.Write(" Yx^1 = ");
        coefficents[1, 0] = int.Parse(Console.ReadLine());
        Console.Write(" free member : Y  = ");
        coefficents[2, 0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2-nd polynomial: ");
        Console.Write(" Yx^2 = ");
        coefficents[0, 1] = int.Parse(Console.ReadLine());
        Console.Write(" Yx^1 = ");
        coefficents[1, 1] = int.Parse(Console.ReadLine());
        Console.Write(" free member : Y  = ");
        coefficents[2, 1] = int.Parse(Console.ReadLine());
        PrintPolynom(coefficents[0, 0], coefficents[1, 0], coefficents[2, 0]);
        PrintPolynom(coefficents[0, 1], coefficents[1, 1], coefficents[2, 1]);
        int[] result = new int[3];
        Console.WriteLine("Sum= ");
        for (int i = 0; i < 3; i++)
        {
            result[i] = Sum(coefficents[i, 0], coefficents[i, 1]);
        }
        PrintPolynom(result[0], result[1], result[2]);
        Console.WriteLine("Difference= ");
        for (int i = 0; i < 3; i++)
        {
            result[i] = Substract(coefficents[i, 0], coefficents[i, 1]);
        }
        PrintPolynom(result[0], result[1], result[2]);
        Console.WriteLine("Product= ");
        for (int i = 0; i < 3; i++)
        {
            result[i] = Multiply(coefficents[i, 0], coefficents[i, 1]);
        }
        PrintPolynom(result[0], result[1], result[2]);
        Console.WriteLine();
    }
}
