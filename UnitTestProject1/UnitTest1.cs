using System;
using BowlingKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BowlingKataTest
    {
        private Game bowlingGame;

        [TestInitialize]
        public void SetUp()
        {
            bowlingGame = new Game();
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                bowlingGame.Roll(pins);
        }



        [TestMethod]
        public void TestAllGutterBalls()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, bowlingGame.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, bowlingGame.Score());
        }

        [TestMethod]
        public void TestOneSpare()
        {
            bowlingGame.Roll(5);
            bowlingGame.Roll(5); //spare
            bowlingGame.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, bowlingGame.Score());
        }

        [TestMethod]
        public void TestTwoSpares()
        {
            bowlingGame.Roll(5);
            bowlingGame.Roll(5); //spare
            bowlingGame.Roll(7);
            bowlingGame.Roll(3); //spare 2
            bowlingGame.Roll(8);
            RollMany(15, 0);
            Assert.AreEqual(43, bowlingGame.Score());
        }


        [TestMethod]
        public void TestOneStrike()
        {
            bowlingGame.Roll(10);
            bowlingGame.Roll(3);
            bowlingGame.Roll(5);
            bowlingGame.Roll(3);
            RollMany(16, 0);
            Assert.AreEqual(29, bowlingGame.Score());
        }

        [TestMethod]
        public void TestThreeConsecutiveStrikes()
        {
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(3);
            bowlingGame.Roll(3);
            bowlingGame.Roll(3);
            RollMany(14, 0);
            Assert.AreEqual(78, bowlingGame.Score());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, bowlingGame.Score());
        }
    }
}