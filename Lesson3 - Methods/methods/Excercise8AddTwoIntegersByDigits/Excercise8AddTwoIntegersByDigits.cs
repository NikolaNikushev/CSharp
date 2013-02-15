using System;
using System.Collections.Generic;

class Excercise8AddTwoIntegersByDigits
{
    static void PrintDigitSum(uint number1, uint number2)
    {
        uint number;
        int length1 = 0;
        int length2 = 0;
        number = number1;
        while (number != 0)
        {
            length1++;
            number /= 10;
        }
        number = number2;
        while (number != 0)
        {
            length2++;
            number /= 10;
        }
        uint[] digits1 = new uint[length1 + 1];
        uint[] digits2 = new uint[length2 + 1];
        int greaterLength;
        if (length1 > length2) greaterLength = length1;
        else greaterLength = length2;
        for (int i = 1; i <= length1; i++)
        {
            digits1[i] = (uint)number1 / (uint)Math.Pow(10, length1 - i);
            number1 -= (uint)Math.Pow(10, length1 - i) * ((uint)number1 / (uint)Math.Pow(10, length1 - i));
        }
        for (int i = 1; i <= length2; i++)
        {
            digits2[i] = (uint)number2 / (uint)Math.Pow(10, length2 - i);
            number2 -= (uint)Math.Pow(10, length2 - i) * ((uint)number2 / (uint)Math.Pow(10, length2 - i));
        }
        uint[] digits1F = new uint[greaterLength];
        for (int i = 0; i < length1; i++)
        {
            digits1F[i] = digits1[i + 1];
        }
        if (length1 < length2) Array.Reverse(digits1F);
        uint[] digits2F = new uint[greaterLength];
        for (int i = 0; i < length2; i++)
        {
            digits2F[i] = digits2[i + 1];
        }
        if (length1 > length2) Array.Reverse(digits2F);
        List<int> result = new List<int>();
        Array.Reverse(digits1F);
        Array.Reverse(digits2F);
        int remainder = 0;
        for (int i = 0; i < greaterLength; i++)
        {
            result.Add((int)digits1F[i] + (int)digits2F[i] + remainder);
            remainder = 0;
            if (result[i] > 9)
            {
                remainder = 1;
                result[i] -= 10;
            }
        }
        if (remainder > 0)
        {
            greaterLength++;
            result.Add(remainder);
        }
        result.Reverse();
        for (int i = 0; i < greaterLength; i++)
        {
            Console.Write("Sum = ", result[i]);
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Console.Write("Integer 1 = ");
        uint number1 = uint.Parse(Console.ReadLine());
        Console.Write("Integer 2 = ");
        uint number2 = uint.Parse(Console.ReadLine());
        PrintDigitSum(number1, number2);
        /*
         * Write a method that adds two positive integer numbers represented
         * as arrays of digits (each array element arr[i] contains a digit;
         * the last digit is kept in arr[0]). Each of the numbers that will
         * be added could have up to 10 000 digits.
         * 
         * NOTE : It says : 2 POSITIVE INTEGERS -> 10 000 digits rule is invalid
         * If it said : 2 REAL numbers -> 10k digits is allowed
         * If that is the case -> The difference is that input = string, and every
         * character is divided into the array.
         */

    }
}
