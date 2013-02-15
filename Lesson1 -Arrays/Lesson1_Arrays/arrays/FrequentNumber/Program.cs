//13
//4
//1
//1
//4
//2
//3
//4
//4
//1
//2
//4
//9
//3
using System;

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Amount = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        int counter = 0;
        int number = array[0];
        int maxCounter = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
                if (maxCounter <= counter)
                {
                    maxCounter = counter;
                    number = array[i];
                }
            }
            else
            {
                counter = 1;
            }
        }
        Console.WriteLine(number);

    }
}

