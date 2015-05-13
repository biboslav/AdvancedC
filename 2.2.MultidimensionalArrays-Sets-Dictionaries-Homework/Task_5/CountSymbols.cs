using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSymbols
{
    static void Main()
    {
        char[] source = Console.ReadLine().ToCharArray();
        SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

        for (int i = 0; i < source.Length; i++)
        {
            if (symbols.ContainsKey(source[i]))
            {
                symbols[source[i]] += 1;
            }
            else
            {
                symbols.Add(source[i], 1);
            }
        }

        //var list = symbols.Keys.ToList();
        //list.Sort();


        foreach (var a in symbols)
        {
            Console.WriteLine("{0}: {1} time/s",
                a.Key, a.Value);
        }
        
    }
}

