using System;

class LastDigit 
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}", GetLastDigitAsWord(n));
    }
    static string GetLastDigitAsWord(int n)
    {
        int LastNumb = n % 10;
        var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return unitsMap[LastNumb];

    }
}

