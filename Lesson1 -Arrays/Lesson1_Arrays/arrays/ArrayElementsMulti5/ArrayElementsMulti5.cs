//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
using System;

class ArrayElementsMulti5
{
    static void Main()
    {
        int[] array = new int[20];
        Console.WriteLine("Enter 20 numbers.");
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Your numbers multiplied by 5, shown in groups of 5, will be:");
        for (int i = 0; i < 20; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine();
            }
            Console.Write(array[i] *5 + " ");           
        }
        Console.WriteLine();
    }
}

