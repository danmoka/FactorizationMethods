using System;
using System.Collections.Generic;
using System.Numerics;

namespace KursachLibrary1
{
    public static class Helper
    {
        //Данный класс служит вспомогательным набором математических методов для работы с числами

        #region SqrtFuncs
        public static BigInteger SqrtMSDN(BigInteger number, int count)
        {
            //Возвращает целую часть от корня из value
			// count - корень какой степени надо извлечь из number
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
            //if (number == sqr * sqr) return sqr;
            //else if (number == (sqr - 1) * (sqr - 1)) return (sqr - 1);
            //else if (number == (sqr - 2) * (sqr - 2)) return (sqr - 2);
            //else if (number == (sqr + 1) * (sqr + 1)) return (sqr + 1);
            //else if (number == (sqr + 2) * (sqr + 2)) return (sqr + 2);
            //else return sqr;
        }

        internal static bool IsTrueSqrt(BigInteger number, BigInteger sqr)
        {
            //Метод, проверяющий является число квадратом числа, полученного в методе Sqrt
            return sqr * sqr == number;

        }

        //internal static BigInteger Sqrt3(BigInteger number)
        //{
        //    //Возвращает целую часть от корня 3 степени из value
        //    var sqr = (BigInteger)Math.Exp(BigInteger.Log(number) / 2);
        //    if (number == sqr * sqr) return sqr;
        //    else if (number == (sqr - 1) * (sqr - 1)) return (sqr - 1);
        //    else if (number == (sqr - 2) * (sqr - 2)) return (sqr - 2);
        //    else if (number == (sqr + 1) * (sqr + 1)) return (sqr + 1);
        //    else if (number == (sqr + 2) * (sqr + 2)) return (sqr + 2);
        //    else return sqr;
        //}

        //internal static BigInteger Sqrt6(BigInteger number)
        //{
        //    //Возвращает целую часть от корня 3 степени из value
        //    var sqr = (BigInteger)Math.Exp(BigInteger.Log(number) / 6);
        //    BigInteger res = 0;
        //    BigInteger resplus1 = 0;
        //    BigInteger resmines1 = 0;
        //    BigInteger resplus2 = 0;
        //    BigInteger resmines2 = 0;
        //    for (int i=0;i<6;i++)
        //    {
        //        res *= sqr;
        //        resmines1 *= (sqr-1);
        //        resplus1 *= (sqr+1);
        //        resmines2 *= (sqr-2);
        //        resplus2 *= (sqr+2);
        //    }
        //    if (number == res) return sqr;
        //    else if (number == resmines1) return (sqr - 1);
        //    else if (number == resmines2) return (sqr - 2);
        //    else if (number == resplus1) return (sqr + 1);
        //    else if (number == resplus2) return (sqr + 2);
        //    else return sqr;
        //}

        //internal static BigInteger Sqrt(BigInteger n)
        //{
        //    //Метод извлечения квадратного корня из числа

        //    if (n == 0) return 0;

        //    if (n > 0)
        //    {
        //        int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
        //        BigInteger root = BigInteger.One << (bitLength / 2);

        //        while (!IsBetween(n, root))
        //        {
        //            root += n / root;
        //            root /= 2;
        //        }

        //        return root;
        //    }

        //    throw new ArithmeticException("NaN");
        //}

        //private static Boolean IsBetween(BigInteger n, BigInteger root)
        //{
        //    //Вспомогательная функция для извлечения квадтратного корня

        //    BigInteger lowerBound = root * root;
        //    BigInteger upperBound = (root + 1) * (root + 1);

        //    return (n >= lowerBound && n < upperBound);
        //}
        #endregion

        internal static BigInteger GCD(BigInteger a, BigInteger b)
        {
            //Алгоритм Евклида

            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }
    }
}
