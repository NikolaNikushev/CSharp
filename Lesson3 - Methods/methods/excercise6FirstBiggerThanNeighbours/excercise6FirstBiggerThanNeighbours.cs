using System;

class Excercise6FirstBiggerThanNeighbours
{
    static int biggerThanNeighbours(int previous, int current, int next, int i)
    {
        if (current > previous && current > next) return i;
        return -1;
    }
    static void Main()
    {
        int index=-1;
        int indexCheckpoint = -1;

        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the array's integers: ");
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("integer {0} = ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = length-2; i > 0; i--)
        {
            index = biggerThanNeighbours(array[i+1], array[i], array[i-1], i);
            if (index != -1) indexCheckpoint = i;
        }
        if(indexCheckpoint!=-1)
        Console.WriteLine("The 1st integer from the array, that is greater than it's neighbours has index = {0}", indexCheckpoint);
        else
        {
            Console.WriteLine("No such integer exists in the given array, that is greater than it's Neighbours.");
        }
    }
}