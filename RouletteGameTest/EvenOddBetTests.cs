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
    public class EvenOddBetTests
    {
        private string _EvenOdd;
        private uint amount;
        private uint wonAmount;
        private EvenOddBet _eobObject;
        private bool _even;
        private Fieldstub fieldstub;


        [SetUp]
        public void Init()
        {
            _EvenOdd = "odd";
            amount = 10;
            wonAmount = 20;
            _eobObject = new EvenOddBet(_EvenOdd, amount, _even);
            fieldstub = new Fieldstub();
        }

        [Test]
        public void wonAmount_WinningOnEvenNumber_GetMoney()
        {
            _eobObject = new EvenOddBet(_EvenOdd, amount, true);
            fieldstub.Even = true;
          //  Assert.Greater(_eobObject.WonAmount(fieldstub), 0);
        }
    }
}
