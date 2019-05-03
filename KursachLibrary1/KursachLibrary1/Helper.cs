using System;
using System.Collections.Generic;
using System.Numerics;

namespace KursachLibrary1
{
    /// <summary>
    /// Данный класс служит вспомогательным набором математических методов для работы с числами
    /// </summary>
    public static class Helper
    {
        #region SqrtFuncs
        /// <summary>
        /// Данный метод возвращает целую часть от корня из value
        /// </summary>
        /// <param name="number"> Число, из которого извелкается корень</param>
        /// <param name="count">Степень извлекаемого корня </param>
        /// <returns> Корень из числа </returns>
        public static BigInteger SqrtMSDN(BigInteger number, int count)
        {
            Dictionary<BigInteger, BigInteger> values = new Dictionary<BigInteger, BigInteger>();
            var sqr = (BigInteger)Math.Exp(BigInteger.Log(number) / count);

            if (IsTrueSqrt(number, sqr)) return sqr;

            values[sqr - 1] = sqr - 1;
            values[sqr + 1] = sqr + 1;
            values[sqr - 2] = sqr - 2;
            values[sqr + 2] = sqr + 2;

            for(int i=0;i<count-1;i++)
            {
                values[sqr - 1] *= (sqr-1);
                values[sqr + 1] *= (sqr+1);
                values[sqr - 2] *= (sqr-2);
                values[sqr + 2] *= (sqr+2);
            }

            foreach (var el in values)
                if (el.Value == number) return el.Key;

            return sqr;
        }

        /// <summary>
        /// Метод, проверяющий является число полным квадратом числа
        /// </summary>
        /// <param name="number"> Исходное число </param>
        /// <param name="sqr"> Квадрат числа </param>
        /// <returns> True, если является, иначе false </returns>
        internal static bool IsTrueSqrt(BigInteger number, BigInteger sqr)
        {
            return sqr * sqr == number;
        }
        #endregion

        /// <summary>
        /// Алгоритм Евклида для вычисления НОД двух чисел
        /// </summary>
        /// <param name="a"> Первое число </param>
        /// <param name="b"> Второе число </param>
        /// <returns> Наибольший общий делитель </returns>
        internal static BigInteger GCD(BigInteger a, BigInteger b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }
    }
}
