using System;

class MaximalSumSequence
{
    static void Main()
    {
        int n = 10;
        int[] array = new int[n];

        Console.WriteLine("Enter 10 numbers:");
       
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = array[0], maxSum = array[0];
        int counter = 0, counterMax = 0;
        int sequence = 1, lastSequence = 1;

        for (int i = 1; i < array.Length; ++i)
        {

            if (array[i] + maxSum > array[i])
            {

                maxSum += array[i];
              
                lastSequence++;
            }
            else
            {

                maxSum = array[i];
                counter = i;
                lastSequence = 1;
            }
            if (maxSum > sum)
            {
                sum = maxSum;
                sequence = lastSequence;
                counterMax = counter;
            }
        }

        for (int i = counterMax; i < counterMax + sequence; ++i)
        {
            Console.Write("{0} ", array[i]);
        }
    }
}

