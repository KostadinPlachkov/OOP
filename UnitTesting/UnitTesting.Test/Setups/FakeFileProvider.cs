using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Data;

namespace UnitTesting.Test.Setups
{
    public class FakeFileProvider : IFileProvider
    {
        private List<Player> data;

        public FakeFileProvider()
        {
            this.data = new List<Player>();
        }

        public string ReadAllText(string filePath)
        {
            return string.Join(",", data
                .Select(n => $"{n.Name},{n.Points}"));
        }

        public void WriteAllText(string filePath, string content)
        {
            this.data = Player.Parse(content).ToList();
        }
    }
}
