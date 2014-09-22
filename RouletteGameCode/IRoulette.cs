using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGameCode
{
    public interface IRoulette
    {
        void Spin();

        Field GetResult();
    }
}
