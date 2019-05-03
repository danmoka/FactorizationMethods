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
        /*Идея: на входе n.
         * Метод Лемана развивает идеи, заложенные в методе факторизации Ферма, и ищет делители числа 
         * n, используя равенство x^2 − y^2 = 4kn для некоторого целого числа k 
         */

        public string Name { get; } = "Leman's Method";

        /// <summary>
        /// Данный метод ищет разложение входного числа
        /// </summary>
        /// <param name="number"> Число для разложения </param>
        /// <returns> Число из разложения </returns>
        public BigInteger Factor(BigInteger number)
        {
            //Нестеренко, Василенко
            BigInteger stop = Helper.SqrtMSDN(number,3);
            BigInteger sqr6N = Helper.SqrtMSDN(number,6);
            BigInteger result = 1;

            //Первый этап алгоритма - попробовать найти делитель подбором
            for (BigInteger a = 2; a <= stop; a++)
            {
                BigInteger.DivRem(number, a, out BigInteger remainder);
                if (remainder == 0) return a;
            }

            //Второй этап алгоритма - проверка условий теоремы
            for( BigInteger k = 1; k <= stop; k++)
            {
                BigInteger sqrK = Helper.SqrtMSDN(k,2);
                BigInteger secondStop = BigInteger.Divide(sqr6N, 4 * sqrK);

                for(BigInteger d=0;d<=secondStop+1;d++)
                {
                    BigInteger a = Helper.SqrtMSDN(4 * k * number,2) + d;
                    BigInteger teor = BigInteger.Pow(a, 2) - 4 * k * number;
                    BigInteger sqrTeor = Helper.SqrtMSDN(BigInteger.Abs(teor),2);

                    if (Helper.IsTrueSqrt(teor, sqrTeor))
                    {
                        BigInteger gcdABPlus = BigInteger.Abs(Helper.GCD(a+sqrTeor,number));
                        BigInteger gcdABMines = BigInteger.Abs(Helper.GCD(a - sqrTeor, number));
                        if (gcdABPlus > 1 && gcdABPlus < number) result = gcdABPlus;
                        else if (gcdABMines > 1 && gcdABMines < number) result = gcdABMines;
                    }
                }
            }

            return result;
        }
    }
}
