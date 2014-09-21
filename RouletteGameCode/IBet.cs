using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGameCode
{
    public interface IBet
    {
        string PlayerName { get; }
        uint Amount { get; }
        uint WonAmount(Field field);
    }
}
