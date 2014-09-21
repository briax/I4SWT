using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGameCode
{
    public class ColorBet : Bet
    {
        private readonly uint _color;

        public ColorBet(string name, uint amount, uint color)
            : base(name, amount)
        {
            _color = color;
        }

        override public uint WonAmount(Field field)
        {
            if (field.Color == _color) return 2 * Amount;
            else return 0;
        }

        public override string ToString()
        {
            string colorString;

            switch (_color)
            {
                case Field.Red: colorString = "red"; break;
                case Field.Black: colorString = "black"; break;
                default: colorString = "green"; break;
            }

            return string.Format("{0}$ color bet on {1}", Amount, colorString);
        }

    }
}
