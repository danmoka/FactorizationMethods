using System.Numerics;

namespace KursachLibrary1
{
    /// <summary>
    /// Класс, реализаующий метод Ферма
    /// </summary>
    public class Ferma: IFactor
    {
        /*Идея: если входное n представляется в виде n=pq, где p,q - простые, тогда n можно представить в виде: n=A^2-B^2=(A+B)(A-B).
        * В ходе алгоритма строим последовательность q(i)=(m+i)^2 - n, где m=[(n)^(1/2)],
        * i=0,1,2..., пока q(i) не является полным квадратом. Если q(i) - полный квадрат, то нашли разложение.
        */

        public string Name { get; } = "Ferma's Method";

        //Коблиц, Ишмухаметов. Одинаковые алгоритмы.
        /// <summary>
        /// Данный метод ищет разложение входного числа
        /// </summary>
        /// <param name="number"> Число для разложения </param>
        /// <returns> Число из разложения </returns>
        public BigInteger Factor(BigInteger number)
        {
            var m = Helper.SqrtMSDN(number,2); // первый шаг - целая часть корня из входного числа

            if (Helper.IsTrueSqrt(number, m)) return m; // если входное число оказалось полным квадратом, вернуть число из предыдущего шага

            BigInteger x = 1;
            //... иначе ищем представление входного числа в виде разницы двух квадратов
            while(true)
            {
                var q = (m + x) * (m + x) - number;
                var qsqr = Helper.SqrtMSDN(q,2);

                if (Helper.IsTrueSqrt(q,qsqr))
                {
                    var a = m + x;

                    return a - qsqr;
                }

                x++;
            }
        }
    }
}
