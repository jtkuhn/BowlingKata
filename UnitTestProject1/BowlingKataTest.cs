﻿using System;
using BowlingKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BowlingKataTest
    {
        private Game bowlingGame;
        //comment so that I can commit? maybe?

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
            int n = 20;
            int pins = 0;
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
    }
}
