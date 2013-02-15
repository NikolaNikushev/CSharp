using System;
using System.Collections.Generic;

class Excercise9MaximumElementInPortion
{
    static int FindMaximalElementFromPortion(int value, int currentMax, int start, int end, int currentPosition)
    {
        if(currentPosition<=end && currentPosition>=start)
        if (value > currentMax) currentMax = value;
        return currentMax;
    }
    static void SortFromMaximal(List<int> integers, int start, int end, int amount)
    {
        int max = int.MinValue;
        for (int i = 0; i < amount; i++)
        {
            for (int j = i + 1; j < amount; j++)
            {
                max = FindMaximalElementFromPortion(integers[j], integers[i], start, end, j);
                if (max > integers[i])
                {
                    integers[j] = integers[i];
                    integers[i] = max;
                }
            }
            start++;
            Console.Write(integers[i] + ", ");
        }
    }
    static void Main()
    {
        Console.Write("How many integers does this array have? : ");
        int amount = int.Parse(Console.ReadLine());
        Console.Write("Start index = ");
        int start = int.Parse(Console.ReadLine());
        while(start>amount) start = int.Parse(Console.ReadLine());
        Console.Write("End index = ");
        int end = int.Parse(Console.ReadLine());
        while(end>=amount||end<start) end = int.Parse(Console.ReadLine());
        List<int> integers = new List<int>();
        int max=int.MinValue;
        for (int i = 0; i < amount; i++)
        {
            Console.Write("Integer {0} = ", i+1);
            integers.Add(int.Parse(Console.ReadLine()));
            max = FindMaximalElementFromPortion(integers[i], max, start, end, i);
        }
        Console.WriteLine("Maximum element = {0}", max);
        start = 0;
        end = amount-1;
        Console.WriteLine();
        Console.WriteLine("Sorted in Descending:");
        SortFromMaximal(integers, start, end, amount);
        Console.WriteLine();
        Console.WriteLine("Sorted in Ascending:");
        for (int i = amount-1; i >= 0; i--)
        {
            Console.Write(integers[i] + ", ");
        }
        Console.WriteLine();
    }
}
