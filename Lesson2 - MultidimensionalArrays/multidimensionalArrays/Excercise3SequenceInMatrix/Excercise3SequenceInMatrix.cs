using System;

class Excercise2Max3x3InRetrangleMatrix
{
    static void Main(string[] args)
    {
        string sequenceElement = "";
        Console.Write("Rows= ");
        int n;
        int sequenceMax = 0;
        do
        {
            n = int.Parse(Console.ReadLine());
            if (n < 1) Console.Write("Rows must not be negative or 0, RETRY: ");
        } while (n < 1);
        Console.Write("Columns= ");
        int m;
        do
        {
            m = int.Parse(Console.ReadLine());
            if (m < 1) Console.Write("Columns must not be negative or 0, RETRY: ");
        } while (m < 1);
        string[,] matrix = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Element {0} {1}= ", i, j);
                matrix[i, j] = Console.ReadLine();
                
            }
        }
        int verticalCounter=1, verticalCounterMax=1;
        int horizontalCounter=1, horizontalCounterMax=1;
        int diagonalCounter=1, diagonalCounterMax=1;
        
        //Horizontal
        for (int row = 0; row < n; row++)
        {
            horizontalCounter = 1;
            for (int col = 0; col < m-1; col++)
            {
                if (matrix[row, col] == matrix[row, col+1])
                {
                    horizontalCounter++;
                    if (horizontalCounter > horizontalCounterMax)
                    {
                        horizontalCounterMax = horizontalCounter;
                        sequenceElement = matrix[row, col];
                    }
                }
                else
                {
                    horizontalCounter = 1;
                }
            }
        }
        //Vertical
        for (int col = 0; col < m; col++)
        {
            verticalCounter = 1;
            for (int row = 0; row < n-1; row++)
            {
                if (matrix[row, col] == matrix[row+1, col])
                {
                    verticalCounter++;
                    if (verticalCounter > verticalCounterMax)
                    {
                        verticalCounterMax = verticalCounter;
                        if(verticalCounterMax>horizontalCounterMax)
                        sequenceElement = matrix[row, col];
                    }
                }
                else
                {
                    verticalCounter = 1;
                }
            }
        }
        //Diagonal Right
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                diagonalCounter = 1;
                for (int number = 1; number < n - row && number < n-col; number++)
                {
                    if (matrix[row, col] == matrix[col + number, col + number])
                    {
                        diagonalCounter++;
                        if (diagonalCounter > diagonalCounterMax)
                        {
                            diagonalCounterMax = diagonalCounter;
                            if (diagonalCounterMax > verticalCounterMax)
                                sequenceElement = matrix[row, col];
                            if (diagonalCounterMax > horizontalCounterMax)
                                sequenceElement = matrix[row, col];
                        }
                    }
                    else
                    {
                        diagonalCounter = 1;
                    }
                }
            }
        }

        for (int row = n-1; row > 0; row--)
        {
            for (int col = m-1; col > 0; col--)
            {
                diagonalCounter=1;
                for (int number = 1; number < n - row && number < n - col; number++)
                {
                    if (matrix[row, col] == matrix[col - number, col - number])
                    {
                        diagonalCounter++;
                        if (diagonalCounter > diagonalCounterMax)
                        {
                            diagonalCounterMax = diagonalCounter;
                            if (diagonalCounterMax > verticalCounterMax)
                                sequenceElement = matrix[row, col];
                            if (diagonalCounterMax > horizontalCounterMax)
                                sequenceElement = matrix[row, col];
                        }
                    }
                    else
                    {
                        diagonalCounter = 1;
                    }
                }
            }
        }
        Console.WriteLine("From this matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,5}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        if(verticalCounterMax>=horizontalCounterMax)
        {
            if(verticalCounterMax>=diagonalCounterMax)
            {
                sequenceMax=verticalCounterMax;
            }
        }
        if(horizontalCounterMax>=verticalCounterMax)
        {
            if(horizontalCounterMax>=diagonalCounterMax)
            {
                sequenceMax=horizontalCounterMax;
            }
        }
        if(diagonalCounterMax>=horizontalCounterMax)
        {
            if(diagonalCounterMax>=verticalCounterMax)
            {
                sequenceMax=diagonalCounterMax;
            }
        }
        Console.WriteLine("Maximal sequence= {0}", sequenceMax);
        Console.WriteLine("It consists of: {0}", sequenceElement);
    }
}
