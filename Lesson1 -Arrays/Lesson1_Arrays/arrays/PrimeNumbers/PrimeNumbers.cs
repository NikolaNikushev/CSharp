using System;

class PrimeNumbers
{
    static void Main()
    {
        bool[] array = new bool[100000000];
        for (int i = 2; i < Math.Sqrt(array.Length); i++)
        {
            if (array[i] == false)
            {
                for (int j = i * i; j < array.Length; j = j + i)
                {
                    array[j] = true;
                }
            }
        }
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == false)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}