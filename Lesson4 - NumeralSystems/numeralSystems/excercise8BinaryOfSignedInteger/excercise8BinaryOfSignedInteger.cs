using System;

class Excercise8BinaryOfSignedInteger
{
    static void Main()
    {
        Console.Write("number = ");
        ushort number = ushort.Parse(Console.ReadLine());
        string result = "";
        int counter = 0;
        while (number != 0)
        {
            result += number % 2;
            number /= 2;
            counter++;
            if (counter % 4 == 0) result += " ";
        }
        Console.WriteLine("binary representation of your number = {0}", Functions.Functions.Reverse(result));
    }
}
