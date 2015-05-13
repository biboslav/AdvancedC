using System;

class MaximalSum
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        int rows = input[0];
        int cols = input[1];

        int[,] source = new int[rows, cols];
        int[,] square = new int[3, 3]; //tyrsenata platforma

        for (int i = 0; i < rows; i++)
        {
            input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);

            for (int j = 0; j < cols; j++)
            {
                source[i, j] = input[j];
            }
        }
        int max = int.MinValue;


        for (int row = 0; row < rows - 2; row++) // platform -1 za da nqma izlizane ot matricata 
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int sum = SumSquare(source, row, col);
                if (sum > max)
                {
                    max = sum;
                    square = StoreSquare(source, row, col);
                }

            }
        }
       
        Console.WriteLine("Sum = " + max);
        PrintMatrix(square);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static int SumSquare(int[,] source, int row, int col)
        {
            int sum = 0;
            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    sum += source[i, j];
                }
            }
            return sum;
        }

    static int[,] StoreSquare(int[,] source, int row, int col)
        {
            int[,] TempMat = new int[3,3] ;
            for (int i = row, k = 0; i < row + 3; i++, k++)
            {
                for (int j = col, l = 0; j < col +3; j++, l++)
                {
                    TempMat[k, l] = source[i, j];
                }
            }
            return TempMat;
        }
}

