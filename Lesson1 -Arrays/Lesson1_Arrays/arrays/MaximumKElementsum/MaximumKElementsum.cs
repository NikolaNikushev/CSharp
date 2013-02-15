using System;

class MaximumKElementsum
{
    static void Main()
    {
        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k= ");
        int k = int.Parse(Console.ReadLine());     
 
        int[] array = new int[n];
        int currentSum = 0;
        int maxSum = int.MinValue;
        int start = 0;
        int result = 0;

        Console.WriteLine("Enter {0} numbers:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length ; i++)
        {
            if (i + k - 1 < array.Length)
            {
                if (i == 0)
                {                   
                    for (int j = 0; j < k; j++)
                    {
                        currentSum += array[i + j];
                        maxSum = currentSum;

                    }
                }
                else
                {
                    maxSum = (maxSum - array[i - 1]) + array[i + k - 1];

                }
            }
            
            if (maxSum > result)
            {
                result = maxSum;
            }

        }
        Console.WriteLine(result);
       

    }
}

