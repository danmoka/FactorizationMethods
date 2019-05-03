using System.Numerics;

namespace KursachLibrary1
{
    /// <summary>
    /// Алгоритм пробных делений
    /// </summary>
    public class DivisionCheck : IFactor
    {
        public string Name { get; } = "Division Check Method";

        /// <summary>
        /// Данный метод подбирает делители входного числа n до корня из n
        /// </summary>
        /// <param name="number"> Входное число </param>
        /// <returns> Делитель входного числа </returns>
        public BigInteger Factor(BigInteger number)
        {
            BigInteger a = 2;
            BigInteger result = 1;

            while (a <= Helper.SqrtMSDN(number,2))
            {
                if (number % a == 0)
                {
                    result = a;
                    break;
                }

                a++;
            }

            return result;
        }
    }
}
