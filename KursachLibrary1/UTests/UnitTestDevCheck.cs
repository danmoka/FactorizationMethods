using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KursachLibrary1;
using System.Numerics;

namespace UTests
{
    [TestClass]
    public class UnitTestDevCheck
    {
        private DivisionCheck Dc { get; set; } = new DivisionCheck();
        private BigInteger Res { get; set; } = 0;

        [TestMethod]
        public void Prime950001915000209()
        {
            Res = Dc.Factor(950001915000209);

            Assert.AreEqual(10000019, Res);
        }

        [TestMethod]
        public void Prime9500049500063()
        {
            Res = Dc.Factor(9500049500063);

            Assert.AreEqual(1000003, Res);
        }

        [TestMethod]
        public void Prime950695021()
        {
            Res = Dc.Factor(950695021);

            Assert.AreEqual(10007, Res);
        }

        [TestMethod]
        public void Prime9596599()
        {
            Res = Dc.Factor(9596599);

            Assert.AreEqual(1009, Res);
        }

        [TestMethod]
        public void Prime96253()
        {
            Res = Dc.Factor(96253);

            Assert.AreEqual(101, Res);
        }

        [TestMethod]
        public void Prime3()
        {
            Res = Dc.Factor(3);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime1193()
        {
            Res = Dc.Factor(1193);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime4337()
        {
            Res = Dc.Factor(4337);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime10169()
        {
            Res = Dc.Factor(10169);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime32957()
        {
            Res = Dc.Factor(32957);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime65699()
        {
            Res = Dc.Factor(65699);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime100393()
        {
            Res = Dc.Factor(100393);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime1000313()
        {
            Res = Dc.Factor(1000313);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime2147484197()
        {
            Res = Dc.Factor(2147484197);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Sqr9()
        {
            Res = Dc.Factor(9);

            Assert.AreEqual(3, Res);
        }
        [TestMethod]
        public void Sqr25()
        {
            Res = Dc.Factor(25);

            Assert.AreEqual(5, Res);
        }

        [TestMethod]
        public void Sqr49()
        {
            Res = Dc.Factor(49);

            Assert.AreEqual(7, Res);
        }

        [TestMethod]
        public void Sqr18809569()
        {
            Res = Dc.Factor(18809569);

            Assert.AreEqual(4337, Res);
        }
    }
}
