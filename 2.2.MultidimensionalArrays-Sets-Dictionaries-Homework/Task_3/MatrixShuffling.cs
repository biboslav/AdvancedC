using System;

class MatrixShuffling
{
    static void Main()
    {
        //int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        string[,] source = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                source[row, col] = Console.ReadLine();
            }
        }

        string [] comands = Console.ReadLine().Trim().Split(' ');
        do
        {
            if (comands[0] == "swap")
            {
                int x1 = int.Parse(comands[1]);
                int y1 = int.Parse(comands[2]);
                int x2 = int.Parse(comands[3]);
                int y2 = int.Parse(comands[4]);

                if (
                    (x1 < rows && x1 >= 0) &&
                    (x2 < rows && x2 >= 0) &&
                    (y1 < cols && y1 >= 0) &&
                    (y2 < cols && y2 >= 0)
                   )
                {
                    string temp = source[x1, y1];
                    source[x1, y1] = source[x2, y2];
                    source[x2, y2] = temp;
                    PrintMatrix(source);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }


            comands = Console.ReadLine().Trim().Split(' ');

        } while (comands[0] != "END");

    }
    static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write( matrix[i, j]+ " ");
            }
            Console.WriteLine();
        }
    }
}

