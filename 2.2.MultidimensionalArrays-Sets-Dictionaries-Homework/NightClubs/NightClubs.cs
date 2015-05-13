using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightClubs
{
    class NightClubs
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<string>>> Clubs = new Dictionary<string, SortedDictionary<string, List<string>>>();
            string[] source = Console.ReadLine().Split(';');

            do
            {
                string city = source[0];
                string venue = source[1];
                string performer = source[2];
                if (Clubs.ContainsKey(city))
                {
                    if (Clubs[city].ContainsKey(venue))
                    {
                        if (!Clubs[city][venue].Contains(performer))
                        {
                            Clubs[city][venue].Add(performer);
                            Clubs[city][venue].Sort();
                        }
                    }
                    else
                    {
                        Clubs[city].Add(venue, new List<string>());
                        Clubs[city][venue].Add(performer);
                    }
                }
                else
                {
                    Clubs.Add(city, new SortedDictionary<string, List<string>>());
                    Clubs[city].Add(venue, new List<string>());
                    Clubs[city][venue].Add(performer);
                }

                source = Console.ReadLine().Split(';');

            } while (source[0] != "END");

            foreach (string city in Clubs.Keys)
            {
                Console.WriteLine(city);
                //var venueList = Clubs[city].Keys.ToList();
                //venueList.Sort();
                foreach (string venue in Clubs[city].Keys)
                {
                    Console.WriteLine("->{0}: {1}", venue, string.Join(", ", Clubs[city][venue]));
                }
            }

        }
    }
}
