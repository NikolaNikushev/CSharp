using System;

class Excercise5HexDecToBin
{
    static void Main()
    {
        Console.Write("hexadecimal number = ");
        string number = Console.ReadLine();
        number = number.ToUpper(); ;
        number = Functions.Functions.Reverse(number);
        string result = "";
        int middleStatus=0;
        int counter = 0;
        string[] letter = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        for (int i = 0; i < number.Length; i++)
        {
            for (int j = 0; j < letter.Length; j++)
            {
                if (Convert.ToString(number[i]) == letter[j])
                {
                    middleStatus = j;
                    for (int binCount = 0; binCount <= 3; binCount++)
                    {
                        result += middleStatus%2;
                        middleStatus /= 2;
                        counter++;
                        if (counter % 4 == 0) result += " ";
                    }
                }
            }
        }
        Console.WriteLine("binary representation of your number = {0}", Functions.Functions.Reverse(result));
    }
}
