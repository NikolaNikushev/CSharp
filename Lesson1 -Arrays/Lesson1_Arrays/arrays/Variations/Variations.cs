using System;

class Variations
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {

            for (int j = 1; j <= n; j++)
            {
                Console.Write("{ ");
                Console.Write("{0}, ", i);
                Console.Write("{0}", j);
                Console.Write(" }");

            }

        }
        Console.WriteLine();
    }
}
