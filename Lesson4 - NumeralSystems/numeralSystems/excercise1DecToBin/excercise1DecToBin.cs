using System;

class Excercise1DecToBin
{
    static void Main()
    {
        Console.Write("decimal number = ");
        int number = int.Parse(Console.ReadLine());
        string result = "";
        int counter = 0;
        while (number != 0)
        {
            result += number % 2;
            number /= 2;
            counter++;
            if (counter % 4 == 0) result += " ";
        }
        Console.WriteLine("binary representation of your number = {0}",Functions.Functions.Reverse(result));
    }
}
