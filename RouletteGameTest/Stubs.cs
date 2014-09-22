using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using RouletteGameCode;

namespace RouletteGameTest
{
    public class Fieldstub : IField
    {
        private uint number;
        private uint color;
        private bool even;

        public Fieldstub()
        {
            number = 2;
            color = Field.Red;
            even = true;
        }
        
        public uint Number
        {
	        get { return number; }
            set { number = value; }
        }

        public uint Color
        {
	        get { return color; }
            set { color = value; }
        }

        public bool Even
        {
	        get { return even; }
            set { even = value; }
        }
    }

    public class RouletteStub : IRoulette
    {
        public void Spin()
        {
            throw new NotImplementedException();
        }

        public Field GetResult()
        {
            throw new NotImplementedException();
        }
    }

    public class BetStub : IBet
    {
        public string PlayerName
        {
            get { throw new NotImplementedException(); }
        }

        public uint Amount
        {
            get { throw new NotImplementedException(); }
        }

        public uint WonAmount(Field field)
        {
            throw new NotImplementedException();
        }
    }
}
