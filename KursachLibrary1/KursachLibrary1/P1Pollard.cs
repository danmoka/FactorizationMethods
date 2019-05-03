using System;
using System.Numerics;

namespace KursachLibrary1
{
    public class P1Pollard
    {
        public string Name { get; } = "P1-Pollard's Method";

        public BigInteger Factor(BigInteger number)
        {
            BigInteger a = 2;
            BigInteger e = 2;
            BigInteger b = 4;

            while (e <= b)
            {
                a = BigInteger.ModPow(a, e, number);
                e++;
            }

            BigInteger p = BigInteger.Abs(Helper.GCD(a - 1, number));

            return p;
        }

        //8316 алгоритм
        //public BigInteger Factor(BigInteger number)
        //{
        //    BigInteger a = 2;
        //    BigInteger j = 2;
        //    BigInteger b = 7;
        //    BigInteger p = 0;
        //    while (j <= b)
        //    {
        //        a = BigInteger.ModPow(a, j, number);
        //        p = BigInteger.Abs(Helper.GCD(a - 1, number));
        //        if (p > 1 && p < number) return p;

        //        j++;
        //    }

        //    //BigInteger p = BigInteger.Abs(Helper.GCD(a - 1, number));

        //    return p;
        //}

        //Makhovenko алгоритм
        //public BigInteger Factor(BigInteger number)
        //{
        //    int[] Base = {2,3};
        //    BigInteger result = 1;
        //    BigInteger a = 2/*LongRandom(2, number - 2, Rand)*/;
        //    BigInteger d = BigInteger.Abs(Helper.GCD(a, number));

        //    if (d >= 2)
        //    {
        //        result = d;
        //        return result;
        //    }

        //    foreach (int el in Base)
        //    {
        //        int l = (int)Math.Floor(BigInteger.Log(number) / Math.Log(el));//!!!
        //        //BigInteger l = (BigInteger)Math.Floor(log); // мб без бигинт в этой строек
        //        BigInteger p = BigInteger.Pow(el, l);
        //        a = BigInteger.ModPow(a, p, number);
        //    }
        //    d = BigInteger.Abs(Helper.GCD(a - 1, number));
        //    if (d != 1 && d != number) result = d;
        //    return result;
        //}
    }
}
