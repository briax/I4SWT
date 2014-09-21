using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGameCode
{
    public class FieldBet : Bet
    {
        private readonly uint _fieldNumber;

        public FieldBet(string name, uint amount, uint fieldNumber)
            : base(name, amount)
        {
            _fieldNumber = fieldNumber;
        }

        public override uint WonAmount(Field field)
        {
            if (field.Number == _fieldNumber) return 36 * Amount;
            else return 0;
        }

        public override string ToString()
        {
            return string.Format("{0}$ field bet on {1}", Amount, _fieldNumber);
        }
    }
}
