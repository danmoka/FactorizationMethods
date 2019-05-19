using System.Numerics;

namespace KursachLibrary1
{
    /// <summary>
    /// Класс, реализаующий метод Ферма
    /// </summary>
    public class Ferma: IFactor
    {
        public string Name { get; } = "Ferma's Method";

        /// <summary>
        /// Данный метод ищет разложение входного числа
        /// </summary>
        /// <param name="number"> Входное число </param>
        /// <returns> Делитель входного числа </returns>
        public BigInteger Factor(BigInteger number)
        {
            BigInteger startNumber = Helper.SqrtMSDN(number, 2); // Первый шаг - целая часть корня из входного числа

            if (Helper.IsTrueSqrt(number, startNumber))
                return startNumber; // Если входное число оказалось полным квадратом, то вернуть startNumber...

            startNumber++;

            //... иначе ищем представление входного числа в виде разницы двух квадратов
            while(true)
            {
                BigInteger q = (startNumber) * (startNumber) - number;
                BigInteger qSqrt = Helper.SqrtMSDN(q, 2);

                if (Helper.IsTrueSqrt(q, qSqrt))
                    return startNumber - qSqrt;

                startNumber++;
            }
        }
    }
}
