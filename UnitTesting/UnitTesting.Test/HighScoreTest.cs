using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.Test.Setups;
using Moq;
using UnitTesting.Data;

namespace UnitTesting.Test
{
    [TestClass]
    public class HighScoreTest
    {

//        private int test;
//
//        // [ClassInitialize]  // For every test in this class, [ClassInitialize] will execute once.
//        // [TestCleanup]  // Executes code after every test.
//        // [ClassCleanup]  // Executes code after every class.
//        [TestInitialize]  // Executes before every test.
//        public void TestInit()
//        {
//            this.test = 0;
//        }
//
//        [TestMethod]
//        // [ExpectedException(typeof(System.Exception))]
//        // [Ignore]  // Ignores the test
//        // [Timeout(1000)]
//        public void SomeTest()
//        {
//            if (test != 1)
//            {
//                throw new System.Exception();
//            }
//        }

        private HighScore highScore;

        [TestInitialize]
        public void PreparePlayers()
        {
            var fileProviderMock = new Mock<IFileProvider>();

            var data = new List<Player>();

            fileProviderMock
                .Setup(f => f.ReadAllText(It.IsAny<string>()))
                .Returns(() =>
                {
                    return string.Join(",", data
                        .Select(n => $"{n.Name},{n.Points}"));
                });

            fileProviderMock
                .Setup(f => f.WriteAllText(It.IsAny<string>(), It.IsAny<string>()))
                .Callback<string, string>((filePath, content) =>
                {
                    data = Player.Parse(content).ToList();
                });  // Needs the 2 string that the original method takes. Using callback because the method is implemented void

            highScore = new HighScore(fileProviderMock.Object);
            for (int i = 0; i < HighScore.MaxPlayers + 10; i++)
            {
                this.highScore.AddPlayer(new Player(i.ToString(), i + 100));
            }
        }

        [TestMethod]
        public void AddPlayerShoudHaveNoMoreThanTenPlayers()
        {
            for (int i = 0; i < HighScore.MaxPlayers + 10; i++)
            {
                this.highScore.AddPlayer(new Player(i.ToString(), i + 100));
            }

            Assert.AreEqual(HighScore.MaxPlayers, this.highScore.Load().Count());
            
        }

        [TestMethod]
        public void AddPlayerShouldHaveBeenOrderedByDescendingPlayersByPoints()
        {
            var points = this.highScore.Load().Select(p => p.Points).ToList();

            Assert.IsTrue(points.Any(), "High score should have at least one player");
            var max = points.First();
            for (int i = 1; i < points.Count(); i++)
            {
                var current = points[i];
                Assert.IsTrue(max >= current);
                max = current;
            }
        }
    }
}
