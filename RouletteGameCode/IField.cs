using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGameCode
{
    public interface IField
    {
        uint Number { get; }

        uint Color { get; }

        bool Even { get; }
    }
}
