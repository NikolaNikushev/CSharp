using System;
using System.IO;

class Excercise5TextFileMatrixSearchMaxSumInSquare
{
    static int FindSquareBestSum(int upLeft, int upRight, int downLeft, int downRight, int bestSum)
    {

        if (upRight+upLeft+downLeft+downRight > bestSum)
            bestSum = upRight + upLeft + downLeft + downRight;
        return bestSum;
    }
    static void GenerateRandomNumbers(int n)
    {
        StreamWriter writeToMatrix = new StreamWriter("matrix.txt");
        using (writeToMatrix)
            {
            Random generator = new Random();
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    number = generator.Next(0, 1000);
                    writeToMatrix.Write(number + " ");
                }
                writeToMatrix.WriteLine();
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Random generated numbers, or you will input? : ( random / anything else ) : ");
        string input=Console.ReadLine();
        input = input.ToLower();
        Console.Write("(up to 100) n= ");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        if (input == "random")
        {
            GenerateRandomNumbers(n);
        }
        else
        {
            StreamWriter writeToMatrix = new StreamWriter("matrix.txt");
            using (writeToMatrix)
            {
                int number;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        number = int.Parse(Console.ReadLine());;
                        writeToMatrix.Write(number + " ");
                    }
                    writeToMatrix.WriteLine();
                }
            }
        }
        StreamReader reader = new StreamReader("matrix.txt");
        int currentArrayPositionX = 0, currentArrayPositionY = 0;
        int newRow = 0;
        using (reader)
        {
            int currentPosition = 0;
            string digits = "";
            string line1 = reader.ReadLine();
            while (line1 != null)
            {
                if (currentArrayPositionY != n)
                {
                    while ((char)line1[currentPosition] != '\n')
                    {
                        if (newRow == n) break;
                        digits += line1[currentPosition];
                        currentPosition++;
                        if (line1[currentPosition] == ' ')
                        {
                            array[currentArrayPositionY, currentArrayPositionX] = int.Parse(digits);
                            digits = "";
                            currentArrayPositionX++;
                            if (currentArrayPositionX == n)
                            {
                                currentArrayPositionX = 0;
                                currentArrayPositionY++;
                                currentPosition = 0;
                                newRow++;
                                break;
                            }
                        }
                    }
                }
                line1 = reader.ReadLine();
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        int bestSum = int.MinValue;
        for (int row = 0; row < array.GetLength(0) - 1; row++)
            for (int col = 0; col < array.GetLength(1) - 1; col++)
            {
                bestSum = FindSquareBestSum(array[row, col], array[row, col + 1] , array[row + 1, col] , array[row + 1, col + 1], bestSum);
            }
        Console.WriteLine("Best sum = {0}", bestSum);
    }
}
