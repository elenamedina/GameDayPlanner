using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class GameDayPlanner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Who is Down to Clown? [Please enter player names, separated by a comma]");
            string players = Console.ReadLine();
            Console.WriteLine("Where will the clowning go down? [Please select from the following options]\n1. Grosse Pointe Park \n2. Royal Oak \n3. Detroit");
            int location = Convert.ToInt32(Console.ReadLine());

            Players listOfPlayers = new Players(players);
            listOfPlayers.PrintPlayers();

            Location gamingPlace = new Location(location);
        }
    }
}
 