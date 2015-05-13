using System;

class FillMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];

        Console.WriteLine(new string('-', 5 * n));
        FillColRow(matrixA);
        PrintMatrix(matrixA);
        Console.WriteLine(new string('-', 5*n));
        FillDownUp(matrixB);
        PrintMatrix(matrixB);
        Console.WriteLine(new string('-', 5 * n));
    }

    static void FillColRow(int[,] matrix)
    {
        int count = 1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++, count++)
            {
                matrix[j, i] = count;
            }
        }
    }

    static void FillDownUp(int[,] matrix)
    {
        int count = 1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {

            if (i % 2 == 0)
            {
                for (int j = 0; j < matrix.GetLength(0); j++, count++)
                {
                    matrix[j, i] = count;
                }
            }
            else
            {
                for (int j = matrix.GetLength(0) - 1; j >= 0; j--, count++)
                {
                    matrix[j, i] = count;
                }
            }
        }
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
}

