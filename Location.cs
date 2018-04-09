using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartyPlanner
{
    class Location    
    {
        public int location;
        public Location(int theLocation)
        {
            location = theLocation;
            switch (location)
            {
                case 1:
                    {
                        Console.WriteLine("You will be playing in Grosse Pointe Park!");
                        string[] eateries = {"Red Crown", "Atwater", "Cadieux Cafe", "Marais" };
                        restaurantRandomizer(eateries);
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("You will be playing in Royal Oak!");
                        string[] eateries = { "Lockharte's BBQ", "Hopcat", "Jolly Pumpkin", "Royal Oak Brewery" };
                        restaurantRandomizer(eateries);
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("You will be playing in Detroit!");
                        string[] eateries = { "Central", "Sy Thai", "Hopcat", "Grand Trunk"};
                        restaurantRandomizer(eateries);
                        Console.ReadKey();
                        break;
                    }
            }
        }

        private void restaurantRandomizer(string[] eateries)
        {
            Random rnd = new Random();
            int eIndex = rnd.Next(eateries.Length);
            Console.WriteLine("Suggested noms for the big day: {0}", eateries[eIndex]);
        }
    }
}