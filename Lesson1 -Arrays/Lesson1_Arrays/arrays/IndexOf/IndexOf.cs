using System;

class IndexOf
{
    static void Main()
    {
        Console.Write("Enter the max numbers of the aray: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number that you will be searching for: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i <= n - 1; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(Array.IndexOf(array, k));
        Console.WriteLine(BinarySearch(array, k));
    }
    static int BinarySearch(int[] array, int value)
    {
        int low = 0, high = array.Length - 1, midpoint = 0;

        while (low <= high)
        {
            midpoint = low + (high - low) / 2;

            // check to see if value is equal to item in array
            if (value == array[midpoint])
            {
                return midpoint;
            }
            else if (value < array[midpoint])
                high = midpoint - 1;
            else
                low = midpoint + 1;
        }

        // item was not found
        return -1;
    }
}

