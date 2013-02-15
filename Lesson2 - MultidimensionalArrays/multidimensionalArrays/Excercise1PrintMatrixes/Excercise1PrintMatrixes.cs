using System;

class Excercise1PrintMatrixes
{
    //A Top-Bot
    static void PrintTopBottomMatrix()
    {
        int n;
        do
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("N must be n>0");
            }
        } while (n < 0);
        int[,] matrix = new int[n, n];
        int column=0, row=0;
        int printNumber = 1;
        for (column = 0; column < n; column++)
        {
            for (row = 0; row < n; row++)
            {
                matrix[row, column] = printNumber;
                printNumber++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    //B Top-Bot-Top
    static void PrintTopBottomTopMatrix()
    {
        int n;
        do
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("N must be n>0");
            }
        } while (n < 0);
        int[,] matrix = new int[n, n];
        int column = 0, row = 0;
        int printNumber = 1;
        while (printNumber < n * n)
        {
            //Down
            while (row < n)
            {
                matrix[row, column] = printNumber;
                printNumber++;
                row++;
            }
            column++;
            row--;
            if (column == n) break;
            //Up
            while (row >= 0)
            {
                matrix[row, column] = printNumber;
                printNumber++;
                row--;
            }
            row++;
            column++;
            if (column == n) break;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    //C Neighbours
    static void PrintNeighboursMatrix()
    {
        int n;
        do
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("N must be n>0");
            }
        } while ( n < 0);
        int[,] matrix = new int[n, n];
        int printNumber = 1;
        //BottomPart
        for (int row = 0; row <= n - 1; row++)
        {
            for (int column = 0; column <= row; column++)
            {
                matrix[n - row + column - 1, column] = printNumber++;
            }
        }
        //TopPart
        for (int row = n - 2; row >= 0; row--)
        {
            for (int column = row; column >= 0; column--)
            {
                matrix[row - column, n - column - 1] = printNumber++;
            }
        }
        //print
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    //D SpiralCounterClockwise
    static void PrintSpiralCounterClockwiseMatrix()
    {
        int n;
        do
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            if ( n < 0)
            {
                Console.WriteLine("N must be n>0");
            }
        } while ( n < 0);
        int[,] matrix = new int[n, n];
        int printNumber = 0;
        int column = 0, row = 0, currentColumn = n, currentRow = n;
        while (printNumber < n * n)
        {
            //Down
            while (column == n-currentColumn && row <= currentRow)
            {
                if (row == currentRow)
                {
                    column++;
                    row--;
                    break;
                }
                else
                {
                    printNumber++;
                    matrix[row, column] = printNumber;
                    row++;
                }
            }
            //ToRight
            while (column <= currentColumn && row < currentRow)
            {
                if (column == currentColumn)
                {
                    row--;
                    column--;
                    break;
                }
                else
                {
                    printNumber++;
                    matrix[row, column] = printNumber;
                    column++;
                }
            }
            //Up
            while (column == currentColumn-1 && row >= n - currentRow-1)
            {
                if (row == n - currentRow-1)
                {
                    column--;
                    row++;
                    break;
                }
                else
                {
                    printNumber++;
                    matrix[row, column] = printNumber;
                    row--;
                }
            }
            //Left
            while (column >= n - currentColumn && row > n-currentRow - 1)
            {
                if (column == n - currentColumn)
                {
                    row++;
                    column++;
                    break;
                }
                else
                {
                    printNumber++;
                    matrix[row, column] = printNumber;
                    column--;
                }
            }

            currentColumn--;
            currentRow--;
        }
        //print
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    
    static void Main()
    {
        start:
        Console.WriteLine("1 Top-Bot\n2 Top-Bot-Top\n3 Neighbours\n4 SpiralCounterClockwise");
        Console.Write("What do you wish to print? (1, 2, 3, 4): ");
        int input=0;
        string retry="";
        do
        {
            input = int.Parse(Console.ReadLine());
            if (input < 1 || input > 4) Console.Write("Invalid input! Try again: ");
        }while (input < 1 || input > 4);
        switch (input)
        {
            case 1:
                Console.WriteLine("Top-Bottom Matrix:");
                PrintTopBottomMatrix();
        break;
            case 2:
                Console.WriteLine("Top-Bottom-Top Matrix:");
                PrintTopBottomTopMatrix();
        break;
            case 3:
                Console.WriteLine("Neighbours Matrix:");
                PrintNeighboursMatrix();
        break;
            case 4: 
                Console.WriteLine("Spiral Matrix, Counter Clockwise:");
                PrintSpiralCounterClockwiseMatrix();
        break;
            default:Console.WriteLine("How did you get past the while!?");
        break;
        }
        Console.Write("Retry?(yes/no) : ");
        retry:
        retry = Console.ReadLine();
        retry = retry.ToLower();
        if (retry=="yes") 
        {
            Console.WriteLine();
            goto start;
        }
        if (retry == "no")
        {
            Console.WriteLine();
            goto end;
        }
        else 
        {
            Console.Write("Yes or No, please : ");
            goto retry;
        }
        end:
        Console.WriteLine();
    }
}