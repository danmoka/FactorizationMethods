using System.Numerics;

namespace KursachLibrary1
{
    /// <summary>
    /// Данный класс реализует метод факторизации Полларда
    /// </summary>
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
        /// <summary>
        /// Данный метод ищет разложение входного числа
        /// </summary>
        /// <param name="number"> Число для разложения </param>
        /// <returns> Число из разложения </returns>
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
    }
}
