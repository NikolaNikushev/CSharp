//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} --> {2, 2, 2}.

using System;

class MaximumEqualElements
{
    static void Main()
    {
        int n = 10;
        int[] array = new int[n];
        int display = 0;
        int[] numbers = new int[n];
        Console.WriteLine("Enter {0} numbers:", n);
        int counter = 0, maxCounter = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < n; i++)
        {
            
            if (array[i - 1] == array[i])
            {
                counter++;
            }
            else
            {
                if (maxCounter < counter)
                {
                    
                    display = array[i - 1];
                                     
                    maxCounter = counter;

                }
               
                counter = 1;
            }
        }
        Console.Write("{");
        for (int j = 0; j < maxCounter; j++)
        {
            Console.Write(display);
        }
       Console.Write("}"); 
      
 
    }
}

