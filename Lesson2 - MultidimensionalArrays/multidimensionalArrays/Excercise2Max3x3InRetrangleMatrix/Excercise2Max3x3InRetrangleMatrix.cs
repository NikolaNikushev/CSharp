using System;

class Excercise2Max3x3InRetrangleMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Rows= ");
        int n;
        do
        {
            n = int.Parse(Console.ReadLine());
            if (n < 3) Console.Write("Rows must be more than or eqal to 3, for a square, RETRY: ");
        } while (n < 3);
        Console.Write("Columns= ");
        int m;
        do
        {
            m = int.Parse(Console.ReadLine());
            if (m == n) Console.Write("Rows must not be Equal to Columns for a retrangle, RETRY: ");
            if (m < 3) Console.Write("Columns must be more than or equal to 3, for a square, RETRY: ");
        } while (m < 3 || m==n);
        int[,] matrix = new int[n, m];
        int bestSum = int.MinValue;
        int[,] square = new int[3, 3];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Element {0} {1}= ",i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int row1 = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                int row2 = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                int row3 = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                int sum = row1 + row2 + row3;
                if (sum > bestSum)
                {
                    bestSum = sum;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            square[i, j] = matrix[row+i, col+j];
                        }
                    }
                }
            }
        }
        Console.WriteLine("From this matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,5}",matrix[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Maximal sum= {0}", bestSum);
        Console.WriteLine("It consists of:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0,5}", square[i, j]);
            }
            Console.WriteLine();
        }
    }
}
