using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RouletteGameCode;

namespace RouletteGameTest
{   
    [TestFixture]
    public class TestRouletteGame
    {

        private RouletteGame _game;

        [SetUp]
        public void Init()
        {
            var uut = new RouletteGame(new Roulette());
            _game = uut;
        }

        [Test]
        public void Test()
        {
        }
    }
}
