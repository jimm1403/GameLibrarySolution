using GameLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.UnitTest
{
    [TestFixture]
    public class GameTest   
    {
        Ship ship;

        [SetUp]
        public void SetUpUnitTest()
        {
            ship = new Ship();
        }

        [Test]
        public void CanShipTakeDamage()
        {
            int expected = 4;

            int actual = ship.TakeDamage();
            Assert.AreEqual(expected, actual);

        }

    }
}
