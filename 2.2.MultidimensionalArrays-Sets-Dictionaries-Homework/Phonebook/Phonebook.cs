using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
            string[] source = Console.ReadLine().Split('-');

            do
            {
                string name = source[0];
                string number = source[1];
                if (phonebook.ContainsKey(name))
                {
                    if (!phonebook[name].Contains(number))
                    {
                        phonebook[name].Add(number);
                    }
                }
                else
                {
                    phonebook.Add(name, new List<string>());
                    phonebook[name].Add(number);
                }
                source = Console.ReadLine().Split('-');

            } while (source[0] != "search");

            string find = Console.ReadLine();
            do
            {
                if (phonebook.ContainsKey(find))
                {
                    Console.WriteLine(find + " -> " + string.Join("; ", phonebook[find]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", find);
                }

                find = Console.ReadLine();

            } while (find != String.Empty);
        }

        
    }
}
