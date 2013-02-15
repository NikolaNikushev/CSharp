using System;

class resultSum
{
    static void Main()
    {
        Console.Write("Enter the wanted sum of the results: ");
        int Sum = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of elements: ");
        int maxNumbers = int.Parse(Console.ReadLine());
        int[] array = new int[maxNumbers];
        int counter = 0;
        string result = "";
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Number[{0}] = ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= (int)Math.Pow(2, maxNumbers) - 1; i++)
        {
            result = "";
            int checker = 0;
            for (int j = 0; j <= maxNumbers; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checker += array[j];
                    result += " " + array[j];
                }
            }
            if (checker == Sum)
            {
                Console.WriteLine("This result has a sum of {0} : {1} ", Sum, result);
                counter++;
               
            }
        }
        Console.WriteLine("Number of subest that have the sum of {0} are {1}", Sum, counter);
        
    }
}