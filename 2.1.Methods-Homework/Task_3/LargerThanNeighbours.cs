using System;

class LargerThanNeighbours
{
    static void Main()
    {
        //string ArrString = Console.ReadLine();
        //string[] items = ArrString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //int[] arr = new int[items.Length];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = int.Parse(items[i]);

        //}

        int[] numbers = { 1, 3, 4, 5, 0, 1, 5 };//{ 1,1,1,1,1,2 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }

    }
    static bool IsLargerThanNeighbours(int[] n, int i)
    {	
        if (i == 0 )
        {
            //return false; //ne e po-golqmo ot 2 syseda zashtoto ima samo 1
            if (n[i] > n[i + 1])
            {
                return true;
            }
            else return false;

        }
        else if (i == n.Length - 1)
        {
            //return false; //ne e po-golqmo ot 2 syseda zashtoto ima samo 1
            if (n[i] > n[i - 1])
            {
                return true;
            }
            else return false;
        }
        else
        {
            if (n[i] > n[i - 1] && n[i] > n[i + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

