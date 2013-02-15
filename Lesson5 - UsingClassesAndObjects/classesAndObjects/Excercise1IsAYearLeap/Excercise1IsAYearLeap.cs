using System;

class Excercise1IsAYearLeap
{
    static void Main()
    {
        Console.Write("Enter year:");
        Console.WriteLine("Is it leap? : {0}",DateTime.IsLeapYear(int.Parse(Console.ReadLine())));
    }
}
