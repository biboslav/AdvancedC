using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberCalculations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter double set");
        string DoubString = Console.ReadLine();
        string[] DoubItems = DoubString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        double[] doubles = new double[DoubItems.Length];
        for (int i = 0; i < doubles.Length; i++)
        {
            doubles[i] = double.Parse(DoubItems[i]);

        }

        Console.WriteLine("Enter decimal set");
        string DecString = Console.ReadLine();
        string[] DecItems = DecString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        decimal[] decimals = new decimal[DecItems.Length];
        for (int i = 0; i < decimals.Length; i++)
        {
            decimals[i] = decimal.Parse(DecItems[i]);

        }


        Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, AVG: {3}, Product: {4}", //zakruglqne?
            MinNumb(doubles), MaxNumb(doubles), SumNumb(doubles), AvgNumb(doubles), ProdNumb(doubles));


        Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, AVG: {3}, Product: {4}", //zakruglqne?
            MinNumb(decimals), MaxNumb(decimals), SumNumb(decimals), AvgNumb(decimals), ProdNumb(decimals));
    }

    static double MinNumb(double[] numbers)
    {
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (min > numbers[i]) min = numbers[i];
        }
        return min;
    }

    static decimal MinNumb(decimal[] numbers)
    {
        decimal min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (min > numbers[i]) min = numbers[i];
        }
        return min;
    }

    static double MaxNumb(double[] numbers)
    {
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max < numbers[i]) max = numbers[i];
        }
        return max;
    }

    static decimal MaxNumb(decimal[] numbers)
    {
        decimal max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max < numbers[i]) max = numbers[i];
        }
        return max;
    }

    static double SumNumb(double[] numbers)
    {
        double sum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static decimal SumNumb(decimal[] numbers)
    {
        decimal sum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    
    static double AvgNumb(double[] numbers)
    {
        return SumNumb(numbers) / numbers.Length;
    }

    static decimal AvgNumb(decimal[] numbers)
    {
        return SumNumb(numbers) / numbers.Length;
    }

    static double ProdNumb(double[] numbers)
    {
        double product = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    static decimal ProdNumb(decimal[] numbers)
    {
        decimal product = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}

