using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    public class Players
    {           
        public List<string> players;
        public Players(string thePlayers)          
        {
            string[] userInput = thePlayers.Split(',');
            players = userInput.ToList();            
        }        
    }
}
