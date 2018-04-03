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
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("You will be playing in Royal Oak!");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("You will be playing in Detroit!");
                        Console.ReadKey();
                        break;
                    }
            }           
        }

        //public void PrintLocation()
        //{
            
        //}
    }
}