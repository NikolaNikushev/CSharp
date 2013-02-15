using System;

class Excercise4HexDecToDec
{
    static void Main()
    {
        Console.Write("hexadecimal number = ");
        string number = Console.ReadLine();
        number = number.ToUpper(); ;
        number = Functions.Functions.Reverse(number);
        int result = 0;
        string[] letter = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        for(int i=0;i<number.Length;i++)
        {
            for (int j = 0; j < letter.Length; j++)
            {
                if (Convert.ToString(number[i]) == letter[j])
                {
                    result += j*(int)Math.Pow(16,i);
                }
            }
        }
        Console.WriteLine("decimal representation of your number = {0}", result);
    }
}
