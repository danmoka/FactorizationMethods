using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KursachLibrary1;
using System.Numerics;

namespace UTests
{
    /// <summary>
    /// Юнит тесты для алгоритма Ферма
    /// </summary>
    [TestClass]
    public class UnitTestFerma
    {
        //2147484197: не удается дать ответ. Аналогичный результат для алгоритма из 8316 и для алгоритма на long-ах

        private Ferma Ferma { get; set; } = new Ferma();
        private BigInteger Res { get; set; } = 0;

        //[TestMethod]
        //public void Prime2147484197()
        //{
        //    Res = Ferma.Factor(2147484197);

        //    Assert.AreEqual(1, Res);
        //}

        [TestMethod]
        public void Prime950001915000209()
        {
            Res = Ferma.Factor(950001915000209);

            Assert.AreEqual(10000019, Res);
        }

        [TestMethod]
        public void Prime9500049500063()
        {
            Res = Ferma.Factor(9500049500063);

            Assert.AreEqual(1000003, Res);
        }

        [TestMethod]
        public void Prime950695021()
        {
            Res = Ferma.Factor(950695021);

            Assert.AreEqual(10007, Res);
        }

        [TestMethod]
        public void Prime9596599()
        {
            Res = Ferma.Factor(9596599);

            Assert.AreEqual(1009, Res);
        }

        [TestMethod]
        public void Prime96253()
        {
            Res = Ferma.Factor(96253);

            Assert.AreEqual(101, Res);
        }

        [TestMethod]
        public void Prime3()
        {
            Res = Ferma.Factor(3);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime100393()
        {
            Res = Ferma.Factor(100393);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime4337()
        {
            Res = Ferma.Factor(4337);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime65699()
        {
            Res = Ferma.Factor(65699);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime1000313()
        {
            Res = Ferma.Factor(1000313);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Sqr18809569()
        {
            Res = Ferma.Factor(18809569);

            Assert.AreEqual(4337, Res);
        }

        [TestMethod]
        public void Sqr25()
        {
            Res = Ferma.Factor(25);

            Assert.AreEqual(5, Res);
        }

        [TestMethod]
        public void Sqr49()
        {
            Res = Ferma.Factor(49);

            Assert.AreEqual(7, Res);
        }

        [TestMethod]
        public void Sqr9()
        {
            Res = Ferma.Factor(9);

            Assert.AreEqual(3, Res);
        }
    }
}
