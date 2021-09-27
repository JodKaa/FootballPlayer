using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayer.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer _player;

        [TestInitialize]
        public void Setup()
        {
            _player = new FootballPlayer(6, "Jonas", 50000, 6);
        }

        [TestMethod]
        public void TestConstructor()
        {
            FootballPlayer pl = new FootballPlayer(1, "Jonas", 50000, 6);

            //Assert.AreEqual(1, pl.Id);
            Assert.AreEqual("Jonas", pl.Name);
            Assert.AreEqual(50000, pl.Price);
            Assert.AreEqual(6, pl.ShirtNumber);
        }

        [TestMethod]
        public void TestName()
        {
            _player.Name = "Jonas";
            Assert.AreEqual("Jonas", _player.Name);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.Name = "J");
            Assert.ThrowsException<ArgumentNullException>(() => _player.Name = null); // Assert.ThrowsException failed. Threw exception NullReferenceException, but exception ArgumentNullException was expected.
        }

        [TestMethod]
        public void TestPrice()
        {
            _player.Price = 50000;
            Assert.AreEqual(50000, _player.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.Price = -6);
        }

        [TestMethod]
        public void TestShirtNumber()
        {
            _player.ShirtNumber = 6;
            Assert.AreEqual(6, _player.ShirtNumber);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ShirtNumber = 101);
        }
    }
}