using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class GameDayPlanner
    {
        static void Main(string[] args)
        {
            Person Rich = new Person("Rich", 30, "brown", 1.5f);           
            Rich.PrintPerson();
            Console.ReadKey();

            Person Elena = new Person("Elena", 33, "brown");
            Elena.PrintPerson();
            Console.ReadKey();
        }
    }
}
