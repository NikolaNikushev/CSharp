using System;

class Excercise6BinToHexDec
{
    static void Main(string[] args)
    {
            
        Console.Write("binary number = ");
        string number = Console.ReadLine();
        if (number.Length % 4 != 0)
        {
            number=Functions.Functions.Reverse(number);
            for (int i = 0; i < number.Length % 4; i++)
            {
                number += "0";
            }
            number = Functions.Functions.Reverse(number);
        }
        string currentResult="";
        string result = "";
        string[] letter = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        string[] binary = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
        for (int i = 0; i < number.Length; i++)
        {
            currentResult = "";
            for (int j = 0; j <= 3; j++)
            {
                currentResult += number[i + j];
                if(j==3)i+=3;
            }
            for (int j = 0; j < letter.Length; j++)
            {
                if (currentResult == binary[j])
                {
                    result += letter[j];
                    break;
                }
            }
        }
        Console.WriteLine("hexadecimal representation of your number = {0}", result);
    }
}
