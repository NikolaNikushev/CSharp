//Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareArrayElements
{
    static void Main()
    {
        Console.Write("How many numbers will each array contaion?\nn = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int[] array2 = new int[n];
        Console.WriteLine("Enter array1's numbers:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter array2's numbers:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i] == array2[j])
                {
                    Console.WriteLine("{0} = {1}", array[i], array2[j]);
                }
                else if (array[i] > array2[j])
                {
                    Console.WriteLine("{0} > {1}", array[i], array2[j]);
                }
                else
                {
                    Console.WriteLine("{0} < {1}", array[i], array2[j]);
                }
            }
        }
    }
}

