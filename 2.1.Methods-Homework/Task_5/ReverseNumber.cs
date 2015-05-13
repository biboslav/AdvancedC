using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}", ReverseNumb(n));
       
    }
    
    static double ReverseNumb(double number)
    {
        return double.Parse(ReverseString(number.ToString()));
    }

    static string ReverseString(string s)
    {

        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
       
    }

   
}

