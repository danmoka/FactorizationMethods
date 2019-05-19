using System.Numerics;

namespace KursachLibrary1
{
    /// <summary>
    /// Данный класс реализует метод факторизации Полларда
    /// </summary>
    public class PPollard:IFactor
    {
        public string Name { get; } = "P-Pollard's Method";

        //Ишмухаметов.
        /// <summary>
        /// Данный метод ищет разложение входного числа
        /// </summary>
        /// <param name="number"> Входное число </param>
        /// <returns> Делитель входного числа </returns>
        public BigInteger Factor(BigInteger number)
        {
            BigInteger x = 2;
            BigInteger y = 1;
            int i = 0;
            int stage = 2;

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

        private BigInteger CompressiveFunc(BigInteger x)
        {
            return x * x + 1;
        }
    }
}
