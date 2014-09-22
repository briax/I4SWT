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
    class FieldTests
    {
        private Field fieldTestObject;
        private uint number;
        private uint color;


        [SetUp]
        public void Init()
        {
            number = 2;
        }

        [Test]
        public void Color_SetColorGreen_IsGreen()
        {
            fieldTestObject = new Field(number, Field.Green);
            Assert.AreEqual(Field.Green, fieldTestObject.Color);
        }

        [Test]
        public void Color_SetColorRed_IsRed()
        {
            fieldTestObject = new Field(number, Field.Red);
            Assert.AreEqual(Field.Red, fieldTestObject.Color);
        }

        [Test]
        public void Color_SetColorBlack_IsBlack()
        {
            fieldTestObject = new Field(number, Field.Black);
            Assert.AreEqual(Field.Black, fieldTestObject.Color);
        }


    }
}
