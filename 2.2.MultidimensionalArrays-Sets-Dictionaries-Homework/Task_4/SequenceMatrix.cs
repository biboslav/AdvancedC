using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceMatrix
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        int rows = input[0], cols = input[1], cnt = 0, maxSeq = 0;
        string OutputElement = "";
        string[,] source = new string[rows, cols];
        //for (int row = 0; row < rows; row++)
        //{
        //    for (int col = 0; col < cols; col++)
        //    {
        //        source[row, col] = Console.ReadLine();
        //    }
        //}

        for (int row = 0; row < rows; row++)
        {
            string[] tmp = Console.ReadLine().Split(' ');
            for (int col = 0; col < cols; col++)
            {
                source[row, col] = tmp[col];
            }
        }

        //PrintMatrix(source);

        for (int row = 0; row < source.GetLength(0); row++)
        {
            for (int col = 0; col < source.GetLength(1) - 1; col++)    
            {
                if ((source[row, col] == source[row, col + 1]))
                {
                    cnt++;
                }
                else
                {
                    cnt = 1;
                }
                if (cnt > maxSeq)
                {
                    maxSeq = cnt;
                    OutputElement = source[row, col];
                }
            }
            cnt = 1;
        }

        for (int col = 0; col < source.GetLength(1); col++)                 //Searching vertically
        {
            for (int row = 0; row < source.GetLength(0) - 1; row++)
            {
                if ((source[row, col] == source[row + 1, col]))
                {
                    cnt++;
                }
                else
                {
                    cnt = 1;
                }
                if (cnt > maxSeq)
                {
                    maxSeq = cnt;
                    OutputElement = source[row, col];
                }
            }
            cnt = 1;
        }


        //Searching diagonally from left to right
        for (int row = 0, col = 0; row < source.GetLength(0) - 1 && col < source.GetLength(1) - 1; row++, col++)
        {
            if ((source[row, col] == source[row + 1, col + 1]))
            {
                cnt++;
            }
            else
            {
                cnt = 1;
            }
            if (cnt > maxSeq)
            {
                maxSeq = cnt;
                OutputElement = source[row, col];
            }
        }
        cnt = 1;


        //Searching diagonally from right to left
        for (int row = 0, col = 0; row < source.GetLength(0) - 1 && col > 0; row++, col--)
        {
            if ((source[row, col] == source[row + 1, col + 1]))
            {
                cnt++;
            }
            else
            {
                cnt = 1;
            }
            if (cnt > maxSeq)
            {
                maxSeq = cnt;
                OutputElement = source[row, col];
            }
        }


        for (int i = 0; i < maxSeq; i++)
        {
            if (i < maxSeq - 1)
            {
                Console.Write("{0}, ", OutputElement);
            }
            else  Console.Write("{0}", OutputElement);
        }
        Console.WriteLine();

    }
    static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
