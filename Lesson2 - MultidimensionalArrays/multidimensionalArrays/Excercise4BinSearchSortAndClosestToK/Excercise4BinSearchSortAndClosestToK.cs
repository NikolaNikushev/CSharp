using System;

class Excercise4BinSearchSortAndClosestToK
{
    static void Main()
    {
        Console.Write("Amount of integers= ");
        int amount = int.Parse(Console.ReadLine());
        Console.Write("Number ( K ) to search: ");
        int k = int.Parse(Console.ReadLine());
        int[] integers = new int [amount];
        for (int i = 0; i < amount; i++)
        {
            Console.Write("Integer {0} =",i+1);
            integers[i]=int.Parse(Console.ReadLine());
        }
        Array.Sort(integers);
        int result = 0;
        int indexOfK;
        if (integers[0] > k)
        {
            Console.WriteLine("There is not integer, less or equal to K");
        }
        else
        {
            indexOfK = Array.BinarySearch(integers, k);
            if (indexOfK >= 0)
            {
                result = integers[indexOfK];
            }
            else
            {
                result = integers[~indexOfK - 1];
            }
            Console.WriteLine("Nearst to K is {0}", result);
        }
    }
}