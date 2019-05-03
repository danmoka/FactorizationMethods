using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using KursachLibrary1;

namespace UTests
{
    [TestClass]
    public class UnitTestP1Pollard
    {
        //Результаты на 3-х алгоритмах разные. Ни один не прошел все тесты. Кажется проблема в константе B (или Base), вопрос как их выбрать.

        private P1Pollard P1Pollard { get; set; } = new P1Pollard();
        private BigInteger Res = 0;

        [TestMethod]
        public void Prime950001915000209()
        {
            Res = P1Pollard.Factor(950001915000209);

            Assert.AreEqual(10000019, Res);
        }

        [TestMethod]
        public void Prime9500049500063()
        {
            Res = P1Pollard.Factor(9500049500063);

            Assert.AreEqual(1000003, Res);
        }

        [TestMethod]
        public void Prime950695021()
        {
            Res = P1Pollard.Factor(950695021);

            Assert.AreEqual(10007, Res);
        }

        [TestMethod]
        public void Prime9596599()
        {
            Res = P1Pollard.Factor(9596599);

            Assert.AreEqual(1009, Res);
        }

        [TestMethod]
        public void Prime96253()
        {
            Res = P1Pollard.Factor(96253);

            Assert.AreEqual(101, Res);
        }

        [TestMethod]
        public void Prime3()
        {
            Res = P1Pollard.Factor(3);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime1000313()
        {
            Res = P1Pollard.Factor(1000313);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime100393()
        {
            Res = P1Pollard.Factor(100393);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime10169()
        {
            Res = P1Pollard.Factor(10169);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime65699()
        {
            Res = P1Pollard.Factor(65699);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime2147484197()
        {
            Res = P1Pollard.Factor(2147484197);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Sqr9()
        {
            Res = P1Pollard.Factor(9);

            Assert.AreEqual(3, Res);
        }

        [TestMethod]
        public void Sqr25()
        {
            Res = P1Pollard.Factor(25);

            Assert.AreEqual(5, Res);
        }

        [TestMethod]
        public void Sqr49()
        {
            Res = P1Pollard.Factor(49);

            Assert.AreEqual(7, Res);
        }

        [TestMethod]
        public void Sqr18809569()
        {
            Res = P1Pollard.Factor(18809569);

            Assert.AreEqual(4337, Res);
        }
    }
}
