using System;

class Excercise11ReadNumberPrintVariations
{
    static void Main()
    {
        Console.WriteLine("Enter number :");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Decimal     :{0,15:D}", number);
        Console.WriteLine("Hexadecimal :{0,15:X}", number);
        Console.WriteLine("Percent     :{0,15:P}", number);
        Console.WriteLine("Scientific  :{0,15:E}", number);
    }
}

