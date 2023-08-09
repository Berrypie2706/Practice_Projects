using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEndProject1
{
    public class OnedayTeam : ITeam
    {
       
        public static List<Player> oneDayTeam = new List<Player>();
        public OnedayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            oneDayTeam.Add(player);
            Console.WriteLine($"Player {player.PlayerName} added to the team.");
        }

        public void Remove(int player_id)
        {

            Player remove = oneDayTeam.FirstOrDefault(p => p.PlayerId == player_id);
            if (remove != null)
            {
                oneDayTeam.Remove(remove);
                Console.WriteLine($"PLayer {remove.PlayerName} is removed from the team");
            }
            else
            {
                Console.WriteLine("No such player in the list!!!");
            }

        }

        public Player GetPlayerById(int playerid)
        {
            return oneDayTeam.FirstOrDefault(p => p.PlayerId == playerid);
        }

        public List<Player> GetPlayerByName(string playername)
        {
            return oneDayTeam.Where(p => p.PlayerName.Equals(playername, StringComparison.OrdinalIgnoreCase)).ToList();

        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam.ToList();
        }
          
    }
}
