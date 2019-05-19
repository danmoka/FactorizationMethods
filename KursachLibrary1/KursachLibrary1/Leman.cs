using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KursachLibrary1
{
    /// <summary>
    /// Данный класс реализует мето факторизации Лемана
    /// </summary>
    public class Leman : IFactor
    {
        public string Name { get; } = "Leman's Method";

        /// <summary>
        /// Данный метод ищет разложение входного числа
        /// </summary>
        /// <param name="number"> Входное число </param>
        /// <returns> Делитель входного числа </returns>
        public BigInteger Factor(BigInteger number)
        {
            BigInteger firstBorder = Helper.SqrtMSDN(number, 3);
            BigInteger sqrt6N = Helper.SqrtMSDN(number, 6);
            BigInteger devisor = 1;

            //Первый этап алгоритма - попробовать найти делитель подбором
            for (BigInteger i = 2; i <= firstBorder; i++)
            {
                BigInteger.DivRem(number, i, out BigInteger remainder);
                if (remainder == 0) return i;
            }

            //Второй этап алгоритма - проверка условий теоремы
            for( BigInteger k = 1; k <= firstBorder; k++)
            {
                BigInteger sqrtK = Helper.SqrtMSDN(k, 2);
                BigInteger secondBorder = BigInteger.Divide(sqrt6N, 4 * sqrtK);

                for(BigInteger i = 0; i <= secondBorder + 1; i++)
                {
                    BigInteger A = Helper.SqrtMSDN(4 * k * number, 2) + i;
                    BigInteger B = BigInteger.Pow(A, 2) - 4 * k * number;
                    BigInteger sqrtB = Helper.SqrtMSDN(BigInteger.Abs(B),2);

                    if (Helper.IsTrueSqrt(B, sqrtB))
                    {
                        BigInteger gcdABPlus = BigInteger.Abs(Helper.GCD(A+sqrtB, number));
                        BigInteger gcdABMines = BigInteger.Abs(Helper.GCD(A - sqrtB, number));
                        if (gcdABPlus > 1 && gcdABPlus < number) devisor = gcdABPlus;
                        else if (gcdABMines > 1 && gcdABMines < number) devisor = gcdABMines;
                    }
                }
            }

            return devisor;
        }
    }
}
