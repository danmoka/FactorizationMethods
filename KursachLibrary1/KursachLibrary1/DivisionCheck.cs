using System.Numerics;

namespace KursachLibrary1
{
    /// <summary>
    /// Алгоритм пробных делений
    /// </summary>
    public class TrialDivisionMethod : IFactor
    {
        public string Name { get; } = "Trial division method";

        /// <summary>
        /// Данный метод подбирает делители входного числа n до корня из n
        /// </summary>
        /// <param name="number"> Входное число </param>
        /// <returns> Делитель входного числа </returns>
        public BigInteger Factor(BigInteger number)
        {
            BigInteger startNumber = 2;
            BigInteger divisor = 1;

            // До корня из n подбираем делитель входного числа
            while (startNumber <= Helper.SqrtMSDN(number,2))
            {
                if (number % startNumber == 0)
                {
                    divisor = startNumber;
                    break;
                }

                startNumber++;
            }

            return divisor;
        }
    }
}
