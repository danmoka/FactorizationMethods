using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KursachLibrary1;
using System.Numerics;

namespace UTests
{
    /// <summary>
    /// Юнит тесты для алгоритма Лемана
    /// </summary>
    [TestClass]
    public class UnitTestLeman
    {
        private Leman Leman { get; set; } = new Leman();
        private BigInteger Res { get; set; } = 0;

        //Для 49 возвращает 1, а надо 7

        [TestMethod]
        public void Prime950001915000209()
        {
            Res = Leman.Factor(49);

            Assert.AreEqual(7, Res);
        }

        [TestMethod]
        public void Prime9500049500063()
        {
            Res = Leman.Factor(9500049500063);

            Assert.AreEqual(1000003, Res);
        }

        [TestMethod]
        public void Prime950695021()
        {
            Res = Leman.Factor(950695021);

            Assert.AreEqual(10007, Res);
        }

        [TestMethod]
        public void Prime9596599()
        {
            Res = Leman.Factor(9596599);

            Assert.AreEqual(1009, Res);
        }

        [TestMethod]
        public void Prime96253()
        {
            Res = Leman.Factor(96253);

            Assert.AreEqual(101, Res);
        }

        [TestMethod]
        public void Prime2147484197()
        {
            Res = Leman.Factor(2147484197);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime100393()
        {
            Res = Leman.Factor(100393);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime4337()
        {
            Res = Leman.Factor(4337);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime65699()
        {
            Res = Leman.Factor(65699);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime1000313()
        {
            Res = Leman.Factor(1000313);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Sqr18809569()
        {
            Res = Leman.Factor(18809569);

            Assert.AreEqual(4337, Res);
        }

        [TestMethod]
        public void Sqr25()
        {
            Res = Leman.Factor(25);

            Assert.AreEqual(5, Res);
        }

        [TestMethod]
        public void Sqr2809()
        {
            Res = Leman.Factor(2809);

            Assert.AreEqual(53, Res);
        }

        [TestMethod]
        public void Sqr343()
        {
            Res = Leman.Factor(343);

            Assert.AreEqual(7, Res);
        }

    }
}
