using System;

class Excercise5BiggerThanNeighbors
{
    static bool biggerThanNeighbours(int previous, int current, int next)
    {
        if (current > previous && current > next) return true;
        return false;
    }
    static void Main()
    {
        bool result = false;

        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("The position to search = ");

        int positionToSearch;

        do
        {
            positionToSearch = int.Parse(Console.ReadLine());
            if (positionToSearch < 1 || positionToSearch > length - 2) Console.Write("Enter a position, from 1 to {0}, so that it can have 2 neighbours :", length-2);
        } while (positionToSearch < 1 || positionToSearch > length - 2);

        Console.WriteLine("Enter the array's integers: ");
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("integer {0} = ", i+1);
            array[i] = int.Parse(Console.ReadLine());
        }
        result = biggerThanNeighbours(array[positionToSearch-1], array[positionToSearch], array[positionToSearch+1]);
        if (result)
        {
            Console.WriteLine("Yes, the number at position {0} , {1} , is bigger than it's neighbours, {2} and {3}", positionToSearch, array[positionToSearch], array[positionToSearch-1], array[positionToSearch+1] );
        }
        else
        {
            Console.WriteLine("No, the number at position {0}, {1}, is not bigger than it's neighbours, {2} and {3}", positionToSearch, array[positionToSearch], array[positionToSearch - 1], array[positionToSearch + 1]);
        }
    }
}
