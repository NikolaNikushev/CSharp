using System;
using System.Numerics;

class Excercise10PermutationsOfAllToN
{
    static BigInteger CalculatePermutation(int i)
    {
        BigInteger result = 1;
        for (int j = 1; j <= i; j++)
        {
            result *= j;
        }
        return result;
    }
    static void Main()
    {
        Console.Write("n= ");
        byte n = byte.Parse(Console.ReadLine());
        for (byte i = 1; i <= n; i++)
        {
            Console.WriteLine("Permutation of {0}= {1}", i, CalculatePermutation(i));
        }
    }
}
