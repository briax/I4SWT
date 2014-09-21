using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGameCode
{
    public class EvenOddBet : Bet
    {
        private readonly bool _even;

        public EvenOddBet(string name, uint amount, bool even)
            : base(name, amount)
        {
            _even = even;
        }

        override public uint WonAmount(Field field)
        {
            if (field.Even == _even) return 2 * Amount;
            else return 0;
        }

        public override string ToString()
        {
            string evenOddString = _even ? "even" : "odd";

            return string.Format("{0}$ even/odd bet on {1}", Amount, evenOddString);
        }
    }
}
