using System.Numerics;
using KursachLibrary1;
using System;
using System.Diagnostics;

namespace TestConsol
{
    class Program
    {
        /// <summary>
        /// Результат работы программы - время разложения для алгоритмов факторизации на нескольких тестовых выборках чисел
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BigInteger[,] testNumbersPrime = new BigInteger[11, 2]
            {
                {373, 1193},
                {3877, 4337},
                {9743, 10169},
                {32479, 32957},
                {65183, 65699},
                {99707, 100393},
                {999563, 1000313},
                {16776763, 16777721},
                {999999223, 1000000447},
                {2147482951, 2147484161},
                {4294967779, 4294966553}
            };

            BigInteger[] testNumbersNotPrime = new BigInteger[11];
            
            for( int i = 0; i < testNumbersNotPrime.Length; i++)
            {
                testNumbersNotPrime[i] = testNumbersPrime[i, 0] * testNumbersPrime[i, 1];
            }

            BigInteger[] testNumbersNotPrimeFarAway = new BigInteger[8];

            for (int i = 0; i < testNumbersNotPrimeFarAway.Length; i++)
            {
                testNumbersNotPrimeFarAway[i] = testNumbersPrime[i, 0] * testNumbersPrime[testNumbersNotPrimeFarAway.Length - 1 - i, 1];
            }

            TrialDivisionMethod divisionCheck = new TrialDivisionMethod();
            Ferma ferma = new Ferma();
            Leman leman = new Leman();
            PPollard pPollard = new PPollard();

            BigInteger resultForDivisionCheck = 0;
            BigInteger resultForFerma = 0;
            BigInteger resultForLeman = 0;
            BigInteger resultForPPollard = 0;

            const int column = 0;

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Prime");

            for (int i = 0; i < testNumbersPrime.Length; i++)
            {
                Console.WriteLine("\t DivCheck | Ferma | Leman | pPollard");
                Console.Write(testNumbersPrime[i, column]);

                stopwatch.Start();
                resultForDivisionCheck = divisionCheck.Factor(testNumbersPrime[i, column]);
                stopwatch.Stop();
                Console.Write(" {0}:{1}", resultForDivisionCheck, stopwatch.ElapsedMilliseconds);

                stopwatch.Reset();

                if (testNumbersPrime[i, 0] <= 999999223)
                {
                    stopwatch.Start();
                    resultForFerma = ferma.Factor(testNumbersPrime[i, column]);
                    stopwatch.Stop();
                    Console.Write(" {0}:{1}", resultForFerma, stopwatch.ElapsedMilliseconds);
                }

                stopwatch.Reset();

                stopwatch.Start();
                resultForLeman = leman.Factor(testNumbersPrime[i, column]);
                stopwatch.Stop();
                Console.Write(" {0}:{1}", resultForLeman, stopwatch.ElapsedMilliseconds);

                stopwatch.Reset();

                stopwatch.Start();
                resultForPPollard = pPollard.Factor(testNumbersPrime[i, column]);
                stopwatch.Stop();
                Console.WriteLine(" {0}:{1}", resultForPPollard, stopwatch.ElapsedMilliseconds);

                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("NotPrime");

            for (int i = 0; i < testNumbersNotPrime.Length; i++)
            {
                Console.WriteLine("\t DivCheck | Ferma | Leman | pPollard");
                Console.Write(testNumbersNotPrime[i]);

                if (testNumbersNotPrime[i] <= 999875863219)
                {
                    stopwatch.Start();
                    resultForDivisionCheck = divisionCheck.Factor(testNumbersNotPrime[i]);
                    stopwatch.Stop();
                    Console.Write(" {0}:{1}", resultForDivisionCheck, stopwatch.ElapsedMilliseconds);
                }

                stopwatch.Reset();

                stopwatch.Start();
                resultForFerma = ferma.Factor(testNumbersNotPrime[i]);
                stopwatch.Stop();
                Console.Write(" {0}:{1}", resultForFerma, stopwatch.ElapsedMilliseconds);

                stopwatch.Reset();

                stopwatch.Start();
                resultForLeman = leman.Factor(testNumbersNotPrime[i]);
                stopwatch.Stop();
                Console.Write(" {0}:{1}", resultForLeman, stopwatch.ElapsedMilliseconds);

                stopwatch.Reset();

                stopwatch.Start();
                resultForPPollard = pPollard.Factor(testNumbersNotPrime[i]);
                stopwatch.Stop();
                Console.WriteLine(" {0}:{1}", resultForPPollard, stopwatch.ElapsedMilliseconds);

                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("NotPrimeFarAway");

            for (int i = 0; i < testNumbersNotPrimeFarAway.Length; i++)
            {
                Console.WriteLine("\t DivCheck | Ferma | Leman | pPollard");
                Console.Write(testNumbersNotPrimeFarAway[i]);

                stopwatch.Start();
                resultForDivisionCheck = divisionCheck.Factor(testNumbersNotPrimeFarAway[i]);
                stopwatch.Stop();
                Console.Write(" {0}:{1}", resultForDivisionCheck, stopwatch.ElapsedMilliseconds);
                
                stopwatch.Reset();

                stopwatch.Start();
                resultForFerma = ferma.Factor(testNumbersNotPrimeFarAway[i]);
                stopwatch.Stop();
                Console.Write(" {0}:{1}", resultForFerma, stopwatch.ElapsedMilliseconds);

                stopwatch.Reset();

                stopwatch.Start();
                resultForLeman = leman.Factor(testNumbersNotPrimeFarAway[i]);
                stopwatch.Stop();
                Console.Write(" {0}:{1}", resultForLeman, stopwatch.ElapsedMilliseconds);

                stopwatch.Reset();

                stopwatch.Start();
                resultForPPollard = pPollard.Factor(testNumbersNotPrimeFarAway[i]);
                stopwatch.Stop();
                Console.WriteLine(" {0}:{1}", resultForPPollard, stopwatch.ElapsedMilliseconds);

                Console.WriteLine("----------------------------------");
            }
            //{
            //    2305843009213693951,
            //    489133282872437279,
            //    99194853094755497,
            //    1111111111111111111
            //};
        }
    }
}
