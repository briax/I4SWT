using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGameCode
{
    public abstract class Bet : IBet
    {
        private readonly string _playerName;
        private readonly uint _amount;

        protected Bet(string name, uint amount)
        {
            _playerName = name;
            _amount = amount;
        }

        public string PlayerName { get { return _playerName; } }
        public uint Amount { get { return _amount; } }

        public virtual uint WonAmount(Field field) { return 0; }
    }
}
