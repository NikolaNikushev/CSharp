using System;

class Excercise2BinToDec
{
    
    static void Main()
    {
        Console.Write("bin number = ");
        string number = Console.ReadLine();
        number=Functions.Functions.Reverse(number);
        if (number.Length % 4 != 0)
        {
            for (int i = 0; i < number.Length % 4; i++)
            {
                number += "0";
            }
        }
        int result=0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '1')
            {
                result += (int)Math.Pow(2, i);
            }
        }
        Console.WriteLine("decimal representation of your number = {0}", result);
    }
}