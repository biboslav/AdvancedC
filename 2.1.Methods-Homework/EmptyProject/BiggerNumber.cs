using System;

class BiggerNumber
{
    static void Main()
    {
        int FirstNumb = int.Parse(Console.ReadLine());
        int SecondNumb = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}", GetMax(FirstNumb, SecondNumb));
    }
    static int GetMax(int FirstNumb, int SecondNumb)
    {
        if (FirstNumb >= SecondNumb)
        {
            return FirstNumb;
        }
        else
        {
            return SecondNumb;
        }
    }
}

