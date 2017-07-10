using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class HighScore
    {
        private static List<Player> currentHighScore;
        public static IEnumerable<Player> Load()
        {
            return new ReadOnlyCollection<Player>(currentHighScore);
        }

        public static void AddPlayer(Player player)
        {
            
            currentHighScore.Add(player);
            currentHighScore = currentHighScore
                .OrderByDescending(p => p.Points)
                .Take(10)
                .ToList();
            
        }
    }
}
