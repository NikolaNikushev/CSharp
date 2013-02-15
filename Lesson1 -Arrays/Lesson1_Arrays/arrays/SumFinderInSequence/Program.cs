using System;

class SumFinderInSequence
{
    static void Main()
    {
        Console.Write("Enter the array max: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the sum you wish to find: ");
        int sumFind = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number{0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        string result = "";
        for (int i = 0; i < array.Length; i++)
        {
            if (sum == sumFind)
            {
                Console.WriteLine("{" + result + "}");
                break;
            }
            for (int j = i; j < array.Length; j++)
            {

                sum += array[j];
                result += array[j] + ", ";
                if (sum == sumFind)
                {
                    result += "\b\b";
                    break;
                }
                if (sum > sumFind)
                {
                    result = "";
                    sum = 0;
                    break;
                }


            }
        }
    }
}

