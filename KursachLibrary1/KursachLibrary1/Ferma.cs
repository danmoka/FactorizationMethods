using System.Numerics;

namespace KursachLibrary1
{
    public class Ferma: IFactor
    {
        /*Идея: если входное n представляется в виде n=pq, где p,q - простые, тогда n можно представить в виде: n=A^2-B^2=(A+B)(A-B).
        * В ходе алгоритма строим последовательность q(i)=(m+i)^2 - n, где m=[(n)^(1/2)],
        * i=0,1,2..., пока q(i) не является полным квадратом. Если q(i) - полный квадрат, то нашли разложение.
        */

        public string Name { get; } = "Ferma's Method";

        //Коблиц, Ишмухаметов. Одинаковые алгоритмы.
        public BigInteger Factor(BigInteger number)
        {
            var m = Helper.SqrtMSDN(number,2);

            if (Helper.IsTrueSqrt(number, m)) return m;

            BigInteger x = 1;

            while(true)
            {
                var q = (m + x) * (m + x) - number;
                var qsqr = Helper.SqrtMSDN(q,2);

                //System.Console.WriteLine("{0} {1} {2}",x,q,qsqr);

                if (Helper.IsTrueSqrt(q,qsqr))
                {
                    var a = m + x;
                    //var b = Helper.SqrtMSDN(q,2);
                    return a - qsqr;
                }
                x++;
            }
        }

        //INTUIT
        //public BigInteger Factor(BigInteger number)
        //{
        //    BigInteger x = Helper.SqrtMSDN(number);

        //    if (Helper.IsTrueSqrt(number, x)==x) return x;
        //    else
        //    {
        //        while (true)//можно заменить на (n+1)/2
        //        {
        //            x = x + 1;
        //            BigInteger w = x * x - number;
        //            BigInteger wsqr = Helper.SqrtMSDN(w);
        //            BigInteger istrue = Helper.IsTrueSqrt(w, wsqr);
        //            if (istrue!=-1)
        //                return x - istrue;
        //        }
        //    }
        //}

        //Emaxx
        //public BigInteger Factor(BigInteger number)
        //{
        //    var x = Helper.SqrtMSDN(number);
        //    //if (Helper.IsTrueSqrt(number, x) != -1) x = Helper.IsTrueSqrt(number, x);
        //    var y = 0;
        //    var r = x * x - y * y - number;
        //    while(true)
        //    {
        //        if (r == 0) return x != y ? x - y : x + y;
        //        else
        //        {
        //            if(r>0)
        //            {
        //                r -= y + y + 1;
        //                ++y;
        //            }
        //            else
        //            {
        //                r += x + x + 1;
        //                ++x;
        //            }
        //        }
        //    }
        //}

        //8316 алгоритм
        // public BigInteger Factor(BigInteger number)
        //{
        //    BigInteger x = Helper.Sqrt(number);

        //    if (!Helper.IsTrueSqrt(number, x)) x = x + 1;
        //    BigInteger y = x * x - number;
        //    BigInteger ysqr = Helper.Sqrt(y);
        //    while (!Helper.IsTrueSqrt(y, ysqr))
        //    {
        //        x = x + 1;
        //        y = x * x - number;
        //        ysqr = Helper.Sqrt(y);
        //    }

        //    return x - ysqr;
        //}
    }
}
