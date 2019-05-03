using System.Numerics;

namespace KursachLibrary1
{
    public class DivisionCheck : IFactor
    {
        //Факторизация методом подбора делителей до корня из n

        public string Name { get; } = "Division Check Method";

        public BigInteger Factor(BigInteger number)
        {
            BigInteger a = 2;
            BigInteger result = 1;

            while (a<= Helper.SqrtMSDN(number,2))
            {
                if (number % a == 0)
                {
                    result = a;
                    break;
                }

                a++;
            }

            return result;
        }
    }
}
