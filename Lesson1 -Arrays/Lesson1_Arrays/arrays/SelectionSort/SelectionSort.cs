using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
      
        Console.WriteLine("Enter {0} numbers:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        for (int i = 0; i < n; i++)
        {
            Console.Write(" {0} ", array[i] );
        }
    }
}
