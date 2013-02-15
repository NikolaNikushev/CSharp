using System;
using System.Collections.Generic;

class IncreasingSequence
{

    static void Main()
      {
        int n = 10;
        int[] array = new int[n];
        string display = "";
        string maxDisplay = "";
        Console.WriteLine("Enter 10 numbers:");
        int counter = 0, maxCounter = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            
            if (array[i] < array[i + 1])
            {
                counter++;
                display += array[i] + " ";
            }
            else
            {
                if (maxCounter < counter)
                {
                   
                    maxCounter = counter;
                    display += array[i] + " ";
                    maxDisplay = display;

                }
                display = "";
                counter = 1;
            }
        }
       
        if (maxCounter < counter)
        {
            display += array[array.Length - 1];
            maxDisplay = display;
        }
        Console.Write("{" + maxDisplay + "}");
      
    }
}

