using System.Numerics;

namespace KursachLibrary1
{
    public class PPollard:IFactor
    {
        /* Идея: на входе n. ρ-алгоритм Полларда строит числовую последовательность.
         * Выберем небольшое X0 и построим последовательность {Xk}, k=0,1,2...,
         * определяя каждое следующее Xk+1 по формуле Xk+1=F(Xk)(mod n). F(x) не должна порождать взаимно однозначное отображение.
         * На каждом шаге вычисляем всевозможные d=НОД(n,xi-xj), где j<i.
         * Если d!=1, то d - делитель n.
         */
        public string Name { get; } = "P-Pollard's Method";
        //Ишмухаметов.
        public BigInteger Factor(BigInteger number)
        {
            BigInteger x = 2;
            BigInteger y = 1;
            var i = 0;
            var stage = 2;

            while (Helper.GCD(number, BigInteger.Abs(x - y)) == 1)
            {
                if (i == stage)
                {
                    y = x;
                    stage = stage * 2;
                }

                x = CompressiveFunc(x) % number;
                i++;
            }
            var p = Helper.GCD(number, BigInteger.Abs(x - y));
            return p == number ? 1 : p;
        }

        private BigInteger CompressiveFunc(BigInteger n)
        {
            return n * n + 1;
        }

        //INTUIT
        //public BigInteger Factor(BigInteger number)
        //{
        //    BigInteger x = 2;
        //    BigInteger y = 2;
        //    BigInteger p = 1;

        //    while (p == 1)
        //    {
        //        x = CompressiveFunc(x) % number;
        //        y = CompressiveFunc(y) % number;
        //        y = CompressiveFunc(y) % number;

        //        p = BigInteger.Abs(Helper.GCD(x - y, number));
        //    }
        //    return p == number ? 1 : p;
        //}

        //issledovanie-parall алгоритм
        //public BigInteger Factor(BigInteger number)
        //{
        //    BigInteger x = 2;
        //    BigInteger y = CompressiveFunc(x)%number;

        //    while (BigInteger.Abs(Helper.GCD(y - x, number))==1 || BigInteger.Abs(Helper.GCD(y - x, number))==number)
        //    {
        //        x = CompressiveFunc(x) % number;
        //        y = CompressiveFunc(CompressiveFunc(x)) % number;
        //    }
        //    return BigInteger.Abs(Helper.GCD(y - x, number));
        //}
    }
}
