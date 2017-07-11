using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Data;

namespace UnitTesting
{
    public class HighScore
    {
        public const int MaxPlayers = 10;
        private const string DataFile = "highscore.dat";
        private List<Player> currentHighScore;
        private readonly IFileProvider fileProvider;

        

        public HighScore(IFileProvider fileProvider)
        {
            this.fileProvider = fileProvider;
        }

        public IEnumerable<Player> Load()
        {
            var savedData = this.fileProvider.ReadAllText(DataFile);

            var list = Player.Parse(savedData);

            return new ReadOnlyCollection<Player>(list);
        }

        public void AddPlayer(Player player)
        {
            var data = this.Load().ToList();
            data.Add(player);
            var newData = data
                .OrderByDescending(p => p.Points)
                .Take(MaxPlayers)
                .Select(p => $"{p.Name},{p.Points}")
                .ToList();

            this.fileProvider.WriteAllText(DataFile, string.Join(",", newData));
            
        }
    }
}
