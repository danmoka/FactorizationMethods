using System;
using System.Collections.Generic;
using System.Numerics;

namespace KursachLibrary1
{
    /// <summary>
    /// Данный класс является вспомогательным набором математических методов для работы с числами
    /// </summary>
    internal static class Helper
    {
        #region SqrtFuncs
        /// <summary>
        /// Данный метод возвращает целую часть от корня из value
        /// </summary>
        /// <param name="number"> Число, из которого извелкается корень</param>
        /// <param name="degree"> Степень извлекаемого корня </param>
        /// <returns> Корень из числа </returns>
        internal static BigInteger SqrtMSDN(BigInteger number, int degree)
        {
            Dictionary<BigInteger, BigInteger> nearValues = new Dictionary<BigInteger, BigInteger>();
            BigInteger sqrtFromNumber = (BigInteger)Math.Exp(BigInteger.Log(number) / degree);

            if (IsTrueSqrt(number, sqrtFromNumber)) return sqrtFromNumber;

            // Проверяем соседние числа
            nearValues[sqrtFromNumber - 1] = sqrtFromNumber - 1;
            nearValues[sqrtFromNumber + 1] = sqrtFromNumber + 1;

            for(int i = 0; i < degree - 1; i++)
            {
                nearValues[sqrtFromNumber - 1] *= (sqrtFromNumber-1);
                nearValues[sqrtFromNumber + 1] *= (sqrtFromNumber+1);
            }

            foreach (KeyValuePair<BigInteger, BigInteger> num in nearValues)
                if (num.Value == number) return num.Key;

            return sqrtFromNumber;
        }

        /// <summary>
        /// Метод, проверяющий является число полным квадратом числа
        /// </summary>
        /// <param name="number"> Исходное число </param>
        /// <param name="sqrt"> Квадрат числа </param>
        /// <returns> True, если является, иначе false </returns>
        internal static bool IsTrueSqrt(BigInteger number, BigInteger sqrt)
        {
            return sqrt * sqrt == number;
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
