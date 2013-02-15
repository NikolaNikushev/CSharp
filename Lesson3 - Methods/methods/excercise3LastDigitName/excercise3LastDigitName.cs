using System;

class Excercise3LastDigitName
{
    static string lastDigitName(int number)
    {
        int digit = number % 10;
        if (digit == 0) return "0, zero";
        if (digit == 1) return "1, one";
        if (digit == 2) return "2, two";
        if (digit == 3) return "3, three";
        if (digit == 4) return "4, four";
        if (digit == 5) return "5, five";
        if (digit == 6) return "6, six";
        if (digit == 7) return "7, seven";
        if (digit == 8) return "8, eight";
        if (digit == 9) return "9, nine";
        return "Error";
    }
    static void Main()
    {
        Console.Write("Enter integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit of {0} is : {1}", integer, lastDigitName(integer));
    }
}
