using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KursachLibrary1;
using System.Numerics;

namespace UTests
{
    [TestClass]
    public class UnitTestPPollard
    {
        //В методе стоит вопрос о выборе сжимающей функции, обычно это x*x+1, для числа 25 результат неверный.
        //для числа 25 данная сжим. функ. не подходит. Например, для x*x+4 все тесты проходят, но есть уверенность, что 
        //найдется число, для которого данная сжимающая функция не подходит.

        private PPollard PPollard { get; set; } = new PPollard();
        private BigInteger Res { get; set; } = 0;

        [TestMethod]
        public void Prime950001915000209()
        {
            Res = PPollard.Factor(950001915000209);

            Assert.AreEqual(10000019, Res);
        }

        [TestMethod]
        public void Prime9500049500063()
        {
            Res = PPollard.Factor(9500049500063);

            Assert.AreEqual(1000003, Res);
        }

        [TestMethod]
        public void Prime950695021()
        {
            Res = PPollard.Factor(950695021);

            Assert.AreEqual(10007, Res);
        }

        [TestMethod]
        public void Prime9596599()
        {
            Res = PPollard.Factor(9596599);

            Assert.AreEqual(1009, Res);
        }

        [TestMethod]
        public void Prime96253()
        {
            Res = PPollard.Factor(96253);

            Assert.AreEqual(101, Res);
        }

        [TestMethod]
        public void Prime3()
        {
            Res = PPollard.Factor(3);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime1193()
        {
            Res = PPollard.Factor(1193);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime10169()
        {
            Res = PPollard.Factor(10169);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime100393()
        {
            Res = PPollard.Factor(100393);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime1000313()
        {
            Res = PPollard.Factor(1000313);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime4337()
        {
            Res = PPollard.Factor(4337);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime65699()
        {
            Res = PPollard.Factor(65699);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Prime2147484197()
        {
            Res = PPollard.Factor(2147484197);

            Assert.AreEqual(1, Res);
        }

        [TestMethod]
        public void Sqr25()
        {
            Res = PPollard.Factor(25);

            Assert.AreEqual(5, Res);
        }

        [TestMethod]
        public void Sqr9()
        {
            Res = PPollard.Factor(9);

            Assert.AreEqual(3, Res);
        }

        [TestMethod]
        public void Sqr49()
        {
            Res = PPollard.Factor(49);

            Assert.AreEqual(7, Res);
        }
        
        [TestMethod]
        public void Sqr18809569()
        {
            Res = PPollard.Factor(18809569);

            Assert.AreEqual(4337, Res);
        }
    }
}
