using System;
using Functions;

class Excercise3DecToHexDec
{
    static void Main()
    {
        Console.Write("decimal number = ");
        int number = int.Parse(Console.ReadLine());
        string result = "";
        string[] letter={"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F"};
        while (number != 0)
        {
            result+=letter[number%16];
            number /= 16;
            counter++;
        }
        Console.WriteLine("hexadecimal representation of your number = {0}", Functions.Functions.Reverse(result));
    }
}
